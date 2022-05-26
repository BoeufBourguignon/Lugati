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
            this.dataGridActivite = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActivite = new System.Windows.Forms.BindingSource(this.components);
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxNbPlaces = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarif = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxHeure = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelLibelleSession = new System.Windows.Forms.Label();
            this.textBoxLibelleActivite = new System.Windows.Forms.TextBox();
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnModifierActivité = new System.Windows.Forms.Button();
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerActivité = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivite)).BeginInit();
            this.grpInfos.SuspendLayout();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridActivite
            // 
            this.dataGridActivite.AllowUserToAddRows = false;
            this.dataGridActivite.AllowUserToDeleteRows = false;
            this.dataGridActivite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridActivite.AutoGenerateColumns = false;
            this.dataGridActivite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dataGridActivite.Location = new System.Drawing.Point(12, 7);
            this.dataGridActivite.MultiSelect = false;
            this.dataGridActivite.Name = "dataGridActivite";
            this.dataGridActivite.ReadOnly = true;
            this.dataGridActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivite.Size = new System.Drawing.Size(700, 200);
            this.dataGridActivite.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numActivite";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 69;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tarif";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tarif";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nbPlaces";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre de places";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "libelle";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 55;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "heure";
            this.dataGridViewTextBoxColumn6.HeaderText = "Heure";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 61;
            // 
            // bindingSourceActivite
            // 
            this.bindingSourceActivite.DataSource = typeof(Lugati.dll.Activite);
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpInfos.Controls.Add(this.maskedTextBoxNbPlaces);
            this.grpInfos.Controls.Add(this.maskedTextBoxTarif);
            this.grpInfos.Controls.Add(this.comboBoxHeure);
            this.grpInfos.Controls.Add(this.dateTimePickerDate);
            this.grpInfos.Controls.Add(this.labelLibelleSession);
            this.grpInfos.Controls.Add(this.textBoxLibelleActivite);
            this.grpInfos.Controls.Add(this.labelAdresseHotel);
            this.grpInfos.Controls.Add(this.labelPrixHotel);
            this.grpInfos.Controls.Add(this.labelVilleHotel);
            this.grpInfos.Controls.Add(this.labelTelHotel);
            this.grpInfos.Enabled = false;
            this.grpInfos.ForeColor = System.Drawing.Color.White;
            this.grpInfos.Location = new System.Drawing.Point(12, 217);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(507, 259);
            this.grpInfos.TabIndex = 2;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // maskedTextBoxNbPlaces
            // 
            this.maskedTextBoxNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "nbPlaces", true));
            this.maskedTextBoxNbPlaces.Location = new System.Drawing.Point(97, 158);
            this.maskedTextBoxNbPlaces.Mask = "9999";
            this.maskedTextBoxNbPlaces.Name = "maskedTextBoxNbPlaces";
            this.maskedTextBoxNbPlaces.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBoxNbPlaces.TabIndex = 5;
            // 
            // maskedTextBoxTarif
            // 
            this.maskedTextBoxTarif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "tarif", true));
            this.maskedTextBoxTarif.Location = new System.Drawing.Point(97, 115);
            this.maskedTextBoxTarif.Mask = "99999";
            this.maskedTextBoxTarif.Name = "maskedTextBoxTarif";
            this.maskedTextBoxTarif.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBoxTarif.TabIndex = 4;
            // 
            // comboBoxHeure
            // 
            this.comboBoxHeure.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceActivite, "heure", true));
            this.comboBoxHeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeure.FormattingEnabled = true;
            this.comboBoxHeure.Items.AddRange(new object[] {
            "09:00",
            "14:30"});
            this.comboBoxHeure.Location = new System.Drawing.Point(319, 141);
            this.comboBoxHeure.Name = "comboBoxHeure";
            this.comboBoxHeure.Size = new System.Drawing.Size(165, 21);
            this.comboBoxHeure.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceActivite, "date", true));
            this.dateTimePickerDate.Location = new System.Drawing.Point(319, 97);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // labelLibelleSession
            // 
            this.labelLibelleSession.AutoSize = true;
            this.labelLibelleSession.ForeColor = System.Drawing.Color.White;
            this.labelLibelleSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLibelleSession.Location = new System.Drawing.Point(57, 75);
            this.labelLibelleSession.Name = "labelLibelleSession";
            this.labelLibelleSession.Size = new System.Drawing.Size(37, 13);
            this.labelLibelleSession.TabIndex = 4;
            this.labelLibelleSession.Text = "Libelle";
            // 
            // textBoxLibelleActivite
            // 
            this.textBoxLibelleActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "libelle", true));
            this.textBoxLibelleActivite.Location = new System.Drawing.Point(97, 72);
            this.textBoxLibelleActivite.MaxLength = 100;
            this.textBoxLibelleActivite.Name = "textBoxLibelleActivite";
            this.textBoxLibelleActivite.Size = new System.Drawing.Size(150, 20);
            this.textBoxLibelleActivite.TabIndex = 3;
            // 
            // labelAdresseHotel
            // 
            this.labelAdresseHotel.AutoSize = true;
            this.labelAdresseHotel.ForeColor = System.Drawing.Color.White;
            this.labelAdresseHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdresseHotel.Location = new System.Drawing.Point(283, 101);
            this.labelAdresseHotel.Name = "labelAdresseHotel";
            this.labelAdresseHotel.Size = new System.Drawing.Size(30, 13);
            this.labelAdresseHotel.TabIndex = 7;
            this.labelAdresseHotel.Text = "Date";
            // 
            // labelPrixHotel
            // 
            this.labelPrixHotel.AutoSize = true;
            this.labelPrixHotel.ForeColor = System.Drawing.Color.White;
            this.labelPrixHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrixHotel.Location = new System.Drawing.Point(66, 118);
            this.labelPrixHotel.Name = "labelPrixHotel";
            this.labelPrixHotel.Size = new System.Drawing.Size(28, 13);
            this.labelPrixHotel.TabIndex = 9;
            this.labelPrixHotel.Text = "Tarif";
            // 
            // labelVilleHotel
            // 
            this.labelVilleHotel.AutoSize = true;
            this.labelVilleHotel.ForeColor = System.Drawing.Color.White;
            this.labelVilleHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVilleHotel.Location = new System.Drawing.Point(277, 144);
            this.labelVilleHotel.Name = "labelVilleHotel";
            this.labelVilleHotel.Size = new System.Drawing.Size(36, 13);
            this.labelVilleHotel.TabIndex = 10;
            this.labelVilleHotel.Text = "Heure";
            // 
            // labelTelHotel
            // 
            this.labelTelHotel.AutoSize = true;
            this.labelTelHotel.ForeColor = System.Drawing.Color.White;
            this.labelTelHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelHotel.Location = new System.Drawing.Point(16, 161);
            this.labelTelHotel.Name = "labelTelHotel";
            this.labelTelHotel.Size = new System.Drawing.Size(78, 13);
            this.labelTelHotel.TabIndex = 12;
            this.labelTelHotel.Text = "Nombre places";
            // 
            // grpBoutons
            // 
            this.grpBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierActivité);
            this.grpBoutons.Controls.Add(this.btnSupprimerActivite);
            this.grpBoutons.Controls.Add(this.btnAjouterActivite);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Location = new System.Drawing.Point(586, 217);
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.Size = new System.Drawing.Size(126, 145);
            this.grpBoutons.TabIndex = 8;
            this.grpBoutons.TabStop = false;
            // 
            // btnModifierActivité
            // 
            this.btnModifierActivité.BackColor = System.Drawing.Color.White;
            this.btnModifierActivité.ForeColor = System.Drawing.Color.Black;
            this.btnModifierActivité.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifierActivité.Location = new System.Drawing.Point(6, 101);
            this.btnModifierActivité.Name = "btnModifierActivité";
            this.btnModifierActivité.Size = new System.Drawing.Size(114, 35);
            this.btnModifierActivité.TabIndex = 11;
            this.btnModifierActivité.Text = "Modifier";
            this.btnModifierActivité.UseVisualStyleBackColor = false;
            this.btnModifierActivité.Click += new System.EventHandler(this.btnModifierActivité_Click);
            // 
            // btnSupprimerActivite
            // 
            this.btnSupprimerActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerActivite.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimerActivite.Location = new System.Drawing.Point(6, 60);
            this.btnSupprimerActivite.Name = "btnSupprimerActivite";
            this.btnSupprimerActivite.Size = new System.Drawing.Size(114, 35);
            this.btnSupprimerActivite.TabIndex = 10;
            this.btnSupprimerActivite.Text = "Supprimer l\'activité";
            this.btnSupprimerActivite.UseVisualStyleBackColor = false;
            this.btnSupprimerActivite.Click += new System.EventHandler(this.btnSupprimerActivite_Click);
            // 
            // btnAjouterActivite
            // 
            this.btnAjouterActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAjouterActivite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjouterActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjouterActivite.Location = new System.Drawing.Point(6, 19);
            this.btnAjouterActivite.Name = "btnAjouterActivite";
            this.btnAjouterActivite.Size = new System.Drawing.Size(114, 35);
            this.btnAjouterActivite.TabIndex = 9;
            this.btnAjouterActivite.Text = "Ajouter une activité";
            this.btnAjouterActivite.UseVisualStyleBackColor = false;
            this.btnAjouterActivite.Click += new System.EventHandler(this.btnAjouterActivite_Click);
            // 
            // grpBtnsSaveCancel
            // 
            this.grpBtnsSaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBtnsSaveCancel.Controls.Add(this.btnEnregistrerActivité);
            this.grpBtnsSaveCancel.Controls.Add(this.btnAnnuler);
            this.grpBtnsSaveCancel.Location = new System.Drawing.Point(586, 372);
            this.grpBtnsSaveCancel.Name = "grpBtnsSaveCancel";
            this.grpBtnsSaveCancel.Size = new System.Drawing.Size(126, 104);
            this.grpBtnsSaveCancel.TabIndex = 12;
            this.grpBtnsSaveCancel.TabStop = false;
            this.grpBtnsSaveCancel.Visible = false;
            // 
            // btnEnregistrerActivité
            // 
            this.btnEnregistrerActivité.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerActivité.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnregistrerActivité.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnregistrerActivité.Location = new System.Drawing.Point(6, 19);
            this.btnEnregistrerActivité.Name = "btnEnregistrerActivité";
            this.btnEnregistrerActivité.Size = new System.Drawing.Size(114, 35);
            this.btnEnregistrerActivité.TabIndex = 13;
            this.btnEnregistrerActivité.Text = "Enregistrer modifications";
            this.btnEnregistrerActivité.UseVisualStyleBackColor = false;
            this.btnEnregistrerActivité.Click += new System.EventHandler(this.btnEnregistrerActivite_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnuler.Location = new System.Drawing.Point(6, 60);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(114, 35);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(724, 488);
            this.Controls.Add(this.grpBtnsSaveCancel);
            this.Controls.Add(this.grpBoutons);
            this.Controls.Add(this.dataGridActivite);
            this.Controls.Add(this.grpInfos);
            this.Name = "FrmActivite";
            this.Text = "Activités";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivite)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceActivite;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label labelLibelleSession;
        private System.Windows.Forms.TextBox textBoxLibelleActivite;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.ComboBox comboBoxHeure;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.GroupBox grpBoutons;
        private System.Windows.Forms.Button btnModifierActivité;
        private System.Windows.Forms.Button btnSupprimerActivite;
        private System.Windows.Forms.Button btnAjouterActivite;
        private System.Windows.Forms.GroupBox grpBtnsSaveCancel;
        private System.Windows.Forms.Button btnEnregistrerActivité;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNbPlaces;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarif;
    }
}