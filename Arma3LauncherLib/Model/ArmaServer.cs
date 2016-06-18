using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.SSQLib;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides a collection of methods to use with a Arma server.
    /// </summary>
    public class ArmaServer {
        /// <summary>
        /// Initialzes a new Arma server using an <see cref="IPEndPoint">IPEndPoint.</see>
        /// </summary>
        /// <param name="ipEndPointSteam">IPEndPoint of Arma server with steam querry port (usually gameport + 1).</param>
        /// <param name="gameport">Gameport of Arma server.</param>
        /// <param name="password">Password of Arma server (default: "")</param>
        public ArmaServer(IPEndPoint ipEndPointSteam, int gameport, string password = "") {
            ServerAdress = ipEndPointSteam.Address.ToString();
            GamePort = gameport;
            SteamPort = ipEndPointSteam.Port;
            Password = password;
        }

        /// <summary>
        /// Initialzes a new Arma server using an <see cref="IPEndPoint">IPEndPoint.</see>
        /// </summary>
        /// <param name="host">IP or hostname of Arma server.</param>
        /// <param name="gameport">Gameport of Arma server.</param>
        /// <param name="steamport">Steam query port (usually gameport + 1) of Arma server.</param>
        /// <param name="password">Password of Arma server (default: "")</param>
        public ArmaServer(string host, int gameport, int steamport, string password = "") {
            ServerAdress = host;
            GamePort = gameport;
            SteamPort = steamport;
            Password = password;
        }

        /// <summary>
        /// Gets or sets the adress of the Arma server.
        /// </summary>
        public string ServerAdress { get; set; }

        /// <summary>
        /// Gets or sets the game port of the Arma server.
        /// </summary>
        public int GamePort { get; set; }

        /// <summary>
        /// Gets or sets the steam query port of the Arma server.
        /// </summary>
        public int SteamPort { get; set; }

        /// <summary>
        /// Gets or sets the server password to use.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Fetches the server info of the provided server.
        /// </summary>
        /// <returns><see cref="ServerInfo">Server info</see> of the provided server.</returns>
        public ServerInfo GetServerInfo() {
            return new SourceServerQuery().Server(ServerAdress, SteamPort);
        }

        /// <summary>
        /// Fetches the server info of the provided server asynchronously.
        /// </summary>
        /// <returns><see cref="ServerInfo">Server info</see> of the provided server.</returns>
        public async Task<ServerInfo> GetServerInfoAsync() {
            return await Task.Run(() => GetServerInfo());
        }

        /// <summary>
        /// Fetches the connected players on the provided server.
        /// </summary>
        /// <returns>Array with multiple <see cref="PlayerInfo">player infos</see>.</returns>
        public List<PlayerInfo> GetPlayerList() {
            return new SourceServerQuery().Players(ServerAdress, SteamPort);
        }

        /// <summary>
        /// Fetches the connected players on the provided server asynchronously.
        /// </summary>
        /// <returns>Array with multiple <see cref="PlayerInfo">player infos</see>.</returns>
        public async Task<List<PlayerInfo>> GetPlayerListAsync() {
            return await Task.Run(() => GetPlayerList());
        }
    }
}
