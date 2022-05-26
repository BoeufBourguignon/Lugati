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
            this.components = new System.ComponentModel.Container();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.comboBoxHeure = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxNbPlaces = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarif = new System.Windows.Forms.MaskedTextBox();
            this.labelLibelleSession = new System.Windows.Forms.Label();
            this.textBoxLibelleSession = new System.Windows.Forms.TextBox();
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnModifierSession = new System.Windows.Forms.Button();
            this.btnSupprimerSession = new System.Windows.Forms.Button();
            this.btnAjouterSession = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerSession = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSession = new System.Windows.Forms.BindingSource(this.components);
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSession)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpInfos.Controls.Add(this.comboBoxHeure);
            this.grpInfos.Controls.Add(this.dateTimePickerDate);
            this.grpInfos.Controls.Add(this.maskedTextBoxNbPlaces);
            this.grpInfos.Controls.Add(this.maskedTextBoxTarif);
            this.grpInfos.Controls.Add(this.labelLibelleSession);
            this.grpInfos.Controls.Add(this.textBoxLibelleSession);
            this.grpInfos.Controls.Add(this.labelAdresseHotel);
            this.grpInfos.Controls.Add(this.labelPrixHotel);
            this.grpInfos.Controls.Add(this.labelVilleHotel);
            this.grpInfos.Controls.Add(this.labelTelHotel);
            this.grpInfos.Enabled = false;
            this.grpInfos.ForeColor = System.Drawing.Color.Black;
            this.grpInfos.Location = new System.Drawing.Point(12, 217);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(507, 259);
            this.grpInfos.TabIndex = 31;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // comboBoxHeure
            // 
            this.comboBoxHeure.BackColor = System.Drawing.Color.White;
            this.comboBoxHeure.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceSession, "heure", true));
            this.comboBoxHeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeure.FormattingEnabled = true;
            this.comboBoxHeure.Items.AddRange(new object[] {
            "09:00",
            "14:30"});
            this.comboBoxHeure.Location = new System.Drawing.Point(290, 140);
            this.comboBoxHeure.Name = "comboBoxHeure";
            this.comboBoxHeure.Size = new System.Drawing.Size(193, 21);
            this.comboBoxHeure.TabIndex = 20;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceSession, "date", true));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(290, 96);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(193, 20);
            this.dateTimePickerDate.TabIndex = 19;
            // 
            // maskedTextBoxNbPlaces
            // 
            this.maskedTextBoxNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "nbPlaces", true));
            this.maskedTextBoxNbPlaces.Location = new System.Drawing.Point(73, 159);
            this.maskedTextBoxNbPlaces.Mask = "9999";
            this.maskedTextBoxNbPlaces.Name = "maskedTextBoxNbPlaces";
            this.maskedTextBoxNbPlaces.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBoxNbPlaces.TabIndex = 18;
            // 
            // maskedTextBoxTarif
            // 
            this.maskedTextBoxTarif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "tarif", true));
            this.maskedTextBoxTarif.Location = new System.Drawing.Point(73, 116);
            this.maskedTextBoxTarif.Mask = "9999";
            this.maskedTextBoxTarif.Name = "maskedTextBoxTarif";
            this.maskedTextBoxTarif.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBoxTarif.TabIndex = 17;
            // 
            // labelLibelleSession
            // 
            this.labelLibelleSession.AutoSize = true;
            this.labelLibelleSession.ForeColor = System.Drawing.Color.Black;
            this.labelLibelleSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLibelleSession.Location = new System.Drawing.Point(30, 76);
            this.labelLibelleSession.Name = "labelLibelleSession";
            this.labelLibelleSession.Size = new System.Drawing.Size(37, 13);
            this.labelLibelleSession.TabIndex = 4;
            this.labelLibelleSession.Text = "Libelle";
            // 
            // textBoxLibelleSession
            // 
            this.textBoxLibelleSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "libelle", true));
            this.textBoxLibelleSession.Location = new System.Drawing.Point(73, 73);
            this.textBoxLibelleSession.MaxLength = 100;
            this.textBoxLibelleSession.Name = "textBoxLibelleSession";
            this.textBoxLibelleSession.Size = new System.Drawing.Size(150, 20);
            this.textBoxLibelleSession.TabIndex = 6;
            // 
            // labelAdresseHotel
            // 
            this.labelAdresseHotel.AutoSize = true;
            this.labelAdresseHotel.ForeColor = System.Drawing.Color.Black;
            this.labelAdresseHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdresseHotel.Location = new System.Drawing.Point(254, 100);
            this.labelAdresseHotel.Name = "labelAdresseHotel";
            this.labelAdresseHotel.Size = new System.Drawing.Size(30, 13);
            this.labelAdresseHotel.TabIndex = 7;
            this.labelAdresseHotel.Text = "Date";
            // 
            // labelPrixHotel
            // 
            this.labelPrixHotel.AutoSize = true;
            this.labelPrixHotel.ForeColor = System.Drawing.Color.Black;
            this.labelPrixHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrixHotel.Location = new System.Drawing.Point(39, 119);
            this.labelPrixHotel.Name = "labelPrixHotel";
            this.labelPrixHotel.Size = new System.Drawing.Size(28, 13);
            this.labelPrixHotel.TabIndex = 9;
            this.labelPrixHotel.Text = "Tarif";
            // 
            // labelVilleHotel
            // 
            this.labelVilleHotel.AutoSize = true;
            this.labelVilleHotel.ForeColor = System.Drawing.Color.Black;
            this.labelVilleHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVilleHotel.Location = new System.Drawing.Point(248, 143);
            this.labelVilleHotel.Name = "labelVilleHotel";
            this.labelVilleHotel.Size = new System.Drawing.Size(36, 13);
            this.labelVilleHotel.TabIndex = 10;
            this.labelVilleHotel.Text = "Heure";
            // 
            // labelTelHotel
            // 
            this.labelTelHotel.AutoSize = true;
            this.labelTelHotel.ForeColor = System.Drawing.Color.Black;
            this.labelTelHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelHotel.Location = new System.Drawing.Point(12, 162);
            this.labelTelHotel.Name = "labelTelHotel";
            this.labelTelHotel.Size = new System.Drawing.Size(55, 13);
            this.labelTelHotel.TabIndex = 12;
            this.labelTelHotel.Text = "Nb places";
            // 
            // dataGridSession
            // 
            this.dataGridSession.AllowUserToAddRows = false;
            this.dataGridSession.AllowUserToDeleteRows = false;
            this.dataGridSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSession.AutoGenerateColumns = false;
            this.dataGridSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridSession.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.nbPlacesDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn});
            this.dataGridSession.DataSource = this.bindingSourceSession;
            this.dataGridSession.Location = new System.Drawing.Point(12, 12);
            this.dataGridSession.MultiSelect = false;
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSession.Size = new System.Drawing.Size(700, 194);
            this.dataGridSession.TabIndex = 0;
            // 
            // grpBoutons
            // 
            this.grpBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierSession);
            this.grpBoutons.Controls.Add(this.btnSupprimerSession);
            this.grpBoutons.Controls.Add(this.btnAjouterSession);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Location = new System.Drawing.Point(586, 217);
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.Size = new System.Drawing.Size(126, 145);
            this.grpBoutons.TabIndex = 34;
            this.grpBoutons.TabStop = false;
            // 
            // btnModifierSession
            // 
            this.btnModifierSession.BackColor = System.Drawing.Color.White;
            this.btnModifierSession.ForeColor = System.Drawing.Color.Black;
            this.btnModifierSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifierSession.Location = new System.Drawing.Point(6, 101);
            this.btnModifierSession.Name = "btnModifierSession";
            this.btnModifierSession.Size = new System.Drawing.Size(114, 35);
            this.btnModifierSession.TabIndex = 11;
            this.btnModifierSession.Text = "Modifier";
            this.btnModifierSession.UseVisualStyleBackColor = false;
            this.btnModifierSession.Click += new System.EventHandler(this.btnModifierSession_Click);
            // 
            // btnSupprimerSession
            // 
            this.btnSupprimerSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerSession.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimerSession.Location = new System.Drawing.Point(6, 60);
            this.btnSupprimerSession.Name = "btnSupprimerSession";
            this.btnSupprimerSession.Size = new System.Drawing.Size(114, 35);
            this.btnSupprimerSession.TabIndex = 10;
            this.btnSupprimerSession.Text = "Supprimer la session";
            this.btnSupprimerSession.UseVisualStyleBackColor = false;
            this.btnSupprimerSession.Click += new System.EventHandler(this.btnSupprimerSession_Click);
            // 
            // btnAjouterSession
            // 
            this.btnAjouterSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAjouterSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjouterSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjouterSession.Location = new System.Drawing.Point(6, 19);
            this.btnAjouterSession.Name = "btnAjouterSession";
            this.btnAjouterSession.Size = new System.Drawing.Size(114, 35);
            this.btnAjouterSession.TabIndex = 9;
            this.btnAjouterSession.Text = "Ajouter une session";
            this.btnAjouterSession.UseVisualStyleBackColor = false;
            this.btnAjouterSession.Click += new System.EventHandler(this.btnAjouterSession_Click);
            // 
            // grpBtnsSaveCancel
            // 
            this.grpBtnsSaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBtnsSaveCancel.Controls.Add(this.btnEnregistrerSession);
            this.grpBtnsSaveCancel.Controls.Add(this.btnAnnuler);
            this.grpBtnsSaveCancel.Location = new System.Drawing.Point(586, 372);
            this.grpBtnsSaveCancel.Name = "grpBtnsSaveCancel";
            this.grpBtnsSaveCancel.Size = new System.Drawing.Size(126, 104);
            this.grpBtnsSaveCancel.TabIndex = 35;
            this.grpBtnsSaveCancel.TabStop = false;
            this.grpBtnsSaveCancel.Visible = false;
            // 
            // btnEnregistrerSession
            // 
            this.btnEnregistrerSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnregistrerSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnregistrerSession.Location = new System.Drawing.Point(6, 19);
            this.btnEnregistrerSession.Name = "btnEnregistrerSession";
            this.btnEnregistrerSession.Size = new System.Drawing.Size(114, 35);
            this.btnEnregistrerSession.TabIndex = 13;
            this.btnEnregistrerSession.Text = "Enregistrer modifications";
            this.btnEnregistrerSession.UseVisualStyleBackColor = false;
            this.btnEnregistrerSession.Click += new System.EventHandler(this.btnEnregistrerSession_Click);
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
            // numSessionDataGridViewTextBoxColumn
            // 
            this.numSessionDataGridViewTextBoxColumn.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn.HeaderText = "Numéro";
            this.numSessionDataGridViewTextBoxColumn.Name = "numSessionDataGridViewTextBoxColumn";
            this.numSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numSessionDataGridViewTextBoxColumn.Width = 69;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            this.tarifDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn.Width = 53;
            // 
            // nbPlacesDataGridViewTextBoxColumn
            // 
            this.nbPlacesDataGridViewTextBoxColumn.DataPropertyName = "nbPlaces";
            this.nbPlacesDataGridViewTextBoxColumn.HeaderText = "Nombre de places";
            this.nbPlacesDataGridViewTextBoxColumn.Name = "nbPlacesDataGridViewTextBoxColumn";
            this.nbPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlacesDataGridViewTextBoxColumn.Width = 80;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn.Width = 54;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "Heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            this.heureDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureDataGridViewTextBoxColumn.Width = 61;
            // 
            // bindingSourceSession
            // 
            this.bindingSourceSession.AllowNew = true;
            this.bindingSourceSession.DataSource = typeof(Lugati.dll.Session);
            // 
            // FrmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(724, 488);
            this.Controls.Add(this.grpBtnsSaveCancel);
            this.Controls.Add(this.grpBoutons);
            this.Controls.Add(this.dataGridSession);
            this.Controls.Add(this.grpInfos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSession";
            this.Text = "Sessions";
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label labelLibelleSession;
        private System.Windows.Forms.TextBox textBoxLibelleSession;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.BindingSource bindingSourceSession;
        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNbPlaces;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarif;
        private System.Windows.Forms.ComboBox comboBoxHeure;
        private System.Windows.Forms.GroupBox grpBoutons;
        private System.Windows.Forms.Button btnModifierSession;
        private System.Windows.Forms.Button btnSupprimerSession;
        private System.Windows.Forms.Button btnAjouterSession;
        private System.Windows.Forms.GroupBox grpBtnsSaveCancel;
        private System.Windows.Forms.Button btnEnregistrerSession;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
    }
}