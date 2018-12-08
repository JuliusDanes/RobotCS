using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RobotCS
{
    public partial class RobotCS : Form
    {
        public RobotCS(dynamic args)
        {
            InitializeComponent();
            useAs = args;
            setTransparent(grpRobot, new dynamic[] { lblRobot, lblConnectionR, tbxIPR, tbxPortR, lblPipeR, lblPipe2R, lblPipe3R, lblEncoderR, lblEncCommaR, tbxEncXR, tbxEncYR, lblEncDegR, tbxEncAngleR, lblGoto, lblGotoCommaR, tbxGotoX, tbxGotoY, lblGotoDegR, tbxGotoAngleR });
            setTransparent(grpBaseStation, new dynamic[] { lblBaseStation, lblConnectionBS, tbxIPBS, tbxPortBS, lblPipeBS });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = lblRobot.Text = useAs;
            myIP = GetIPAddress();
            tbxIPR.Text /*= "169.254.162.201"*/ = GetIPAddress();
            tbxPortR.Text = "8686";
            tbxIPBS.Text = GetIPAddress() /*= "192.168.165.10"*/;
            tbxPortBS.Text = "8686";

            resetText();
            chkConnection = new System.Threading.Timer(new TimerCallback(checkConnection), null, 100, 100);
            chkAppResponding = new System.Threading.Timer(new TimerCallback(checkAppResponding), null, 100, 100);
        }

        delegate void addCommandCallback(string text);

        private void addCommand(string text)
        {
            try
            {
                if (this.tbxStatus.InvokeRequired)
                {
                    addCommandCallback d = new addCommandCallback(addCommand);
                    this.Invoke(d, new object[] { text });
                }
                else
                    this.tbxStatus.Text += text + Environment.NewLine;
            }
            catch (Exception e)
            {
                addCommand("# Error set text tbxStatus \n\n" + e);
            }
        }

        void checkAppResponding(object state)
        {
            try {
                Process[] processes = Process.GetProcessesByName("RobotCS");
                foreach (var i in processes)
                    if (!i.Responding)      // When the application not responding
                        i.Kill(); }
            catch (Exception)
            { }
        }

        void resetText()
        {
            dynamic[] arr = { tbxEncXR, tbxEncYR, tbxEncAngleR, tbxGotoX, tbxGotoY, tbxGotoAngleR };
            foreach (var i in arr)
                i.Text = "0";
        }

        void setTransparent(dynamic backImage, dynamic[] frontImages)
        {
            foreach (var frontImage in frontImages)
            {
                var pos = this.PointToScreen(frontImage.Location);
                pos = backImage.PointToClient(pos);
                frontImage.Parent = backImage;
                frontImage.Location = pos;
            }
        }

        private void tbxStatus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbxStatus.SelectionStart = tbxStatus.Text.Length;
                tbxStatus.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("# Error tbxStatus \n\n" + ex);
            }
        }


        //////////////////////////////////////////////////////////////      TRACK LOCACTION       //////////////////////////////////////////////////////////////
        ///
        void changeCounter(object sender, KeyEventArgs e)
        {
            var obj = ((dynamic)sender).Name;
            dynamic[,] arr = { { tbxEncXR, tbxEncYR, tbxEncAngleR }, { tbxGotoX, tbxGotoY, tbxGotoAngleR } };
            int n = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j].Name == obj)
                        n = i;
            if (e.KeyCode == Keys.Right)
                arr[n, 0].Text = (int.Parse(arr[n, 0].Text) + 1).ToString();
            else if (e.KeyCode == Keys.Left)
                arr[n, 0].Text = (int.Parse(arr[n, 0].Text) - 1).ToString();
            else if (e.KeyCode == Keys.Up)
                arr[n, 1].Text = (int.Parse(arr[n, 1].Text) - 1).ToString();
            else if (e.KeyCode == Keys.Down)
                arr[n, 1].Text = (int.Parse(arr[n, 1].Text) + 1).ToString();
            else if (e.KeyCode == Keys.PageUp)
                arr[n, 2].Text = (int.Parse(arr[n, 2].Text) + 1).ToString();
            else if (e.KeyCode == Keys.PageDown)
                arr[n, 2].Text = (int.Parse(arr[n, 2].Text) - 1).ToString();
        }

        private void tbxGoto_KeyDown(object sender, KeyEventArgs e)
        {
            changeCounter(sender, e);
            if ((e.KeyCode == Keys.Enter) && (!string.IsNullOrWhiteSpace(tbxGotoX.Text)) && (!string.IsNullOrWhiteSpace(tbxGotoY.Text)) && (!string.IsNullOrWhiteSpace(tbxGotoAngleR.Text)))
                new Thread(obj => GotoLoc(this.Text, tbxEncXR, tbxEncYR, tbxEncAngleR, int.Parse(tbxGotoX.Text), int.Parse(tbxGotoY.Text), int.Parse(tbxGotoAngleR.Text), 20, 20, 1)).Start();
        }

        void GotoLoc(string Robot, dynamic encXRobot, dynamic encYRobot, dynamic angleRobot, int endX, int endY, int endAngle, int shiftX, int shiftY, int shiftAngle)
        {
            try
            {
                int startX = int.Parse(encXRobot.Text), startY = int.Parse(encYRobot.Text), startAngle = int.Parse(angleRobot.Text);
                addCommand("# " + Robot + " : Goto >> " + ("X:" + endX + " Y:" + endY + " ∠:" + endAngle + "°"));
                bool[] chk = { true, true, true };
                while (chk[0] |= chk[1] |= chk[2])
                {
                    if (startX > 12000)
                        startX = int.Parse(startX.ToString().Substring(0, 4));
                    if (startY > 12000)
                        startY = int.Parse(startY.ToString().Substring(0, 4));
                    if (startAngle > 360)
                        startAngle = int.Parse(startAngle.ToString().Substring(0, 2));

                    if ((startX > endX) && (shiftX > 0))
                        shiftX *= -1;
                    else if ((startX < endX) && (shiftX < 0))
                        shiftX *= -1;
                    if ((startY > endY) && (shiftY > 0))
                        shiftY *= -1;
                    else if ((startY < endY) && (shiftY < 0))
                        shiftY *= -1;
                    if ((startAngle > endAngle) && (shiftAngle > 0))
                        shiftAngle *= -1;
                    else if ((startAngle < endAngle) && (shiftAngle < 0))
                        shiftAngle *= -1;

                    if (startX != endX)
                    {
                        if (Math.Abs(endX - startX) < Math.Abs(shiftX))     // Shift not corresponding
                            shiftX = (endX - startX);
                        startX += shiftX;   // On process
                    }
                    else
                        chk[0] = false;     // Done
                    if (startY != endY)
                    {
                        if (Math.Abs(endY - startY) < Math.Abs(shiftY))     // Shift not corresponding
                            shiftY = (endY - startY);
                        startY += shiftY;   // On process
                    }
                    else
                        chk[1] = false;     // Done
                    if (startAngle != endAngle)
                    {
                        if (Math.Abs(endAngle - startAngle) < Math.Abs(shiftAngle))     // Shift not corresponding
                            shiftAngle = (endAngle - startAngle);
                        startAngle += shiftAngle;   // On process
                    }
                    else
                        chk[2] = false;     // Done

                    hc.SetText(this, tbxEncXR, startX.ToString());
                    hc.SetText(this, tbxEncYR, startY.ToString());
                    hc.SetText(this, tbxEncAngleR, startAngle.ToString());
                    Thread.Sleep(100);    // time per limit
                }
            }
            catch (Exception e)
            { }
        }

        private void tbxXY_TextChanged(object sender, EventArgs e)
        {
            string dtEncoder = tbxEncXR.Text + "," + tbxEncYR.Text + "," + tbxEncAngleR.Text;
            if ((!string.IsNullOrWhiteSpace(tbxEncXR.Text)) && (!string.IsNullOrWhiteSpace(tbxEncYR.Text)) && (!string.IsNullOrWhiteSpace(tbxEncAngleR.Text)) && (!string.IsNullOrWhiteSpace(tbxStatus.Text)))
                if (_socketDict.ContainsKey("BaseStation"))
                    new Thread(obj => SendCallBack(_socketDict["BaseStation"], dtEncoder)).Start();
                else
                    MessageBox.Show("Connection to BaseStation is DISCONNECTED :<");
        }


        //////////////////////////////////////////////////////////////      COMUNICATION       //////////////////////////////////////////////////////////////
        ///
        HelperClass hc = new HelperClass();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        static byte[] _buffer = new byte[1024];
        static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket _toServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Dictionary<string, Socket> _socketDict = new Dictionary<string, Socket>();
        Dictionary<dynamic, bool> chkReconnect = new Dictionary<dynamic, bool>();
        List<dynamic> _chkRobotCollect = new List<dynamic>(), notConnectionCollect = new List<dynamic>();
        internal int port, attempts = 0;
        internal string useAs, myIP, chkRobotCollect = string.Empty;
        System.Threading.Timer chkConnection, chkAppResponding;

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

        void checkConnection(object state)
        {
            try
            {
                dynamic[,] arr = { { lblRobot, lblConnectionR }, { lblBaseStation, lblConnectionBS } };
                for (int i = 0; i < arr.GetLength(0); i++)      // Check for Server and Client Connection
                    if ((((_socketDict.ContainsKey(arr[i, 0].Text)) && (!_socketDict[arr[i, 0].Text].Connected)) ^ ((arr[i, 1].Text.Equals("Open")) && (!_serverSocket.IsBound))) && (!notConnectionCollect.Contains(arr[i, 1])))
                    {
                        notConnectionCollect.Add(arr[i, 1]);
                        chkReconnect.Add(arr[i, 1].Name, true);
                    }
                    else if ((((_socketDict.ContainsKey(arr[i, 0].Text)) && (_socketDict[arr[i, 0].Text].Connected)) ^ ((arr[i, 1].Text.Equals("Open")) && (_serverSocket.IsBound))) && (notConnectionCollect.Contains(arr[i, 1])))
                        notConnectionCollect.Remove(arr[i, 1]);
                foreach (dynamic j in notConnectionCollect)          // Auto Reconnecting
                    if (chkReconnect[j.Name] == true)
                    {
                        if (j.Text == "Disconnected"){
                            chkReconnect[j.Name] = false;
                            grpBaseStation_Click(j, EventArgs.Empty); }
                        else if (j.Text == "Close") { 
                            chkReconnect[j.Name] = false;
                            grpRobot_Click(grpRobot, EventArgs.Empty); }
                        if (j.Text == "Connected")
                            hc.SetText(this, j, "Disconnected");
                        else if (j.Text == "Open")
                            hc.SetText(this, j, "Close");
                    }
            }
            catch (Exception)
            { }
        }

        private void lblConnection_TextChanged(object sender, EventArgs e)
        {
            var obj = ((dynamic)sender).Name;
            dynamic[,] arr;
            if (obj == lblConnectionR.Name)
                arr = new dynamic[,] { { lblConnectionR, lblRobot, lblEncoderR, tbxEncXR, tbxEncYR, tbxEncAngleR, lblEncDegR, lblGoto, tbxGotoX, tbxGotoY, tbxGotoAngleR, lblGotoDegR } };
            else
                arr = new dynamic[,] { { lblConnectionBS, lblBaseStation, chkR1, chkR2, chkR3, lblRobot, lblEncoderR, tbxEncXR, tbxEncYR, tbxEncAngleR, lblEncDegR, lblGoto, tbxGotoX, tbxGotoY, tbxGotoAngleR, lblGotoDegR } };
            int n = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                if (arr[i, 0].Name == obj)
                    n = i;
            if ((arr[n, 0].Text == "Connected") ^ (arr[n, 0].Text == "Open"))
            {
                arr[n, 0].BackColor = Color.SeaGreen;
                for (int i = 0; i < arr.GetLength(1); i++)
                    arr[n, i].Enabled = true;
            }
            else
            {
                if (obj == lblConnectionR.Name)
                    addCommand("\n# " + arr[n, 1].Text + " server is CLOSE :<");
                else
                    addCommand("\n# " + arr[n, 1].Text + " has DISCONNECTED :<");
                _socketDict.Remove(arr[n, 1].Text);
                arr[n, 0].BackColor = Color.Firebrick;
                for (int i = 0; i < arr.GetLength(1); i++)
                    if (i != 0)
                        arr[n, i].Enabled = false;
            }
        }

        private void ChkRobot_OnChange(object sender, EventArgs e)
        {
            var obj = ((dynamic)sender).Name;
            dynamic[,] arr = { { chkR1, "Robot1" }, { chkR2, "Robot2" }, { chkR3, "Robot3" } };
            int n = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                if (arr[i, 0].Name == obj)
                    n = i;
            if (arr[n, 0].Checked == true)
                _chkRobotCollect.Add(arr[n, 1]);
            else
                _chkRobotCollect.Remove(arr[n, 1]);
            _chkRobotCollect.Sort();
            if (_chkRobotCollect.Count == 0)
                chkRobotCollect = string.Empty;
            for (int i = 0; i < _chkRobotCollect.Count; i++)
            {
                if (i == 0)
                    chkRobotCollect = _chkRobotCollect.ElementAtOrDefault(i);
                else
                    chkRobotCollect += "," + _chkRobotCollect.ElementAtOrDefault(i);
            }
        }

        string socketToIP(Socket socket)
        {
            return (socket.RemoteEndPoint.ToString().Split(':'))[0];
        }

        string socketToName(Socket socket)
        {
            dynamic[] arr = { "BaseStation", "RefereeBox", "Robot1", "Robot2", "Robot3" };
            for (int i = 0; i < arr.Length; i++)
                if ((_socketDict.ContainsKey(arr[i])) && (_socketDict[arr[i]].RemoteEndPoint == socket.RemoteEndPoint))
                    return arr[i];
            return socket.RemoteEndPoint.ToString();
        }

        void reqConnect(string ipDst, dynamic port, string keyName, dynamic connection)
        {
            addCommand("# Connecting to " + ipDst + " (" + keyName + ") \t Port : " + port);
            try
            {
                attempts++;
                _toServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //_toServerSocket.Connect(IPAddress.Parse(ipDst = "169.254.162.201"), 100);
                _toServerSocket.Connect(IPAddress.Parse(ipDst), int.Parse(port));
                if (_toServerSocket.Connected)
                    addCommand("# Success Connecting to: " + ipDst + " (" + keyName + ") \t Port : " + port);
                hc.SetText(this, connection, "Connected");
                SendCallBack(_toServerSocket, this.Text);
                _socketDict.Add(keyName, _toServerSocket);
                _toServerSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _toServerSocket);
                //new Thread(obj => _toServerSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _toServerSocket)).Start();
                if (chkReconnect.ContainsKey(connection.Name))
                    chkReconnect.Remove(connection.Name);
            }
            catch (SocketException)
            {
                hc.SetText(this, tbxStatus, string.Empty);
                addCommand("# IP This Device  : " + myIP + " (" + this.Text + ")");
                addCommand("# IP Destination  : " + ipDst + " (" + keyName + ") \t Port : " + port);
                addCommand("# Connection attempts: " + attempts.ToString());
                hc.SetText(this, connection, "Disconnected");
                if (chkReconnect.ContainsKey(connection.Name))
                    chkReconnect[connection.Name] = true;
            }
        }

        void SetupServer(dynamic port)
        {
            try
            {
                if ((!string.IsNullOrWhiteSpace(tbxIPR.Text)) && (!string.IsNullOrWhiteSpace(tbxPortR.Text)))
                {
                    _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    addCommand("# Setting up server...");
                    addCommand("# Open for IP : " + tbxIPR.Text + " (" + this.Text + ") \t Port : " + port);
                    hc.SetText(this, lblConnectionR, "Open");
                    _serverSocket.Bind(new IPEndPoint(IPAddress.Any, this.port = int.Parse(port)));
                    _serverSocket.Listen(1);
                    _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                    if (chkReconnect.ContainsKey(lblConnectionR.Name))
                        chkReconnect.Remove(lblConnectionR.Name);
                }
            }
            catch (Exception e)
            {
                addCommand("# FAILED to open server connection \n\n" + e);
                _serverSocket.Dispose();
                //hc.SetText(this, lblConnectionR, "Close");
                if (chkReconnect.ContainsKey(lblConnectionR.Name))
                    chkReconnect[lblConnectionR.Name] = true;
            }
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                Socket socket = _serverSocket.EndAccept(AR);
                if (socket.Connected)
                {
                    _socketDict.Add(socket.RemoteEndPoint.ToString(), socket);
                    socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
                    //new Thread(obj => socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket)).Start();
                    _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                    addCommand("# Success Connected to: " + socketToIP(socket));
                    //MessageBox.Show(_toServerSocketDict.Keys.Where(item => item.StartsWith("192.168.1.107")).ElementAt(0))  
                }
            }
            catch (Exception e)
            {
                addCommand("# FAILED to connect \n\n" + e);
            }
        }

        private void ReceiveCallBack(IAsyncResult AR)
        {
            try
            {
                Socket socket = (Socket)AR.AsyncState;
                int received = socket.EndReceive(AR);
                byte[] dataBuf = new byte[received];
                Array.Copy(_buffer, dataBuf, received);
                string text = Encoding.ASCII.GetString(dataBuf).Trim();
                var _data = text.Split('|');

                string respone = ResponeCallback(_data[0], socket);
                if (!string.IsNullOrEmpty(respone))
                {
                    if (_data.Count() == 1)
                        SendCallBack(socket, respone);
                    else
                        sendByHostList(_data[1], respone);
                }
                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
                //new Thread(obj => socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket)).Start();
            }
            catch (Exception e)
            {
                addCommand("# FAILED to receive message \n\n" + e);
            }
        }

        void SendCallBack(Socket _dstSocket, string txtMessage)
        {
            try
            {
                if (Regex.IsMatch(txtMessage, "[-]{0,1}[0-9]{1,4},[-]{0,1}[0-9]{1,4},[-]{0,1}[0-9]{1,4}"))
                {
                    //var pos = txtMessage.Split(',');
                    //addCommand("@ " + socketToName(_dstSocket) + " : " + ("X:" + pos[0] + " Y:" + pos[1] + " ∠:" + pos[2] + "°"));
                }
                else
                    addCommand("@ " + socketToName(_dstSocket) + " : " + txtMessage);
                byte[] buffer = Encoding.ASCII.GetBytes(txtMessage);
                _dstSocket.Send(buffer);
                _dstSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _dstSocket);
                //new Thread(obj => _dstSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _dstSocket)).Start();
            }
            catch (Exception e)
            {
                addCommand("# FAILED to send message \n\n" + e);
            }
        }

        void sendByHostList(dynamic inputHostList, string txtMsg)
        {
            try
            {
                var hostList = inputHostList.Split(',');
                foreach (var _hostList in hostList)
                {
                    try
                    {
                        SendCallBack(_socketDict[_socketDict.Keys.Where(host => host.StartsWith(_hostList)).ElementAtOrDefault(0).ToString()], txtMsg);
                    }
                    catch (Exception)
                    {
                        continue;   // If host not found then Skip
                    }
                }
            }
            catch (Exception e)
            {
                addCommand("# FAILED to send message \n\n" + e);
                MessageBox.Show("host Not Found :<");
            }
        }

        string ResponeCallback(dynamic text, Socket socket)
        {
            string respone = string.Empty; if (Regex.IsMatch(text, "[-]{0,1}[0-9]{1,4},[-]{0,1}[0-9]{1,4},[-]{0,1}[0-9]{1,4}"))
            {
                // If message is data X & Y from encoder
                /// Scale is 1 : 20 
                dynamic[] posXYZ = text.Split(',');
                posXYZ = posXYZ.Where(item => (!string.IsNullOrWhiteSpace(item))).ToArray();
                text = string.Empty;
                if (posXYZ.Length > 3) // If data receive multi value X & Y (error bug problem)
                {
                    posXYZ[0] = posXYZ[posXYZ.Length - 3].Substring(posXYZ[posXYZ.Length - 1].Length);
                    posXYZ[1] = posXYZ[posXYZ.Length - 2];
                    posXYZ[2] = posXYZ[posXYZ.Length - 1];
                }

                if ((!string.IsNullOrWhiteSpace(posXYZ[0])) && (Convert.ToInt64(posXYZ[0]) > 12000))
                    posXYZ[0] = posXYZ[0].ToString().Substring(0, 4);
                if ((!string.IsNullOrWhiteSpace(posXYZ[1])) && (Convert.ToInt64(posXYZ[1]) > 12000))
                    posXYZ[1] = posXYZ[1].ToString().Substring(0, 4);
                if ((!string.IsNullOrWhiteSpace(posXYZ[2])) && (Convert.ToInt64(posXYZ[2]) > 360))
                    posXYZ[2] = posXYZ[2].ToString().Substring(0, 2);
                hc.SetText(this, tbxEncXR, posXYZ[0].ToString());          // On encoder tbx
                hc.SetText(this, tbxEncYR, posXYZ[1].ToString());
                hc.SetText(this, tbxEncAngleR, posXYZ[2].ToString());
                //text = "X:" + posXY[0] + " Y:" + posXY[1] + " ∠:" + posXY[2] + "°";
            }
            else if (Regex.IsMatch(text, @"BaseStation"))
            {
                // If will rename key in socket dictionary
                Socket temp = _socketDict[socket.RemoteEndPoint.ToString()];    // Backup
                _socketDict.Remove(socket.RemoteEndPoint.ToString());           // Remove with old key
                _socketDict.Add(text, temp);                                    // Add with new key
                dynamic[,] arr = { { lblBaseStation.Text, lblConnectionBS, tbxIPBS, tbxPortBS } };
                int n = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                    if (arr[i, 0] == text)
                        n = i;
                hc.SetText(this, arr[n, 1], "Connected");
                hc.SetText(this, arr[n, 2], socketToIP(socket));
                hc.SetText(this, arr[n, 3], this.port.ToString());
            }
            else if ((_socketDict.ContainsKey("BaseStation")) && (socket.RemoteEndPoint.ToString().Contains(_socketDict["BaseStation"].RemoteEndPoint.ToString())))
            //else if (true)
            {
                // If socket is Base Station socket     
                switch (text)
                {
                    /// INFORMATION ///
                    case "B": //Get the ball
                        respone = "Ball on " + socketToName(socket);
                        goto broadcast;

                    /// OTHERS ///
                    case "get_time": //TIME NOW
                        respone = DateTime.Now.ToLongTimeString();
                        break;
                    default:
                        //addCommand("# Invalid Command :<");
                        break;
                }
            }
            goto end;

            broadcast:
            sendByHostList("BaseStation", respone +"|"+ "Robot1,Robot2,Robot3");
            return string.Empty;

            multicast:
            sendByHostList("BaseStation", respone +"|"+ chkRobotCollect);
            return string.Empty;

            end:
            if (text != string.Empty)
                addCommand("> " + socketToName(socket) + " : " + text);
            return respone;
        }

        void sendFromTextBox()
        {
            var dataMessage = tbxMessage.Text.Trim().Split('|');
            if (_socketDict.ContainsKey("BaseStation"))
            {
                if ((dataMessage.Count() == 1) && (!string.IsNullOrWhiteSpace(dataMessage[0]))) //for to be Client
                    if (!string.IsNullOrEmpty(chkRobotCollect))
                        SendCallBack(_socketDict["BaseStation"], dataMessage[0].Trim() +"|"+ chkRobotCollect);
                    else
                        SendCallBack(_socketDict["BaseStation"], dataMessage[0].Trim());
                else if ((dataMessage.Count() == 2) && (!string.IsNullOrWhiteSpace(dataMessage[0])) && (!string.IsNullOrWhiteSpace(dataMessage[1])))   //for to be Server
                    SendCallBack(_socketDict["BaseStation"], tbxMessage.Text.Trim());
                else
                    MessageBox.Show("Incorrect Format!");
            }
            else
                MessageBox.Show("Not connected to BaseStation");
            tbxMessage.ResetText();
        }

        private void grpRobot_Click(object sender, EventArgs e)
        {
            if ((lblConnectionR.Text == "Close") && (!string.IsNullOrWhiteSpace(tbxIPR.Text)) && (!string.IsNullOrWhiteSpace(tbxPortR.Text)))
                new Thread(obj => SetupServer(tbxPortR.Text)).Start();
        }

        private void tbxOpenServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if ((lblConnectionR.Text == "Close") && (!string.IsNullOrWhiteSpace(tbxIPR.Text)) && (!string.IsNullOrWhiteSpace(tbxPortR.Text)))
                    new Thread(obj => SetupServer(tbxPortR.Text)).Start();
        }

        private void grpBaseStation_Click(object sender, EventArgs e)
        {
            if ((lblConnectionBS.Text == "Disconnected") && (!string.IsNullOrWhiteSpace(tbxIPBS.Text)) && (!string.IsNullOrWhiteSpace(tbxPortBS.Text)))
                new Thread(objs => reqConnect(tbxIPBS.Text, tbxPortBS.Text, lblBaseStation.Text, lblConnectionBS)).Start();
        }

        private void Connection_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if ((lblConnectionBS.Text == "Disconnected") && (!String.IsNullOrWhiteSpace(tbxIPBS.Text)) && (!String.IsNullOrWhiteSpace(tbxPortBS.Text)))
                    new Thread(objs => reqConnect(tbxIPBS.Text, tbxPortBS.Text, lblBaseStation.Text, lblConnectionBS)).Start();
        }

        private void Disconnect_byDistinct(object sender, EventArgs e)
        {
            try
            {
                var obj = ((dynamic)sender).Name;
                dynamic[,] arr = { { lblRobot, lblConnectionR }, { lblBaseStation, lblConnectionBS } };
                int n = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                    if (arr[i, 1].Name == obj)
                        n = i;
                if (chkReconnect.ContainsKey(arr[n, 1].Name))
                    chkReconnect.Remove(arr[n, 1].Name);
                if (arr[n, 1].Text == "Connected") {
                    _socketDict[arr[n, 0].Text].Dispose();
                    hc.SetText(this, arr[n, 1], "Disconnected"); }
                else if (arr[n, 1].Text == "Open") {
                    _serverSocket.Dispose();
                    hc.SetText(this, arr[n, 1], "Close"); }
            }
            catch
            { }
        }

        private void tbxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (!string.IsNullOrWhiteSpace(tbxMessage.Text)))
                sendFromTextBox();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxMessage.Text))
                sendFromTextBox();
        }

        private void btnTO_Click(object sender, EventArgs e)
        {

        }
    }
}
