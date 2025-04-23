using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TcpIpServer
{
    public partial class IpServer : Form
    {
        public IpServer()
        {
            InitializeComponent();
        }
        Socket socketSend;//Socket responsible for communication
        Socket socketListener;//Socket responsible for monitoring
        Dictionary<string, Socket> dictionary = new Dictionary<string, Socket>();//Store the connected Socket
        private void listnerB_Click(object sender, EventArgs e)
        {
            //Create a listening socket
            //SocketType.Stream streaming corresponds to the tcp protocol
            //Dgram, datagram corresponds to UDP protocol
            socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //Create IP address and port number;
                IPAddress ip = IPAddress.Parse(IpBox.Text);
                int port = Convert.ToInt32(PortBox.Text);
                IPEndPoint iPEndPoint = new IPEndPoint(ip, port);
                //Let the listening socket bind the ip and port number
                socketListener.Bind(iPEndPoint);
                Log("Listen successfully" + ip + "\t" + port);
                //Set up the listening queue
                socketListener.Listen(10);//Maximum number of connections at a time
                Thread thread = new Thread(Listen);
                thread.IsBackground = true;
                thread.Start(socketListener);
            }
            catch
            {
                Log("Failed to listen");
            }
        }

        //Use threads to receive data
        private void Listen(object o)
        {
            Socket socket = o as Socket;
            while (true)
            {
                //The socket responsible for monitoring is used to receive client connections
                try
                {
                    //Create a socket responsible for communication
                    socketSend = socket.Accept();
                    dictionary.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    ClientCombox.Items.Add(socketSend.RemoteEndPoint.ToString());
                    ClientCombox.SelectedIndex = ClientCombox.Items.IndexOf(socketSend.RemoteEndPoint.ToString());
                    Log("Connected " + socketSend.RemoteEndPoint.ToString());
                    //Start a new thread to receive information from the client
                    Thread th = new Thread(receive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch
                {
                    continue;
                }
            }
        }

        //The server receives the message from the client
        private void receive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                //Try to connect to the client
                try
                {
                    //After the client connects successfully, the server receives the message from the client
                    byte[] buffer = new byte[1024 * 1024 * 2];//2M大小
                                                              //Number of valid bytes received
                    int length = socketSend.Receive(buffer);
                    if (length == 0)
                    {
                        string tmpIp = socketSend.RemoteEndPoint.ToString();
                        Log(tmpIp + " Offline");
                        ClientCombox.Items.Remove(tmpIp);
                        //Try to delete the connection information
                        try
                        {
                            ClientCombox.SelectedIndex = 0;
                        }
                        catch
                        {
                            ClientCombox.Text = null;
                        }
                        CloseSocket(dictionary[tmpIp]);
                        dictionary.Remove(tmpIp);
                        break;
                    }
                    string str = Encoding.ASCII.GetString(buffer, 0, length);
                    Log(socketSend.RemoteEndPoint.ToString() + "\n\t" + str);
                }
                catch
                {
                    break;
                }
            }
        }

        private void Log(string str)
        {
            ServerLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cancel errors caused by cross-thread calls
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //Send a message
        private void SendB_Click(object sender, EventArgs e)
        {
            string txt = SendText.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(txt);
            try
            {
                string ip = ClientCombox.SelectedItem.ToString();//Get the selected ip address
                Socket socketsend = dictionary[ip];
                socketsend.Send(buffer);
            }
            catch
            {
                Log("Transmission failed");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string tmpip = socketSend.RemoteEndPoint.ToString();
                    CloseSocket(dictionary[tmpip]);
                    dictionary.Remove(tmpip);
                    ClientCombox.Items.Remove(tmpip);
                    try
                    {
                        ClientCombox.SelectedIndex = 0;
                    }
                    catch
                    {
                        ClientCombox.Text = null;
                    }
                    socketSend.Close();
                    Log(socketSend.RemoteEndPoint.ToString() + "Offline");
                    socketListener.Close();
                    Log("Listener is closed");
                }
                catch
                {
                    socketListener.Close();
                    Log("Listener is closed");
                }
            }
            catch
            {
                Log("close error");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                try
                {
                    string tmpip = socketSend.RemoteEndPoint.ToString();
                    CloseSocket(dictionary[tmpip]);
                    dictionary.Remove(tmpip);
                    ClientCombox.Items.Remove(tmpip);
                    try
                    {
                        ClientCombox.SelectedIndex = 0;
                    }
                    catch
                    {
                        ClientCombox.Text = null;
                    }
                    socketSend.Close();
                    socketListener.Close();
                }
                catch
                {
                    socketListener.Close();
                }
            }
            catch
            {
            }
        }

        private void CloseSocket(Socket o)
        {
            try
            {
                o.Shutdown(SocketShutdown.Both);
                o.Disconnect(false);
                o.Close();
            }
            catch
            {
                Log(o.ToString() + "error");
            }
        }
    }
}
