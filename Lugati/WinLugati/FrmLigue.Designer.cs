﻿namespace WinLugati
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
            this.dgvLigue = new System.Windows.Forms.DataGridView();
            this.idLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcLigue = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLigue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLigue
            // 
            this.dgvLigue.AllowUserToAddRows = false;
            this.dgvLigue.AllowUserToDeleteRows = false;
            this.dgvLigue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLigue.AutoGenerateColumns = false;
            this.dgvLigue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLigue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dgvLigue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLigueDataGridViewTextBoxColumn,
            this.nomLigueDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn});
            this.dgvLigue.DataSource = this.bindSrcLigue;
            this.dgvLigue.GridColor = System.Drawing.Color.Khaki;
            this.dgvLigue.Location = new System.Drawing.Point(12, 12);
            this.dgvLigue.Name = "dgvLigue";
            this.dgvLigue.ReadOnly = true;
            this.dgvLigue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLigue.Size = new System.Drawing.Size(705, 426);
            this.dgvLigue.TabIndex = 0;
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            this.idLigueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLigueDataGridViewTextBoxColumn.Width = 78;
            // 
            // nomLigueDataGridViewTextBoxColumn
            // 
            this.nomLigueDataGridViewTextBoxColumn.DataPropertyName = "nomLigue";
            this.nomLigueDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomLigueDataGridViewTextBoxColumn.Name = "nomLigueDataGridViewTextBoxColumn";
            this.nomLigueDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomLigueDataGridViewTextBoxColumn.Width = 54;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 46;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 51;
            // 
            // bindSrcLigue
            // 
            this.bindSrcLigue.DataSource = typeof(Lugati.dll.Ligue);
            // 
            // FrmLigue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.dgvLigue);
            this.Name = "FrmLigue";
            this.Text = "Ligues";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLigue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLigue;
        private System.Windows.Forms.BindingSource bindSrcLigue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
    }
}