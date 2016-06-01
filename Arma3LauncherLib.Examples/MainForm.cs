﻿using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using DerAtrox.Arma3LauncherLib.Model;
using DerAtrox.Arma3LauncherLib.Utilities;

namespace DerAtrox.Arma3LauncherLib.Examples {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            listProfiles.DataSource = ProfileUtils.GetProfiles();
        }
    }
}
