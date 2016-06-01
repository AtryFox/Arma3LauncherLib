using System.Net.NetworkInformation;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides a collection of methods to use with a Arma server.
    /// </summary>
    public interface IArmaServer {
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
        PlayerInfo[] GetPlayerList();
        /// <summary>
        /// Fetches the connected players on the provided server asynchronously.
        /// </summary>
        /// <returns>Array with multiple <see cref="PlayerInfo">player infos</see>.</returns>
        Task<PlayerInfo[]> GetPlayerListAsync();
        /// <summary>
        /// Pings the provided server.
        /// </summary>
        /// <returns>Ping to the server.</returns>
        int PingServer();
        /// <summary>
        /// Pings the provided server asynchronously.
        /// </summary>
        /// <returns>Ping to the server.</returns>
        Task<int> PingServerAsync();

        /// <summary>
        /// 
        /// </summary>
        void Connect();
    }
}