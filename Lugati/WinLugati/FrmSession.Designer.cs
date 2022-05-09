namespace WinLugati
{
    partial class FrmSession
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.numSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.dataGridSession);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Sessions :";
            // 
            // dataGridSession
            // 
            this.dataGridSession.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSession,
            this.libelle,
            this.tarif,
            this.nbPlaces,
            this.date,
            this.heure});
            this.dataGridSession.Location = new System.Drawing.Point(6, 19);
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.Size = new System.Drawing.Size(535, 167);
            this.dataGridSession.TabIndex = 0;
            // 
            // numSession
            // 
            this.numSession.HeaderText = "numSession";
            this.numSession.Name = "numSession";
            // 
            // libelle
            // 
            this.libelle.HeaderText = "libelle";
            this.libelle.Name = "libelle";
            // 
            // tarif
            // 
            this.tarif.HeaderText = "tarif";
            this.tarif.Name = "tarif";
            // 
            // nbPlaces
            // 
            this.nbPlaces.HeaderText = "nbPlaces";
            this.nbPlaces.Name = "nbPlaces";
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // heure
            // 
            this.heure.HeaderText = "heure";
            this.heure.Name = "heure";
            // 
            // FrmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSession";
            this.Text = "FrmSession";
            this.Load += new System.EventHandler(this.FrmSession_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
    }
}