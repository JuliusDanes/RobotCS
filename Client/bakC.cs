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
    class bakC
    {
        //public Client()
        //{
        //    InitializeComponent();
        //}

        //private static byte[] _buffer = new byte[1024];
        //private static List<Socket> _clientSocketList = new List<Socket>();
        //private static Socket _serverSocketLite = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //static string ipSrc, ipDst;

        //private void Client_Load(object sender, EventArgs e)
        //{
        //    tbxIPServer.Text = "";
        //    //SetupClient();
        //    //LoopConnect();
        //    //Thread LC = new Thread(LoopConnect);
        //    //LC.Start();
        //}

        //delegate void addCommandCallback(string text);

        //private void addCommand(string text)
        //{
        //    if (this.tbxStatus.InvokeRequired)
        //    {
        //        addCommandCallback d = new addCommandCallback(addCommand);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //        this.tbxStatus.Text += "> " + text + Environment.NewLine;
        //}

        //private void SetupClient()
        //{
        //    //Console.WriteLine("Setting up server...");
        //    addCommand("Setting up client...");
        //    _serverSocketLite.Bind(new IPEndPoint(IPAddress.Any, 100));
        //    _serverSocketLite.Listen(1);
        //    //_serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        //}



        ////////////////////////////////////////////////////////////////////////////////////////

        //private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //private void reqSend()
        //{
        //    byte[] buffer = Encoding.ASCII.GetBytes(ipSrc);
        //    _clientSocket.Send(buffer);
        //    string req = tbxMessage.Text;
        //    addCommand("Text request " + req);
        //    buffer = Encoding.ASCII.GetBytes(req);
        //    _clientSocket.Send(buffer);

        //    byte[] receivedBuf = new byte[1024];
        //    int rec = _clientSocket.Receive(receivedBuf);
        //    byte[] data = new byte[rec];
        //    Array.Copy(receivedBuf, data, rec);
        //    addCommand("Received: " + Encoding.ASCII.GetString(data));
        //}

        //int attempts = 0;

        //private void reqConnect()
        //{
        //    try
        //    {
        //        attempts++;
        //        ipSrc = GetIPAddress();
        //        _clientSocket.Connect(IPAddress.Parse(ipDst = "169.254.162.201"), 100);
        //        tbxStatus.ResetText();
        //        if (_clientSocket.Connected)
        //            addCommand("Connected to: " + ipDst);
        //    }
        //    catch (SocketException)
        //    {
        //        tbxStatus.ResetText();
        //        addCommand("IP Source        : " + ipSrc);
        //        addCommand("IP Destination   : " + ipDst);
        //        addCommand("Connection attempts: " + attempts.ToString());
        //    }
        //}

        //public static string GetIPAddress()
        //{
        //    IPHostEntry Host = default(IPHostEntry);
        //    string Hostname = null;
        //    Hostname = System.Environment.MachineName;
        //    Host = Dns.GetHostEntry(Hostname);
        //    foreach (IPAddress IP in Host.AddressList)
        //        if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        //            ipSrc = (IP).ToString();
        //    return ipSrc;
        //}

        //private void btnConnnectClient_Click(object sender, EventArgs e)
        //{
        //    reqConnect();
        //}

        //private void btnSend_Click(object sender, EventArgs e)
        //{
        //    reqSend();
        //    tbxMessage.ResetText();
        //}
    }
}
