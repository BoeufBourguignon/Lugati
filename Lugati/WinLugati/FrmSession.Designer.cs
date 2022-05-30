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
            this.txtNbPlacesRestantes = new System.Windows.Forms.TextBox();
            this.lblNbPlacesRestantes = new System.Windows.Forms.Label();
            this.comboHeure = new System.Windows.Forms.ComboBox();
            this.bindSrcSession = new System.Windows.Forms.BindingSource(this.components);
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.maskTxtNbPlaces = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTarif = new System.Windows.Forms.MaskedTextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblNbPlaces = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnModifierSession = new System.Windows.Forms.Button();
            this.btnSupprimerSession = new System.Windows.Forms.Button();
            this.btnAjouterSession = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerSession = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabSessions = new System.Windows.Forms.TabControl();
            this.tabSessions_CRUDSession = new System.Windows.Forms.TabPage();
            this.tabSessions_Inscrits = new System.Windows.Forms.TabPage();
            this.dgvInscrits = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcInscrits = new System.Windows.Forms.BindingSource(this.components);
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.tabSessions.SuspendLayout();
            this.tabSessions_CRUDSession.SuspendLayout();
            this.tabSessions_Inscrits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscrits)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpInfos.Controls.Add(this.txtNbPlacesRestantes);
            this.grpInfos.Controls.Add(this.lblNbPlacesRestantes);
            this.grpInfos.Controls.Add(this.comboHeure);
            this.grpInfos.Controls.Add(this.dtPickerDate);
            this.grpInfos.Controls.Add(this.maskTxtNbPlaces);
            this.grpInfos.Controls.Add(this.maskTxtTarif);
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
            this.grpInfos.Size = new System.Drawing.Size(507, 252);
            this.grpInfos.TabIndex = 31;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // txtNbPlacesRestantes
            // 
            this.txtNbPlacesRestantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNbPlacesRestantes.Location = new System.Drawing.Point(383, 16);
            this.txtNbPlacesRestantes.Name = "txtNbPlacesRestantes";
            this.txtNbPlacesRestantes.ReadOnly = true;
            this.txtNbPlacesRestantes.Size = new System.Drawing.Size(100, 20);
            this.txtNbPlacesRestantes.TabIndex = 22;
            // 
            // lblNbPlacesRestantes
            // 
            this.lblNbPlacesRestantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNbPlacesRestantes.AutoSize = true;
            this.lblNbPlacesRestantes.Location = new System.Drawing.Point(238, 19);
            this.lblNbPlacesRestantes.Name = "lblNbPlacesRestantes";
            this.lblNbPlacesRestantes.Size = new System.Drawing.Size(139, 13);
            this.lblNbPlacesRestantes.TabIndex = 21;
            this.lblNbPlacesRestantes.Text = "Nombre de places restantes";
            // 
            // comboHeure
            // 
            this.comboHeure.BackColor = System.Drawing.Color.White;
            this.comboHeure.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcSession, "heure", true));
            this.comboHeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHeure.FormattingEnabled = true;
            this.comboHeure.Items.AddRange(new object[] {
            "09:00",
            "14:30"});
            this.comboHeure.Location = new System.Drawing.Point(318, 140);
            this.comboHeure.Name = "comboHeure";
            this.comboHeure.Size = new System.Drawing.Size(165, 21);
            this.comboHeure.TabIndex = 20;
            // 
            // bindSrcSession
            // 
            this.bindSrcSession.AllowNew = true;
            this.bindSrcSession.DataSource = typeof(Lugati.dll.Session);
            this.bindSrcSession.CurrentChanged += new System.EventHandler(this.bindingSourceSession_CurrentChanged);
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcSession, "date", true));
            this.dtPickerDate.Location = new System.Drawing.Point(318, 96);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(165, 20);
            this.dtPickerDate.TabIndex = 19;
            // 
            // maskTxtNbPlaces
            // 
            this.maskTxtNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSession, "nbPlaces", true));
            this.maskTxtNbPlaces.Location = new System.Drawing.Point(73, 159);
            this.maskTxtNbPlaces.Mask = "9999";
            this.maskTxtNbPlaces.Name = "maskTxtNbPlaces";
            this.maskTxtNbPlaces.Size = new System.Drawing.Size(150, 20);
            this.maskTxtNbPlaces.TabIndex = 18;
            // 
            // maskTxtTarif
            // 
            this.maskTxtTarif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSession, "tarif", true));
            this.maskTxtTarif.Location = new System.Drawing.Point(73, 116);
            this.maskTxtTarif.Mask = "9999";
            this.maskTxtTarif.Name = "maskTxtTarif";
            this.maskTxtTarif.Size = new System.Drawing.Size(150, 20);
            this.maskTxtTarif.TabIndex = 17;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.ForeColor = System.Drawing.Color.White;
            this.lblLibelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLibelle.Location = new System.Drawing.Point(30, 76);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 4;
            this.lblLibelle.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSession, "libelle", true));
            this.txtLibelle.Location = new System.Drawing.Point(73, 73);
            this.txtLibelle.MaxLength = 100;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(150, 20);
            this.txtLibelle.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(282, 99);
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
            this.lblTarif.Location = new System.Drawing.Point(39, 119);
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
            this.lblHeure.Location = new System.Drawing.Point(276, 143);
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
            this.lblNbPlaces.Location = new System.Drawing.Point(12, 162);
            this.lblNbPlaces.Name = "lblNbPlaces";
            this.lblNbPlaces.Size = new System.Drawing.Size(55, 13);
            this.lblNbPlaces.TabIndex = 12;
            this.lblNbPlaces.Text = "Nb places";
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSessions.AutoGenerateColumns = false;
            this.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSessions.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.nbPlacesDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn});
            this.dgvSessions.DataSource = this.bindSrcSession;
            this.dgvSessions.Location = new System.Drawing.Point(3, 3);
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(704, 197);
            this.dgvSessions.TabIndex = 0;
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
            // grpBoutons
            // 
            this.grpBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierSession);
            this.grpBoutons.Controls.Add(this.btnSupprimerSession);
            this.grpBoutons.Controls.Add(this.btnAjouterSession);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Location = new System.Drawing.Point(581, 206);
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.Size = new System.Drawing.Size(126, 139);
            this.grpBoutons.TabIndex = 34;
            this.grpBoutons.TabStop = false;
            // 
            // btnModifierSession
            // 
            this.btnModifierSession.BackColor = System.Drawing.Color.White;
            this.btnModifierSession.ForeColor = System.Drawing.Color.Black;
            this.btnModifierSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifierSession.Location = new System.Drawing.Point(6, 94);
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
            this.btnSupprimerSession.Location = new System.Drawing.Point(6, 53);
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
            this.btnAjouterSession.Location = new System.Drawing.Point(6, 12);
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
            this.grpBtnsSaveCancel.Location = new System.Drawing.Point(581, 354);
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
            // tabSessions
            // 
            this.tabSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSessions.Controls.Add(this.tabSessions_CRUDSession);
            this.tabSessions.Controls.Add(this.tabSessions_Inscrits);
            this.tabSessions.Location = new System.Drawing.Point(12, 12);
            this.tabSessions.Name = "tabSessions";
            this.tabSessions.SelectedIndex = 0;
            this.tabSessions.Size = new System.Drawing.Size(718, 487);
            this.tabSessions.TabIndex = 36;
            // 
            // tabSessions_CRUDSession
            // 
            this.tabSessions_CRUDSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabSessions_CRUDSession.Controls.Add(this.dgvSessions);
            this.tabSessions_CRUDSession.Controls.Add(this.grpBtnsSaveCancel);
            this.tabSessions_CRUDSession.Controls.Add(this.grpInfos);
            this.tabSessions_CRUDSession.Controls.Add(this.grpBoutons);
            this.tabSessions_CRUDSession.Location = new System.Drawing.Point(4, 22);
            this.tabSessions_CRUDSession.Name = "tabSessions_CRUDSession";
            this.tabSessions_CRUDSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessions_CRUDSession.Size = new System.Drawing.Size(710, 461);
            this.tabSessions_CRUDSession.TabIndex = 0;
            this.tabSessions_CRUDSession.Text = "Sessions";
            // 
            // tabSessions_Inscrits
            // 
            this.tabSessions_Inscrits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabSessions_Inscrits.Controls.Add(this.dgvInscrits);
            this.tabSessions_Inscrits.Location = new System.Drawing.Point(4, 22);
            this.tabSessions_Inscrits.Name = "tabSessions_Inscrits";
            this.tabSessions_Inscrits.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessions_Inscrits.Size = new System.Drawing.Size(710, 461);
            this.tabSessions_Inscrits.TabIndex = 1;
            this.tabSessions_Inscrits.Text = "Inscrits";
            // 
            // dgvInscrits
            // 
            this.dgvInscrits.AllowUserToAddRows = false;
            this.dgvInscrits.AllowUserToDeleteRows = false;
            this.dgvInscrits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInscrits.AutoGenerateColumns = false;
            this.dgvInscrits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInscrits.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvInscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscrits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn});
            this.dgvInscrits.DataSource = this.bindSrcInscrits;
            this.dgvInscrits.Location = new System.Drawing.Point(3, 3);
            this.dgvInscrits.Name = "dgvInscrits";
            this.dgvInscrits.ReadOnly = true;
            this.dgvInscrits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscrits.Size = new System.Drawing.Size(704, 455);
            this.dgvInscrits.TabIndex = 0;
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
            // bindSrcInscrits
            // 
            this.bindSrcInscrits.DataSource = typeof(Lugati.dll.Participant);
            // 
            // FrmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(742, 511);
            this.Controls.Add(this.tabSessions);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSession";
            this.Text = "Sessions";
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.tabSessions.ResumeLayout(false);
            this.tabSessions_CRUDSession.ResumeLayout(false);
            this.tabSessions_Inscrits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscrits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblNbPlaces;
        private System.Windows.Forms.BindingSource bindSrcSession;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.MaskedTextBox maskTxtNbPlaces;
        private System.Windows.Forms.MaskedTextBox maskTxtTarif;
        private System.Windows.Forms.ComboBox comboHeure;
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
        private System.Windows.Forms.TabControl tabSessions;
        private System.Windows.Forms.TabPage tabSessions_CRUDSession;
        private System.Windows.Forms.TabPage tabSessions_Inscrits;
        private System.Windows.Forms.DataGridView dgvInscrits;
        private System.Windows.Forms.BindingSource bindSrcInscrits;
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