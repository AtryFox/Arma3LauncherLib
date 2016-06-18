using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.SSQLib;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;
using DerAtrox.Arma3LauncherLib.SSQLib.Utilities;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides a collection of methods to use with a Arma server.
    /// </summary>
    public class ArmaServer : IArmaServer {
        /// <summary>
        /// Initialzes a new Arma server using an <see cref="IPEndPoint">IPEndPoint.</see>
        /// </summary>
        /// <param name="ipEndPointSteam">IPEndPoint of Arma server with steam querry port (usually gameport + 1).</param>
        /// <param name="gameport">Gameport of Arma server.</param>
        public ArmaServer(IPEndPoint ipEndPointSteam, int gameport) {
            ServerAdress = ipEndPointSteam.Address.ToString();
            GamePort = gameport;
            SteamPort = ipEndPointSteam.Port;
        }

        /// <summary>
        /// Initialzes a new Arma server using an <see cref="IPEndPoint">IPEndPoint.</see>
        /// </summary>
        /// <param name="host">IP or hostname of Arma server.</param>
        /// <param name="gameport">Gameport of Arma server.</param>
        /// <param name="steamport">Steam query port (usually gameport + 1) of Arma server.</param>
        public ArmaServer(string host, int gameport, int steamport) {
            ServerAdress = host;
            GamePort = gameport;
            SteamPort = steamport;
        }

        public string ServerAdress { get; set; }
        public int GamePort { get; set; }
        public int SteamPort { get; set; }

        public ServerInfo GetServerInfo() {
            return new SourceServerQuery().Server(ServerAdress, SteamPort);
        }

        public async Task<ServerInfo> GetServerInfoAsync() {
            return await Task.Run(() => GetServerInfo());
        }

        public List<PlayerInfo> GetPlayerList() {
            return new SourceServerQuery().Players(ServerAdress, SteamPort);
        }

        public async Task<List<PlayerInfo>> GetPlayerListAsync() {
            return await Task.Run(() => GetPlayerList());
        }
    }
}
