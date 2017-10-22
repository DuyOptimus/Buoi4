using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace bai4_server
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            TcpListener server = new TcpListener(9050);
            server.Start();
            Console.WriteLine(" wating for a client...");
            TcpClient client = server.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            Console.Write("chon lenh: ");
            string cmd = Console.ReadLine();
            data = Encoding.ASCII.GetBytes(cmd);
            ns.Write(data, 0, data.Length);

        }
    }
}
