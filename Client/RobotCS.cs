using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

namespace Client
{
    public partial class RobotCS : Form
    {
        public RobotCS(dynamic args)
        {
            InitializeComponent();
            useAs = args
;        }

        static byte[] _buffer = new byte[1024];
        static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket _toServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Dictionary<string, Socket> _socketDict = new Dictionary<string, Socket>();
        internal int port, attempts = 0;
        internal string useAs, myIP, typeMessage;
        
        private void RobotCS_Load(object sender, EventArgs e)
        {
            this.Text = gbxRobot.Text = useAs;
            myIP = GetIPAddress();
            tbxIPRobot.Text /*= "169.254.162.201"*/ = GetIPAddress();
            tbxPortRobot.Text = "8686";
            tbxIPBS.Text /*= GetIPAddress()*/ = "192.168.165.10";
            tbxPortBS.Text = "8686";
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            SetupServer(tbxPortRobot.Text);
        }

        delegate void addCommandCallback(string text);

        private void addCommand(string text)
        {
            if (this.tbxStatus.InvokeRequired)
            {
                addCommandCallback d = new addCommandCallback(addCommand);
                this.Invoke(d, new object[] { text });
            }
            else
                this.tbxStatus.Text += text + Environment.NewLine;
        }

        void SetupServer(dynamic port)
        {
            addCommand("# Setting up server...");
            addCommand("# IP " + this.Text + "  : " + tbxIPRobot.Text);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, int.Parse(port)));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _socketDict.Add(socket.RemoteEndPoint.ToString(), socket);
            //if (socket.Connected)
            //{
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
            addCommand("# Success Connected to: " + socketToIP(socket));
            //MessageBox.Show(_socketDict.Keys.Where(item => item.StartsWith("192.168.1.107")).ElementAt(0));
        }

        string socketToIP(Socket socket)
        {
            var _temp = socket.RemoteEndPoint.ToString().Split(':');
            return _temp[0];
        }

        private void ReceiveCallBack(IAsyncResult AR) /**/
        {                        
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);

            var _data = text.Split('_');
            //MessageBox.Show("wkwkwk 2 " + _data[2] + " -- " + _data[0]);
            addCommand(_data[0] + "_F=" + socketToIP(socket) + ":_" + _data[2]);

            if (_data[0].Equals("@"))
            {
                string respone = ResponeCallback(_data[2]);
                if (_data.Count() == 3)
                    SendCallBack(socket, typeMessage, respone);
                else
                    sendByIPList(_data[3], typeMessage, respone);
            }
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
        }

        void sendByIPList(dynamic inputListIP, string typeMsg, string txtMsg)
        {
            var listIP = inputListIP.Split(',');
            foreach (var _listIP in listIP)
                SendCallBack(_socketDict[_socketDict.Keys.Where(IP => IP.StartsWith(_listIP)).ElementAtOrDefault(0).ToString()], typeMsg, txtMsg);
        }

        private void SendCallBack(Socket _dstSocket, string typeMsg, string txtMessage)
        {
            //MessageBox.Show("wkwkw 1 " + txtMessage + " -- " + typeMsg);
            addCommand(txtMessage = (typeMsg + "_T=" + socketToIP(_dstSocket) + ":_" + txtMessage));
            byte[] buffer = Encoding.ASCII.GetBytes(txtMessage);
            _dstSocket.Send(buffer);
            _dstSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _dstSocket);
        }
        
        string ResponeCallback(string text)
        {
            string respone = string.Empty;
            if (text.ToLower() == "get time")
                respone = DateTime.Now.ToLongTimeString();
            else if (text.ToUpper() == "K")
                respone = "ON / START";
            else
                respone = "Invalid Request"; ;
            byte[] data = Encoding.ASCII.GetBytes(respone);
            typeMessage = ">";
            return respone;
        }

        ////////////////////////////////////////////////////////////////////////        

        void reqConnect(string ipDst, dynamic port)
        {
            try
            {
                attempts++;
                //_toServerSocket.Connect(IPAddress.Parse(ipDst = "169.254.162.201"), 100);
                _toServerSocket.Connect(IPAddress.Parse(ipDst), int.Parse(port));
                tbxStatus.ResetText();
                if (_toServerSocket.Connected)
                    addCommand("# Success Connecting to: " + ipDst);
                _toServerSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _toServerSocket);
            }
            catch (SocketException)
            {
                tbxStatus.ResetText();
                addCommand("# IP This Device  : " + myIP);
                addCommand("# IP Destination  : " + ipDst);
                addCommand("# Connection attempts: " + attempts.ToString());
            }
        }

        string GetIPAddress()
        {
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    myIP = IP.ToString();
            return myIP;
        }

        private void btnConnectBS_Click(object sender, EventArgs e)
        {
            reqConnect(tbxIPBS.Text, tbxPortBS.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var dataMessage = tbxMessage.Text.Split('_');
            typeMessage = dataMessage[0];
            if (dataMessage.Count() == 2) //for to be Client
                SendCallBack(_toServerSocket, typeMessage, dataMessage[1]);
            else if (dataMessage.Count() == 3)  //for to be Server
                sendByIPList(dataMessage[2], typeMessage, dataMessage[1]);
            else
                MessageBox.Show("Incorrect Format!");
            tbxMessage.ResetText();
        }

        private void btnCloseServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(useAs.ToString());
        }


        //////////////////////////////////////////////////
        ///
        void changeCounter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                tbxX.Text = (int.Parse(tbxX.Text) + 1).ToString();
            else if (e.KeyCode == Keys.Left)
                tbxX.Text = (int.Parse(tbxX.Text) - 1).ToString();
            else if (e.KeyCode == Keys.Up)
                tbxY.Text = (int.Parse(tbxY.Text) - 1).ToString();
            else if (e.KeyCode == Keys.Down)
                tbxY.Text = (int.Parse(tbxY.Text) + 1).ToString();
        }

        void tbxXYChanged(object sender, EventArgs e)
        {
            string dtEncoder = "X:"+tbxX.Text +":Y:"+tbxY.Text;
            //SendCallBack(_toServerSocket, ">", dtEncoder);
            Thread th_Send = new Thread(obj => SendCallBack(_toServerSocket, ">", dtEncoder));
            th_Send.Start();
        }

        private void tbxStatus_TextChanged(object sender, EventArgs e)
        {
            tbxStatus.SelectionStart = tbxStatus.Text.Length;
            tbxStatus.ScrollToCaret();
        }
    }
}
