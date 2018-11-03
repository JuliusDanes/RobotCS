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
    class bakS
    {
        //public BaseStation()
        //{
        //    InitializeComponent();
        //}

        //private static byte[] _buffer = new byte[1024];
        //private static List<Socket> _clientSocketList = new List<Socket>();
        //private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //static string ipSrc, ipDst;

        //private void btnOpenServer_Click(object sender, EventArgs e)
        //{
        //    SetupServer();
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

        //private void SetupServer()
        //{
        //    //Console.WriteLine("Setting up server...");
        //    addCommand("Setting up server...");
        //    _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
        //    _serverSocket.Listen(1);
        //    _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        //}

        //private void AcceptCallback(IAsyncResult AR)
        //{
        //    Socket socket = _serverSocket.EndAccept(AR);
        //    _clientSocketList.Add(socket);
        //    //if (socket.Connected)
        //    //{
        //    socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        //    _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        //    Thread.Sleep(1000);
        //    //Console.WriteLine("Client Connected for: " + ipSrc);
        //    addCommand("Client Connected to: " + ipSrc);
        //    //}
        //}

        //private void ReceiveCallback(IAsyncResult AR)
        //{
        //    Socket socket = (Socket)AR.AsyncState;
        //    int received = socket.EndReceive(AR);
        //    byte[] dataBuf = new byte[received];
        //    Array.Copy(_buffer, dataBuf, received);
        //    string text = Encoding.ASCII.GetString(dataBuf);
        //    string respone = string.Empty;
        //    if (Regex.IsMatch(text, @"[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}"))
        //        ipSrc = text;
        //    else
        //    {
        //        //Console.WriteLine("@{0}> {1}", ipSrc, text);
        //        addCommand("@" + ipSrc + "> " + text);

        //        if (text.ToLower() != "get time")
        //            respone = "Invalid Request";
        //        else
        //            respone = DateTime.Now.ToLongTimeString();
        //    }
        //    byte[] data = Encoding.ASCII.GetBytes(respone);
        //    socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
        //    socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        //}

        ////private static void SendText(string text)
        ////{
        ////    byte[] data = Encoding.ASCII.GetBytes(text);
        ////    socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
        ////}

        //private static void SendCallback(IAsyncResult AR)
        //{
        //    Socket socket = (Socket)AR.AsyncState;
        //    socket.EndSend(AR);
        //}


        //////////////////////////////////////////////////////////////////////////

        //private static Socket _clientSocketLite = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //int attempts = 0;

        //private void reqConnect()
        //{
        //    try
        //    {
        //        attempts++;
        //        ipSrc = GetIPAddress();
        //        _clientSocketLite.Connect(IPAddress.Parse(ipDst = "169.254.162.201"), 100);
        //        tbxStatus.ResetText();
        //        if (_clientSocketLite.Connected)
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
    }
}
