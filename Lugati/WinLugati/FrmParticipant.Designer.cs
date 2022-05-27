using Lugati.dll;

namespace WinLugati
{
    partial class FrmParticipant
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
            this.bindSrcParticipant = new System.Windows.Forms.BindingSource(this.components);
            this.bindSrcLigue = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblEurosReste = new System.Windows.Forms.Label();
            this.lblEurosAcompte = new System.Windows.Forms.Label();
            this.lblEurosTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtReste = new System.Windows.Forms.TextBox();
            this.lblReste = new System.Windows.Forms.Label();
            this.txtAcompte = new System.Windows.Forms.TextBox();
            this.lblAcompte = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpActivites = new System.Windows.Forms.GroupBox();
            this.dgvActivitesDispo = new System.Windows.Forms.DataGridView();
            this.numActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivitesDispo = new System.Windows.Forms.BindingSource(this.components);
            this.lblActivitesDisponible = new System.Windows.Forms.Label();
            this.lblActivitesParticipation = new System.Windows.Forms.Label();
            this.dgvActivitesInscrites = new System.Windows.Forms.DataGridView();
            this.numActiviteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivitesInscrites = new System.Windows.Forms.BindingSource(this.components);
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.grpSessions = new System.Windows.Forms.GroupBox();
            this.lblSessionsDisponible = new System.Windows.Forms.Label();
            this.lblSessionsParticipation = new System.Windows.Forms.Label();
            this.btnSupprimerSession = new System.Windows.Forms.Button();
            this.btnAjouterSession = new System.Windows.Forms.Button();
            this.dgvSessionsDispo = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSessionsDispo = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSessionsInscrites = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSessionsInscrites = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitreInscriptions = new System.Windows.Forms.Label();
            this.tabPageParticipant = new System.Windows.Forms.TabPage();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnEnregistrerParticipant = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnModifierParticipant = new System.Windows.Forms.Button();
            this.btnSupprimerParticipant = new System.Windows.Forms.Button();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.maskTxtCP = new System.Windows.Forms.MaskedTextBox();
            this.comboHebergement = new System.Windows.Forms.ComboBox();
            this.bindSrcHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.comboLigue = new System.Windows.Forms.ComboBox();
            this.lblHebergement = new System.Windows.Forms.Label();
            this.lblLigue = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.idParticipantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hebergement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabParticipant = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLigue)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpActivites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitesDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivitesDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitesInscrites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivitesInscrites)).BeginInit();
            this.grpSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessionsDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsInscrites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessionsInscrites)).BeginInit();
            this.tabPageParticipant.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.grpBoutons.SuspendLayout();
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.tabParticipant.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindSrcParticipant
            // 
            this.bindSrcParticipant.DataSource = typeof(Lugati.dll.Participant);
            this.bindSrcParticipant.CurrentChanged += new System.EventHandler(this.bindingSourceParticipant_CurrentChanged);
            // 
            // bindSrcLigue
            // 
            this.bindSrcLigue.DataSource = typeof(Lugati.dll.Ligue);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.txtTotal);
            this.tabPage4.Controls.Add(this.lblEurosReste);
            this.tabPage4.Controls.Add(this.lblEurosAcompte);
            this.tabPage4.Controls.Add(this.lblEurosTotal);
            this.tabPage4.Controls.Add(this.lblTotal);
            this.tabPage4.Controls.Add(this.txtReste);
            this.tabPage4.Controls.Add(this.lblReste);
            this.tabPage4.Controls.Add(this.txtAcompte);
            this.tabPage4.Controls.Add(this.lblAcompte);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1132, 480);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Comptes";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(153, 36);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // lblEurosReste
            // 
            this.lblEurosReste.AutoSize = true;
            this.lblEurosReste.Location = new System.Drawing.Point(255, 123);
            this.lblEurosReste.Name = "lblEurosReste";
            this.lblEurosReste.Size = new System.Drawing.Size(13, 13);
            this.lblEurosReste.TabIndex = 0;
            this.lblEurosReste.Text = "€";
            // 
            // lblEurosAcompte
            // 
            this.lblEurosAcompte.AutoSize = true;
            this.lblEurosAcompte.Location = new System.Drawing.Point(255, 81);
            this.lblEurosAcompte.Name = "lblEurosAcompte";
            this.lblEurosAcompte.Size = new System.Drawing.Size(13, 13);
            this.lblEurosAcompte.TabIndex = 0;
            this.lblEurosAcompte.Text = "€";
            // 
            // lblEurosTotal
            // 
            this.lblEurosTotal.AutoSize = true;
            this.lblEurosTotal.Location = new System.Drawing.Point(255, 39);
            this.lblEurosTotal.Name = "lblEurosTotal";
            this.lblEurosTotal.Size = new System.Drawing.Size(13, 13);
            this.lblEurosTotal.TabIndex = 0;
            this.lblEurosTotal.Text = "€";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(84, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Motant total";
            // 
            // txtReste
            // 
            this.txtReste.Enabled = false;
            this.txtReste.Location = new System.Drawing.Point(153, 120);
            this.txtReste.Name = "txtReste";
            this.txtReste.Size = new System.Drawing.Size(100, 20);
            this.txtReste.TabIndex = 1;
            // 
            // lblReste
            // 
            this.lblReste.AutoSize = true;
            this.lblReste.Location = new System.Drawing.Point(74, 123);
            this.lblReste.Name = "lblReste";
            this.lblReste.Size = new System.Drawing.Size(73, 13);
            this.lblReste.TabIndex = 0;
            this.lblReste.Text = "Reste à payer";
            // 
            // txtAcompte
            // 
            this.txtAcompte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcParticipant, "acompte", true));
            this.txtAcompte.Enabled = false;
            this.txtAcompte.Location = new System.Drawing.Point(153, 78);
            this.txtAcompte.Name = "txtAcompte";
            this.txtAcompte.Size = new System.Drawing.Size(100, 20);
            this.txtAcompte.TabIndex = 1;
            // 
            // lblAcompte
            // 
            this.lblAcompte.AutoSize = true;
            this.lblAcompte.Location = new System.Drawing.Point(98, 81);
            this.lblAcompte.Name = "lblAcompte";
            this.lblAcompte.Size = new System.Drawing.Size(49, 13);
            this.lblAcompte.TabIndex = 0;
            this.lblAcompte.Text = "Acompte";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.grpActivites);
            this.tabPage3.Controls.Add(this.grpSessions);
            this.tabPage3.Controls.Add(this.lblTitreInscriptions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1132, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inscriptions";
            // 
            // grpActivites
            // 
            this.grpActivites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActivites.Controls.Add(this.dgvActivitesDispo);
            this.grpActivites.Controls.Add(this.lblActivitesDisponible);
            this.grpActivites.Controls.Add(this.lblActivitesParticipation);
            this.grpActivites.Controls.Add(this.dgvActivitesInscrites);
            this.grpActivites.Controls.Add(this.btnSupprimerActivite);
            this.grpActivites.Controls.Add(this.btnAjouterActivite);
            this.grpActivites.Location = new System.Drawing.Point(6, 264);
            this.grpActivites.Name = "grpActivites";
            this.grpActivites.Size = new System.Drawing.Size(1120, 210);
            this.grpActivites.TabIndex = 3;
            this.grpActivites.TabStop = false;
            this.grpActivites.Text = "Activités";
            // 
            // dgvActivitesDispo
            // 
            this.dgvActivitesDispo.AllowUserToAddRows = false;
            this.dgvActivitesDispo.AllowUserToDeleteRows = false;
            this.dgvActivitesDispo.AutoGenerateColumns = false;
            this.dgvActivitesDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActivitesDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivitesDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numActiviteDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn2,
            this.libelleDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn2,
            this.heureDataGridViewTextBoxColumn2});
            this.dgvActivitesDispo.DataSource = this.bindSrcActivitesDispo;
            this.dgvActivitesDispo.Location = new System.Drawing.Point(616, 35);
            this.dgvActivitesDispo.Name = "dgvActivitesDispo";
            this.dgvActivitesDispo.ReadOnly = true;
            this.dgvActivitesDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivitesDispo.Size = new System.Drawing.Size(498, 169);
            this.dgvActivitesDispo.TabIndex = 1;
            // 
            // numActiviteDataGridViewTextBoxColumn
            // 
            this.numActiviteDataGridViewTextBoxColumn.DataPropertyName = "numActivite";
            this.numActiviteDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numActiviteDataGridViewTextBoxColumn.Name = "numActiviteDataGridViewTextBoxColumn";
            this.numActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numActiviteDataGridViewTextBoxColumn.Width = 54;
            // 
            // tarifDataGridViewTextBoxColumn2
            // 
            this.tarifDataGridViewTextBoxColumn2.DataPropertyName = "tarif";
            this.tarifDataGridViewTextBoxColumn2.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn2.Name = "tarifDataGridViewTextBoxColumn2";
            this.tarifDataGridViewTextBoxColumn2.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn2.Width = 53;
            // 
            // libelleDataGridViewTextBoxColumn2
            // 
            this.libelleDataGridViewTextBoxColumn2.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.libelleDataGridViewTextBoxColumn2.Name = "libelleDataGridViewTextBoxColumn2";
            this.libelleDataGridViewTextBoxColumn2.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn2.Width = 54;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn2.Width = 55;
            // 
            // heureDataGridViewTextBoxColumn2
            // 
            this.heureDataGridViewTextBoxColumn2.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn2.HeaderText = "Heure";
            this.heureDataGridViewTextBoxColumn2.Name = "heureDataGridViewTextBoxColumn2";
            this.heureDataGridViewTextBoxColumn2.ReadOnly = true;
            this.heureDataGridViewTextBoxColumn2.Width = 61;
            // 
            // bindSrcActivitesDispo
            // 
            this.bindSrcActivitesDispo.DataSource = typeof(Lugati.dll.Activite);
            // 
            // lblActivitesDisponible
            // 
            this.lblActivitesDisponible.AutoSize = true;
            this.lblActivitesDisponible.Location = new System.Drawing.Point(613, 19);
            this.lblActivitesDisponible.Name = "lblActivitesDisponible";
            this.lblActivitesDisponible.Size = new System.Drawing.Size(56, 13);
            this.lblActivitesDisponible.TabIndex = 2;
            this.lblActivitesDisponible.Text = "Disponible";
            // 
            // lblActivitesParticipation
            // 
            this.lblActivitesParticipation.AutoSize = true;
            this.lblActivitesParticipation.Location = new System.Drawing.Point(3, 19);
            this.lblActivitesParticipation.Name = "lblActivitesParticipation";
            this.lblActivitesParticipation.Size = new System.Drawing.Size(70, 13);
            this.lblActivitesParticipation.TabIndex = 2;
            this.lblActivitesParticipation.Text = "Participations";
            // 
            // dgvActivitesInscrites
            // 
            this.dgvActivitesInscrites.AllowUserToAddRows = false;
            this.dgvActivitesInscrites.AllowUserToDeleteRows = false;
            this.dgvActivitesInscrites.AutoGenerateColumns = false;
            this.dgvActivitesInscrites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActivitesInscrites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivitesInscrites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numActiviteDataGridViewTextBoxColumn1,
            this.tarifDataGridViewTextBoxColumn3,
            this.libelleDataGridViewTextBoxColumn3,
            this.dateDataGridViewTextBoxColumn3,
            this.heureDataGridViewTextBoxColumn3});
            this.dgvActivitesInscrites.DataSource = this.bindSrcActivitesInscrites;
            this.dgvActivitesInscrites.Location = new System.Drawing.Point(6, 35);
            this.dgvActivitesInscrites.Name = "dgvActivitesInscrites";
            this.dgvActivitesInscrites.ReadOnly = true;
            this.dgvActivitesInscrites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivitesInscrites.Size = new System.Drawing.Size(498, 169);
            this.dgvActivitesInscrites.TabIndex = 1;
            // 
            // numActiviteDataGridViewTextBoxColumn1
            // 
            this.numActiviteDataGridViewTextBoxColumn1.DataPropertyName = "numActivite";
            this.numActiviteDataGridViewTextBoxColumn1.HeaderText = "Num";
            this.numActiviteDataGridViewTextBoxColumn1.Name = "numActiviteDataGridViewTextBoxColumn1";
            this.numActiviteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numActiviteDataGridViewTextBoxColumn1.Width = 54;
            // 
            // tarifDataGridViewTextBoxColumn3
            // 
            this.tarifDataGridViewTextBoxColumn3.DataPropertyName = "tarif";
            this.tarifDataGridViewTextBoxColumn3.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn3.Name = "tarifDataGridViewTextBoxColumn3";
            this.tarifDataGridViewTextBoxColumn3.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn3.Width = 53;
            // 
            // libelleDataGridViewTextBoxColumn3
            // 
            this.libelleDataGridViewTextBoxColumn3.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.libelleDataGridViewTextBoxColumn3.Name = "libelleDataGridViewTextBoxColumn3";
            this.libelleDataGridViewTextBoxColumn3.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn3.Width = 54;
            // 
            // dateDataGridViewTextBoxColumn3
            // 
            this.dateDataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn3.Name = "dateDataGridViewTextBoxColumn3";
            this.dateDataGridViewTextBoxColumn3.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn3.Width = 55;
            // 
            // heureDataGridViewTextBoxColumn3
            // 
            this.heureDataGridViewTextBoxColumn3.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn3.HeaderText = "Heure";
            this.heureDataGridViewTextBoxColumn3.Name = "heureDataGridViewTextBoxColumn3";
            this.heureDataGridViewTextBoxColumn3.ReadOnly = true;
            this.heureDataGridViewTextBoxColumn3.Width = 61;
            // 
            // bindSrcActivitesInscrites
            // 
            this.bindSrcActivitesInscrites.DataSource = typeof(Lugati.dll.Activite);
            // 
            // btnSupprimerActivite
            // 
            this.btnSupprimerActivite.Location = new System.Drawing.Point(510, 135);
            this.btnSupprimerActivite.Name = "btnSupprimerActivite";
            this.btnSupprimerActivite.Size = new System.Drawing.Size(100, 23);
            this.btnSupprimerActivite.TabIndex = 0;
            this.btnSupprimerActivite.Text = "Supprimer >>>";
            this.btnSupprimerActivite.UseVisualStyleBackColor = true;
            this.btnSupprimerActivite.Click += new System.EventHandler(this.btnSupprimerActivite_Click);
            // 
            // btnAjouterActivite
            // 
            this.btnAjouterActivite.Location = new System.Drawing.Point(510, 81);
            this.btnAjouterActivite.Name = "btnAjouterActivite";
            this.btnAjouterActivite.Size = new System.Drawing.Size(100, 23);
            this.btnAjouterActivite.TabIndex = 0;
            this.btnAjouterActivite.Text = "<<< Ajouter";
            this.btnAjouterActivite.UseVisualStyleBackColor = true;
            this.btnAjouterActivite.Click += new System.EventHandler(this.btnAjouterActivite_Click);
            // 
            // grpSessions
            // 
            this.grpSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSessions.Controls.Add(this.lblSessionsDisponible);
            this.grpSessions.Controls.Add(this.lblSessionsParticipation);
            this.grpSessions.Controls.Add(this.btnSupprimerSession);
            this.grpSessions.Controls.Add(this.btnAjouterSession);
            this.grpSessions.Controls.Add(this.dgvSessionsDispo);
            this.grpSessions.Controls.Add(this.dgvSessionsInscrites);
            this.grpSessions.Location = new System.Drawing.Point(6, 48);
            this.grpSessions.Name = "grpSessions";
            this.grpSessions.Size = new System.Drawing.Size(1120, 210);
            this.grpSessions.TabIndex = 1;
            this.grpSessions.TabStop = false;
            this.grpSessions.Text = "Sessions";
            // 
            // lblSessionsDisponible
            // 
            this.lblSessionsDisponible.AutoSize = true;
            this.lblSessionsDisponible.Location = new System.Drawing.Point(613, 19);
            this.lblSessionsDisponible.Name = "lblSessionsDisponible";
            this.lblSessionsDisponible.Size = new System.Drawing.Size(56, 13);
            this.lblSessionsDisponible.TabIndex = 2;
            this.lblSessionsDisponible.Text = "Disponible";
            // 
            // lblSessionsParticipation
            // 
            this.lblSessionsParticipation.AutoSize = true;
            this.lblSessionsParticipation.Location = new System.Drawing.Point(3, 19);
            this.lblSessionsParticipation.Name = "lblSessionsParticipation";
            this.lblSessionsParticipation.Size = new System.Drawing.Size(60, 13);
            this.lblSessionsParticipation.TabIndex = 2;
            this.lblSessionsParticipation.Text = "Inscriptions";
            // 
            // btnSupprimerSession
            // 
            this.btnSupprimerSession.Location = new System.Drawing.Point(510, 135);
            this.btnSupprimerSession.Name = "btnSupprimerSession";
            this.btnSupprimerSession.Size = new System.Drawing.Size(100, 23);
            this.btnSupprimerSession.TabIndex = 0;
            this.btnSupprimerSession.Text = "Supprimer >>>";
            this.btnSupprimerSession.UseVisualStyleBackColor = true;
            this.btnSupprimerSession.Click += new System.EventHandler(this.btnSupprimerSession_Click);
            // 
            // btnAjouterSession
            // 
            this.btnAjouterSession.Location = new System.Drawing.Point(510, 81);
            this.btnAjouterSession.Name = "btnAjouterSession";
            this.btnAjouterSession.Size = new System.Drawing.Size(100, 23);
            this.btnAjouterSession.TabIndex = 0;
            this.btnAjouterSession.Text = "<<< Ajouter";
            this.btnAjouterSession.UseVisualStyleBackColor = true;
            this.btnAjouterSession.Click += new System.EventHandler(this.btnAjouterSession_Click);
            // 
            // dgvSessionsDispo
            // 
            this.dgvSessionsDispo.AllowUserToAddRows = false;
            this.dgvSessionsDispo.AllowUserToDeleteRows = false;
            this.dgvSessionsDispo.AutoGenerateColumns = false;
            this.dgvSessionsDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSessionsDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionsDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn});
            this.dgvSessionsDispo.DataSource = this.bindSrcSessionsDispo;
            this.dgvSessionsDispo.Location = new System.Drawing.Point(616, 35);
            this.dgvSessionsDispo.Name = "dgvSessionsDispo";
            this.dgvSessionsDispo.ReadOnly = true;
            this.dgvSessionsDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionsDispo.Size = new System.Drawing.Size(498, 169);
            this.dgvSessionsDispo.TabIndex = 1;
            // 
            // numSessionDataGridViewTextBoxColumn
            // 
            this.numSessionDataGridViewTextBoxColumn.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numSessionDataGridViewTextBoxColumn.Name = "numSessionDataGridViewTextBoxColumn";
            this.numSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numSessionDataGridViewTextBoxColumn.Width = 54;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn.Width = 54;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            this.tarifDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn.Width = 53;
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
            // bindSrcSessionsDispo
            // 
            this.bindSrcSessionsDispo.DataSource = typeof(Lugati.dll.Session);
            // 
            // dgvSessionsInscrites
            // 
            this.dgvSessionsInscrites.AllowUserToAddRows = false;
            this.dgvSessionsInscrites.AllowUserToDeleteRows = false;
            this.dgvSessionsInscrites.AutoGenerateColumns = false;
            this.dgvSessionsInscrites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSessionsInscrites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionsInscrites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn1,
            this.tarifDataGridViewTextBoxColumn1,
            this.libelleDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.heureDataGridViewTextBoxColumn1});
            this.dgvSessionsInscrites.DataSource = this.bindSrcSessionsInscrites;
            this.dgvSessionsInscrites.Location = new System.Drawing.Point(6, 35);
            this.dgvSessionsInscrites.Name = "dgvSessionsInscrites";
            this.dgvSessionsInscrites.ReadOnly = true;
            this.dgvSessionsInscrites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionsInscrites.Size = new System.Drawing.Size(498, 169);
            this.dgvSessionsInscrites.TabIndex = 1;
            // 
            // numSessionDataGridViewTextBoxColumn1
            // 
            this.numSessionDataGridViewTextBoxColumn1.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn1.HeaderText = "Num";
            this.numSessionDataGridViewTextBoxColumn1.Name = "numSessionDataGridViewTextBoxColumn1";
            this.numSessionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numSessionDataGridViewTextBoxColumn1.Width = 54;
            // 
            // tarifDataGridViewTextBoxColumn1
            // 
            this.tarifDataGridViewTextBoxColumn1.DataPropertyName = "tarif";
            this.tarifDataGridViewTextBoxColumn1.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn1.Name = "tarifDataGridViewTextBoxColumn1";
            this.tarifDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn1.Width = 53;
            // 
            // libelleDataGridViewTextBoxColumn1
            // 
            this.libelleDataGridViewTextBoxColumn1.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.libelleDataGridViewTextBoxColumn1.Name = "libelleDataGridViewTextBoxColumn1";
            this.libelleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn1.Width = 54;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn1.Width = 55;
            // 
            // heureDataGridViewTextBoxColumn1
            // 
            this.heureDataGridViewTextBoxColumn1.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn1.HeaderText = "Heure";
            this.heureDataGridViewTextBoxColumn1.Name = "heureDataGridViewTextBoxColumn1";
            this.heureDataGridViewTextBoxColumn1.ReadOnly = true;
            this.heureDataGridViewTextBoxColumn1.Width = 61;
            // 
            // bindSrcSessionsInscrites
            // 
            this.bindSrcSessionsInscrites.DataSource = typeof(Lugati.dll.Session);
            // 
            // lblTitreInscriptions
            // 
            this.lblTitreInscriptions.AutoSize = true;
            this.lblTitreInscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreInscriptions.Location = new System.Drawing.Point(136, 15);
            this.lblTitreInscriptions.Name = "lblTitreInscriptions";
            this.lblTitreInscriptions.Size = new System.Drawing.Size(146, 24);
            this.lblTitreInscriptions.TabIndex = 0;
            this.lblTitreInscriptions.Text = "Inscriptions de";
            // 
            // tabPageParticipant
            // 
            this.tabPageParticipant.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageParticipant.Controls.Add(this.grpBtnsSaveCancel);
            this.tabPageParticipant.Controls.Add(this.grpBoutons);
            this.tabPageParticipant.Controls.Add(this.grpInfos);
            this.tabPageParticipant.Controls.Add(this.dgvParticipants);
            this.tabPageParticipant.Location = new System.Drawing.Point(4, 22);
            this.tabPageParticipant.Name = "tabPageParticipant";
            this.tabPageParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParticipant.Size = new System.Drawing.Size(1132, 480);
            this.tabPageParticipant.TabIndex = 0;
            this.tabPageParticipant.Text = "Participants";
            // 
            // grpBtnsSaveCancel
            // 
            this.grpBtnsSaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBtnsSaveCancel.Controls.Add(this.btnEnregistrerParticipant);
            this.grpBtnsSaveCancel.Controls.Add(this.btnAnnuler);
            this.grpBtnsSaveCancel.Location = new System.Drawing.Point(1002, 382);
            this.grpBtnsSaveCancel.Name = "grpBtnsSaveCancel";
            this.grpBtnsSaveCancel.Size = new System.Drawing.Size(126, 95);
            this.grpBtnsSaveCancel.TabIndex = 13;
            this.grpBtnsSaveCancel.TabStop = false;
            this.grpBtnsSaveCancel.Visible = false;
            // 
            // btnEnregistrerParticipant
            // 
            this.btnEnregistrerParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerParticipant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnregistrerParticipant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnregistrerParticipant.Location = new System.Drawing.Point(6, 12);
            this.btnEnregistrerParticipant.Name = "btnEnregistrerParticipant";
            this.btnEnregistrerParticipant.Size = new System.Drawing.Size(114, 35);
            this.btnEnregistrerParticipant.TabIndex = 13;
            this.btnEnregistrerParticipant.Text = "Enregistrer modifications";
            this.btnEnregistrerParticipant.UseVisualStyleBackColor = false;
            this.btnEnregistrerParticipant.Click += new System.EventHandler(this.btnEnregistrerParticipant_Click);
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
            // grpBoutons
            // 
            this.grpBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierParticipant);
            this.grpBoutons.Controls.Add(this.btnSupprimerParticipant);
            this.grpBoutons.Controls.Add(this.btnAjouterParticipant);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Location = new System.Drawing.Point(1002, 210);
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.Size = new System.Drawing.Size(126, 139);
            this.grpBoutons.TabIndex = 9;
            this.grpBoutons.TabStop = false;
            // 
            // btnModifierParticipant
            // 
            this.btnModifierParticipant.BackColor = System.Drawing.Color.White;
            this.btnModifierParticipant.ForeColor = System.Drawing.Color.Black;
            this.btnModifierParticipant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifierParticipant.Location = new System.Drawing.Point(6, 96);
            this.btnModifierParticipant.Name = "btnModifierParticipant";
            this.btnModifierParticipant.Size = new System.Drawing.Size(114, 35);
            this.btnModifierParticipant.TabIndex = 11;
            this.btnModifierParticipant.Text = "Modifier";
            this.btnModifierParticipant.UseVisualStyleBackColor = false;
            this.btnModifierParticipant.Click += new System.EventHandler(this.btnModifierParticipant_Click);
            // 
            // btnSupprimerParticipant
            // 
            this.btnSupprimerParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerParticipant.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerParticipant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimerParticipant.Location = new System.Drawing.Point(6, 55);
            this.btnSupprimerParticipant.Name = "btnSupprimerParticipant";
            this.btnSupprimerParticipant.Size = new System.Drawing.Size(114, 35);
            this.btnSupprimerParticipant.TabIndex = 10;
            this.btnSupprimerParticipant.Text = "Supprimer le participant";
            this.btnSupprimerParticipant.UseVisualStyleBackColor = false;
            this.btnSupprimerParticipant.Click += new System.EventHandler(this.btnSupprimerParticipant_Click);
            // 
            // btnAjouterParticipant
            // 
            this.btnAjouterParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAjouterParticipant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjouterParticipant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjouterParticipant.Location = new System.Drawing.Point(6, 12);
            this.btnAjouterParticipant.Name = "btnAjouterParticipant";
            this.btnAjouterParticipant.Size = new System.Drawing.Size(114, 35);
            this.btnAjouterParticipant.TabIndex = 9;
            this.btnAjouterParticipant.Text = "Ajouter un participant";
            this.btnAjouterParticipant.UseVisualStyleBackColor = false;
            this.btnAjouterParticipant.Click += new System.EventHandler(this.btnAjouterParticipant_Click);
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.Controls.Add(this.comboGenre);
            this.grpInfos.Controls.Add(this.maskTxtCP);
            this.grpInfos.Controls.Add(this.comboHebergement);
            this.grpInfos.Controls.Add(this.comboLigue);
            this.grpInfos.Controls.Add(this.lblHebergement);
            this.grpInfos.Controls.Add(this.lblLigue);
            this.grpInfos.Controls.Add(this.txtVille);
            this.grpInfos.Controls.Add(this.txtAdresse);
            this.grpInfos.Controls.Add(this.lblCP);
            this.grpInfos.Controls.Add(this.lblVille);
            this.grpInfos.Controls.Add(this.lblAdresse);
            this.grpInfos.Controls.Add(this.lblGenre);
            this.grpInfos.Controls.Add(this.txtPrenom);
            this.grpInfos.Controls.Add(this.lblPrenom);
            this.grpInfos.Controls.Add(this.lblNom);
            this.grpInfos.Controls.Add(this.txtNom);
            this.grpInfos.Enabled = false;
            this.grpInfos.Location = new System.Drawing.Point(3, 210);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(928, 267);
            this.grpInfos.TabIndex = 2;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // comboGenre
            // 
            this.comboGenre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcParticipant, "genre", true));
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(161, 119);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(218, 21);
            this.comboGenre.TabIndex = 40;
            // 
            // maskTxtCP
            // 
            this.maskTxtCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcParticipant, "cp", true));
            this.maskTxtCP.Location = new System.Drawing.Point(597, 120);
            this.maskTxtCP.Mask = "99999";
            this.maskTxtCP.Name = "maskTxtCP";
            this.maskTxtCP.Size = new System.Drawing.Size(218, 20);
            this.maskTxtCP.TabIndex = 39;
            // 
            // comboHebergement
            // 
            this.comboHebergement.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcParticipant, "hebergement", true));
            this.comboHebergement.DataSource = this.bindSrcHebergement;
            this.comboHebergement.DisplayMember = "nomHebergement";
            this.comboHebergement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHebergement.FormattingEnabled = true;
            this.comboHebergement.Location = new System.Drawing.Point(370, 208);
            this.comboHebergement.Name = "comboHebergement";
            this.comboHebergement.Size = new System.Drawing.Size(218, 21);
            this.comboHebergement.TabIndex = 38;
            // 
            // bindSrcHebergement
            // 
            this.bindSrcHebergement.DataSource = typeof(Lugati.dll.Hebergement);
            // 
            // comboLigue
            // 
            this.comboLigue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcParticipant, "ligue", true));
            this.comboLigue.DataSource = this.bindSrcLigue;
            this.comboLigue.DisplayMember = "nomLigue";
            this.comboLigue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLigue.FormattingEnabled = true;
            this.comboLigue.Location = new System.Drawing.Point(370, 167);
            this.comboLigue.Name = "comboLigue";
            this.comboLigue.Size = new System.Drawing.Size(218, 21);
            this.comboLigue.TabIndex = 37;
            // 
            // lblHebergement
            // 
            this.lblHebergement.AutoSize = true;
            this.lblHebergement.Location = new System.Drawing.Point(293, 211);
            this.lblHebergement.Name = "lblHebergement";
            this.lblHebergement.Size = new System.Drawing.Size(71, 13);
            this.lblHebergement.TabIndex = 34;
            this.lblHebergement.Text = "Hebergement";
            // 
            // lblLigue
            // 
            this.lblLigue.AutoSize = true;
            this.lblLigue.Location = new System.Drawing.Point(331, 170);
            this.lblLigue.Name = "lblLigue";
            this.lblLigue.Size = new System.Drawing.Size(33, 13);
            this.lblLigue.TabIndex = 33;
            this.lblLigue.Text = "Ligue";
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcParticipant, "ville", true));
            this.txtVille.Location = new System.Drawing.Point(597, 83);
            this.txtVille.MaxLength = 30;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(218, 20);
            this.txtVille.TabIndex = 30;
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcParticipant, "adresse", true));
            this.txtAdresse.Location = new System.Drawing.Point(597, 46);
            this.txtAdresse.MaxLength = 50;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(218, 20);
            this.txtAdresse.TabIndex = 29;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(527, 123);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(64, 13);
            this.lblCP.TabIndex = 28;
            this.lblCP.Text = "Code Postal";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(565, 86);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 27;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(546, 49);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 26;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(119, 123);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre";
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcParticipant, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(161, 83);
            this.txtPrenom.MaxLength = 30;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(218, 20);
            this.txtPrenom.TabIndex = 24;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(112, 86);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 23;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(126, 49);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcParticipant, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(161, 46);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(218, 20);
            this.txtNom.TabIndex = 21;
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
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.ligue,
            this.hebergement});
            this.dgvParticipants.DataSource = this.bindSrcParticipant;
            this.dgvParticipants.Location = new System.Drawing.Point(3, 3);
            this.dgvParticipants.MultiSelect = false;
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipants.Size = new System.Drawing.Size(1125, 201);
            this.dgvParticipants.TabIndex = 0;
            // 
            // idParticipantDataGridViewTextBoxColumn
            // 
            this.idParticipantDataGridViewTextBoxColumn.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.idParticipantDataGridViewTextBoxColumn.Name = "idParticipantDataGridViewTextBoxColumn";
            this.idParticipantDataGridViewTextBoxColumn.ReadOnly = true;
            this.idParticipantDataGridViewTextBoxColumn.Width = 78;
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
            // ligue
            // 
            this.ligue.DataPropertyName = "ligue";
            this.ligue.HeaderText = "Ligue";
            this.ligue.Name = "ligue";
            this.ligue.ReadOnly = true;
            this.ligue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ligue.Width = 58;
            // 
            // hebergement
            // 
            this.hebergement.DataPropertyName = "hebergement";
            this.hebergement.HeaderText = "Hebergement";
            this.hebergement.Name = "hebergement";
            this.hebergement.ReadOnly = true;
            this.hebergement.Width = 96;
            // 
            // tabParticipant
            // 
            this.tabParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabParticipant.Controls.Add(this.tabPageParticipant);
            this.tabParticipant.Controls.Add(this.tabPage3);
            this.tabParticipant.Controls.Add(this.tabPage4);
            this.tabParticipant.Location = new System.Drawing.Point(12, 12);
            this.tabParticipant.Name = "tabParticipant";
            this.tabParticipant.SelectedIndex = 0;
            this.tabParticipant.Size = new System.Drawing.Size(1140, 506);
            this.tabParticipant.TabIndex = 0;
            // 
            // FrmParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1164, 530);
            this.Controls.Add(this.tabParticipant);
            this.Name = "FrmParticipant";
            this.Text = "Participants";
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLigue)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpActivites.ResumeLayout(false);
            this.grpActivites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitesDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivitesDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitesInscrites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivitesInscrites)).EndInit();
            this.grpSessions.ResumeLayout(false);
            this.grpSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessionsDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsInscrites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessionsInscrites)).EndInit();
            this.tabPageParticipant.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.grpBoutons.ResumeLayout(false);
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.tabParticipant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindSrcParticipant;
        private System.Windows.Forms.BindingSource bindSrcLigue;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageParticipant;
        private System.Windows.Forms.GroupBox grpBtnsSaveCancel;
        private System.Windows.Forms.Button btnEnregistrerParticipant;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grpBoutons;
        private System.Windows.Forms.Button btnModifierParticipant;
        private System.Windows.Forms.Button btnSupprimerParticipant;
        private System.Windows.Forms.Button btnAjouterParticipant;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblHebergement;
        private System.Windows.Forms.Label lblLigue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.TabControl tabParticipant;
        private System.Windows.Forms.ComboBox comboLigue;
        private System.Windows.Forms.BindingSource bindSrcHebergement;
        private System.Windows.Forms.ComboBox comboHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebergement;
        private System.Windows.Forms.MaskedTextBox maskTxtCP;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Label lblTitreInscriptions;
        private System.Windows.Forms.GroupBox grpActivites;
        private System.Windows.Forms.GroupBox grpSessions;
        private System.Windows.Forms.Label lblSessionsDisponible;
        private System.Windows.Forms.Label lblSessionsParticipation;
        private System.Windows.Forms.Button btnSupprimerSession;
        private System.Windows.Forms.Button btnAjouterSession;
        private System.Windows.Forms.DataGridView dgvSessionsDispo;
        private System.Windows.Forms.DataGridView dgvSessionsInscrites;
        private System.Windows.Forms.BindingSource bindSrcSessionsDispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcSessionsInscrites;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvActivitesInscrites;
        private System.Windows.Forms.DataGridView dgvActivitesDispo;
        private System.Windows.Forms.Button btnSupprimerActivite;
        private System.Windows.Forms.Button btnAjouterActivite;
        private System.Windows.Forms.BindingSource bindSrcActivitesDispo;
        private System.Windows.Forms.Label lblActivitesDisponible;
        private System.Windows.Forms.Label lblActivitesParticipation;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bindSrcActivitesInscrites;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtAcompte;
        private System.Windows.Forms.Label lblAcompte;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEurosAcompte;
        private System.Windows.Forms.Label lblEurosTotal;
        private System.Windows.Forms.Label lblEurosReste;
        private System.Windows.Forms.TextBox txtReste;
        private System.Windows.Forms.Label lblReste;
    }
}