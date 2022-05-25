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
            this.btnSupprimerHotel = new System.Windows.Forms.Button();
            this.labelNomHotel = new System.Windows.Forms.Label();
            this.textBoxNomHotel = new System.Windows.Forms.TextBox();
            this.bindSrcHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.textBoxAdresseHotel = new System.Windows.Forms.TextBox();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.labelCPHotel = new System.Windows.Forms.Label();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.textBoxVilleHotel = new System.Windows.Forms.TextBox();
            this.textBoxCPHotel = new System.Windows.Forms.TextBox();
            this.labelNbEtoileHotel = new System.Windows.Forms.Label();
            this.btnAjouterHotel = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxNbEtoileHotel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrix = new System.Windows.Forms.MaskedTextBox();
            this.dataGridHebergement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAjouterSupprimer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).BeginInit();
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).BeginInit();
            this.grpAjouterSupprimer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimerHotel
            // 
            this.btnSupprimerHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerHotel.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnSupprimerHotel, "btnSupprimerHotel");
            this.btnSupprimerHotel.Name = "btnSupprimerHotel";
            this.btnSupprimerHotel.UseVisualStyleBackColor = false;
            this.btnSupprimerHotel.Click += new System.EventHandler(this.btnSupprimerHotel_Click);
            // 
            // labelNomHotel
            // 
            resources.ApplyResources(this.labelNomHotel, "labelNomHotel");
            this.labelNomHotel.ForeColor = System.Drawing.Color.White;
            this.labelNomHotel.Name = "labelNomHotel";
            // 
            // textBoxNomHotel
            // 
            this.textBoxNomHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "nomHebergement", true));
            resources.ApplyResources(this.textBoxNomHotel, "textBoxNomHotel");
            this.textBoxNomHotel.Name = "textBoxNomHotel";
            // 
            // bindSrcHebergement
            // 
            this.bindSrcHebergement.DataSource = typeof(Lugati.dll.Hebergement);
            // 
            // labelAdresseHotel
            // 
            resources.ApplyResources(this.labelAdresseHotel, "labelAdresseHotel");
            this.labelAdresseHotel.ForeColor = System.Drawing.Color.White;
            this.labelAdresseHotel.Name = "labelAdresseHotel";
            // 
            // textBoxAdresseHotel
            // 
            this.textBoxAdresseHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "adresse", true));
            resources.ApplyResources(this.textBoxAdresseHotel, "textBoxAdresseHotel");
            this.textBoxAdresseHotel.Name = "textBoxAdresseHotel";
            // 
            // labelPrixHotel
            // 
            resources.ApplyResources(this.labelPrixHotel, "labelPrixHotel");
            this.labelPrixHotel.ForeColor = System.Drawing.Color.White;
            this.labelPrixHotel.Name = "labelPrixHotel";
            // 
            // labelVilleHotel
            // 
            resources.ApplyResources(this.labelVilleHotel, "labelVilleHotel");
            this.labelVilleHotel.ForeColor = System.Drawing.Color.White;
            this.labelVilleHotel.Name = "labelVilleHotel";
            // 
            // labelCPHotel
            // 
            resources.ApplyResources(this.labelCPHotel, "labelCPHotel");
            this.labelCPHotel.ForeColor = System.Drawing.Color.White;
            this.labelCPHotel.Name = "labelCPHotel";
            // 
            // labelTelHotel
            // 
            resources.ApplyResources(this.labelTelHotel, "labelTelHotel");
            this.labelTelHotel.ForeColor = System.Drawing.Color.White;
            this.labelTelHotel.Name = "labelTelHotel";
            // 
            // textBoxVilleHotel
            // 
            this.textBoxVilleHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "ville", true));
            resources.ApplyResources(this.textBoxVilleHotel, "textBoxVilleHotel");
            this.textBoxVilleHotel.Name = "textBoxVilleHotel";
            // 
            // textBoxCPHotel
            // 
            this.textBoxCPHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "cp", true));
            resources.ApplyResources(this.textBoxCPHotel, "textBoxCPHotel");
            this.textBoxCPHotel.Name = "textBoxCPHotel";
            // 
            // labelNbEtoileHotel
            // 
            resources.ApplyResources(this.labelNbEtoileHotel, "labelNbEtoileHotel");
            this.labelNbEtoileHotel.ForeColor = System.Drawing.Color.White;
            this.labelNbEtoileHotel.Name = "labelNbEtoileHotel";
            // 
            // btnAjouterHotel
            // 
            this.btnAjouterHotel.BackColor = System.Drawing.Color.White;
            this.btnAjouterHotel.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnAjouterHotel, "btnAjouterHotel");
            this.btnAjouterHotel.Name = "btnAjouterHotel";
            this.btnAjouterHotel.UseVisualStyleBackColor = false;
            this.btnAjouterHotel.Click += new System.EventHandler(this.btnAjouterHotel_Click);
            // 
            // grpInfos
            // 
            resources.ApplyResources(this.grpInfos, "grpInfos");
            this.grpInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpInfos.Controls.Add(this.maskedTextBoxNbEtoileHotel);
            this.grpInfos.Controls.Add(this.maskedTextBoxTel);
            this.grpInfos.Controls.Add(this.maskedTextBoxPrix);
            this.grpInfos.Controls.Add(this.labelNomHotel);
            this.grpInfos.Controls.Add(this.textBoxNomHotel);
            this.grpInfos.Controls.Add(this.labelAdresseHotel);
            this.grpInfos.Controls.Add(this.labelNbEtoileHotel);
            this.grpInfos.Controls.Add(this.textBoxAdresseHotel);
            this.grpInfos.Controls.Add(this.labelPrixHotel);
            this.grpInfos.Controls.Add(this.labelVilleHotel);
            this.grpInfos.Controls.Add(this.textBoxCPHotel);
            this.grpInfos.Controls.Add(this.labelCPHotel);
            this.grpInfos.Controls.Add(this.textBoxVilleHotel);
            this.grpInfos.Controls.Add(this.labelTelHotel);
            this.grpInfos.ForeColor = System.Drawing.Color.White;
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.TabStop = false;
            // 
            // maskedTextBoxNbEtoileHotel
            // 
            this.maskedTextBoxNbEtoileHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "nbEtoile", true));
            resources.ApplyResources(this.maskedTextBoxNbEtoileHotel, "maskedTextBoxNbEtoileHotel");
            this.maskedTextBoxNbEtoileHotel.Name = "maskedTextBoxNbEtoileHotel";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "tel", true));
            resources.ApplyResources(this.maskedTextBoxTel, "maskedTextBoxTel");
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            // 
            // maskedTextBoxPrix
            // 
            this.maskedTextBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "prix", true));
            resources.ApplyResources(this.maskedTextBoxPrix, "maskedTextBoxPrix");
            this.maskedTextBoxPrix.Name = "maskedTextBoxPrix";
            // 
            // dataGridHebergement
            // 
            this.dataGridHebergement.AllowUserToAddRows = false;
            this.dataGridHebergement.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridHebergement, "dataGridHebergement");
            this.dataGridHebergement.AutoGenerateColumns = false;
            this.dataGridHebergement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridHebergement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridHebergement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHebergement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3});
            this.dataGridHebergement.DataSource = this.bindSrcHebergement;
            this.dataGridHebergement.MultiSelect = false;
            this.dataGridHebergement.Name = "dataGridHebergement";
            this.dataGridHebergement.ReadOnly = true;
            this.dataGridHebergement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idHebergement";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nomHebergement";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nbEtoile";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "adresse";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cp";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ville";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tel";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prix";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // grpAjouterSupprimer
            // 
            resources.ApplyResources(this.grpAjouterSupprimer, "grpAjouterSupprimer");
            this.grpAjouterSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.grpAjouterSupprimer.Controls.Add(this.btnSupprimerHotel);
            this.grpAjouterSupprimer.Controls.Add(this.btnAjouterHotel);
            this.grpAjouterSupprimer.ForeColor = System.Drawing.Color.White;
            this.grpAjouterSupprimer.Name = "grpAjouterSupprimer";
            this.grpAjouterSupprimer.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnEnregistrerHotel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.White;
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnAnnuler, "btnAnnuler");
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrerHotel
            // 
            this.btnEnregistrerHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerHotel.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnEnregistrerHotel, "btnEnregistrerHotel");
            this.btnEnregistrerHotel.Name = "btnEnregistrerHotel";
            this.btnEnregistrerHotel.UseVisualStyleBackColor = false;
            this.btnEnregistrerHotel.Click += new System.EventHandler(this.btnEnregistrerHotel_Click);
            // 
            // FrmHebergement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAjouterSupprimer);
            this.Controls.Add(this.dataGridHebergement);
            this.Controls.Add(this.grpInfos);
            this.Name = "FrmHebergement";
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).EndInit();
            this.grpAjouterSupprimer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimerHotel;
        private System.Windows.Forms.Label labelNomHotel;
        private System.Windows.Forms.TextBox textBoxNomHotel;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.TextBox textBoxAdresseHotel;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.Label labelCPHotel;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.TextBox textBoxVilleHotel;
        private System.Windows.Forms.TextBox textBoxCPHotel;
        private System.Windows.Forms.Label labelNbEtoileHotel;
        private System.Windows.Forms.Button btnAjouterHotel;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.BindingSource bindSrcHebergement;
        private System.Windows.Forms.DataGridView dataGridHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbEtoileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox grpAjouterSupprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerHotel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrix;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNbEtoileHotel;
    }
}

