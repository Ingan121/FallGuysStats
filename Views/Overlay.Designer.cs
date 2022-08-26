namespace FallGuysStats {
    partial class Overlay {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.lblFilter = new FallGuysStats.TransparentLabel();
            this.lblStreak = new FallGuysStats.TransparentLabel();
            this.lblFinals = new FallGuysStats.TransparentLabel();
            this.lblQualifyChance = new FallGuysStats.TransparentLabel();
            this.lblFastest = new FallGuysStats.TransparentLabel();
            this.lblDuration = new FallGuysStats.TransparentLabel();
            this.lblPlayers = new FallGuysStats.TransparentLabel();
            this.lblName = new FallGuysStats.TransparentLabel();
            this.lblWins = new FallGuysStats.TransparentLabel();
            this.lblFinish = new FallGuysStats.TransparentLabel();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.TextRight = "";
            // 
            // lblStreak
            // 
            resources.ApplyResources(this.lblStreak, "lblStreak");
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.TextRight = "0 (BEST 0)";
            // 
            // lblFinals
            // 
            resources.ApplyResources(this.lblFinals, "lblFinals");
            this.lblFinals.Name = "lblFinals";
            this.lblFinals.TextRight = "0 - 0.0%";
            // 
            // lblQualifyChance
            // 
            resources.ApplyResources(this.lblQualifyChance, "lblQualifyChance");
            this.lblQualifyChance.Name = "lblQualifyChance";
            this.lblQualifyChance.TextRight = "0 / 0 - 0.0%";
            // 
            // lblFastest
            // 
            resources.ApplyResources(this.lblFastest, "lblFastest");
            this.lblFastest.Name = "lblFastest";
            this.lblFastest.TextRight = "-";
            // 
            // lblDuration
            // 
            resources.ApplyResources(this.lblDuration, "lblDuration");
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.TextRight = "-";
            // 
            // lblPlayers
            // 
            resources.ApplyResources(this.lblPlayers, "lblPlayers");
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.TextRight = "0";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.AutoEllipsis = true;
            this.lblName.Name = "lblName";
            this.lblName.TextRight = "N/A";
            // 
            // lblWins
            // 
            resources.ApplyResources(this.lblWins, "lblWins");
            this.lblWins.Name = "lblWins";
            this.lblWins.TextRight = "0 - 0.0%";
            // 
            // lblFinish
            // 
            resources.ApplyResources(this.lblFinish, "lblFinish");
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.TextRight = "-";
            // 
            // Overlay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Magenta;
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblStreak);
            this.Controls.Add(this.lblFinals);
            this.Controls.Add(this.lblQualifyChance);
            this.Controls.Add(this.lblFastest);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblFinish);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Overlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Overlay_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private TransparentLabel lblName;
        private TransparentLabel lblDuration;
        private TransparentLabel lblFinish;
        private TransparentLabel lblFastest;
        private TransparentLabel lblQualifyChance;
        private TransparentLabel lblWins;
        private TransparentLabel lblFinals;
        private TransparentLabel lblPlayers;
        private TransparentLabel lblStreak;
        private TransparentLabel lblFilter;
    }
}