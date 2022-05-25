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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSession = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerSession = new System.Windows.Forms.Button();
            this.grpAjouterSupprimer = new System.Windows.Forms.GroupBox();
            this.btnSupprimerSession = new System.Windows.Forms.Button();
            this.btnAjouterSession = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.labelLibelleSession = new System.Windows.Forms.Label();
            this.textBoxLibelleSession = new System.Windows.Forms.TextBox();
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.textBoxDateSession = new System.Windows.Forms.TextBox();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.textBoxNbPlaceSession = new System.Windows.Forms.TextBox();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.textBoxHeureSession = new System.Windows.Forms.TextBox();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.textBoxTarifSession = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSession)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpAjouterSupprimer.SuspendLayout();
            this.grpInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.dataGridSession);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Sessions :";
            // 
            // dataGridSession
            // 
            this.dataGridSession.AllowUserToAddRows = false;
            this.dataGridSession.AllowUserToDeleteRows = false;
            this.dataGridSession.AutoGenerateColumns = false;
            this.dataGridSession.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.nbPlacesDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn});
            this.dataGridSession.DataSource = this.bindingSourceSession;
            this.dataGridSession.Location = new System.Drawing.Point(6, 19);
            this.dataGridSession.MultiSelect = false;
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSession.Size = new System.Drawing.Size(772, 194);
            this.dataGridSession.TabIndex = 0;
            // 
            // numSessionDataGridViewTextBoxColumn
            // 
            this.numSessionDataGridViewTextBoxColumn.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn.HeaderText = "numSession";
            this.numSessionDataGridViewTextBoxColumn.Name = "numSessionDataGridViewTextBoxColumn";
            this.numSessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            this.tarifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbPlacesDataGridViewTextBoxColumn
            // 
            this.nbPlacesDataGridViewTextBoxColumn.DataPropertyName = "nbPlaces";
            this.nbPlacesDataGridViewTextBoxColumn.HeaderText = "nbPlaces";
            this.nbPlacesDataGridViewTextBoxColumn.Name = "nbPlacesDataGridViewTextBoxColumn";
            this.nbPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            this.heureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceSession
            // 
            this.bindingSourceSession.AllowNew = true;
            this.bindingSourceSession.DataSource = typeof(Lugati.dll.Session);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Coral;
            this.groupBox2.Controls.Add(this.btnAnnuler);
            this.groupBox2.Controls.Add(this.btnEnregistrerSession);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(603, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 119);
            this.groupBox2.TabIndex = 33;
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
            // btnEnregistrerSession
            // 
            this.btnEnregistrerSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnregistrerSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnregistrerSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnregistrerSession.Location = new System.Drawing.Point(6, 19);
            this.btnEnregistrerSession.Name = "btnEnregistrerSession";
            this.btnEnregistrerSession.Size = new System.Drawing.Size(114, 40);
            this.btnEnregistrerSession.TabIndex = 22;
            this.btnEnregistrerSession.Text = "Enregistrer modifications";
            this.btnEnregistrerSession.UseVisualStyleBackColor = false;
            this.btnEnregistrerSession.Click += new System.EventHandler(this.btnEnregistrerSession_Click);
            // 
            // grpAjouterSupprimer
            // 
            this.grpAjouterSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAjouterSupprimer.BackColor = System.Drawing.Color.Coral;
            this.grpAjouterSupprimer.Controls.Add(this.btnSupprimerSession);
            this.grpAjouterSupprimer.Controls.Add(this.btnAjouterSession);
            this.grpAjouterSupprimer.ForeColor = System.Drawing.Color.White;
            this.grpAjouterSupprimer.Location = new System.Drawing.Point(603, 260);
            this.grpAjouterSupprimer.Name = "grpAjouterSupprimer";
            this.grpAjouterSupprimer.Size = new System.Drawing.Size(126, 119);
            this.grpAjouterSupprimer.TabIndex = 32;
            this.grpAjouterSupprimer.TabStop = false;
            // 
            // btnSupprimerSession
            // 
            this.btnSupprimerSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerSession.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimerSession.Location = new System.Drawing.Point(6, 65);
            this.btnSupprimerSession.Name = "btnSupprimerSession";
            this.btnSupprimerSession.Size = new System.Drawing.Size(114, 40);
            this.btnSupprimerSession.TabIndex = 2;
            this.btnSupprimerSession.Text = "Supprimer la Session";
            this.btnSupprimerSession.UseVisualStyleBackColor = false;
            this.btnSupprimerSession.Click += new System.EventHandler(this.btnSupprimerSession_Click);
            // 
            // btnAjouterSession
            // 
            this.btnAjouterSession.BackColor = System.Drawing.Color.White;
            this.btnAjouterSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjouterSession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjouterSession.Location = new System.Drawing.Point(6, 19);
            this.btnAjouterSession.Name = "btnAjouterSession";
            this.btnAjouterSession.Size = new System.Drawing.Size(114, 40);
            this.btnAjouterSession.TabIndex = 22;
            this.btnAjouterSession.Text = "Ajouter une Session";
            this.btnAjouterSession.UseVisualStyleBackColor = false;
            this.btnAjouterSession.Click += new System.EventHandler(this.btnAjouterSession_Click);
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.BackColor = System.Drawing.Color.Coral;
            this.grpInfos.Controls.Add(this.labelLibelleSession);
            this.grpInfos.Controls.Add(this.textBoxLibelleSession);
            this.grpInfos.Controls.Add(this.labelAdresseHotel);
            this.grpInfos.Controls.Add(this.textBoxDateSession);
            this.grpInfos.Controls.Add(this.labelPrixHotel);
            this.grpInfos.Controls.Add(this.textBoxNbPlaceSession);
            this.grpInfos.Controls.Add(this.labelVilleHotel);
            this.grpInfos.Controls.Add(this.textBoxHeureSession);
            this.grpInfos.Controls.Add(this.labelTelHotel);
            this.grpInfos.Controls.Add(this.textBoxTarifSession);
            this.grpInfos.ForeColor = System.Drawing.Color.White;
            this.grpInfos.Location = new System.Drawing.Point(18, 259);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(507, 259);
            this.grpInfos.TabIndex = 31;
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
            // textBoxLibelleSession
            // 
            this.textBoxLibelleSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "libelle", true));
            this.textBoxLibelleSession.Location = new System.Drawing.Point(97, 55);
            this.textBoxLibelleSession.Name = "textBoxLibelleSession";
            this.textBoxLibelleSession.Size = new System.Drawing.Size(150, 20);
            this.textBoxLibelleSession.TabIndex = 6;
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
            // textBoxDateSession
            // 
            this.textBoxDateSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "date", true));
            this.textBoxDateSession.Location = new System.Drawing.Point(334, 78);
            this.textBoxDateSession.Name = "textBoxDateSession";
            this.textBoxDateSession.Size = new System.Drawing.Size(150, 20);
            this.textBoxDateSession.TabIndex = 8;
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
            // textBoxNbPlaceSession
            // 
            this.textBoxNbPlaceSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "nbPlaces", true));
            this.textBoxNbPlaceSession.Location = new System.Drawing.Point(97, 141);
            this.textBoxNbPlaceSession.Name = "textBoxNbPlaceSession";
            this.textBoxNbPlaceSession.Size = new System.Drawing.Size(150, 20);
            this.textBoxNbPlaceSession.TabIndex = 16;
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
            // textBoxHeureSession
            // 
            this.textBoxHeureSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "heure", true));
            this.textBoxHeureSession.Location = new System.Drawing.Point(334, 121);
            this.textBoxHeureSession.Name = "textBoxHeureSession";
            this.textBoxHeureSession.Size = new System.Drawing.Size(150, 20);
            this.textBoxHeureSession.TabIndex = 14;
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
            // textBoxTarifSession
            // 
            this.textBoxTarifSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSession, "tarif", true));
            this.textBoxTarifSession.Location = new System.Drawing.Point(97, 98);
            this.textBoxTarifSession.Name = "textBoxTarifSession";
            this.textBoxTarifSession.Size = new System.Drawing.Size(150, 20);
            this.textBoxTarifSession.TabIndex = 13;
            // 
            // FrmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAjouterSupprimer);
            this.Controls.Add(this.grpInfos);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSession";
            this.Text = "FrmSession";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSession)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpAjouterSupprimer.ResumeLayout(false);
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerSession;
        private System.Windows.Forms.GroupBox grpAjouterSupprimer;
        private System.Windows.Forms.Button btnSupprimerSession;
        private System.Windows.Forms.Button btnAjouterSession;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label labelLibelleSession;
        private System.Windows.Forms.TextBox textBoxLibelleSession;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.TextBox textBoxDateSession;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.TextBox textBoxNbPlaceSession;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.TextBox textBoxHeureSession;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.TextBox textBoxTarifSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceSession;
    }
}