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
            this.dgvActivite = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivite = new System.Windows.Forms.BindingSource(this.components);
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.lblNbPlacesRestantes = new System.Windows.Forms.Label();
            this.txtNbPlacesRestantes = new System.Windows.Forms.TextBox();
            this.maskTxtNbPlaces = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTarif = new System.Windows.Forms.MaskedTextBox();
            this.comboHeure = new System.Windows.Forms.ComboBox();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblNbPlaces = new System.Windows.Forms.Label();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnModifierActivite = new System.Windows.Forms.Button();
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerActivité = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabActivites = new System.Windows.Forms.TabControl();
            this.tabActivites_CRUDActivite = new System.Windows.Forms.TabPage();
            this.tabActivites_Participants = new System.Windows.Forms.TabPage();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcParticipants = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivite)).BeginInit();
            this.grpInfos.SuspendLayout();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.tabActivites.SuspendLayout();
            this.tabActivites_CRUDActivite.SuspendLayout();
            this.tabActivites_Participants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivite
            // 
            this.dgvActivite.AllowUserToAddRows = false;
            this.dgvActivite.AllowUserToDeleteRows = false;
            this.dgvActivite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivite.AutoGenerateColumns = false;
            this.dgvActivite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActivite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvActivite.DataSource = this.bindSrcActivite;
            this.dgvActivite.Location = new System.Drawing.Point(3, 3);
            this.dgvActivite.MultiSelect = false;
            this.dgvActivite.Name = "dgvActivite";
            this.dgvActivite.ReadOnly = true;
            this.dgvActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivite.Size = new System.Drawing.Size(706, 197);
            this.dgvActivite.TabIndex = 1;
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
            // bindSrcActivite
            // 
            this.bindSrcActivite.DataSource = typeof(Lugati.dll.Activite);
            this.bindSrcActivite.CurrentChanged += new System.EventHandler(this.bindingSourceActivite_CurrentChanged);
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpInfos.Controls.Add(this.lblNbPlacesRestantes);
            this.grpInfos.Controls.Add(this.txtNbPlacesRestantes);
            this.grpInfos.Controls.Add(this.maskTxtNbPlaces);
            this.grpInfos.Controls.Add(this.maskTxtTarif);
            this.grpInfos.Controls.Add(this.comboHeure);
            this.grpInfos.Controls.Add(this.dtPickerDate);
            this.grpInfos.Controls.Add(this.lblLibelle);
            this.grpInfos.Controls.Add(this.txtLibelle);
            this.grpInfos.Controls.Add(this.lblDate);
            this.grpInfos.Controls.Add(this.lblTarif);
            this.grpInfos.Controls.Add(this.lblHeure);
            this.grpInfos.Controls.Add(this.lblNbPlaces);
            this.grpInfos.Enabled = false;
            this.grpInfos.ForeColor = System.Drawing.Color.White;
            this.grpInfos.Location = new System.Drawing.Point(3, 206);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(509, 252);
            this.grpInfos.TabIndex = 2;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // lblNbPlacesRestantes
            // 
            this.lblNbPlacesRestantes.AutoSize = true;
            this.lblNbPlacesRestantes.Location = new System.Drawing.Point(236, 22);
            this.lblNbPlacesRestantes.Name = "lblNbPlacesRestantes";
            this.lblNbPlacesRestantes.Size = new System.Drawing.Size(139, 13);
            this.lblNbPlacesRestantes.TabIndex = 14;
            this.lblNbPlacesRestantes.Text = "Nombre de places restantes";
            // 
            // txtNbPlacesRestantes
            // 
            this.txtNbPlacesRestantes.Location = new System.Drawing.Point(381, 19);
            this.txtNbPlacesRestantes.Name = "txtNbPlacesRestantes";
            this.txtNbPlacesRestantes.ReadOnly = true;
            this.txtNbPlacesRestantes.Size = new System.Drawing.Size(100, 20);
            this.txtNbPlacesRestantes.TabIndex = 13;
            // 
            // maskTxtNbPlaces
            // 
            this.maskTxtNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivite, "nbPlaces", true));
            this.maskTxtNbPlaces.Location = new System.Drawing.Point(74, 162);
            this.maskTxtNbPlaces.Mask = "9999";
            this.maskTxtNbPlaces.Name = "maskTxtNbPlaces";
            this.maskTxtNbPlaces.Size = new System.Drawing.Size(150, 20);
            this.maskTxtNbPlaces.TabIndex = 5;
            // 
            // maskTxtTarif
            // 
            this.maskTxtTarif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivite, "tarif", true));
            this.maskTxtTarif.Location = new System.Drawing.Point(74, 119);
            this.maskTxtTarif.Mask = "99999";
            this.maskTxtTarif.Name = "maskTxtTarif";
            this.maskTxtTarif.Size = new System.Drawing.Size(150, 20);
            this.maskTxtTarif.TabIndex = 4;
            // 
            // comboHeure
            // 
            this.comboHeure.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcActivite, "heure", true));
            this.comboHeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHeure.FormattingEnabled = true;
            this.comboHeure.Items.AddRange(new object[] {
            "09:00",
            "14:30"});
            this.comboHeure.Location = new System.Drawing.Point(316, 139);
            this.comboHeure.Name = "comboHeure";
            this.comboHeure.Size = new System.Drawing.Size(165, 21);
            this.comboHeure.TabIndex = 7;
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcActivite, "date", true));
            this.dtPickerDate.Location = new System.Drawing.Point(316, 95);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(165, 20);
            this.dtPickerDate.TabIndex = 6;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.ForeColor = System.Drawing.Color.White;
            this.lblLibelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLibelle.Location = new System.Drawing.Point(34, 79);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 4;
            this.lblLibelle.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivite, "libelle", true));
            this.txtLibelle.Location = new System.Drawing.Point(74, 76);
            this.txtLibelle.MaxLength = 100;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(150, 20);
            this.txtLibelle.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(280, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.ForeColor = System.Drawing.Color.White;
            this.lblTarif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTarif.Location = new System.Drawing.Point(43, 122);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(28, 13);
            this.lblTarif.TabIndex = 9;
            this.lblTarif.Text = "Tarif";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.ForeColor = System.Drawing.Color.White;
            this.lblHeure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeure.Location = new System.Drawing.Point(274, 142);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(36, 13);
            this.lblHeure.TabIndex = 10;
            this.lblHeure.Text = "Heure";
            // 
            // lblNbPlaces
            // 
            this.lblNbPlaces.AutoSize = true;
            this.lblNbPlaces.ForeColor = System.Drawing.Color.White;
            this.lblNbPlaces.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNbPlaces.Location = new System.Drawing.Point(13, 165);
            this.lblNbPlaces.Name = "lblNbPlaces";
            this.lblNbPlaces.Size = new System.Drawing.Size(55, 13);
            this.lblNbPlaces.TabIndex = 12;
            this.lblNbPlaces.Text = "Nb places";
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
            // tabActivites
            // 
            this.tabActivites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabActivites.Controls.Add(this.tabActivites_CRUDActivite);
            this.tabActivites.Controls.Add(this.tabActivites_Participants);
            this.tabActivites.Location = new System.Drawing.Point(12, 12);
            this.tabActivites.Name = "tabActivites";
            this.tabActivites.SelectedIndex = 0;
            this.tabActivites.Size = new System.Drawing.Size(720, 487);
            this.tabActivites.TabIndex = 13;
            // 
            // tabActivites_CRUDActivite
            // 
            this.tabActivites_CRUDActivite.BackColor = System.Drawing.Color.Crimson;
            this.tabActivites_CRUDActivite.Controls.Add(this.dgvActivite);
            this.tabActivites_CRUDActivite.Controls.Add(this.grpBtnsSaveCancel);
            this.tabActivites_CRUDActivite.Controls.Add(this.grpBoutons);
            this.tabActivites_CRUDActivite.Controls.Add(this.grpInfos);
            this.tabActivites_CRUDActivite.Location = new System.Drawing.Point(4, 22);
            this.tabActivites_CRUDActivite.Name = "tabActivites_CRUDActivite";
            this.tabActivites_CRUDActivite.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivites_CRUDActivite.Size = new System.Drawing.Size(712, 461);
            this.tabActivites_CRUDActivite.TabIndex = 0;
            this.tabActivites_CRUDActivite.Text = "Activités";
            // 
            // tabActivites_Participants
            // 
            this.tabActivites_Participants.BackColor = System.Drawing.Color.Crimson;
            this.tabActivites_Participants.Controls.Add(this.dgvParticipants);
            this.tabActivites_Participants.Location = new System.Drawing.Point(4, 22);
            this.tabActivites_Participants.Name = "tabActivites_Participants";
            this.tabActivites_Participants.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivites_Participants.Size = new System.Drawing.Size(712, 461);
            this.tabActivites_Participants.TabIndex = 1;
            this.tabActivites_Participants.Text = "Participants";
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.AllowUserToDeleteRows = false;
            this.dgvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipants.AutoGenerateColumns = false;
            this.dgvParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn});
            this.dgvParticipants.DataSource = this.bindSrcParticipants;
            this.dgvParticipants.Location = new System.Drawing.Point(3, 3);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipants.Size = new System.Drawing.Size(704, 455);
            this.dgvParticipants.TabIndex = 0;
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
            // bindSrcParticipants
            // 
            this.bindSrcParticipants.DataSource = typeof(Lugati.dll.Participant);
            // 
            // FrmActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.tabActivites);
            this.Name = "FrmActivite";
            this.Text = "Activités";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivite)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.tabActivites.ResumeLayout(false);
            this.tabActivites_CRUDActivite.ResumeLayout(false);
            this.tabActivites_Participants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcActivite;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblNbPlaces;
        private System.Windows.Forms.ComboBox comboHeure;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
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
        private System.Windows.Forms.MaskedTextBox maskTxtNbPlaces;
        private System.Windows.Forms.MaskedTextBox maskTxtTarif;
        private System.Windows.Forms.TabControl tabActivites;
        private System.Windows.Forms.TabPage tabActivites_CRUDActivite;
        private System.Windows.Forms.TabPage tabActivites_Participants;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.BindingSource bindSrcParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNbPlacesRestantes;
        private System.Windows.Forms.Label lblNbPlacesRestantes;
    }
}