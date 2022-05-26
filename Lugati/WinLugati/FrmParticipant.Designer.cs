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
            this.bindingSourceInscrire = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceParticiper = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridParticipant2 = new System.Windows.Forms.DataGridView();
            this.idHebergementDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLigueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParticipantDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMontant = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxActivite = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAjouterInscriptionActivite = new System.Windows.Forms.Button();
            this.dataGridViewParticiper = new System.Windows.Forms.DataGridView();
            this.numActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParticipantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIdParticipantA = new System.Windows.Forms.TextBox();
            this.textBoxNumActivite = new System.Windows.Forms.TextBox();
            this.buttonSupprimerActivite = new System.Windows.Forms.Button();
            this.labelNbPlaceActivite = new System.Windows.Forms.Label();
            this.textBoxNbPlaceDispoA = new System.Windows.Forms.TextBox();
            this.groupBoxSession = new System.Windows.Forms.GroupBox();
            this.dataGridViewInscrire = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParticipantDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSupprimerSession = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIdParticipantS = new System.Windows.Forms.TextBox();
            this.textBoxNumSession = new System.Windows.Forms.TextBox();
            this.buttonAjouterInscriptionSession = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNbPlaceDispoS = new System.Windows.Forms.TextBox();
            this.tabPageParticipant = new System.Windows.Forms.TabPage();
            this.dataGridParticipant = new System.Windows.Forms.DataGridView();
            this.idHebergementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParticipantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInfosParticipant = new System.Windows.Forms.GroupBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblNomParticipant = new System.Windows.Forms.Label();
            this.lblPrenomParticipant = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblGenreParticipant = new System.Windows.Forms.Label();
            this.lblAdresseParticipant = new System.Windows.Forms.Label();
            this.lblVilleParticipant = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIdHebergement = new System.Windows.Forms.TextBox();
            this.grpBoutons = new System.Windows.Forms.GroupBox();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            this.btnSupprimerParticipant = new System.Windows.Forms.Button();
            this.btnModifierParticipant = new System.Windows.Forms.Button();
            this.grpBtnsSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerParticipant = new System.Windows.Forms.Button();
            this.tabParticipant = new System.Windows.Forms.TabControl();
            this.comboBoxLigue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLigue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscrire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticiper)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticiper)).BeginInit();
            this.groupBoxSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrire)).BeginInit();
            this.tabPageParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant)).BeginInit();
            this.groupBoxInfosParticipant.SuspendLayout();
            this.grpBoutons.SuspendLayout();
            this.grpBtnsSaveCancel.SuspendLayout();
            this.tabParticipant.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceParticipant
            // 
            this.bindingSourceParticipant.DataSource = typeof(Lugati.dll.Participant);
            // 
            // bindingSourceLigue
            // 
            this.bindingSourceLigue.DataSource = typeof(Lugati.dll.Ligue);
            // 
            // bindingSourceInscrire
            // 
            this.bindingSourceInscrire.DataSource = typeof(Lugati.dll.Inscrire);
            // 
            // bindingSourceParticiper
            // 
            this.bindingSourceParticiper.DataSource = typeof(Lugati.dll.Participer);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxMontant);
            this.tabPage4.Controls.Add(this.labelMontant);
            this.tabPage4.Controls.Add(this.dataGridParticipant2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(746, 480);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Montant";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridParticipant2
            // 
            this.dataGridParticipant2.AutoGenerateColumns = false;
            this.dataGridParticipant2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParticipant2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn3,
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn1,
            this.adresseDataGridViewTextBoxColumn1,
            this.villeDataGridViewTextBoxColumn1,
            this.cpDataGridViewTextBoxColumn1,
            this.idLigueDataGridViewTextBoxColumn1,
            this.idHebergementDataGridViewTextBoxColumn1});
            this.dataGridParticipant2.DataSource = this.bindingSourceParticipant;
            this.dataGridParticipant2.Location = new System.Drawing.Point(6, 6);
            this.dataGridParticipant2.Name = "dataGridParticipant2";
            this.dataGridParticipant2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParticipant2.Size = new System.Drawing.Size(553, 175);
            this.dataGridParticipant2.TabIndex = 0;
            // 
            // idHebergementDataGridViewTextBoxColumn1
            // 
            this.idHebergementDataGridViewTextBoxColumn1.DataPropertyName = "idHebergement";
            this.idHebergementDataGridViewTextBoxColumn1.HeaderText = "idHebergement";
            this.idHebergementDataGridViewTextBoxColumn1.Name = "idHebergementDataGridViewTextBoxColumn1";
            // 
            // idLigueDataGridViewTextBoxColumn1
            // 
            this.idLigueDataGridViewTextBoxColumn1.DataPropertyName = "idLigue";
            this.idLigueDataGridViewTextBoxColumn1.HeaderText = "idLigue";
            this.idLigueDataGridViewTextBoxColumn1.Name = "idLigueDataGridViewTextBoxColumn1";
            // 
            // cpDataGridViewTextBoxColumn1
            // 
            this.cpDataGridViewTextBoxColumn1.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn1.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn1.Name = "cpDataGridViewTextBoxColumn1";
            // 
            // villeDataGridViewTextBoxColumn1
            // 
            this.villeDataGridViewTextBoxColumn1.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn1.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn1.Name = "villeDataGridViewTextBoxColumn1";
            // 
            // adresseDataGridViewTextBoxColumn1
            // 
            this.adresseDataGridViewTextBoxColumn1.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn1.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn1.Name = "adresseDataGridViewTextBoxColumn1";
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            // 
            // prenomDataGridViewTextBoxColumn1
            // 
            this.prenomDataGridViewTextBoxColumn1.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn1.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn1.Name = "prenomDataGridViewTextBoxColumn1";
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            // 
            // idParticipantDataGridViewTextBoxColumn3
            // 
            this.idParticipantDataGridViewTextBoxColumn3.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn3.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn3.Name = "idParticipantDataGridViewTextBoxColumn3";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(96, 228);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(79, 13);
            this.labelMontant.TabIndex = 1;
            this.labelMontant.Text = "Montant Total :";
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(181, 225);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(181, 20);
            this.textBoxMontant.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxSession);
            this.tabPage3.Controls.Add(this.groupBoxActivite);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(746, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inscriptions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxActivite
            // 
            this.groupBoxActivite.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxActivite.Controls.Add(this.textBoxNbPlaceDispoA);
            this.groupBoxActivite.Controls.Add(this.labelNbPlaceActivite);
            this.groupBoxActivite.Controls.Add(this.buttonSupprimerActivite);
            this.groupBoxActivite.Controls.Add(this.textBoxNumActivite);
            this.groupBoxActivite.Controls.Add(this.textBoxIdParticipantA);
            this.groupBoxActivite.Controls.Add(this.dataGridViewParticiper);
            this.groupBoxActivite.Controls.Add(this.buttonAjouterInscriptionActivite);
            this.groupBoxActivite.Controls.Add(this.label11);
            this.groupBoxActivite.Controls.Add(this.label1);
            this.groupBoxActivite.Location = new System.Drawing.Point(6, 6);
            this.groupBoxActivite.Name = "groupBoxActivite";
            this.groupBoxActivite.Size = new System.Drawing.Size(270, 375);
            this.groupBoxActivite.TabIndex = 0;
            this.groupBoxActivite.TabStop = false;
            this.groupBoxActivite.Text = "Inscription Pour Activite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdParticipant :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "NumActivite : ";
            // 
            // buttonAjouterInscriptionActivite
            // 
            this.buttonAjouterInscriptionActivite.Location = new System.Drawing.Point(54, 335);
            this.buttonAjouterInscriptionActivite.Name = "buttonAjouterInscriptionActivite";
            this.buttonAjouterInscriptionActivite.Size = new System.Drawing.Size(162, 26);
            this.buttonAjouterInscriptionActivite.TabIndex = 4;
            this.buttonAjouterInscriptionActivite.Text = "Ajouter";
            this.buttonAjouterInscriptionActivite.UseVisualStyleBackColor = true;
            this.buttonAjouterInscriptionActivite.Click += new System.EventHandler(this.buttonAjouterInscriptionActivite_Click);
            // 
            // dataGridViewParticiper
            // 
            this.dataGridViewParticiper.AutoGenerateColumns = false;
            this.dataGridViewParticiper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticiper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn1,
            this.numActiviteDataGridViewTextBoxColumn});
            this.dataGridViewParticiper.DataSource = this.bindingSourceParticiper;
            this.dataGridViewParticiper.Location = new System.Drawing.Point(6, 68);
            this.dataGridViewParticiper.MultiSelect = false;
            this.dataGridViewParticiper.Name = "dataGridViewParticiper";
            this.dataGridViewParticiper.ReadOnly = true;
            this.dataGridViewParticiper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticiper.Size = new System.Drawing.Size(258, 150);
            this.dataGridViewParticiper.TabIndex = 7;
            // 
            // numActiviteDataGridViewTextBoxColumn
            // 
            this.numActiviteDataGridViewTextBoxColumn.DataPropertyName = "numActivite";
            this.numActiviteDataGridViewTextBoxColumn.HeaderText = "numActivite";
            this.numActiviteDataGridViewTextBoxColumn.Name = "numActiviteDataGridViewTextBoxColumn";
            this.numActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idParticipantDataGridViewTextBoxColumn1
            // 
            this.idParticipantDataGridViewTextBoxColumn1.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn1.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn1.Name = "idParticipantDataGridViewTextBoxColumn1";
            this.idParticipantDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // textBoxIdParticipantA
            // 
            this.textBoxIdParticipantA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticiper, "idParticipant", true));
            this.textBoxIdParticipantA.Location = new System.Drawing.Point(98, 263);
            this.textBoxIdParticipantA.Name = "textBoxIdParticipantA";
            this.textBoxIdParticipantA.Size = new System.Drawing.Size(118, 20);
            this.textBoxIdParticipantA.TabIndex = 8;
            // 
            // textBoxNumActivite
            // 
            this.textBoxNumActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticiper, "numActivite", true));
            this.textBoxNumActivite.Location = new System.Drawing.Point(99, 306);
            this.textBoxNumActivite.Name = "textBoxNumActivite";
            this.textBoxNumActivite.Size = new System.Drawing.Size(117, 20);
            this.textBoxNumActivite.TabIndex = 9;
            // 
            // buttonSupprimerActivite
            // 
            this.buttonSupprimerActivite.Location = new System.Drawing.Point(54, 224);
            this.buttonSupprimerActivite.Name = "buttonSupprimerActivite";
            this.buttonSupprimerActivite.Size = new System.Drawing.Size(162, 23);
            this.buttonSupprimerActivite.TabIndex = 10;
            this.buttonSupprimerActivite.Text = "Supprimer";
            this.buttonSupprimerActivite.UseVisualStyleBackColor = true;
            this.buttonSupprimerActivite.Click += new System.EventHandler(this.buttonSupprimerActivite_Click);
            // 
            // labelNbPlaceActivite
            // 
            this.labelNbPlaceActivite.AutoSize = true;
            this.labelNbPlaceActivite.Location = new System.Drawing.Point(19, 33);
            this.labelNbPlaceActivite.Name = "labelNbPlaceActivite";
            this.labelNbPlaceActivite.Size = new System.Drawing.Size(81, 13);
            this.labelNbPlaceActivite.TabIndex = 11;
            this.labelNbPlaceActivite.Text = "NbPlaceDispo :";
            // 
            // textBoxNbPlaceDispoA
            // 
            this.textBoxNbPlaceDispoA.Location = new System.Drawing.Point(106, 30);
            this.textBoxNbPlaceDispoA.Name = "textBoxNbPlaceDispoA";
            this.textBoxNbPlaceDispoA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbPlaceDispoA.TabIndex = 12;
            // 
            // groupBoxSession
            // 
            this.groupBoxSession.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSession.Controls.Add(this.textBoxNbPlaceDispoS);
            this.groupBoxSession.Controls.Add(this.label14);
            this.groupBoxSession.Controls.Add(this.buttonAjouterInscriptionSession);
            this.groupBoxSession.Controls.Add(this.textBoxNumSession);
            this.groupBoxSession.Controls.Add(this.textBoxIdParticipantS);
            this.groupBoxSession.Controls.Add(this.label13);
            this.groupBoxSession.Controls.Add(this.label12);
            this.groupBoxSession.Controls.Add(this.buttonSupprimerSession);
            this.groupBoxSession.Controls.Add(this.dataGridViewInscrire);
            this.groupBoxSession.Location = new System.Drawing.Point(283, 6);
            this.groupBoxSession.Name = "groupBoxSession";
            this.groupBoxSession.Size = new System.Drawing.Size(276, 375);
            this.groupBoxSession.TabIndex = 1;
            this.groupBoxSession.TabStop = false;
            this.groupBoxSession.Text = "Inscription Pour Session";
            // 
            // dataGridViewInscrire
            // 
            this.dataGridViewInscrire.AutoGenerateColumns = false;
            this.dataGridViewInscrire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscrire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn2,
            this.numSessionDataGridViewTextBoxColumn});
            this.dataGridViewInscrire.DataSource = this.bindingSourceInscrire;
            this.dataGridViewInscrire.Location = new System.Drawing.Point(7, 68);
            this.dataGridViewInscrire.MultiSelect = false;
            this.dataGridViewInscrire.Name = "dataGridViewInscrire";
            this.dataGridViewInscrire.ReadOnly = true;
            this.dataGridViewInscrire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInscrire.Size = new System.Drawing.Size(263, 150);
            this.dataGridViewInscrire.TabIndex = 0;
            // 
            // numSessionDataGridViewTextBoxColumn
            // 
            this.numSessionDataGridViewTextBoxColumn.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn.HeaderText = "numSession";
            this.numSessionDataGridViewTextBoxColumn.Name = "numSessionDataGridViewTextBoxColumn";
            this.numSessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idParticipantDataGridViewTextBoxColumn2
            // 
            this.idParticipantDataGridViewTextBoxColumn2.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn2.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn2.Name = "idParticipantDataGridViewTextBoxColumn2";
            this.idParticipantDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonSupprimerSession
            // 
            this.buttonSupprimerSession.Location = new System.Drawing.Point(56, 224);
            this.buttonSupprimerSession.Name = "buttonSupprimerSession";
            this.buttonSupprimerSession.Size = new System.Drawing.Size(160, 23);
            this.buttonSupprimerSession.TabIndex = 1;
            this.buttonSupprimerSession.Text = "Supprimer";
            this.buttonSupprimerSession.UseVisualStyleBackColor = true;
            this.buttonSupprimerSession.Click += new System.EventHandler(this.buttonSupprimerSession_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "idParticipant :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "NumSession : ";
            // 
            // textBoxIdParticipantS
            // 
            this.textBoxIdParticipantS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceInscrire, "idParticipant", true));
            this.textBoxIdParticipantS.Location = new System.Drawing.Point(95, 263);
            this.textBoxIdParticipantS.Name = "textBoxIdParticipantS";
            this.textBoxIdParticipantS.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdParticipantS.TabIndex = 4;
            // 
            // textBoxNumSession
            // 
            this.textBoxNumSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceInscrire, "numSession", true));
            this.textBoxNumSession.Location = new System.Drawing.Point(101, 310);
            this.textBoxNumSession.Name = "textBoxNumSession";
            this.textBoxNumSession.Size = new System.Drawing.Size(114, 20);
            this.textBoxNumSession.TabIndex = 5;
            // 
            // buttonAjouterInscriptionSession
            // 
            this.buttonAjouterInscriptionSession.Location = new System.Drawing.Point(56, 335);
            this.buttonAjouterInscriptionSession.Name = "buttonAjouterInscriptionSession";
            this.buttonAjouterInscriptionSession.Size = new System.Drawing.Size(160, 23);
            this.buttonAjouterInscriptionSession.TabIndex = 6;
            this.buttonAjouterInscriptionSession.Text = "Ajouter";
            this.buttonAjouterInscriptionSession.UseVisualStyleBackColor = true;
            this.buttonAjouterInscriptionSession.Click += new System.EventHandler(this.buttonAjouterInscriptionSession_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "NbPlaceDispo :";
            // 
            // textBoxNbPlaceDispoS
            // 
            this.textBoxNbPlaceDispoS.Location = new System.Drawing.Point(115, 30);
            this.textBoxNbPlaceDispoS.Name = "textBoxNbPlaceDispoS";
            this.textBoxNbPlaceDispoS.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbPlaceDispoS.TabIndex = 14;
            // 
            // tabPageParticipant
            // 
            this.tabPageParticipant.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageParticipant.Controls.Add(this.grpBtnsSaveCancel);
            this.tabPageParticipant.Controls.Add(this.grpBoutons);
            this.tabPageParticipant.Controls.Add(this.groupBoxInfosParticipant);
            this.tabPageParticipant.Controls.Add(this.dataGridParticipant);
            this.tabPageParticipant.Location = new System.Drawing.Point(4, 22);
            this.tabPageParticipant.Name = "tabPageParticipant";
            this.tabPageParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParticipant.Size = new System.Drawing.Size(746, 480);
            this.tabPageParticipant.TabIndex = 0;
            this.tabPageParticipant.Text = "Participants";
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
            this.idLigueDataGridViewTextBoxColumn,
            this.idHebergementDataGridViewTextBoxColumn});
            this.dataGridParticipant.DataSource = this.bindingSourceParticipant;
            this.dataGridParticipant.Location = new System.Drawing.Point(3, 3);
            this.dataGridParticipant.MultiSelect = false;
            this.dataGridParticipant.Name = "dataGridParticipant";
            this.dataGridParticipant.ReadOnly = true;
            this.dataGridParticipant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParticipant.Size = new System.Drawing.Size(740, 201);
            this.dataGridParticipant.TabIndex = 0;
            // 
            // idHebergementDataGridViewTextBoxColumn
            // 
            this.idHebergementDataGridViewTextBoxColumn.DataPropertyName = "idHebergement";
            this.idHebergementDataGridViewTextBoxColumn.HeaderText = "idHebergement";
            this.idHebergementDataGridViewTextBoxColumn.Name = "idHebergementDataGridViewTextBoxColumn";
            this.idHebergementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHebergementDataGridViewTextBoxColumn.Width = 104;
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            this.idLigueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLigueDataGridViewTextBoxColumn.Width = 66;
            // 
            // ligue
            // 
            this.ligue.DataPropertyName = "ligue";
            this.ligue.DataSource = this.bindingSourceLigue;
            this.ligue.HeaderText = "ligue";
            this.ligue.Name = "ligue";
            this.ligue.ReadOnly = true;
            this.ligue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ligue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ligue.Width = 54;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 44;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 50;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 69;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 59;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 67;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 52;
            // 
            // idParticipantDataGridViewTextBoxColumn
            // 
            this.idParticipantDataGridViewTextBoxColumn.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn.Name = "idParticipantDataGridViewTextBoxColumn";
            this.idParticipantDataGridViewTextBoxColumn.ReadOnly = true;
            this.idParticipantDataGridViewTextBoxColumn.Width = 90;
            // 
            // groupBoxInfosParticipant
            // 
            this.groupBoxInfosParticipant.Controls.Add(this.comboBoxLigue);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxIdHebergement);
            this.groupBoxInfosParticipant.Controls.Add(this.label10);
            this.groupBoxInfosParticipant.Controls.Add(this.label9);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxGenre);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxCp);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxVille);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxAdresse);
            this.groupBoxInfosParticipant.Controls.Add(this.label8);
            this.groupBoxInfosParticipant.Controls.Add(this.lblVilleParticipant);
            this.groupBoxInfosParticipant.Controls.Add(this.lblAdresseParticipant);
            this.groupBoxInfosParticipant.Controls.Add(this.lblGenreParticipant);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxPrenom);
            this.groupBoxInfosParticipant.Controls.Add(this.lblPrenomParticipant);
            this.groupBoxInfosParticipant.Controls.Add(this.lblNomParticipant);
            this.groupBoxInfosParticipant.Controls.Add(this.textBoxNom);
            this.groupBoxInfosParticipant.Enabled = false;
            this.groupBoxInfosParticipant.Location = new System.Drawing.Point(3, 210);
            this.groupBoxInfosParticipant.Name = "groupBoxInfosParticipant";
            this.groupBoxInfosParticipant.Size = new System.Drawing.Size(543, 267);
            this.groupBoxInfosParticipant.TabIndex = 2;
            this.groupBoxInfosParticipant.TabStop = false;
            this.groupBoxInfosParticipant.Text = "Informations";
            // 
            // textBoxNom
            // 
            this.textBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "nom", true));
            this.textBoxNom.Location = new System.Drawing.Point(81, 50);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(157, 20);
            this.textBoxNom.TabIndex = 21;
            // 
            // lblNomParticipant
            // 
            this.lblNomParticipant.AutoSize = true;
            this.lblNomParticipant.Location = new System.Drawing.Point(46, 53);
            this.lblNomParticipant.Name = "lblNomParticipant";
            this.lblNomParticipant.Size = new System.Drawing.Size(29, 13);
            this.lblNomParticipant.TabIndex = 22;
            this.lblNomParticipant.Text = "Nom";
            // 
            // lblPrenomParticipant
            // 
            this.lblPrenomParticipant.AutoSize = true;
            this.lblPrenomParticipant.Location = new System.Drawing.Point(32, 90);
            this.lblPrenomParticipant.Name = "lblPrenomParticipant";
            this.lblPrenomParticipant.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomParticipant.TabIndex = 23;
            this.lblPrenomParticipant.Text = "Prenom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "prenom", true));
            this.textBoxPrenom.Location = new System.Drawing.Point(81, 87);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(157, 20);
            this.textBoxPrenom.TabIndex = 24;
            // 
            // lblGenreParticipant
            // 
            this.lblGenreParticipant.AutoSize = true;
            this.lblGenreParticipant.Location = new System.Drawing.Point(39, 127);
            this.lblGenreParticipant.Name = "lblGenreParticipant";
            this.lblGenreParticipant.Size = new System.Drawing.Size(36, 13);
            this.lblGenreParticipant.TabIndex = 25;
            this.lblGenreParticipant.Text = "Genre";
            // 
            // lblAdresseParticipant
            // 
            this.lblAdresseParticipant.AutoSize = true;
            this.lblAdresseParticipant.Location = new System.Drawing.Point(289, 53);
            this.lblAdresseParticipant.Name = "lblAdresseParticipant";
            this.lblAdresseParticipant.Size = new System.Drawing.Size(45, 13);
            this.lblAdresseParticipant.TabIndex = 26;
            this.lblAdresseParticipant.Text = "Adresse";
            // 
            // lblVilleParticipant
            // 
            this.lblVilleParticipant.AutoSize = true;
            this.lblVilleParticipant.Location = new System.Drawing.Point(308, 90);
            this.lblVilleParticipant.Name = "lblVilleParticipant";
            this.lblVilleParticipant.Size = new System.Drawing.Size(26, 13);
            this.lblVilleParticipant.TabIndex = 27;
            this.lblVilleParticipant.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Code Postal";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "adresse", true));
            this.textBoxAdresse.Location = new System.Drawing.Point(340, 50);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(157, 20);
            this.textBoxAdresse.TabIndex = 29;
            // 
            // textBoxVille
            // 
            this.textBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "ville", true));
            this.textBoxVille.Location = new System.Drawing.Point(340, 87);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(157, 20);
            this.textBoxVille.TabIndex = 30;
            // 
            // textBoxCp
            // 
            this.textBoxCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "cp", true));
            this.textBoxCp.Location = new System.Drawing.Point(340, 124);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(157, 20);
            this.textBoxCp.TabIndex = 31;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "genre", true));
            this.textBoxGenre.Location = new System.Drawing.Point(81, 124);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(157, 20);
            this.textBoxGenre.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ligue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Hebergement";
            // 
            // textBoxIdHebergement
            // 
            this.textBoxIdHebergement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "idHebergement", true));
            this.textBoxIdHebergement.Location = new System.Drawing.Point(194, 213);
            this.textBoxIdHebergement.Name = "textBoxIdHebergement";
            this.textBoxIdHebergement.Size = new System.Drawing.Size(211, 20);
            this.textBoxIdHebergement.TabIndex = 36;
            // 
            // grpBoutons
            // 
            this.grpBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoutons.Controls.Add(this.btnModifierParticipant);
            this.grpBoutons.Controls.Add(this.btnSupprimerParticipant);
            this.grpBoutons.Controls.Add(this.btnAjouterParticipant);
            this.grpBoutons.ForeColor = System.Drawing.Color.White;
            this.grpBoutons.Location = new System.Drawing.Point(617, 210);
            this.grpBoutons.Name = "grpBoutons";
            this.grpBoutons.Size = new System.Drawing.Size(126, 139);
            this.grpBoutons.TabIndex = 9;
            this.grpBoutons.TabStop = false;
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
            // 
            // grpBtnsSaveCancel
            // 
            this.grpBtnsSaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBtnsSaveCancel.Controls.Add(this.btnEnregistrerParticipant);
            this.grpBtnsSaveCancel.Controls.Add(this.btnAnnuler);
            this.grpBtnsSaveCancel.Location = new System.Drawing.Point(617, 382);
            this.grpBtnsSaveCancel.Name = "grpBtnsSaveCancel";
            this.grpBtnsSaveCancel.Size = new System.Drawing.Size(126, 95);
            this.grpBtnsSaveCancel.TabIndex = 13;
            this.grpBtnsSaveCancel.TabStop = false;
            this.grpBtnsSaveCancel.Visible = false;
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
            this.tabParticipant.Size = new System.Drawing.Size(754, 506);
            this.tabParticipant.TabIndex = 0;
            // 
            // comboBoxLigue
            // 
            this.comboBoxLigue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceParticipant, "ligue", true));
            this.comboBoxLigue.DataSource = this.bindingSourceLigue;
            this.comboBoxLigue.DisplayMember = "nomLigue";
            this.comboBoxLigue.FormattingEnabled = true;
            this.comboBoxLigue.Location = new System.Drawing.Point(194, 172);
            this.comboBoxLigue.Name = "comboBoxLigue";
            this.comboBoxLigue.Size = new System.Drawing.Size(211, 21);
            this.comboBoxLigue.TabIndex = 37;
            // 
            // FrmParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 530);
            this.Controls.Add(this.tabParticipant);
            this.Name = "FrmParticipant";
            this.Text = "Participants";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLigue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscrire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticiper)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxActivite.ResumeLayout(false);
            this.groupBoxActivite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticiper)).EndInit();
            this.groupBoxSession.ResumeLayout(false);
            this.groupBoxSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrire)).EndInit();
            this.tabPageParticipant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant)).EndInit();
            this.groupBoxInfosParticipant.ResumeLayout(false);
            this.groupBoxInfosParticipant.PerformLayout();
            this.grpBoutons.ResumeLayout(false);
            this.grpBtnsSaveCancel.ResumeLayout(false);
            this.tabParticipant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceParticipant;
        private System.Windows.Forms.BindingSource bindingSourceParticiper;
        private System.Windows.Forms.BindingSource bindingSourceInscrire;
        private System.Windows.Forms.BindingSource bindingSourceLigue;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.DataGridView dataGridParticipant2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergementDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxSession;
        private System.Windows.Forms.TextBox textBoxNbPlaceDispoS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonAjouterInscriptionSession;
        private System.Windows.Forms.TextBox textBoxNumSession;
        private System.Windows.Forms.TextBox textBoxIdParticipantS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSupprimerSession;
        private System.Windows.Forms.DataGridView dataGridViewInscrire;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxActivite;
        private System.Windows.Forms.TextBox textBoxNbPlaceDispoA;
        private System.Windows.Forms.Label labelNbPlaceActivite;
        private System.Windows.Forms.Button buttonSupprimerActivite;
        private System.Windows.Forms.TextBox textBoxNumActivite;
        private System.Windows.Forms.TextBox textBoxIdParticipantA;
        private System.Windows.Forms.DataGridView dataGridViewParticiper;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAjouterInscriptionActivite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageParticipant;
        private System.Windows.Forms.GroupBox grpBtnsSaveCancel;
        private System.Windows.Forms.Button btnEnregistrerParticipant;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grpBoutons;
        private System.Windows.Forms.Button btnModifierParticipant;
        private System.Windows.Forms.Button btnSupprimerParticipant;
        private System.Windows.Forms.Button btnAjouterParticipant;
        private System.Windows.Forms.GroupBox groupBoxInfosParticipant;
        private System.Windows.Forms.TextBox textBoxIdHebergement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxCp;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabParticipant;
        private System.Windows.Forms.ComboBox comboBoxLigue;
    }
}