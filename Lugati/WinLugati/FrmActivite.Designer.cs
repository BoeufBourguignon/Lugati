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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridActivite = new System.Windows.Forms.DataGridView();
            this.bindingSourceActivite = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerActivite = new System.Windows.Forms.Button();
            this.grpAjouterSupprimer = new System.Windows.Forms.GroupBox();
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.labelLibelleSession = new System.Windows.Forms.Label();
            this.textBoxLibelleActivite = new System.Windows.Forms.TextBox();
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.textBoxDateActivite = new System.Windows.Forms.TextBox();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.textBoxNbPlaceActivite = new System.Windows.Forms.TextBox();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.textBoxHeureActivite = new System.Windows.Forms.TextBox();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.textBoxTarifActivite = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivite)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpAjouterSupprimer.SuspendLayout();
            this.grpInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.dataGridActivite);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Activités :";
            // 
            // dataGridActivite
            // 
            this.dataGridActivite.AllowUserToAddRows = false;
            this.dataGridActivite.AllowUserToDeleteRows = false;
            this.dataGridActivite.AutoGenerateColumns = false;
            this.dataGridActivite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridActivite.DataSource = this.bindingSourceActivite;
            this.dataGridActivite.Location = new System.Drawing.Point(6, 19);
            this.dataGridActivite.MultiSelect = false;
            this.dataGridActivite.Name = "dataGridActivite";
            this.dataGridActivite.ReadOnly = true;
            this.dataGridActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivite.Size = new System.Drawing.Size(696, 179);
            this.dataGridActivite.TabIndex = 0;
            // 
            // bindingSourceActivite
            // 
            this.bindingSourceActivite.DataSource = typeof(Lugati.dll.Activite);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numActivite";
            this.dataGridViewTextBoxColumn1.HeaderText = "numActivite";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tarif";
            this.dataGridViewTextBoxColumn2.HeaderText = "tarif";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nbPlaces";
            this.dataGridViewTextBoxColumn3.HeaderText = "nbPlaces";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "libelle";
            this.dataGridViewTextBoxColumn4.HeaderText = "libelle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "heure";
            this.dataGridViewTextBoxColumn6.HeaderText = "heure";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Salmon;
            this.groupBox2.Controls.Add(this.btnAnnuler);
            this.groupBox2.Controls.Add(this.btnEnregistrerActivite);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(603, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 119);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.White;
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnuler.Location = new System.Drawing.Point(6, 65);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(114, 40);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrerActivite
            // 
            this.btnEnregistrerActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerActivite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnregistrerActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnregistrerActivite.Location = new System.Drawing.Point(6, 19);
            this.btnEnregistrerActivite.Name = "btnEnregistrerActivite";
            this.btnEnregistrerActivite.Size = new System.Drawing.Size(114, 40);
            this.btnEnregistrerActivite.TabIndex = 22;
            this.btnEnregistrerActivite.Text = "Enregistrer modifications";
            this.btnEnregistrerActivite.UseVisualStyleBackColor = false;
            this.btnEnregistrerActivite.Click += new System.EventHandler(this.btnEnregistrerActivite_Click);
            // 
            // grpAjouterSupprimer
            // 
            this.grpAjouterSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAjouterSupprimer.BackColor = System.Drawing.Color.Salmon;
            this.grpAjouterSupprimer.Controls.Add(this.btnSupprimerActivite);
            this.grpAjouterSupprimer.Controls.Add(this.btnAjouterActivite);
            this.grpAjouterSupprimer.ForeColor = System.Drawing.Color.White;
            this.grpAjouterSupprimer.Location = new System.Drawing.Point(603, 280);
            this.grpAjouterSupprimer.Name = "grpAjouterSupprimer";
            this.grpAjouterSupprimer.Size = new System.Drawing.Size(126, 119);
            this.grpAjouterSupprimer.TabIndex = 35;
            this.grpAjouterSupprimer.TabStop = false;
            // 
            // btnSupprimerActivite
            // 
            this.btnSupprimerActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerActivite.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimerActivite.Location = new System.Drawing.Point(6, 65);
            this.btnSupprimerActivite.Name = "btnSupprimerActivite";
            this.btnSupprimerActivite.Size = new System.Drawing.Size(114, 40);
            this.btnSupprimerActivite.TabIndex = 2;
            this.btnSupprimerActivite.Text = "Supprimer une Activite";
            this.btnSupprimerActivite.UseVisualStyleBackColor = false;
            this.btnSupprimerActivite.Click += new System.EventHandler(this.btnSupprimerActivite_Click);
            // 
            // btnAjouterActivite
            // 
            this.btnAjouterActivite.BackColor = System.Drawing.Color.White;
            this.btnAjouterActivite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjouterActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjouterActivite.Location = new System.Drawing.Point(6, 19);
            this.btnAjouterActivite.Name = "btnAjouterActivite";
            this.btnAjouterActivite.Size = new System.Drawing.Size(114, 40);
            this.btnAjouterActivite.TabIndex = 22;
            this.btnAjouterActivite.Text = "Ajouter une Activite";
            this.btnAjouterActivite.UseVisualStyleBackColor = false;
            this.btnAjouterActivite.Click += new System.EventHandler(this.btnAjouterActivite_Click);
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.BackColor = System.Drawing.Color.Salmon;
            this.grpInfos.Controls.Add(this.labelLibelleSession);
            this.grpInfos.Controls.Add(this.textBoxLibelleActivite);
            this.grpInfos.Controls.Add(this.labelAdresseHotel);
            this.grpInfos.Controls.Add(this.textBoxDateActivite);
            this.grpInfos.Controls.Add(this.labelPrixHotel);
            this.grpInfos.Controls.Add(this.textBoxNbPlaceActivite);
            this.grpInfos.Controls.Add(this.labelVilleHotel);
            this.grpInfos.Controls.Add(this.textBoxHeureActivite);
            this.grpInfos.Controls.Add(this.labelTelHotel);
            this.grpInfos.Controls.Add(this.textBoxTarifActivite);
            this.grpInfos.ForeColor = System.Drawing.Color.White;
            this.grpInfos.Location = new System.Drawing.Point(18, 279);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(507, 259);
            this.grpInfos.TabIndex = 34;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // labelLibelleSession
            // 
            this.labelLibelleSession.AutoSize = true;
            this.labelLibelleSession.ForeColor = System.Drawing.Color.White;
            this.labelLibelleSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLibelleSession.Location = new System.Drawing.Point(54, 58);
            this.labelLibelleSession.Name = "labelLibelleSession";
            this.labelLibelleSession.Size = new System.Drawing.Size(43, 13);
            this.labelLibelleSession.TabIndex = 4;
            this.labelLibelleSession.Text = "Libelle :";
            // 
            // textBoxLibelleActivite
            // 
            this.textBoxLibelleActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "libelle", true));
            this.textBoxLibelleActivite.Location = new System.Drawing.Point(97, 55);
            this.textBoxLibelleActivite.Name = "textBoxLibelleActivite";
            this.textBoxLibelleActivite.Size = new System.Drawing.Size(150, 20);
            this.textBoxLibelleActivite.TabIndex = 6;
            // 
            // labelAdresseHotel
            // 
            this.labelAdresseHotel.AutoSize = true;
            this.labelAdresseHotel.ForeColor = System.Drawing.Color.White;
            this.labelAdresseHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdresseHotel.Location = new System.Drawing.Point(283, 83);
            this.labelAdresseHotel.Name = "labelAdresseHotel";
            this.labelAdresseHotel.Size = new System.Drawing.Size(36, 13);
            this.labelAdresseHotel.TabIndex = 7;
            this.labelAdresseHotel.Text = "Date :";
            // 
            // textBoxDateActivite
            // 
            this.textBoxDateActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "date", true));
            this.textBoxDateActivite.Location = new System.Drawing.Point(334, 78);
            this.textBoxDateActivite.Name = "textBoxDateActivite";
            this.textBoxDateActivite.Size = new System.Drawing.Size(150, 20);
            this.textBoxDateActivite.TabIndex = 8;
            // 
            // labelPrixHotel
            // 
            this.labelPrixHotel.AutoSize = true;
            this.labelPrixHotel.ForeColor = System.Drawing.Color.White;
            this.labelPrixHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrixHotel.Location = new System.Drawing.Point(57, 101);
            this.labelPrixHotel.Name = "labelPrixHotel";
            this.labelPrixHotel.Size = new System.Drawing.Size(34, 13);
            this.labelPrixHotel.TabIndex = 9;
            this.labelPrixHotel.Text = "Tarif :";
            // 
            // textBoxNbPlaceActivite
            // 
            this.textBoxNbPlaceActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "nbPlaces", true));
            this.textBoxNbPlaceActivite.Location = new System.Drawing.Point(97, 141);
            this.textBoxNbPlaceActivite.Name = "textBoxNbPlaceActivite";
            this.textBoxNbPlaceActivite.Size = new System.Drawing.Size(150, 20);
            this.textBoxNbPlaceActivite.TabIndex = 16;
            // 
            // labelVilleHotel
            // 
            this.labelVilleHotel.AutoSize = true;
            this.labelVilleHotel.ForeColor = System.Drawing.Color.White;
            this.labelVilleHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVilleHotel.Location = new System.Drawing.Point(286, 124);
            this.labelVilleHotel.Name = "labelVilleHotel";
            this.labelVilleHotel.Size = new System.Drawing.Size(42, 13);
            this.labelVilleHotel.TabIndex = 10;
            this.labelVilleHotel.Text = "Heure :";
            // 
            // textBoxHeureActivite
            // 
            this.textBoxHeureActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "heure", true));
            this.textBoxHeureActivite.Location = new System.Drawing.Point(334, 121);
            this.textBoxHeureActivite.Name = "textBoxHeureActivite";
            this.textBoxHeureActivite.Size = new System.Drawing.Size(150, 20);
            this.textBoxHeureActivite.TabIndex = 14;
            // 
            // labelTelHotel
            // 
            this.labelTelHotel.AutoSize = true;
            this.labelTelHotel.ForeColor = System.Drawing.Color.White;
            this.labelTelHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelHotel.Location = new System.Drawing.Point(33, 144);
            this.labelTelHotel.Name = "labelTelHotel";
            this.labelTelHotel.Size = new System.Drawing.Size(57, 13);
            this.labelTelHotel.TabIndex = 12;
            this.labelTelHotel.Text = "nbPlaces :";
            // 
            // textBoxTarifActivite
            // 
            this.textBoxTarifActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "tarif", true));
            this.textBoxTarifActivite.Location = new System.Drawing.Point(97, 98);
            this.textBoxTarifActivite.Name = "textBoxTarifActivite";
            this.textBoxTarifActivite.Size = new System.Drawing.Size(150, 20);
            this.textBoxTarifActivite.TabIndex = 13;
            // 
            // FrmActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(820, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAjouterSupprimer);
            this.Controls.Add(this.grpInfos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActivite";
            this.Text = "FrmActivite";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpAjouterSupprimer.ResumeLayout(false);
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bindingSourceActivite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerActivite;
        private System.Windows.Forms.GroupBox grpAjouterSupprimer;
        private System.Windows.Forms.Button btnSupprimerActivite;
        private System.Windows.Forms.Button btnAjouterActivite;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label labelLibelleSession;
        private System.Windows.Forms.TextBox textBoxLibelleActivite;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.TextBox textBoxDateActivite;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.TextBox textBoxNbPlaceActivite;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.TextBox textBoxHeureActivite;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.TextBox textBoxTarifActivite;
    }
}