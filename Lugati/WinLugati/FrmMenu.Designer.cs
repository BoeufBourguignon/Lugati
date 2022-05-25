namespace WinLugati
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuLugati = new System.Windows.Forms.MenuStrip();
            this.menuLugatiItemParticipant = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLugatiItemHebergement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLugatiItemSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLugatiItemActivite = new System.Windows.Forms.ToolStripMenuItem();
            this.ligueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLugati.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLugati
            // 
            this.menuLugati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLugatiItemParticipant,
            this.menuLugatiItemHebergement,
            this.menuLugatiItemSession,
            this.menuLugatiItemActivite,
            this.ligueToolStripMenuItem});
            this.menuLugati.Location = new System.Drawing.Point(0, 0);
            this.menuLugati.Name = "menuLugati";
            this.menuLugati.Size = new System.Drawing.Size(800, 24);
            this.menuLugati.TabIndex = 0;
            this.menuLugati.Text = "menuStrip1";
            // 
            // menuLugatiItemParticipant
            // 
            this.menuLugatiItemParticipant.Name = "menuLugatiItemParticipant";
            this.menuLugatiItemParticipant.Size = new System.Drawing.Size(97, 20);
            this.menuLugatiItemParticipant.Text = "FrmParticipant";
            this.menuLugatiItemParticipant.Click += new System.EventHandler(this.menuLugatiItemParticipant_Click);
            // 
            // menuLugatiItemHebergement
            // 
            this.menuLugatiItemHebergement.Name = "menuLugatiItemHebergement";
            this.menuLugatiItemHebergement.Size = new System.Drawing.Size(113, 20);
            this.menuLugatiItemHebergement.Text = "FrmHebergement";
            this.menuLugatiItemHebergement.Click += new System.EventHandler(this.frmHebergementToolStripMenuItem_Click);
            // 
            // menuLugatiItemSession
            // 
            this.menuLugatiItemSession.Name = "menuLugatiItemSession";
            this.menuLugatiItemSession.Size = new System.Drawing.Size(79, 20);
            this.menuLugatiItemSession.Text = "FrmSession";
            this.menuLugatiItemSession.Click += new System.EventHandler(this.frmSessionToolStripMenuItem_Click);
            // 
            // menuLugatiItemActivite
            // 
            this.menuLugatiItemActivite.Name = "menuLugatiItemActivite";
            this.menuLugatiItemActivite.Size = new System.Drawing.Size(80, 20);
            this.menuLugatiItemActivite.Text = "FrmActivite";
            this.menuLugatiItemActivite.Click += new System.EventHandler(this.menuLugatiItemActivite_Click);
            // 
            // ligueToolStripMenuItem
            // 
            this.ligueToolStripMenuItem.Name = "ligueToolStripMenuItem";
            this.ligueToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ligueToolStripMenuItem.Text = "FrmLigue";
            this.ligueToolStripMenuItem.Click += new System.EventHandler(this.ligueToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuLugati);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuLugati;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuLugati.ResumeLayout(false);
            this.menuLugati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLugati;
        private System.Windows.Forms.ToolStripMenuItem menuLugatiItemParticipant;
        private System.Windows.Forms.ToolStripMenuItem menuLugatiItemHebergement;
        private System.Windows.Forms.ToolStripMenuItem menuLugatiItemSession;
        private System.Windows.Forms.ToolStripMenuItem menuLugatiItemActivite;
        private System.Windows.Forms.ToolStripMenuItem ligueToolStripMenuItem;
    }
}