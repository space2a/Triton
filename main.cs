using System;
using System.Collections.Generic;
using System.Threading;

namespace triton
{
    class main
    {
        public static string tVersion = "1.0";
        static List<TServer> servers = new List<TServer>();

        static void Main(string[] args)
        {
            Console.WriteLine("triton web server v" + tVersion + "\n\n");

            servers.Add(new TServer() { name = "example", port = 8880, fulldirectorypath = "D:", isHttps = false });


            for (int i = 0; i < servers.Count; i++)
                Console.WriteLine("server: " + servers[i].name + ":" + servers[i].port + " directory: " + servers[i].fulldirectorypath + " started:" + new webserver(servers[i].threads).Start(servers[i]));
        }

    }



    class TServer
    {
        public string name = "";
        public int port = 0;
        public int threads = 12;
        public string defaultServerFile = "index.html";
        public string fulldirectorypath = "";
        public bool isHttps = false;

    }
}
