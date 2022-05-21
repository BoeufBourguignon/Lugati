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
            this.tabParticipant = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSupprimerPart = new System.Windows.Forms.Button();
            this.dataGridParticipant = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.btnAnnulerParticipant = new System.Windows.Forms.Button();
            this.btnValiderParticipant = new System.Windows.Forms.Button();
            this.textBoxIdHebergement = new System.Windows.Forms.TextBox();
            this.textBoxIdLigue = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBoxActivite = new System.Windows.Forms.GroupBox();
            this.groupBoxSession = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAjouterInscriptionActivite = new System.Windows.Forms.Button();
            this.dataGridViewParticiper = new System.Windows.Forms.DataGridView();
            this.textBoxIdParticipantA = new System.Windows.Forms.TextBox();
            this.textBoxNumActivite = new System.Windows.Forms.TextBox();
            this.buttonSupprimerActivite = new System.Windows.Forms.Button();
            this.idParticipantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHebergementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceParticipant = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceParticiper = new System.Windows.Forms.BindingSource(this.components);
            this.idParticipantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewInscrire = new System.Windows.Forms.DataGridView();
            this.bindingSourceInscrire = new System.Windows.Forms.BindingSource(this.components);
            this.idParticipantDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSupprimerSession = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIdParticipantS = new System.Windows.Forms.TextBox();
            this.textBoxNumSession = new System.Windows.Forms.TextBox();
            this.buttonAjouterInscriptionSession = new System.Windows.Forms.Button();
            this.tabParticipant.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxActivite.SuspendLayout();
            this.groupBoxSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticiper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticiper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscrire)).BeginInit();
            this.SuspendLayout();
            // 
            // tabParticipant
            // 
            this.tabParticipant.Controls.Add(this.tabPage1);
            this.tabParticipant.Controls.Add(this.tabPage2);
            this.tabParticipant.Controls.Add(this.tabPage3);
            this.tabParticipant.Controls.Add(this.tabPage4);
            this.tabParticipant.Location = new System.Drawing.Point(12, 12);
            this.tabParticipant.Name = "tabParticipant";
            this.tabParticipant.SelectedIndex = 0;
            this.tabParticipant.Size = new System.Drawing.Size(573, 413);
            this.tabParticipant.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Participant Existant";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnSupprimerPart);
            this.groupBox1.Controls.Add(this.dataGridParticipant);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Participants :";
            // 
            // btnSupprimerPart
            // 
            this.btnSupprimerPart.Location = new System.Drawing.Point(168, 242);
            this.btnSupprimerPart.Name = "btnSupprimerPart";
            this.btnSupprimerPart.Size = new System.Drawing.Size(195, 32);
            this.btnSupprimerPart.TabIndex = 1;
            this.btnSupprimerPart.Text = "Supprimer un Participant";
            this.btnSupprimerPart.UseVisualStyleBackColor = true;
            this.btnSupprimerPart.Click += new System.EventHandler(this.btnSupprimerPart_Click);
            // 
            // dataGridParticipant
            // 
            this.dataGridParticipant.AutoGenerateColumns = false;
            this.dataGridParticipant.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.idLigueDataGridViewTextBoxColumn,
            this.idHebergementDataGridViewTextBoxColumn});
            this.dataGridParticipant.DataSource = this.bindingSourceParticipant;
            this.dataGridParticipant.Location = new System.Drawing.Point(3, 19);
            this.dataGridParticipant.MultiSelect = false;
            this.dataGridParticipant.Name = "dataGridParticipant";
            this.dataGridParticipant.ReadOnly = true;
            this.dataGridParticipant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParticipant.Size = new System.Drawing.Size(541, 168);
            this.dataGridParticipant.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAjouterParticipant);
            this.tabPage2.Controls.Add(this.textBoxGenre);
            this.tabPage2.Controls.Add(this.btnAnnulerParticipant);
            this.tabPage2.Controls.Add(this.btnValiderParticipant);
            this.tabPage2.Controls.Add(this.textBoxIdHebergement);
            this.tabPage2.Controls.Add(this.textBoxIdLigue);
            this.tabPage2.Controls.Add(this.textBoxCp);
            this.tabPage2.Controls.Add(this.textBoxVille);
            this.tabPage2.Controls.Add(this.textBoxAdresse);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxPrenom);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxNom);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(565, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participant Ajouter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAjouterParticipant
            // 
            this.btnAjouterParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAjouterParticipant.Location = new System.Drawing.Point(306, 219);
            this.btnAjouterParticipant.Name = "btnAjouterParticipant";
            this.btnAjouterParticipant.Size = new System.Drawing.Size(100, 46);
            this.btnAjouterParticipant.TabIndex = 21;
            this.btnAjouterParticipant.Text = "Ajouter";
            this.btnAjouterParticipant.UseVisualStyleBackColor = false;
            this.btnAjouterParticipant.Click += new System.EventHandler(this.btnAjouterParticipant_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "genre", true));
            this.textBoxGenre.Location = new System.Drawing.Point(71, 143);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(161, 20);
            this.textBoxGenre.TabIndex = 20;
            // 
            // btnAnnulerParticipant
            // 
            this.btnAnnulerParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnulerParticipant.Location = new System.Drawing.Point(306, 278);
            this.btnAnnulerParticipant.Name = "btnAnnulerParticipant";
            this.btnAnnulerParticipant.Size = new System.Drawing.Size(100, 54);
            this.btnAnnulerParticipant.TabIndex = 19;
            this.btnAnnulerParticipant.Text = "Annuler";
            this.btnAnnulerParticipant.UseVisualStyleBackColor = false;
            this.btnAnnulerParticipant.Click += new System.EventHandler(this.btnAnnulerParticipant_Click);
            // 
            // btnValiderParticipant
            // 
            this.btnValiderParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnValiderParticipant.Location = new System.Drawing.Point(306, 156);
            this.btnValiderParticipant.Name = "btnValiderParticipant";
            this.btnValiderParticipant.Size = new System.Drawing.Size(100, 54);
            this.btnValiderParticipant.TabIndex = 18;
            this.btnValiderParticipant.Text = "Enregistrer Modif";
            this.btnValiderParticipant.UseVisualStyleBackColor = false;
            this.btnValiderParticipant.Click += new System.EventHandler(this.btnValiderParticipant_Click);
            // 
            // textBoxIdHebergement
            // 
            this.textBoxIdHebergement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "idHebergement", true));
            this.textBoxIdHebergement.Location = new System.Drawing.Point(402, 101);
            this.textBoxIdHebergement.Name = "textBoxIdHebergement";
            this.textBoxIdHebergement.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdHebergement.TabIndex = 17;
            // 
            // textBoxIdLigue
            // 
            this.textBoxIdLigue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "idLigue", true));
            this.textBoxIdLigue.Location = new System.Drawing.Point(371, 60);
            this.textBoxIdLigue.Name = "textBoxIdLigue";
            this.textBoxIdLigue.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdLigue.TabIndex = 16;
            // 
            // textBoxCp
            // 
            this.textBoxCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "cp", true));
            this.textBoxCp.Location = new System.Drawing.Point(106, 278);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(126, 20);
            this.textBoxCp.TabIndex = 15;
            // 
            // textBoxVille
            // 
            this.textBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "ville", true));
            this.textBoxVille.Location = new System.Drawing.Point(65, 230);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(167, 20);
            this.textBoxVille.TabIndex = 14;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "adresse", true));
            this.textBoxAdresse.Location = new System.Drawing.Point(81, 190);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(151, 20);
            this.textBoxAdresse.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "idHebergement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "IdLigue :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Code Postal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genre :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "prenom", true));
            this.textBoxPrenom.Location = new System.Drawing.Point(75, 98);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(157, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticipant, "nom", true));
            this.textBoxNom.Location = new System.Drawing.Point(69, 61);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(163, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saisir les Informations du nouveau Participant :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxSession);
            this.tabPage3.Controls.Add(this.groupBoxActivite);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(565, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inscriptions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(565, 387);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Montant";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBoxActivite
            // 
            this.groupBoxActivite.BackColor = System.Drawing.Color.LightGray;
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
            // groupBoxSession
            // 
            this.groupBoxSession.BackColor = System.Drawing.Color.LightGray;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdParticipant :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 278);
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
            this.dataGridViewParticiper.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewParticiper.MultiSelect = false;
            this.dataGridViewParticiper.Name = "dataGridViewParticiper";
            this.dataGridViewParticiper.ReadOnly = true;
            this.dataGridViewParticiper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticiper.Size = new System.Drawing.Size(258, 150);
            this.dataGridViewParticiper.TabIndex = 7;
            // 
            // textBoxIdParticipantA
            // 
            this.textBoxIdParticipantA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticiper, "idParticipant", true));
            this.textBoxIdParticipantA.Location = new System.Drawing.Point(98, 235);
            this.textBoxIdParticipantA.Name = "textBoxIdParticipantA";
            this.textBoxIdParticipantA.Size = new System.Drawing.Size(118, 20);
            this.textBoxIdParticipantA.TabIndex = 8;
            // 
            // textBoxNumActivite
            // 
            this.textBoxNumActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParticiper, "numActivite", true));
            this.textBoxNumActivite.Location = new System.Drawing.Point(99, 278);
            this.textBoxNumActivite.Name = "textBoxNumActivite";
            this.textBoxNumActivite.Size = new System.Drawing.Size(117, 20);
            this.textBoxNumActivite.TabIndex = 9;
            // 
            // buttonSupprimerActivite
            // 
            this.buttonSupprimerActivite.Location = new System.Drawing.Point(54, 188);
            this.buttonSupprimerActivite.Name = "buttonSupprimerActivite";
            this.buttonSupprimerActivite.Size = new System.Drawing.Size(162, 23);
            this.buttonSupprimerActivite.TabIndex = 10;
            this.buttonSupprimerActivite.Text = "Supprimer";
            this.buttonSupprimerActivite.UseVisualStyleBackColor = true;
            this.buttonSupprimerActivite.Click += new System.EventHandler(this.buttonSupprimerActivite_Click);
            // 
            // idParticipantDataGridViewTextBoxColumn
            // 
            this.idParticipantDataGridViewTextBoxColumn.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn.Name = "idParticipantDataGridViewTextBoxColumn";
            this.idParticipantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            this.idLigueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idHebergementDataGridViewTextBoxColumn
            // 
            this.idHebergementDataGridViewTextBoxColumn.DataPropertyName = "idHebergement";
            this.idHebergementDataGridViewTextBoxColumn.HeaderText = "idHebergement";
            this.idHebergementDataGridViewTextBoxColumn.Name = "idHebergementDataGridViewTextBoxColumn";
            this.idHebergementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceParticipant
            // 
            this.bindingSourceParticipant.DataSource = typeof(Lugati.dll.Participant);
            // 
            // bindingSourceParticiper
            // 
            this.bindingSourceParticiper.DataSource = typeof(Lugati.dll.Participer);
            // 
            // idParticipantDataGridViewTextBoxColumn1
            // 
            this.idParticipantDataGridViewTextBoxColumn1.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn1.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn1.Name = "idParticipantDataGridViewTextBoxColumn1";
            this.idParticipantDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numActiviteDataGridViewTextBoxColumn
            // 
            this.numActiviteDataGridViewTextBoxColumn.DataPropertyName = "numActivite";
            this.numActiviteDataGridViewTextBoxColumn.HeaderText = "numActivite";
            this.numActiviteDataGridViewTextBoxColumn.Name = "numActiviteDataGridViewTextBoxColumn";
            this.numActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewInscrire
            // 
            this.dataGridViewInscrire.AutoGenerateColumns = false;
            this.dataGridViewInscrire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscrire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantDataGridViewTextBoxColumn2,
            this.numSessionDataGridViewTextBoxColumn});
            this.dataGridViewInscrire.DataSource = this.bindingSourceInscrire;
            this.dataGridViewInscrire.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewInscrire.MultiSelect = false;
            this.dataGridViewInscrire.Name = "dataGridViewInscrire";
            this.dataGridViewInscrire.ReadOnly = true;
            this.dataGridViewInscrire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInscrire.Size = new System.Drawing.Size(263, 150);
            this.dataGridViewInscrire.TabIndex = 0;
            // 
            // bindingSourceInscrire
            // 
            this.bindingSourceInscrire.DataSource = typeof(Lugati.dll.Inscrire);
            // 
            // idParticipantDataGridViewTextBoxColumn2
            // 
            this.idParticipantDataGridViewTextBoxColumn2.DataPropertyName = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn2.HeaderText = "idParticipant";
            this.idParticipantDataGridViewTextBoxColumn2.Name = "idParticipantDataGridViewTextBoxColumn2";
            this.idParticipantDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numSessionDataGridViewTextBoxColumn
            // 
            this.numSessionDataGridViewTextBoxColumn.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn.HeaderText = "numSession";
            this.numSessionDataGridViewTextBoxColumn.Name = "numSessionDataGridViewTextBoxColumn";
            this.numSessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonSupprimerSession
            // 
            this.buttonSupprimerSession.Location = new System.Drawing.Point(56, 187);
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
            this.label12.Location = new System.Drawing.Point(17, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "idParticipant :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "NumSession : ";
            // 
            // textBoxIdParticipantS
            // 
            this.textBoxIdParticipantS.Location = new System.Drawing.Point(95, 234);
            this.textBoxIdParticipantS.Name = "textBoxIdParticipantS";
            this.textBoxIdParticipantS.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdParticipantS.TabIndex = 4;
            // 
            // textBoxNumSession
            // 
            this.textBoxNumSession.Location = new System.Drawing.Point(101, 281);
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
            // 
            // FrmParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.tabParticipant);
            this.Name = "FrmParticipant";
            this.Text = "FrmParticipant";
            this.Load += new System.EventHandler(this.FrmParticipant_Load);
            this.tabParticipant.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipant)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxActivite.ResumeLayout(false);
            this.groupBoxActivite.PerformLayout();
            this.groupBoxSession.ResumeLayout(false);
            this.groupBoxSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticiper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticiper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscrire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabParticipant;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridParticipant;
        private System.Windows.Forms.TextBox textBoxIdHebergement;
        private System.Windows.Forms.TextBox textBoxIdLigue;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSourceParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergementDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnValiderParticipant;
        private System.Windows.Forms.Button btnAnnulerParticipant;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button btnAjouterParticipant;
        private System.Windows.Forms.Button btnSupprimerPart;
        private System.Windows.Forms.GroupBox groupBoxSession;
        private System.Windows.Forms.GroupBox groupBoxActivite;
        private System.Windows.Forms.Button buttonAjouterInscriptionActivite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceParticiper;
        private System.Windows.Forms.DataGridView dataGridViewParticiper;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSupprimerActivite;
        private System.Windows.Forms.TextBox textBoxNumActivite;
        private System.Windows.Forms.TextBox textBoxIdParticipantA;
        private System.Windows.Forms.Button buttonAjouterInscriptionSession;
        private System.Windows.Forms.TextBox textBoxNumSession;
        private System.Windows.Forms.TextBox textBoxIdParticipantS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSupprimerSession;
        private System.Windows.Forms.DataGridView dataGridViewInscrire;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceInscrire;
    }
}