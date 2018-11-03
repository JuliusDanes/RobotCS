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

namespace ClientServer
{
    public partial class BaseStationCS : Form
    {
        public BaseStationCS()
        {
            InitializeComponent();
        }

        static byte[] _buffer = new byte[1024];
        Dictionary<string, Socket> _socketDict = new Dictionary<string, Socket>();
        static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket _toServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        internal int port, attempts = 0;
        internal string myIP, typeMessage;

        private void BaseStationCS_Load(object sender, EventArgs e)
        {
            tbxIPBS.Text /*= GetIPAddress()*/ = "192.168.165.10";
            tbxPortBS.Text = "8686";
            tbxIPRobot1.Text /*= "169.254.162.201"*/ = GetIPAddress();
            tbxPortRobot1.Text = "8686";
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            SetupServer(tbxPortBS.Text);
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
            addCommand("# IP " + this.Text + "  : " + tbxIPBS.Text);
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
            //MessageBox.Show(_socketDict.Keys.Where(item => item.StartsWith("192.168.1.107")).ElementAt(0))           
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

        private void SendCallBack(Socket _dstSocket, string typeMsg, string txtMessage)
        {
            //MessageBox.Show("wkkwkw 3 " + txtMessage + " --- " + typeMsg);
            addCommand(txtMessage = (typeMsg + "_T=" + socketToIP(_dstSocket) + ":_" + txtMessage));
            byte[] buffer = Encoding.ASCII.GetBytes(txtMessage);
            _dstSocket.Send(buffer);
            _dstSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _dstSocket);
        }

        void sendByIPList(dynamic inputListIP, string typeMsg, string txtMsg)
        {
            var listIP = inputListIP.Split(',');
            foreach (var _listIP in listIP)
                SendCallBack(_socketDict[_socketDict.Keys.Where(IP => IP.StartsWith(_listIP)).ElementAtOrDefault(0).ToString()], typeMsg, txtMsg);
        }

        string ResponeCallback(string text)
        {
            string respone = string.Empty;
            if (text.ToLower() == "get time")
                respone = DateTime.Now.ToLongTimeString();
            else if (text.ToUpper() == "K")
                respone = "ON / START";
            else
                respone = "Invalid Request";
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
                    addCommand("# Success Connected to: " + ipDst);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_toServerSocket.RemoteEndPoint.ToString());
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

        private void btnConnectRefBox_Click(object sender, EventArgs e)
        {
            reqConnect(tbxIPRefBox.Text, tbxPortRefBox.Text);
        }

        private void btnConnnectRobot1_Click(object sender, EventArgs e)
        {
            reqConnect(tbxIPRobot1.Text, tbxPortRobot1.Text);
        }

        private void btnConnnectRobot2_Click(object sender, EventArgs e)
        {
            reqConnect(tbxIPRobot2.Text, tbxPortRobot2.Text);
        }
        
        private void btnConnnectRobot3_Click(object sender, EventArgs e)
        {
            reqConnect(tbxPortRobot3.Text, tbxPortRobot3.Text);
        }

        private void tbxStatus_TextChanged(object sender, EventArgs e)
        {
            tbxStatus.SelectionStart = tbxStatus.Text.Length;
            tbxStatus.ScrollToCaret();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var dataMessage = tbxMessage.Text.Split('_');
            typeMessage = dataMessage[0];
            if (dataMessage.Count() == 3)
                sendByIPList(dataMessage[2], typeMessage, dataMessage[1]);
            else
                MessageBox.Show("Incorrect Format!");
            tbxMessage.ResetText();
        }
    }
}
