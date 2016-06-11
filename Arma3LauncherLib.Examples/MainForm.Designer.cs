﻿namespace DerAtrox.Arma3LauncherLib.Examples {
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
            this.numServerSteamPort = new System.Windows.Forms.NumericUpDown();
            this.lblServerGamePort = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerSteamPort)).BeginInit();
            this.SuspendLayout();
            // 
            // listProfiles
            // 
            this.listProfiles.FormattingEnabled = true;
            this.listProfiles.Location = new System.Drawing.Point(6, 19);
            this.listProfiles.Name = "listProfiles";
            this.listProfiles.Size = new System.Drawing.Size(136, 95);
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
            this.groupBox2.Controls.Add(this.numServerSteamPort);
            this.groupBox2.Controls.Add(this.lblServerGamePort);
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
            this.groupBox2.Size = new System.Drawing.Size(185, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test server query";
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
            this.numServerSteamPort.Size = new System.Drawing.Size(173, 20);
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
            this.lblServerPing.Size = new System.Drawing.Size(86, 13);
            this.lblServerPing.TabIndex = 10;
            this.lblServerPing.Text = "Not implemented";
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
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Steam port (mostly gameport + 1)";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Arma3LauncherLib.Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerSteamPort)).EndInit();
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
    }
}

