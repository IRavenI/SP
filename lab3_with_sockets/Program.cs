using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name");
            Console.WriteLine(Environment.NewLine);

            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello, " + name);

            Console.WriteLine("Your ip address is:");
            Console.WriteLine(Environment.NewLine);

            String strHostName = new String("");
            if (args.Length == 0)
            {
                strHostName = Dns.GetHostName();
                Console.WriteLine("Local Machine's Host Name: " + strHostName);
            }
            else
            {
                strHostName = args[0];
            }

            // Then using host name, get the IP address list..

            IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            }
			Console.ReadLine();
        }
    }
}
