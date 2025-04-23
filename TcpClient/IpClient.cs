using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class IpClient : Form
    {
        public IpClient()
        {
            InitializeComponent();
        }
         Socket socket;//The socket responsible for the connection
        private void ConnectB_Click(object sender, EventArgs e) {
            //Determine whether to request a connection repeatedly
            try {
                Log("Connected " + socket.LocalEndPoint.ToString() + "\nPlease do not request the connection repeatedly");
            } catch {
                //Determine whether the input is wrong
                try {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //Create IP address and port number;
                    IPAddress ip = IPAddress.Parse(IpBox.Text);
                    int port = Convert.ToInt32(PortBox.Text);
                    IPEndPoint iPEndPoint = new IPEndPoint(ip, port);
                    //Determine whether you can connect to the server
                    try {
                        socket.Connect(iPEndPoint);
                        Log("Connected " + socket.LocalEndPoint.ToString());
                        //Start receiving data thread
                        Thread th = new Thread(receive);
                        th.IsBackground = true;
                        th.Start();
                    } catch {
                        Log("Port is not open");
                    }                  
                } catch  {
                    socket = null;
                    Log("Input error");
                }
            }
        }

        private void Log(string str) {
            ClientLog.AppendText(str + "\r\n");
        }
        private void receive() {
            while (true) {
                //Determine whether the data can be received
                try {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int length = socket.Receive(buffer);
                    if (length == 0) {
                        Log("Port is not open");
                        CloseSocket(socket);
                        socket = null;
                        break;
                    }
                    string txt = Encoding.UTF8.GetString(buffer, 0, length);
                    Log(socket.RemoteEndPoint + ":\r\t" + txt);
                } catch {
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void CloseB_Click(object sender, EventArgs e) {
            if (socket != null) {
                CloseSocket(socket);
                socket = null;
                Log("Connection closed");
                
            } else {
                Log("Not connected");
            }
        }

        private void SendB_Click(object sender, EventArgs e) {
            try {
                string txt = SendText.Text;
                byte[] buffer = Encoding.ASCII.GetBytes(txt);//ascii encoding
                socket.Send(buffer);
            } catch {
                Log("Not connected");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (socket != null) {
                CloseSocket(socket);
                socket = null;
            }
        }

        //Disconnect socket
        private void CloseSocket(Socket o) {
            try {
                o.Shutdown(SocketShutdown.Both);
                o.Disconnect(false);
                o.Close();
            } catch {
                Log("error");
            }
        }
    }
}
