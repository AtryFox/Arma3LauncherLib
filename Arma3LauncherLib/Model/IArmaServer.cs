using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides a collection of methods to use with a Arma server.
    /// </summary>
    public interface IArmaServer {
        /// <summary>
        /// Gets or sets the adress of the Arma server.
        /// </summary>
        string ServerAdress { get; set; }
        /// <summary>
        /// Gets or sets the game port of the Arma server.
        /// </summary>
        int GamePort { get; set; }
        /// <summary>
        /// Gets or sets the steam query port of the Arma server.
        /// </summary>
        int SteamPort { get; set; }
        /// <summary>
        /// Fetches the server info of the provided server.
        /// </summary>
        /// <returns><see cref="ServerInfo">Server info</see> of the provided server.</returns>
        ServerInfo GetServerInfo();
        /// <summary>
        /// Fetches the server info of the provided server asynchronously.
        /// </summary>
        /// <returns><see cref="ServerInfo">Server info</see> of the provided server.</returns>
        Task<ServerInfo> GetServerInfoAsync();
        /// <summary>
        /// Fetches the connected players on the provided server.
        /// </summary>
        /// <returns>Array with multiple <see cref="PlayerInfo">player infos</see>.</returns>
        List<PlayerInfo> GetPlayerList();
        /// <summary>
        /// Fetches the connected players on the provided server asynchronously.
        /// </summary>
        /// <returns>Array with multiple <see cref="PlayerInfo">player infos</see>.</returns>
        Task<List<PlayerInfo>> GetPlayerListAsync();
    }
}