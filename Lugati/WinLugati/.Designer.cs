﻿
namespace WinLugati
{
    partial class FrmHebergement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHebergement));
            this.BtnAjouterHebergement = new System.Windows.Forms.Button();
            this.labelNomHotel = new System.Windows.Forms.Label();
            this.textBoxNomHotel = new System.Windows.Forms.TextBox();
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.textBoxAdresseHotel = new System.Windows.Forms.TextBox();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.labelCPHotel = new System.Windows.Forms.Label();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.textBoxPrixHotel = new System.Windows.Forms.TextBox();
            this.textBoxVilleHotel = new System.Windows.Forms.TextBox();
            this.textBoxCPHotel = new System.Windows.Forms.TextBox();
            this.textBoxTelHotel = new System.Windows.Forms.TextBox();
            this.labelNbEtoileHotel = new System.Windows.Forms.Label();
            this.textBoxNbEtoileHotel = new System.Windows.Forms.TextBox();
            this.BtnValiderHotel = new System.Windows.Forms.Button();
            this.BtnAnnulerHotel = new System.Windows.Forms.Button();
            this.BtnSupprimerHotel = new System.Windows.Forms.Button();
            this.BtnModifierHotel = new System.Windows.Forms.Button();
            this.BtnValiderModifHotel = new System.Windows.Forms.Button();
            this.BtnAnnulerModifHotel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxIdHotel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindSrcHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridHebergement = new System.Windows.Forms.DataGridView();
            this.idHebergementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbEtoileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomHebergementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAjouterHebergement
            // 
            this.BtnAjouterHebergement.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.BtnAjouterHebergement, "BtnAjouterHebergement");
            this.BtnAjouterHebergement.Name = "BtnAjouterHebergement";
            this.BtnAjouterHebergement.UseVisualStyleBackColor = false;
            this.BtnAjouterHebergement.Click += new System.EventHandler(this.BtnAjouterHebergement_Click);
            // 
            // labelNomHotel
            // 
            resources.ApplyResources(this.labelNomHotel, "labelNomHotel");
            this.labelNomHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNomHotel.Name = "labelNomHotel";
            // 
            // textBoxNomHotel
            // 
            resources.ApplyResources(this.textBoxNomHotel, "textBoxNomHotel");
            this.textBoxNomHotel.Name = "textBoxNomHotel";
            // 
            // labelAdresseHotel
            // 
            resources.ApplyResources(this.labelAdresseHotel, "labelAdresseHotel");
            this.labelAdresseHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdresseHotel.Name = "labelAdresseHotel";
            // 
            // textBoxAdresseHotel
            // 
            resources.ApplyResources(this.textBoxAdresseHotel, "textBoxAdresseHotel");
            this.textBoxAdresseHotel.Name = "textBoxAdresseHotel";
            // 
            // labelPrixHotel
            // 
            resources.ApplyResources(this.labelPrixHotel, "labelPrixHotel");
            this.labelPrixHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrixHotel.Name = "labelPrixHotel";
            // 
            // labelVilleHotel
            // 
            resources.ApplyResources(this.labelVilleHotel, "labelVilleHotel");
            this.labelVilleHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVilleHotel.Name = "labelVilleHotel";
            // 
            // labelCPHotel
            // 
            resources.ApplyResources(this.labelCPHotel, "labelCPHotel");
            this.labelCPHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCPHotel.Name = "labelCPHotel";
            // 
            // labelTelHotel
            // 
            resources.ApplyResources(this.labelTelHotel, "labelTelHotel");
            this.labelTelHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTelHotel.Name = "labelTelHotel";
            // 
            // textBoxPrixHotel
            // 
            resources.ApplyResources(this.textBoxPrixHotel, "textBoxPrixHotel");
            this.textBoxPrixHotel.Name = "textBoxPrixHotel";
            // 
            // textBoxVilleHotel
            // 
            resources.ApplyResources(this.textBoxVilleHotel, "textBoxVilleHotel");
            this.textBoxVilleHotel.Name = "textBoxVilleHotel";
            // 
            // textBoxCPHotel
            // 
            resources.ApplyResources(this.textBoxCPHotel, "textBoxCPHotel");
            this.textBoxCPHotel.Name = "textBoxCPHotel";
            // 
            // textBoxTelHotel
            // 
            resources.ApplyResources(this.textBoxTelHotel, "textBoxTelHotel");
            this.textBoxTelHotel.Name = "textBoxTelHotel";
            // 
            // labelNbEtoileHotel
            // 
            resources.ApplyResources(this.labelNbEtoileHotel, "labelNbEtoileHotel");
            this.labelNbEtoileHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNbEtoileHotel.Name = "labelNbEtoileHotel";
            // 
            // textBoxNbEtoileHotel
            // 
            resources.ApplyResources(this.textBoxNbEtoileHotel, "textBoxNbEtoileHotel");
            this.textBoxNbEtoileHotel.Name = "textBoxNbEtoileHotel";
            // 
            // BtnValiderHotel
            // 
            resources.ApplyResources(this.BtnValiderHotel, "BtnValiderHotel");
            this.BtnValiderHotel.Name = "BtnValiderHotel";
            this.BtnValiderHotel.UseVisualStyleBackColor = true;
            this.BtnValiderHotel.Click += new System.EventHandler(this.BtnValiderHotel_Click);
            // 
            // BtnAnnulerHotel
            // 
            resources.ApplyResources(this.BtnAnnulerHotel, "BtnAnnulerHotel");
            this.BtnAnnulerHotel.Name = "BtnAnnulerHotel";
            this.BtnAnnulerHotel.UseVisualStyleBackColor = true;
            this.BtnAnnulerHotel.Click += new System.EventHandler(this.BtnAnnulerHotel_Click);
            // 
            // BtnSupprimerHotel
            // 
            this.BtnSupprimerHotel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSupprimerHotel.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.BtnSupprimerHotel, "BtnSupprimerHotel");
            this.BtnSupprimerHotel.Name = "BtnSupprimerHotel";
            this.BtnSupprimerHotel.UseVisualStyleBackColor = false;
            this.BtnSupprimerHotel.Click += new System.EventHandler(this.BtnSupprimerHotel_Click);
            // 
            // BtnModifierHotel
            // 
            this.BtnModifierHotel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.BtnModifierHotel, "BtnModifierHotel");
            this.BtnModifierHotel.Name = "BtnModifierHotel";
            this.BtnModifierHotel.UseVisualStyleBackColor = false;
            this.BtnModifierHotel.Click += new System.EventHandler(this.BtnModifierHotel_Click);
            // 
            // BtnValiderModifHotel
            // 
            resources.ApplyResources(this.BtnValiderModifHotel, "BtnValiderModifHotel");
            this.BtnValiderModifHotel.Name = "BtnValiderModifHotel";
            this.BtnValiderModifHotel.UseVisualStyleBackColor = true;
            this.BtnValiderModifHotel.Click += new System.EventHandler(this.BtnValiderModifHotel_Click);
            // 
            // BtnAnnulerModifHotel
            // 
            resources.ApplyResources(this.BtnAnnulerModifHotel, "BtnAnnulerModifHotel");
            this.BtnAnnulerModifHotel.Name = "BtnAnnulerModifHotel";
            this.BtnAnnulerModifHotel.UseVisualStyleBackColor = true;
            this.BtnAnnulerModifHotel.Click += new System.EventHandler(this.BtnAnnulerModifHotel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.comboBoxIdHotel);
            this.groupBox2.Controls.Add(this.BtnValiderModifHotel);
            this.groupBox2.Controls.Add(this.BtnModifierHotel);
            this.groupBox2.Controls.Add(this.BtnAnnulerModifHotel);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboBoxIdHotel
            // 
            this.comboBoxIdHotel.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxIdHotel, "comboBoxIdHotel");
            this.comboBoxIdHotel.Name = "comboBoxIdHotel";
            this.comboBoxIdHotel.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdHotel_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.BtnSupprimerHotel);
            this.groupBox3.Controls.Add(this.BtnAjouterHebergement);
            this.groupBox3.Controls.Add(this.labelNomHotel);
            this.groupBox3.Controls.Add(this.BtnAnnulerHotel);
            this.groupBox3.Controls.Add(this.textBoxNomHotel);
            this.groupBox3.Controls.Add(this.BtnValiderHotel);
            this.groupBox3.Controls.Add(this.labelAdresseHotel);
            this.groupBox3.Controls.Add(this.textBoxNbEtoileHotel);
            this.groupBox3.Controls.Add(this.textBoxAdresseHotel);
            this.groupBox3.Controls.Add(this.labelNbEtoileHotel);
            this.groupBox3.Controls.Add(this.labelPrixHotel);
            this.groupBox3.Controls.Add(this.textBoxTelHotel);
            this.groupBox3.Controls.Add(this.labelVilleHotel);
            this.groupBox3.Controls.Add(this.textBoxCPHotel);
            this.groupBox3.Controls.Add(this.labelCPHotel);
            this.groupBox3.Controls.Add(this.textBoxVilleHotel);
            this.groupBox3.Controls.Add(this.labelTelHotel);
            this.groupBox3.Controls.Add(this.textBoxPrixHotel);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // bindSrcHebergement
            // 
            this.bindSrcHebergement.DataSource = typeof(Lugati.dll.Hebergement);
            // 
            // dataGridHebergement
            // 
            this.dataGridHebergement.AutoGenerateColumns = false;
            this.dataGridHebergement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHebergement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHebergementDataGridViewTextBoxColumn,
            this.nbEtoileDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.nomHebergementDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridHebergement.DataSource = this.bindSrcHebergement;
            resources.ApplyResources(this.dataGridHebergement, "dataGridHebergement");
            this.dataGridHebergement.Name = "dataGridHebergement";
            // 
            // idHebergementDataGridViewTextBoxColumn
            // 
            this.idHebergementDataGridViewTextBoxColumn.DataPropertyName = "idHebergement";
            resources.ApplyResources(this.idHebergementDataGridViewTextBoxColumn, "idHebergementDataGridViewTextBoxColumn");
            this.idHebergementDataGridViewTextBoxColumn.Name = "idHebergementDataGridViewTextBoxColumn";
            // 
            // nbEtoileDataGridViewTextBoxColumn
            // 
            this.nbEtoileDataGridViewTextBoxColumn.DataPropertyName = "nbEtoile";
            resources.ApplyResources(this.nbEtoileDataGridViewTextBoxColumn, "nbEtoileDataGridViewTextBoxColumn");
            this.nbEtoileDataGridViewTextBoxColumn.Name = "nbEtoileDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            resources.ApplyResources(this.prixDataGridViewTextBoxColumn, "prixDataGridViewTextBoxColumn");
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // nomHebergementDataGridViewTextBoxColumn
            // 
            this.nomHebergementDataGridViewTextBoxColumn.DataPropertyName = "nomHebergement";
            resources.ApplyResources(this.nomHebergementDataGridViewTextBoxColumn, "nomHebergementDataGridViewTextBoxColumn");
            this.nomHebergementDataGridViewTextBoxColumn.Name = "nomHebergementDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            resources.ApplyResources(this.adresseDataGridViewTextBoxColumn, "adresseDataGridViewTextBoxColumn");
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            resources.ApplyResources(this.villeDataGridViewTextBoxColumn, "villeDataGridViewTextBoxColumn");
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            resources.ApplyResources(this.cpDataGridViewTextBoxColumn, "cpDataGridViewTextBoxColumn");
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            resources.ApplyResources(this.telDataGridViewTextBoxColumn, "telDataGridViewTextBoxColumn");
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // FrmHebergement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.dataGridHebergement);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmHebergement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAjouterHebergement;
        private System.Windows.Forms.Label labelNomHotel;
        private System.Windows.Forms.TextBox textBoxNomHotel;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.TextBox textBoxAdresseHotel;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.Label labelCPHotel;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.TextBox textBoxPrixHotel;
        private System.Windows.Forms.TextBox textBoxVilleHotel;
        private System.Windows.Forms.TextBox textBoxCPHotel;
        private System.Windows.Forms.TextBox textBoxTelHotel;
        private System.Windows.Forms.Label labelNbEtoileHotel;
        private System.Windows.Forms.TextBox textBoxNbEtoileHotel;
        private System.Windows.Forms.Button BtnValiderHotel;
        private System.Windows.Forms.Button BtnAnnulerHotel;
        private System.Windows.Forms.Button BtnSupprimerHotel;
        private System.Windows.Forms.Button BtnModifierHotel;
        private System.Windows.Forms.Button BtnValiderModifHotel;
        private System.Windows.Forms.Button BtnAnnulerModifHotel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxIdHotel;
        private System.Windows.Forms.BindingSource bindSrcHebergement;
        private System.Windows.Forms.DataGridView dataGridHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbEtoileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
    }
}

