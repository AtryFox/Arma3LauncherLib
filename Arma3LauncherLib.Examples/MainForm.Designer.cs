namespace DerAtrox.Arma3LauncherLib.Examples {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.listProfiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numServerGamePort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numServerSteamPort = new System.Windows.Forms.NumericUpDown();
            this.lblServerGamePort = new System.Windows.Forms.Label();
            this.listServerPlayers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnServerAsync = new System.Windows.Forms.Button();
            this.lblServerMaxSlots = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblServerSlots = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblServerPing = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblServerMap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServerGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerAdress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArmaPath = new System.Windows.Forms.TextBox();
            this.chkNoSplash = new System.Windows.Forms.CheckBox();
            this.chkScriptErrors = new System.Windows.Forms.CheckBox();
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerGamePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerSteamPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProfiles
            // 
            this.listProfiles.FormattingEnabled = true;
            this.listProfiles.IntegralHeight = false;
            this.listProfiles.Location = new System.Drawing.Point(6, 19);
            this.listProfiles.Name = "listProfiles";
            this.listProfiles.Size = new System.Drawing.Size(136, 100);
            this.listProfiles.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listProfiles);
            this.groupBox1.Location = new System.Drawing.Point(203, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arma 3 profiles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numServerGamePort);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numServerSteamPort);
            this.groupBox2.Controls.Add(this.lblServerGamePort);
            this.groupBox2.Controls.Add(this.listServerPlayers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnServerAsync);
            this.groupBox2.Controls.Add(this.lblServerMaxSlots);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblServerSlots);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblServerPing);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblServerMap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblServerName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnServerGo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtServerAdress);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 350);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test server query";
            // 
            // numServerGamePort
            // 
            this.numServerGamePort.Location = new System.Drawing.Point(87, 71);
            this.numServerGamePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerGamePort.Name = "numServerGamePort";
            this.numServerGamePort.Size = new System.Drawing.Size(75, 20);
            this.numServerGamePort.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Game port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Playerlist:";
            // 
            // numServerSteamPort
            // 
            this.numServerSteamPort.Location = new System.Drawing.Point(6, 71);
            this.numServerSteamPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerSteamPort.Name = "numServerSteamPort";
            this.numServerSteamPort.Size = new System.Drawing.Size(75, 20);
            this.numServerSteamPort.TabIndex = 18;
            // 
            // lblServerGamePort
            // 
            this.lblServerGamePort.AutoSize = true;
            this.lblServerGamePort.Location = new System.Drawing.Point(61, 152);
            this.lblServerGamePort.Name = "lblServerGamePort";
            this.lblServerGamePort.Size = new System.Drawing.Size(0, 13);
            this.lblServerGamePort.TabIndex = 17;
            // 
            // listServerPlayers
            // 
            this.listServerPlayers.FormattingEnabled = true;
            this.listServerPlayers.IntegralHeight = false;
            this.listServerPlayers.Location = new System.Drawing.Point(9, 249);
            this.listServerPlayers.Name = "listServerPlayers";
            this.listServerPlayers.Size = new System.Drawing.Size(170, 95);
            this.listServerPlayers.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gameport:";
            // 
            // btnServerAsync
            // 
            this.btnServerAsync.Location = new System.Drawing.Point(87, 97);
            this.btnServerAsync.Name = "btnServerAsync";
            this.btnServerAsync.Size = new System.Drawing.Size(75, 23);
            this.btnServerAsync.TabIndex = 15;
            this.btnServerAsync.Text = "Go Async";
            this.btnServerAsync.UseVisualStyleBackColor = true;
            this.btnServerAsync.Click += new System.EventHandler(this.btnServerGo_Click);
            // 
            // lblServerMaxSlots
            // 
            this.lblServerMaxSlots.AutoSize = true;
            this.lblServerMaxSlots.Location = new System.Drawing.Point(61, 204);
            this.lblServerMaxSlots.Name = "lblServerMaxSlots";
            this.lblServerMaxSlots.Size = new System.Drawing.Size(0, 13);
            this.lblServerMaxSlots.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Max slots:";
            // 
            // lblServerSlots
            // 
            this.lblServerSlots.AutoSize = true;
            this.lblServerSlots.Location = new System.Drawing.Point(61, 191);
            this.lblServerSlots.Name = "lblServerSlots";
            this.lblServerSlots.Size = new System.Drawing.Size(0, 13);
            this.lblServerSlots.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Slots:";
            // 
            // lblServerPing
            // 
            this.lblServerPing.AutoSize = true;
            this.lblServerPing.Location = new System.Drawing.Point(61, 178);
            this.lblServerPing.Name = "lblServerPing";
            this.lblServerPing.Size = new System.Drawing.Size(0, 13);
            this.lblServerPing.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ping";
            // 
            // lblServerMap
            // 
            this.lblServerMap.AutoSize = true;
            this.lblServerMap.Location = new System.Drawing.Point(61, 165);
            this.lblServerMap.Name = "lblServerMap";
            this.lblServerMap.Size = new System.Drawing.Size(0, 13);
            this.lblServerMap.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Map:";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(61, 139);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(0, 13);
            this.lblServerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // btnServerGo
            // 
            this.btnServerGo.Location = new System.Drawing.Point(6, 97);
            this.btnServerGo.Name = "btnServerGo";
            this.btnServerGo.Size = new System.Drawing.Size(75, 23);
            this.btnServerGo.TabIndex = 4;
            this.btnServerGo.Text = "Go";
            this.btnServerGo.UseVisualStyleBackColor = true;
            this.btnServerGo.Click += new System.EventHandler(this.btnServerGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Steam port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server adress";
            // 
            // txtServerAdress
            // 
            this.txtServerAdress.Location = new System.Drawing.Point(6, 32);
            this.txtServerAdress.Name = "txtServerAdress";
            this.txtServerAdress.Size = new System.Drawing.Size(173, 20);
            this.txtServerAdress.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(63, 184);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtArmaPath);
            this.groupBox3.Controls.Add(this.chkNoSplash);
            this.groupBox3.Controls.Add(this.chkScriptErrors);
            this.groupBox3.Controls.Add(this.chkWindow);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(203, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 213);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arma settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Arma 3 Exe";
            // 
            // txtArmaPath
            // 
            this.txtArmaPath.Location = new System.Drawing.Point(6, 105);
            this.txtArmaPath.Name = "txtArmaPath";
            this.txtArmaPath.Size = new System.Drawing.Size(136, 20);
            this.txtArmaPath.TabIndex = 9;
            // 
            // chkNoSplash
            // 
            this.chkNoSplash.AutoSize = true;
            this.chkNoSplash.Location = new System.Drawing.Point(6, 65);
            this.chkNoSplash.Name = "chkNoSplash";
            this.chkNoSplash.Size = new System.Drawing.Size(121, 17);
            this.chkNoSplash.TabIndex = 8;
            this.chkNoSplash.Text = "NoSplash/NoPause";
            this.chkNoSplash.UseVisualStyleBackColor = true;
            // 
            // chkScriptErrors
            // 
            this.chkScriptErrors.AutoSize = true;
            this.chkScriptErrors.Location = new System.Drawing.Point(6, 42);
            this.chkScriptErrors.Name = "chkScriptErrors";
            this.chkScriptErrors.Size = new System.Drawing.Size(110, 17);
            this.chkScriptErrors.TabIndex = 7;
            this.chkScriptErrors.Text = "Show script errors";
            this.chkScriptErrors.UseVisualStyleBackColor = true;
            // 
            // chkWindow
            // 
            this.chkWindow.AutoSize = true;
            this.chkWindow.Location = new System.Drawing.Point(6, 19);
            this.chkWindow.Name = "chkWindow";
            this.chkWindow.Size = new System.Drawing.Size(106, 17);
            this.chkWindow.TabIndex = 6;
            this.chkWindow.Text = "Windowed mode";
            this.chkWindow.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Arma3LauncherLib.Examples";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerGamePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerSteamPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ListBox listProfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblServerGamePort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnServerAsync;
        private System.Windows.Forms.Label lblServerMaxSlots;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblServerSlots;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblServerPing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblServerMap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnServerGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerAdress;
        private System.Windows.Forms.NumericUpDown numServerSteamPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listServerPlayers;
        private System.Windows.Forms.NumericUpDown numServerGamePort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkNoSplash;
        private System.Windows.Forms.CheckBox chkScriptErrors;
        private System.Windows.Forms.CheckBox chkWindow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArmaPath;
    }
}

