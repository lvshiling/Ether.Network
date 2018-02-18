using Ether.Network.Common;
using Ether.Network.Server;
using System;

namespace Ether.Network.Tests.Contexts.NetConfig
{
    public class ConfigServer : NetServer<Client>
    {
        protected override void Initialize()
        {
        }

        protected override void OnClientConnected(Client connection)
        {
        }

        protected override void OnClientDisconnected(Client connection)
        {
        }

        protected override void OnError(Exception exception)
        {
        }

        public void SetupConfiguration()
        {
            this.Configuration.Blocking = false;
            this.Configuration.Host = "127.0.0.1";
            this.Configuration.Port = 4444;
            this.Configuration.BufferSize = 1024;
        }
    }

    public class Client : NetUser
    {
    }
}
