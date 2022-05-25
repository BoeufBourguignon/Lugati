namespace WinLugati
{
    partial class FrmLigue
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxLigue = new System.Windows.Forms.GroupBox();
            this.dataGridLigue = new System.Windows.Forms.DataGridView();
            this.bindingSourceLigue = new System.Windows.Forms.BindingSource(this.components);
            this.idLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLigue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLigue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLigue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLigue
            // 
            this.groupBoxLigue.BackColor = System.Drawing.Color.Gold;
            this.groupBoxLigue.Controls.Add(this.dataGridLigue);
            this.groupBoxLigue.Location = new System.Drawing.Point(13, 13);
            this.groupBoxLigue.Name = "groupBoxLigue";
            this.groupBoxLigue.Size = new System.Drawing.Size(587, 320);
            this.groupBoxLigue.TabIndex = 0;
            this.groupBoxLigue.TabStop = false;
            this.groupBoxLigue.Text = "Ensemble des Ligues :";
            // 
            // dataGridLigue
            // 
            this.dataGridLigue.AutoGenerateColumns = false;
            this.dataGridLigue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridLigue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLigue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLigueDataGridViewTextBoxColumn,
            this.nomLigueDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn});
            this.dataGridLigue.DataSource = this.bindingSourceLigue;
            this.dataGridLigue.GridColor = System.Drawing.Color.Khaki;
            this.dataGridLigue.Location = new System.Drawing.Point(7, 20);
            this.dataGridLigue.Name = "dataGridLigue";
            this.dataGridLigue.Size = new System.Drawing.Size(574, 294);
            this.dataGridLigue.TabIndex = 0;
            // 
            // bindingSourceLigue
            // 
            this.bindingSourceLigue.DataSource = typeof(Lugati.dll.Ligue);
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            // 
            // nomLigueDataGridViewTextBoxColumn
            // 
            this.nomLigueDataGridViewTextBoxColumn.DataPropertyName = "nomLigue";
            this.nomLigueDataGridViewTextBoxColumn.HeaderText = "nomLigue";
            this.nomLigueDataGridViewTextBoxColumn.Name = "nomLigueDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // FrmLigue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.groupBoxLigue);
            this.Name = "FrmLigue";
            this.Text = "FrmLigue";
            this.Load += new System.EventHandler(this.FrmLigue_Load);
            this.groupBoxLigue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLigue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLigue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLigue;
        private System.Windows.Forms.DataGridView dataGridLigue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceLigue;
    }
}