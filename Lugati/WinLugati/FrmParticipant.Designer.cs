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
            this.bindingSourceParticipant = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceLigue = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtAcompte = new System.Windows.Forms.TextBox();
            this.lblAcompte = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxActivites = new System.Windows.Forms.GroupBox();
            this.dataGridViewActivitesDispo = new System.Windows.Forms.DataGridView();
            this.numActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActivitesDispo = new System.Windows.Forms.BindingSource(this.components);
            this.lblActivitesDisponible = new System.Windows.Forms.Label();
            this.lblActivitesParticipation = new System.Windows.Forms.Label();
            this.dataGridViewActivitesInscrites = new System.Windows.Forms.DataGridView();
            this.numActiviteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActivitesInscrites = new System.Windows.Forms.BindingSource(this.components);
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.groupBoxSessions = new System.Windows.Forms.GroupBox();
            this.lblSessionsDisponible = new System.Windows.Forms.Label();
            this.lblSessionsParticipation = new System.Windows.Forms.Label();
            this.btnSupprimerSession = new System.Windows.Forms.Button();
            this.btnAjouterSession = new System.Windows.Forms.Button();
            this.dataGridViewSessionsDispo = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSessionsDispo = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSessionsInscrites = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSessionsInscrites = new System.Windows.Forms.BindingSource(this.components);
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
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCP = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxHebergement = new System.Windows.Forms.ComboBox();
            this.bindingSourceHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxLigue = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVilleParticipant = new System.Windows.Forms.Label();
            this.lblAdresseParticipant = new System.Windows.Forms.Label();
            this.lblGenreParticipant = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenomParticipant = new System.Windows.Forms.Label();
            this.lblNomParticipant = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.dataGridParticipant = new System.Windows.Forms.DataGridView();
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLigue)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxActivites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitesDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitesDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitesInscrites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitesInscrites)).BeginInit();
            this.groupBoxSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionsDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSessionsDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionsInscrites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSessionsInscrites)).BeginInit();
            this.tabPageParticipant.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.grpBoutons.SuspendLayout();
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHebergement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant)).BeginInit();
            this.tabParticipant.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceParticipant
            // 
            this.bindingSourceParticipant.DataSource = typeof(Lugati.dll.Participant);
            this.bindingSourceParticipant.CurrentChanged += new System.EventHandler(this.bindingSourceParticipant_CurrentChanged);
            // 
            // bindingSourceLigue
            // 
            this.bindingSourceLigue.DataSource = typeof(Lugati.dll.Ligue);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.txtTotal);
            this.tabPage4.Controls.Add(this.lblTotal);
            this.tabPage4.Controls.Add(this.txtAcompte);
            this.tabPage4.Controls.Add(this.lblAcompte);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1132, 480);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Comptes";
            // 
            // txtAcompte
            // 
            this.txtAcompte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "acompte", true));
            this.txtAcompte.Enabled = false;
            this.txtAcompte.Location = new System.Drawing.Point(127, 78);
            this.txtAcompte.Name = "txtAcompte";
            this.txtAcompte.Size = new System.Drawing.Size(100, 20);
            this.txtAcompte.TabIndex = 1;
            // 
            // lblAcompte
            // 
            this.lblAcompte.AutoSize = true;
            this.lblAcompte.Location = new System.Drawing.Point(72, 81);
            this.lblAcompte.Name = "lblAcompte";
            this.lblAcompte.Size = new System.Drawing.Size(49, 13);
            this.lblAcompte.TabIndex = 0;
            this.lblAcompte.Text = "Acompte";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBoxActivites);
            this.tabPage3.Controls.Add(this.groupBoxSessions);
            this.tabPage3.Controls.Add(this.lblTitreInscriptions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1132, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inscriptions";
            // 
            // groupBoxActivites
            // 
            this.groupBoxActivites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActivites.Controls.Add(this.dataGridViewActivitesDispo);
            this.groupBoxActivites.Controls.Add(this.lblActivitesDisponible);
            this.groupBoxActivites.Controls.Add(this.lblActivitesParticipation);
            this.groupBoxActivites.Controls.Add(this.dataGridViewActivitesInscrites);
            this.groupBoxActivites.Controls.Add(this.btnSupprimerActivite);
            this.groupBoxActivites.Controls.Add(this.btnAjouterActivite);
            this.groupBoxActivites.Location = new System.Drawing.Point(6, 264);
            this.groupBoxActivites.Name = "groupBoxActivites";
            this.groupBoxActivites.Size = new System.Drawing.Size(1120, 210);
            this.groupBoxActivites.TabIndex = 3;
            this.groupBoxActivites.TabStop = false;
            this.groupBoxActivites.Text = "Activités";
            // 
            // dataGridViewActivitesDispo
            // 
            this.dataGridViewActivitesDispo.AllowUserToAddRows = false;
            this.dataGridViewActivitesDispo.AllowUserToDeleteRows = false;
            this.dataGridViewActivitesDispo.AutoGenerateColumns = false;
            this.dataGridViewActivitesDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewActivitesDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivitesDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numActiviteDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn2,
            this.libelleDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn2,
            this.heureDataGridViewTextBoxColumn2});
            this.dataGridViewActivitesDispo.DataSource = this.bindingSourceActivitesDispo;
            this.dataGridViewActivitesDispo.Location = new System.Drawing.Point(616, 35);
            this.dataGridViewActivitesDispo.Name = "dataGridViewActivitesDispo";
            this.dataGridViewActivitesDispo.ReadOnly = true;
            this.dataGridViewActivitesDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivitesDispo.Size = new System.Drawing.Size(498, 169);
            this.dataGridViewActivitesDispo.TabIndex = 1;
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
            // bindingSourceActivitesDispo
            // 
            this.bindingSourceActivitesDispo.DataSource = typeof(Lugati.dll.Activite);
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
            // dataGridViewActivitesInscrites
            // 
            this.dataGridViewActivitesInscrites.AllowUserToAddRows = false;
            this.dataGridViewActivitesInscrites.AllowUserToDeleteRows = false;
            this.dataGridViewActivitesInscrites.AutoGenerateColumns = false;
            this.dataGridViewActivitesInscrites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewActivitesInscrites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivitesInscrites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numActiviteDataGridViewTextBoxColumn1,
            this.tarifDataGridViewTextBoxColumn3,
            this.libelleDataGridViewTextBoxColumn3,
            this.dateDataGridViewTextBoxColumn3,
            this.heureDataGridViewTextBoxColumn3});
            this.dataGridViewActivitesInscrites.DataSource = this.bindingSourceActivitesInscrites;
            this.dataGridViewActivitesInscrites.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewActivitesInscrites.Name = "dataGridViewActivitesInscrites";
            this.dataGridViewActivitesInscrites.ReadOnly = true;
            this.dataGridViewActivitesInscrites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivitesInscrites.Size = new System.Drawing.Size(498, 169);
            this.dataGridViewActivitesInscrites.TabIndex = 1;
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
            // bindingSourceActivitesInscrites
            // 
            this.bindingSourceActivitesInscrites.DataSource = typeof(Lugati.dll.Activite);
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
            // groupBoxSessions
            // 
            this.groupBoxSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSessions.Controls.Add(this.lblSessionsDisponible);
            this.groupBoxSessions.Controls.Add(this.lblSessionsParticipation);
            this.groupBoxSessions.Controls.Add(this.btnSupprimerSession);
            this.groupBoxSessions.Controls.Add(this.btnAjouterSession);
            this.groupBoxSessions.Controls.Add(this.dataGridViewSessionsDispo);
            this.groupBoxSessions.Controls.Add(this.dataGridViewSessionsInscrites);
            this.groupBoxSessions.Location = new System.Drawing.Point(6, 48);
            this.groupBoxSessions.Name = "groupBoxSessions";
            this.groupBoxSessions.Size = new System.Drawing.Size(1120, 210);
            this.groupBoxSessions.TabIndex = 1;
            this.groupBoxSessions.TabStop = false;
            this.groupBoxSessions.Text = "Sessions";
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
            // dataGridViewSessionsDispo
            // 
            this.dataGridViewSessionsDispo.AllowUserToAddRows = false;
            this.dataGridViewSessionsDispo.AllowUserToDeleteRows = false;
            this.dataGridViewSessionsDispo.AutoGenerateColumns = false;
            this.dataGridViewSessionsDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessionsDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessionsDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn});
            this.dataGridViewSessionsDispo.DataSource = this.bindingSourceSessionsDispo;
            this.dataGridViewSessionsDispo.Location = new System.Drawing.Point(616, 35);
            this.dataGridViewSessionsDispo.Name = "dataGridViewSessionsDispo";
            this.dataGridViewSessionsDispo.ReadOnly = true;
            this.dataGridViewSessionsDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSessionsDispo.Size = new System.Drawing.Size(498, 169);
            this.dataGridViewSessionsDispo.TabIndex = 1;
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
            // bindingSourceSessionsDispo
            // 
            this.bindingSourceSessionsDispo.DataSource = typeof(Lugati.dll.Session);
            // 
            // dataGridViewSessionsInscrites
            // 
            this.dataGridViewSessionsInscrites.AllowUserToAddRows = false;
            this.dataGridViewSessionsInscrites.AllowUserToDeleteRows = false;
            this.dataGridViewSessionsInscrites.AutoGenerateColumns = false;
            this.dataGridViewSessionsInscrites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessionsInscrites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessionsInscrites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn1,
            this.tarifDataGridViewTextBoxColumn1,
            this.libelleDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.heureDataGridViewTextBoxColumn1});
            this.dataGridViewSessionsInscrites.DataSource = this.bindingSourceSessionsInscrites;
            this.dataGridViewSessionsInscrites.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewSessionsInscrites.Name = "dataGridViewSessionsInscrites";
            this.dataGridViewSessionsInscrites.ReadOnly = true;
            this.dataGridViewSessionsInscrites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSessionsInscrites.Size = new System.Drawing.Size(498, 169);
            this.dataGridViewSessionsInscrites.TabIndex = 1;
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
            // bindingSourceSessionsInscrites
            // 
            this.bindingSourceSessionsInscrites.DataSource = typeof(Lugati.dll.Session);
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
            this.tabPageParticipant.Controls.Add(this.dataGridParticipant);
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
            this.grpInfos.Controls.Add(this.comboBoxGenre);
            this.grpInfos.Controls.Add(this.maskedTextBoxCP);
            this.grpInfos.Controls.Add(this.comboBoxHebergement);
            this.grpInfos.Controls.Add(this.comboBoxLigue);
            this.grpInfos.Controls.Add(this.label10);
            this.grpInfos.Controls.Add(this.label9);
            this.grpInfos.Controls.Add(this.textBoxVille);
            this.grpInfos.Controls.Add(this.textBoxAdresse);
            this.grpInfos.Controls.Add(this.label8);
            this.grpInfos.Controls.Add(this.lblVilleParticipant);
            this.grpInfos.Controls.Add(this.lblAdresseParticipant);
            this.grpInfos.Controls.Add(this.lblGenreParticipant);
            this.grpInfos.Controls.Add(this.textBoxPrenom);
            this.grpInfos.Controls.Add(this.lblPrenomParticipant);
            this.grpInfos.Controls.Add(this.lblNomParticipant);
            this.grpInfos.Controls.Add(this.textBoxNom);
            this.grpInfos.Enabled = false;
            this.grpInfos.Location = new System.Drawing.Point(3, 210);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(928, 267);
            this.grpInfos.TabIndex = 2;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceParticipant, "genre", true));
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(161, 119);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(218, 21);
            this.comboBoxGenre.TabIndex = 40;
            // 
            // maskedTextBoxCP
            // 
            this.maskedTextBoxCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "cp", true));
            this.maskedTextBoxCP.Location = new System.Drawing.Point(597, 120);
            this.maskedTextBoxCP.Mask = "99999";
            this.maskedTextBoxCP.Name = "maskedTextBoxCP";
            this.maskedTextBoxCP.Size = new System.Drawing.Size(218, 20);
            this.maskedTextBoxCP.TabIndex = 39;
            // 
            // comboBoxHebergement
            // 
            this.comboBoxHebergement.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceParticipant, "hebergement", true));
            this.comboBoxHebergement.DataSource = this.bindingSourceHebergement;
            this.comboBoxHebergement.DisplayMember = "nomHebergement";
            this.comboBoxHebergement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHebergement.FormattingEnabled = true;
            this.comboBoxHebergement.Location = new System.Drawing.Point(370, 208);
            this.comboBoxHebergement.Name = "comboBoxHebergement";
            this.comboBoxHebergement.Size = new System.Drawing.Size(218, 21);
            this.comboBoxHebergement.TabIndex = 38;
            // 
            // bindingSourceHebergement
            // 
            this.bindingSourceHebergement.DataSource = typeof(Lugati.dll.Hebergement);
            // 
            // comboBoxLigue
            // 
            this.comboBoxLigue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceParticipant, "ligue", true));
            this.comboBoxLigue.DataSource = this.bindingSourceLigue;
            this.comboBoxLigue.DisplayMember = "nomLigue";
            this.comboBoxLigue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLigue.FormattingEnabled = true;
            this.comboBoxLigue.Location = new System.Drawing.Point(370, 167);
            this.comboBoxLigue.Name = "comboBoxLigue";
            this.comboBoxLigue.Size = new System.Drawing.Size(218, 21);
            this.comboBoxLigue.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Hebergement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ligue";
            // 
            // textBoxVille
            // 
            this.textBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "ville", true));
            this.textBoxVille.Location = new System.Drawing.Point(597, 83);
            this.textBoxVille.MaxLength = 30;
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(218, 20);
            this.textBoxVille.TabIndex = 30;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "adresse", true));
            this.textBoxAdresse.Location = new System.Drawing.Point(597, 46);
            this.textBoxAdresse.MaxLength = 50;
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(218, 20);
            this.textBoxAdresse.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Code Postal";
            // 
            // lblVilleParticipant
            // 
            this.lblVilleParticipant.AutoSize = true;
            this.lblVilleParticipant.Location = new System.Drawing.Point(565, 86);
            this.lblVilleParticipant.Name = "lblVilleParticipant";
            this.lblVilleParticipant.Size = new System.Drawing.Size(26, 13);
            this.lblVilleParticipant.TabIndex = 27;
            this.lblVilleParticipant.Text = "Ville";
            // 
            // lblAdresseParticipant
            // 
            this.lblAdresseParticipant.AutoSize = true;
            this.lblAdresseParticipant.Location = new System.Drawing.Point(546, 49);
            this.lblAdresseParticipant.Name = "lblAdresseParticipant";
            this.lblAdresseParticipant.Size = new System.Drawing.Size(45, 13);
            this.lblAdresseParticipant.TabIndex = 26;
            this.lblAdresseParticipant.Text = "Adresse";
            // 
            // lblGenreParticipant
            // 
            this.lblGenreParticipant.AutoSize = true;
            this.lblGenreParticipant.Location = new System.Drawing.Point(119, 123);
            this.lblGenreParticipant.Name = "lblGenreParticipant";
            this.lblGenreParticipant.Size = new System.Drawing.Size(36, 13);
            this.lblGenreParticipant.TabIndex = 25;
            this.lblGenreParticipant.Text = "Genre";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "prenom", true));
            this.textBoxPrenom.Location = new System.Drawing.Point(161, 83);
            this.textBoxPrenom.MaxLength = 30;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(218, 20);
            this.textBoxPrenom.TabIndex = 24;
            // 
            // lblPrenomParticipant
            // 
            this.lblPrenomParticipant.AutoSize = true;
            this.lblPrenomParticipant.Location = new System.Drawing.Point(112, 86);
            this.lblPrenomParticipant.Name = "lblPrenomParticipant";
            this.lblPrenomParticipant.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomParticipant.TabIndex = 23;
            this.lblPrenomParticipant.Text = "Prenom";
            // 
            // lblNomParticipant
            // 
            this.lblNomParticipant.AutoSize = true;
            this.lblNomParticipant.Location = new System.Drawing.Point(126, 49);
            this.lblNomParticipant.Name = "lblNomParticipant";
            this.lblNomParticipant.Size = new System.Drawing.Size(29, 13);
            this.lblNomParticipant.TabIndex = 22;
            this.lblNomParticipant.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "nom", true));
            this.textBoxNom.Location = new System.Drawing.Point(161, 46);
            this.textBoxNom.MaxLength = 30;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(218, 20);
            this.textBoxNom.TabIndex = 21;
            // 
            // dataGridParticipant
            // 
            this.dataGridParticipant.AllowUserToAddRows = false;
            this.dataGridParticipant.AllowUserToDeleteRows = false;
            this.dataGridParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridParticipant.AutoGenerateColumns = false;
            this.dataGridParticipant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridParticipant.BackgroundColor = System.Drawing.Color.White;
            this.dataGridParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.ligue,
            this.hebergement});
            this.dataGridParticipant.DataSource = this.bindingSourceParticipant;
            this.dataGridParticipant.Location = new System.Drawing.Point(3, 3);
            this.dataGridParticipant.MultiSelect = false;
            this.dataGridParticipant.Name = "dataGridParticipant";
            this.dataGridParticipant.ReadOnly = true;
            this.dataGridParticipant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParticipant.Size = new System.Drawing.Size(1125, 201);
            this.dataGridParticipant.TabIndex = 0;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(58, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Motant total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(127, 36);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLigue)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxActivites.ResumeLayout(false);
            this.groupBoxActivites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitesDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitesDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitesInscrites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitesInscrites)).EndInit();
            this.groupBoxSessions.ResumeLayout(false);
            this.groupBoxSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionsDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSessionsDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionsInscrites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSessionsInscrites)).EndInit();
            this.tabPageParticipant.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.grpBoutons.ResumeLayout(false);
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHebergement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant)).EndInit();
            this.tabParticipant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceParticipant;
        private System.Windows.Forms.BindingSource bindingSourceLigue;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVilleParticipant;
        private System.Windows.Forms.Label lblAdresseParticipant;
        private System.Windows.Forms.Label lblGenreParticipant;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblPrenomParticipant;
        private System.Windows.Forms.Label lblNomParticipant;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.DataGridView dataGridParticipant;
        private System.Windows.Forms.TabControl tabParticipant;
        private System.Windows.Forms.ComboBox comboBoxLigue;
        private System.Windows.Forms.BindingSource bindingSourceHebergement;
        private System.Windows.Forms.ComboBox comboBoxHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebergement;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCP;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label lblTitreInscriptions;
        private System.Windows.Forms.GroupBox groupBoxActivites;
        private System.Windows.Forms.GroupBox groupBoxSessions;
        private System.Windows.Forms.Label lblSessionsDisponible;
        private System.Windows.Forms.Label lblSessionsParticipation;
        private System.Windows.Forms.Button btnSupprimerSession;
        private System.Windows.Forms.Button btnAjouterSession;
        private System.Windows.Forms.DataGridView dataGridViewSessionsDispo;
        private System.Windows.Forms.DataGridView dataGridViewSessionsInscrites;
        private System.Windows.Forms.BindingSource bindingSourceSessionsDispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceSessionsInscrites;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewActivitesInscrites;
        private System.Windows.Forms.DataGridView dataGridViewActivitesDispo;
        private System.Windows.Forms.Button btnSupprimerActivite;
        private System.Windows.Forms.Button btnAjouterActivite;
        private System.Windows.Forms.BindingSource bindingSourceActivitesDispo;
        private System.Windows.Forms.Label lblActivitesDisponible;
        private System.Windows.Forms.Label lblActivitesParticipation;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bindingSourceActivitesInscrites;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtAcompte;
        private System.Windows.Forms.Label lblAcompte;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}