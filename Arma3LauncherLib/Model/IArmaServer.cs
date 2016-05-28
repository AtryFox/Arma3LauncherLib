using DerAtrox.Arma3LauncherLib.SSQLib.Model;

namespace DerAtrox.Arma3LauncherLib.Model {
    public interface IArmaServer {
        ServerInfo GetServerInfo();
        PlayerInfo[] GetPlayerList();
        int PingServer();
        void Connect();
    }
}