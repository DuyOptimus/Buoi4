using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipAddress;
            int port;
            string protocol;
            Console.Write("nhap host ip:");
            ipAddress = Console.ReadLine();
            Console.Write("nhap host port:");
            port = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap protocol:");
            protocol = Console.ReadLine();
            switch (protocol)
            {
                case "TCP":
                    IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipAddress), port);
                    TcpClient client = new TcpClient();
                    try
                    {
                        client.Connect(ip);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("host:{0}:{1} is close", ipAddress, port);
                        Console.WriteLine(ex);
                        Environment.Exit(0);
                    }
                    Console.WriteLine("host; {0}:{1} is open", ipAddress, port);
                    break;
                case "UDP":
                    break;
            }
        }
    }
}
