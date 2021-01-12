using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSocketTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 49321);

            // Create a Socket that will use Tcp protocol      
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // A Socket must be associated with an endpoint using the Bind method  
            listener.Bind(localEndPoint);
            // Specify how many requests a Socket can listen before it gives Server busy response.  
            // We will listen 10 requests at a time  
            listener.Listen(10);

            Console.WriteLine("Waiting for a connection...");
            Socket handler = listener.Accept();

            string data = null;
            byte[] bytes = null;

            while (true)
            {
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                Console.WriteLine(data+Environment.NewLine);
            }

            Console.WriteLine("Text received : {0}", data);

            byte[] msg = Encoding.ASCII.GetBytes(data);

            Console.Read();
        }

    }
}
