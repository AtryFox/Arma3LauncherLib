using System;
using System.Net;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;

#pragma warning disable CS1591

namespace DerAtrox.Arma3LauncherLib.Model {
    public class ArmaServer : IArmaServer {
        private IPEndPoint _ipEndPoint;

        public ArmaServer(IPEndPoint ipEndPoint) {
            _ipEndPoint = ipEndPoint;
        }

        public ServerInfo GetServerInfo() {
            throw new NotImplementedException();
        }

        public async Task<ServerInfo> GetServerInfoAsync() {
            return await Task.Run(() => GetServerInfo());
        }

        public PlayerInfo[] GetPlayerList() {
            throw new NotImplementedException();
        }

        public async Task<PlayerInfo[]> GetPlayerListAsync() {
            return await Task.Run(() => GetPlayerList());
        }

        public int PingServer() {
            throw new NotImplementedException();
        }

        public void Connect() {
            throw new NotImplementedException();
        }
    }
}
