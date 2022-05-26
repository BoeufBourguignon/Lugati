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
            this.btnModifierActivite = new System.Windows.Forms.Button();
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerActivité = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabControlActivites = new System.Windows.Forms.TabControl();
            this.tabPageCRUDActivite = new System.Windows.Forms.TabPage();
            this.tabPageParticipants = new System.Windows.Forms.TabPage();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceParticipants = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivite)).BeginInit();
            this.grpInfos.SuspendLayout();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.tabControlActivites.SuspendLayout();
            this.tabPageCRUDActivite.SuspendLayout();
            this.tabPageParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipants)).BeginInit();
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
            this.dataGridActivite.Location = new System.Drawing.Point(3, 3);
            this.dataGridActivite.MultiSelect = false;
            this.dataGridActivite.Name = "dataGridActivite";
            this.dataGridActivite.ReadOnly = true;
            this.dataGridActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivite.Size = new System.Drawing.Size(706, 197);
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
            this.bindingSourceActivite.CurrentChanged += new System.EventHandler(this.bindingSourceActivite_CurrentChanged);
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
            this.grpInfos.Location = new System.Drawing.Point(3, 206);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(509, 252);
            this.grpInfos.TabIndex = 2;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // maskedTextBoxNbPlaces
            // 
            this.maskedTextBoxNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "nbPlaces", true));
            this.maskedTextBoxNbPlaces.Location = new System.Drawing.Point(94, 162);
            this.maskedTextBoxNbPlaces.Mask = "9999";
            this.maskedTextBoxNbPlaces.Name = "maskedTextBoxNbPlaces";
            this.maskedTextBoxNbPlaces.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBoxNbPlaces.TabIndex = 5;
            // 
            // maskedTextBoxTarif
            // 
            this.maskedTextBoxTarif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "tarif", true));
            this.maskedTextBoxTarif.Location = new System.Drawing.Point(94, 119);
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
            this.comboBoxHeure.Location = new System.Drawing.Point(316, 139);
            this.comboBoxHeure.Name = "comboBoxHeure";
            this.comboBoxHeure.Size = new System.Drawing.Size(165, 21);
            this.comboBoxHeure.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceActivite, "date", true));
            this.dateTimePickerDate.Location = new System.Drawing.Point(316, 95);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // labelLibelleSession
            // 
            this.labelLibelleSession.AutoSize = true;
            this.labelLibelleSession.ForeColor = System.Drawing.Color.White;
            this.labelLibelleSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLibelleSession.Location = new System.Drawing.Point(54, 79);
            this.labelLibelleSession.Name = "labelLibelleSession";
            this.labelLibelleSession.Size = new System.Drawing.Size(37, 13);
            this.labelLibelleSession.TabIndex = 4;
            this.labelLibelleSession.Text = "Libelle";
            // 
            // textBoxLibelleActivite
            // 
            this.textBoxLibelleActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActivite, "libelle", true));
            this.textBoxLibelleActivite.Location = new System.Drawing.Point(94, 76);
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
            this.labelAdresseHotel.Location = new System.Drawing.Point(280, 99);
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
            this.labelPrixHotel.Location = new System.Drawing.Point(63, 122);
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
            this.labelVilleHotel.Location = new System.Drawing.Point(274, 142);
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
            this.labelTelHotel.Location = new System.Drawing.Point(13, 165);
            this.labelTelHotel.Name = "labelTelHotel";
            this.labelTelHotel.Size = new System.Drawing.Size(78, 13);
            this.labelTelHotel.TabIndex = 12;
            this.labelTelHotel.Text = "Nombre places";
            // 
            // grpBoutons
            // 
            this.grpBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierActivite);
            this.grpBoutons.Controls.Add(this.btnSupprimerActivite);
            this.grpBoutons.Controls.Add(this.btnAjouterActivite);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Location = new System.Drawing.Point(583, 206);
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.Size = new System.Drawing.Size(126, 139);
            this.grpBoutons.TabIndex = 8;
            this.grpBoutons.TabStop = false;
            // 
            // btnModifierActivite
            // 
            this.btnModifierActivite.BackColor = System.Drawing.Color.White;
            this.btnModifierActivite.ForeColor = System.Drawing.Color.Black;
            this.btnModifierActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifierActivite.Location = new System.Drawing.Point(6, 96);
            this.btnModifierActivite.Name = "btnModifierActivite";
            this.btnModifierActivite.Size = new System.Drawing.Size(114, 35);
            this.btnModifierActivite.TabIndex = 11;
            this.btnModifierActivite.Text = "Modifier";
            this.btnModifierActivite.UseVisualStyleBackColor = false;
            this.btnModifierActivite.Click += new System.EventHandler(this.btnModifierActivite_Click);
            // 
            // btnSupprimerActivite
            // 
            this.btnSupprimerActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerActivite.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimerActivite.Location = new System.Drawing.Point(6, 55);
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
            this.btnAjouterActivite.Location = new System.Drawing.Point(6, 12);
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
            this.grpBtnsSaveCancel.Location = new System.Drawing.Point(583, 363);
            this.grpBtnsSaveCancel.Name = "grpBtnsSaveCancel";
            this.grpBtnsSaveCancel.Size = new System.Drawing.Size(126, 95);
            this.grpBtnsSaveCancel.TabIndex = 12;
            this.grpBtnsSaveCancel.TabStop = false;
            this.grpBtnsSaveCancel.Visible = false;
            // 
            // btnEnregistrerActivité
            // 
            this.btnEnregistrerActivité.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerActivité.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnregistrerActivité.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnregistrerActivité.Location = new System.Drawing.Point(6, 12);
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
            this.btnAnnuler.Location = new System.Drawing.Point(6, 53);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(114, 35);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tabControlActivites
            // 
            this.tabControlActivites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlActivites.Controls.Add(this.tabPageCRUDActivite);
            this.tabControlActivites.Controls.Add(this.tabPageParticipants);
            this.tabControlActivites.Location = new System.Drawing.Point(12, 12);
            this.tabControlActivites.Name = "tabControlActivites";
            this.tabControlActivites.SelectedIndex = 0;
            this.tabControlActivites.Size = new System.Drawing.Size(720, 487);
            this.tabControlActivites.TabIndex = 13;
            // 
            // tabPageCRUDActivite
            // 
            this.tabPageCRUDActivite.BackColor = System.Drawing.Color.Crimson;
            this.tabPageCRUDActivite.Controls.Add(this.dataGridActivite);
            this.tabPageCRUDActivite.Controls.Add(this.grpBtnsSaveCancel);
            this.tabPageCRUDActivite.Controls.Add(this.grpBoutons);
            this.tabPageCRUDActivite.Controls.Add(this.grpInfos);
            this.tabPageCRUDActivite.Location = new System.Drawing.Point(4, 22);
            this.tabPageCRUDActivite.Name = "tabPageCRUDActivite";
            this.tabPageCRUDActivite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCRUDActivite.Size = new System.Drawing.Size(712, 461);
            this.tabPageCRUDActivite.TabIndex = 0;
            this.tabPageCRUDActivite.Text = "Activités";
            // 
            // tabPageParticipants
            // 
            this.tabPageParticipants.BackColor = System.Drawing.Color.Crimson;
            this.tabPageParticipants.Controls.Add(this.dataGridViewParticipants);
            this.tabPageParticipants.Location = new System.Drawing.Point(4, 22);
            this.tabPageParticipants.Name = "tabPageParticipants";
            this.tabPageParticipants.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParticipants.Size = new System.Drawing.Size(712, 461);
            this.tabPageParticipants.TabIndex = 1;
            this.tabPageParticipants.Text = "Participants";
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParticipants.AutoGenerateColumns = false;
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn});
            this.dataGridViewParticipants.DataSource = this.bindingSourceParticipants;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(704, 455);
            this.dataGridViewParticipants.TabIndex = 0;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 54;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 68;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 61;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 51;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 46;
            // 
            // bindingSourceParticipants
            // 
            this.bindingSourceParticipants.DataSource = typeof(Lugati.dll.Participant);
            // 
            // FrmActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.tabControlActivites);
            this.Name = "FrmActivite";
            this.Text = "Activités";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivite)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.tabControlActivites.ResumeLayout(false);
            this.tabPageCRUDActivite.ResumeLayout(false);
            this.tabPageParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipants)).EndInit();
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
        private System.Windows.Forms.Button btnModifierActivite;
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
        private System.Windows.Forms.TabControl tabControlActivites;
        private System.Windows.Forms.TabPage tabPageCRUDActivite;
        private System.Windows.Forms.TabPage tabPageParticipants;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.BindingSource bindingSourceParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
    }
}