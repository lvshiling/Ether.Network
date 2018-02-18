﻿using System.Net.Sockets;
using Ether.Network.Client;

namespace Ether.Network.Tests.Contexts.NetConfig
{
    public class ConfigClient : NetClient
    {
        protected override void OnConnected()
        {
        }

        protected override void OnDisconnected()
        {
        }

        protected override void OnSocketError(SocketError socketError)
        {
        }

        public void SetConfiguration()
        {
            this.Configuration.Host = "127.0.0.1";
            this.Configuration.Port = 4444;
            this.Configuration.BufferSize = 512;
        }
    }
}
