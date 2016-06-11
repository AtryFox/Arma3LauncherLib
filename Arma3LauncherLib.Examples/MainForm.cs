using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using DerAtrox.Arma3LauncherLib.Model;
using DerAtrox.Arma3LauncherLib.SSQLib.Exceptions;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;
using DerAtrox.Arma3LauncherLib.Utilities;

namespace DerAtrox.Arma3LauncherLib.Examples {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            listProfiles.DataSource = ProfileUtils.GetProfiles();
        }

        private void SetServerInfo(ServerInfo serverInfo) {
            lblServerName.Text = serverInfo.Name;
            lblServerGamePort.Text = serverInfo.Port;
            lblServerMap.Text = serverInfo.Map;
            lblServerSlots.Text = serverInfo.PlayerCount;
            lblServerMaxSlots.Text = serverInfo.MaxPlayers;
        }

        private async void btnServerGo_Click(object sender, EventArgs e) {
            IArmaServer server;

            try {
                server = new ArmaServer(txtServerAdress.Text, Convert.ToInt32(numServerSteamPort.Value));
            } catch (ArgumentException ex) {
                MessageBox.Show(@"Error: " + ex.Message);
                return;
            }

            var b = (Button)sender;

            try {
                if (b.Text.Contains("Async")) {
                    SetServerInfo(await server.GetServerInfoAsync());
                } else {
                    SetServerInfo(server.GetServerInfo());
                }
            } catch (SourceServerException ex) {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
