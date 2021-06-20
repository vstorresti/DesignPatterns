using System;
using System.Collections.Generic;

namespace Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "Server I", IP = "120.14.220.18" },
                new Server{ Name = "Server II", IP = "120.14.220.19" },
                new Server{ Name = "Server III", IP = "120.14.220.20" },
                new Server{ Name = "Server IV", IP = "120.14.220.21" },
                new Server{ Name = "Server V", IP = "120.14.220.22" }
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}