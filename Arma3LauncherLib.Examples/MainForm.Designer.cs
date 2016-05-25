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
            this.labelListProfiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listProfiles
            // 
            this.listProfiles.FormattingEnabled = true;
            this.listProfiles.Location = new System.Drawing.Point(12, 25);
            this.listProfiles.Name = "listProfiles";
            this.listProfiles.Size = new System.Drawing.Size(127, 95);
            this.listProfiles.TabIndex = 0;
            // 
            // labelListProfiles
            // 
            this.labelListProfiles.AutoSize = true;
            this.labelListProfiles.Location = new System.Drawing.Point(9, 9);
            this.labelListProfiles.Name = "labelListProfiles";
            this.labelListProfiles.Size = new System.Drawing.Size(79, 13);
            this.labelListProfiles.TabIndex = 1;
            this.labelListProfiles.Text = "Arma 3 profiles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListProfiles);
            this.Controls.Add(this.listProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Arma3LauncherLib.Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ListBox listProfiles;
        private System.Windows.Forms.Label labelListProfiles;
        private System.Windows.Forms.Label label1;
    }
}

