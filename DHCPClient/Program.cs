using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace DHCPClient
{
    class Program
    {
        private static dclient client;
        static void Main(string[] args)
        {
            client = new dclient();
            System.Console.WriteLine("Received: " + client.requestAddress());
            System.Console.ReadKey();
        }
    }
}
