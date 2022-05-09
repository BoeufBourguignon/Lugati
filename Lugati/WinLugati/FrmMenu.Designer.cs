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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.frmParticipantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmHebergementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hebergementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmActiviteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmParticipantToolStripMenuItem,
            this.frmHebergementToolStripMenuItem,
            this.frmSessionToolStripMenuItem,
            this.frmActiviteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // frmParticipantToolStripMenuItem
            // 
            this.frmParticipantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantToolStripMenuItem});
            this.frmParticipantToolStripMenuItem.Name = "frmParticipantToolStripMenuItem";
            this.frmParticipantToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.frmParticipantToolStripMenuItem.Text = "FrmParticipant";
            // 
            // participantToolStripMenuItem
            // 
            this.participantToolStripMenuItem.Name = "participantToolStripMenuItem";
            this.participantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.participantToolStripMenuItem.Text = "Participant";
            this.participantToolStripMenuItem.Click += new System.EventHandler(this.participantToolStripMenuItem_Click);
            // 
            // frmHebergementToolStripMenuItem
            // 
            this.frmHebergementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hebergementToolStripMenuItem});
            this.frmHebergementToolStripMenuItem.Name = "frmHebergementToolStripMenuItem";
            this.frmHebergementToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.frmHebergementToolStripMenuItem.Text = "FrmHebergement";
            // 
            // hebergementToolStripMenuItem
            // 
            this.hebergementToolStripMenuItem.Name = "hebergementToolStripMenuItem";
            this.hebergementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hebergementToolStripMenuItem.Text = "Hebergement";
            this.hebergementToolStripMenuItem.Click += new System.EventHandler(this.hebergementToolStripMenuItem_Click);
            // 
            // frmSessionToolStripMenuItem
            // 
            this.frmSessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem});
            this.frmSessionToolStripMenuItem.Name = "frmSessionToolStripMenuItem";
            this.frmSessionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.frmSessionToolStripMenuItem.Text = "FrmSession";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sessionToolStripMenuItem.Text = "Session";
            this.sessionToolStripMenuItem.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // frmActiviteToolStripMenuItem
            // 
            this.frmActiviteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activiteToolStripMenuItem});
            this.frmActiviteToolStripMenuItem.Name = "frmActiviteToolStripMenuItem";
            this.frmActiviteToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.frmActiviteToolStripMenuItem.Text = "FrmActivite";
            // 
            // activiteToolStripMenuItem
            // 
            this.activiteToolStripMenuItem.Name = "activiteToolStripMenuItem";
            this.activiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activiteToolStripMenuItem.Text = "Activite";
            this.activiteToolStripMenuItem.Click += new System.EventHandler(this.activiteToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem frmParticipantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmHebergementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hebergementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmActiviteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activiteToolStripMenuItem;
    }
}