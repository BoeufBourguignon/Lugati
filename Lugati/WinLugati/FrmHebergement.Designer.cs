
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.bindSrcHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblNbEtoiles = new System.Windows.Forms.Label();
            this.btnAjouterHotel = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.maskTxtCP = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtNbEtoiles = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtPrix = new System.Windows.Forms.MaskedTextBox();
            this.dgvHebergement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnModifierHotel = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerHotel = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).BeginInit();
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHebergement)).BeginInit();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
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
            // lblNom
            // 
            resources.ApplyResources(this.lblNom, "lblNom");
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Name = "lblNom";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "nomHebergement", true));
            resources.ApplyResources(this.txtNom, "txtNom");
            this.txtNom.Name = "txtNom";
            // 
            // bindSrcHebergement
            // 
            this.bindSrcHebergement.DataSource = typeof(Lugati.dll.Hebergement);
            // 
            // lblAdresse
            // 
            resources.ApplyResources(this.lblAdresse, "lblAdresse");
            this.lblAdresse.ForeColor = System.Drawing.Color.White;
            this.lblAdresse.Name = "lblAdresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "adresse", true));
            resources.ApplyResources(this.txtAdresse, "txtAdresse");
            this.txtAdresse.Name = "txtAdresse";
            // 
            // lblPrix
            // 
            resources.ApplyResources(this.lblPrix, "lblPrix");
            this.lblPrix.ForeColor = System.Drawing.Color.White;
            this.lblPrix.Name = "lblPrix";
            // 
            // lblVille
            // 
            resources.ApplyResources(this.lblVille, "lblVille");
            this.lblVille.ForeColor = System.Drawing.Color.White;
            this.lblVille.Name = "lblVille";
            // 
            // lblCP
            // 
            resources.ApplyResources(this.lblCP, "lblCP");
            this.lblCP.ForeColor = System.Drawing.Color.White;
            this.lblCP.Name = "lblCP";
            // 
            // lblTel
            // 
            resources.ApplyResources(this.lblTel, "lblTel");
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Name = "lblTel";
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "ville", true));
            resources.ApplyResources(this.txtVille, "txtVille");
            this.txtVille.Name = "txtVille";
            // 
            // lblNbEtoiles
            // 
            resources.ApplyResources(this.lblNbEtoiles, "lblNbEtoiles");
            this.lblNbEtoiles.ForeColor = System.Drawing.Color.White;
            this.lblNbEtoiles.Name = "lblNbEtoiles";
            // 
            // btnAjouterHotel
            // 
            this.btnAjouterHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.grpInfos.Controls.Add(this.maskTxtCP);
            this.grpInfos.Controls.Add(this.maskTxtNbEtoiles);
            this.grpInfos.Controls.Add(this.maskTxtTel);
            this.grpInfos.Controls.Add(this.maskTxtPrix);
            this.grpInfos.Controls.Add(this.lblNom);
            this.grpInfos.Controls.Add(this.txtNom);
            this.grpInfos.Controls.Add(this.lblAdresse);
            this.grpInfos.Controls.Add(this.lblNbEtoiles);
            this.grpInfos.Controls.Add(this.txtAdresse);
            this.grpInfos.Controls.Add(this.lblPrix);
            this.grpInfos.Controls.Add(this.lblVille);
            this.grpInfos.Controls.Add(this.lblCP);
            this.grpInfos.Controls.Add(this.txtVille);
            this.grpInfos.Controls.Add(this.lblTel);
            this.grpInfos.ForeColor = System.Drawing.Color.White;
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.TabStop = false;
            // 
            // maskTxtCP
            // 
            this.maskTxtCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "cp", true));
            resources.ApplyResources(this.maskTxtCP, "maskTxtCP");
            this.maskTxtCP.Name = "maskTxtCP";
            // 
            // maskTxtNbEtoiles
            // 
            this.maskTxtNbEtoiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "nbEtoile", true));
            resources.ApplyResources(this.maskTxtNbEtoiles, "maskTxtNbEtoiles");
            this.maskTxtNbEtoiles.Name = "maskTxtNbEtoiles";
            // 
            // maskTxtTel
            // 
            this.maskTxtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "tel", true));
            resources.ApplyResources(this.maskTxtTel, "maskTxtTel");
            this.maskTxtTel.Name = "maskTxtTel";
            // 
            // maskTxtPrix
            // 
            this.maskTxtPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "prix", true));
            resources.ApplyResources(this.maskTxtPrix, "maskTxtPrix");
            this.maskTxtPrix.Name = "maskTxtPrix";
            // 
            // dgvHebergement
            // 
            this.dgvHebergement.AllowUserToAddRows = false;
            this.dgvHebergement.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvHebergement, "dgvHebergement");
            this.dgvHebergement.AutoGenerateColumns = false;
            this.dgvHebergement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHebergement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvHebergement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHebergement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3});
            this.dgvHebergement.DataSource = this.bindSrcHebergement;
            this.dgvHebergement.MultiSelect = false;
            this.dgvHebergement.Name = "dgvHebergement";
            this.dgvHebergement.ReadOnly = true;
            this.dgvHebergement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // grpBoutons
            // 
            resources.ApplyResources(this.grpBoutons, "grpBoutons");
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierHotel);
            this.grpBoutons.Controls.Add(this.btnSupprimerHotel);
            this.grpBoutons.Controls.Add(this.btnAjouterHotel);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.TabStop = false;
            // 
            // btnModifierHotel
            // 
            this.btnModifierHotel.BackColor = System.Drawing.Color.White;
            this.btnModifierHotel.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnModifierHotel, "btnModifierHotel");
            this.btnModifierHotel.Name = "btnModifierHotel";
            this.btnModifierHotel.UseVisualStyleBackColor = false;
            this.btnModifierHotel.Click += new System.EventHandler(this.btnModifierHotel_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            // grpBtnsSaveCancel
            // 
            this.grpBtnsSaveCancel.Controls.Add(this.btnEnregistrerHotel);
            this.grpBtnsSaveCancel.Controls.Add(this.btnAnnuler);
            resources.ApplyResources(this.grpBtnsSaveCancel, "grpBtnsSaveCancel");
            this.grpBtnsSaveCancel.Name = "grpBtnsSaveCancel";
            this.grpBtnsSaveCancel.TabStop = false;
            // 
            // FrmHebergement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.grpBtnsSaveCancel);
            this.Controls.Add(this.grpBoutons);
            this.Controls.Add(this.dgvHebergement);
            this.Controls.Add(this.grpInfos);
            this.Name = "FrmHebergement";
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHebergement)).EndInit();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimerHotel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblNbEtoiles;
        private System.Windows.Forms.Button btnAjouterHotel;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.BindingSource bindSrcHebergement;
        private System.Windows.Forms.DataGridView dgvHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbEtoileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpBoutons;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerHotel;
        private System.Windows.Forms.MaskedTextBox maskTxtPrix;
        private System.Windows.Forms.MaskedTextBox maskTxtTel;
        private System.Windows.Forms.MaskedTextBox maskTxtNbEtoiles;
        private System.Windows.Forms.Button btnModifierHotel;
        private System.Windows.Forms.GroupBox grpBtnsSaveCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.MaskedTextBox maskTxtCP;
    }
}

