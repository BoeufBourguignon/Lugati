namespace WinLugati
{
    partial class FrmActivite
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
            this.dataGridActivite = new System.Windows.Forms.DataGridView();
            this.numActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.dataGridActivite);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Activités :";
            // 
            // dataGridActivite
            // 
            this.dataGridActivite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numActivite,
            this.libelle,
            this.tarif,
            this.nbPlaces,
            this.date,
            this.heure});
            this.dataGridActivite.Location = new System.Drawing.Point(6, 19);
            this.dataGridActivite.Name = "dataGridActivite";
            this.dataGridActivite.Size = new System.Drawing.Size(536, 168);
            this.dataGridActivite.TabIndex = 0;
            // 
            // numActivite
            // 
            this.numActivite.HeaderText = "numActivite";
            this.numActivite.Name = "numActivite";
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
            // FrmActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActivite";
            this.Text = "FrmActivite";
            this.Load += new System.EventHandler(this.FrmActivite_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
    }
}