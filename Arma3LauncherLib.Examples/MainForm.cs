using System;
using System.Collections.Generic;
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

        private IArmaServer _currentServer;

        private async void btnServerGo_Click(object sender, EventArgs e) {
            try {
                _currentServer = new ArmaServer(txtServerAdress.Text, Convert.ToInt32(numServerGamePort.Value), Convert.ToInt32(numServerSteamPort.Value));
            } catch (ArgumentException ex) {
                MessageBox.Show(@"Error: " + ex.Message);
                return;
            }

            var b = (Button)sender;

            try {
                ServerInfo serverInfo;
                List<PlayerInfo> playerInfo;

                if (b.Text.Contains("Async")) {
                    serverInfo = await _currentServer.GetServerInfoAsync();
                    playerInfo = await _currentServer.GetPlayerListAsync();
                } else {
                    serverInfo = _currentServer.GetServerInfo();
                    playerInfo = _currentServer.GetPlayerList();
                }

                lblServerName.Text = serverInfo.Name;
                lblServerGamePort.Text = _currentServer.GamePort.ToString();
                lblServerPing.Text = serverInfo.Ping.ToString();
                lblServerMap.Text = serverInfo.Map;
                lblServerSlots.Text = serverInfo.PlayerCount;
                lblServerMaxSlots.Text = serverInfo.MaxPlayers;

                listServerPlayers.Items.Clear();
                foreach (PlayerInfo p in playerInfo) {
                    listServerPlayers.Items.Add(p.Name);
                }
            } catch (SourceServerException ex) {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
