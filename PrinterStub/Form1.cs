using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterStub
{
    public partial class Form1 : Form
    {
        IPAddress ipAddr;
        IPHostEntry ipHost;
        IPEndPoint localEndPoint;
        public Form1()
        {
            InitializeComponent();

            ipHost = Dns.GetHostEntry(Dns.GetHostName());
            ipAddr = ipHost.AddressList[3];
            localEndPoint = new IPEndPoint(ipAddr, 49321);



        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            try
            {
                Socket listener = new Socket(ipAddr.AddressFamily,
               SocketType.Stream, ProtocolType.Tcp);
                listener.Listen(10);
                listener.Bind(localEndPoint);

                while (true)
                {
                    Console.WriteLine("Waiting connection ... ");

                    // Suspend while waiting for 
                    // incoming connection Using  
                    // Accept() method the server  
                    // will accept connection of client 
                    Socket clientSocket = listener.Accept();

                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {

                        int numByte = clientSocket.Receive(bytes);

                        txtMessagesFromSFS.AppendText(Encoding.ASCII.GetString(bytes,
                                                   0, numByte));


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
