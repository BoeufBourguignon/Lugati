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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridActivite = new System.Windows.Forms.DataGridView();
            this.bindSrcActivite = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelLibelleActivite = new System.Windows.Forms.Label();
            this.BtnAnnulerActivite = new System.Windows.Forms.Button();
            this.textBoxLibelleActivite = new System.Windows.Forms.TextBox();
            this.BtnValiderActivite = new System.Windows.Forms.Button();
            this.labelTarifActivite = new System.Windows.Forms.Label();
            this.textBoxTarifActivite = new System.Windows.Forms.TextBox();
            this.textBoxHeureActivite = new System.Windows.Forms.TextBox();
            this.labelNbPlacesActivite = new System.Windows.Forms.Label();
            this.textBoxDateActivite = new System.Windows.Forms.TextBox();
            this.labelDateActivite = new System.Windows.Forms.Label();
            this.textBoxNbPlacesActivite = new System.Windows.Forms.TextBox();
            this.labelHeureActivite = new System.Windows.Forms.Label();
            this.BtnSupprimerHotel = new System.Windows.Forms.Button();
            this.BtnAjouterHebergement = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxIdHotel = new System.Windows.Forms.ComboBox();
            this.BtnValiderModifActivite = new System.Windows.Forms.Button();
            this.BtnAnnulerModifActivite = new System.Windows.Forms.Button();
            this.BtnModifierActivite = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivite)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.dataGridActivite);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Activités :";
            // 
            // dataGridActivite
            // 
            this.dataGridActivite.AllowUserToAddRows = false;
            this.dataGridActivite.AllowUserToDeleteRows = false;
            this.dataGridActivite.AutoGenerateColumns = false;
            this.dataGridActivite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridActivite.DataSource = this.bindSrcActivite;
            this.dataGridActivite.Location = new System.Drawing.Point(6, 19);
            this.dataGridActivite.MultiSelect = false;
            this.dataGridActivite.Name = "dataGridActivite";
            this.dataGridActivite.ReadOnly = true;
            this.dataGridActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivite.Size = new System.Drawing.Size(644, 168);
            this.dataGridActivite.TabIndex = 0;
            // 
            // bindSrcActivite
            // 
            this.bindSrcActivite.DataSource = typeof(Lugati.dll.Activite);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.labelLibelleActivite);
            this.groupBox3.Controls.Add(this.BtnAnnulerActivite);
            this.groupBox3.Controls.Add(this.textBoxLibelleActivite);
            this.groupBox3.Controls.Add(this.BtnValiderActivite);
            this.groupBox3.Controls.Add(this.labelTarifActivite);
            this.groupBox3.Controls.Add(this.textBoxTarifActivite);
            this.groupBox3.Controls.Add(this.textBoxHeureActivite);
            this.groupBox3.Controls.Add(this.labelNbPlacesActivite);
            this.groupBox3.Controls.Add(this.textBoxDateActivite);
            this.groupBox3.Controls.Add(this.labelDateActivite);
            this.groupBox3.Controls.Add(this.textBoxNbPlacesActivite);
            this.groupBox3.Controls.Add(this.labelHeureActivite);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 162);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter ou Supprimer";
            // 
            // labelLibelleActivite
            // 
            this.labelLibelleActivite.AutoSize = true;
            this.labelLibelleActivite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLibelleActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLibelleActivite.Location = new System.Drawing.Point(11, 21);
            this.labelLibelleActivite.Name = "labelLibelleActivite";
            this.labelLibelleActivite.Size = new System.Drawing.Size(43, 13);
            this.labelLibelleActivite.TabIndex = 4;
            this.labelLibelleActivite.Text = "Libellé :";
            // 
            // BtnAnnulerActivite
            // 
            this.BtnAnnulerActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnnulerActivite.Location = new System.Drawing.Point(257, 100);
            this.BtnAnnulerActivite.Name = "BtnAnnulerActivite";
            this.BtnAnnulerActivite.Size = new System.Drawing.Size(122, 34);
            this.BtnAnnulerActivite.TabIndex = 21;
            this.BtnAnnulerActivite.Text = "Annuler";
            this.BtnAnnulerActivite.UseVisualStyleBackColor = true;
            // 
            // textBoxLibelleActivite
            // 
            this.textBoxLibelleActivite.Location = new System.Drawing.Point(80, 21);
            this.textBoxLibelleActivite.Name = "textBoxLibelleActivite";
            this.textBoxLibelleActivite.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibelleActivite.TabIndex = 6;
            // 
            // BtnValiderActivite
            // 
            this.BtnValiderActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnValiderActivite.Location = new System.Drawing.Point(257, 38);
            this.BtnValiderActivite.Name = "BtnValiderActivite";
            this.BtnValiderActivite.Size = new System.Drawing.Size(122, 37);
            this.BtnValiderActivite.TabIndex = 20;
            this.BtnValiderActivite.Text = "Valider";
            this.BtnValiderActivite.UseVisualStyleBackColor = true;
            // 
            // labelTarifActivite
            // 
            this.labelTarifActivite.AutoSize = true;
            this.labelTarifActivite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTarifActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTarifActivite.Location = new System.Drawing.Point(11, 47);
            this.labelTarifActivite.Name = "labelTarifActivite";
            this.labelTarifActivite.Size = new System.Drawing.Size(34, 13);
            this.labelTarifActivite.TabIndex = 7;
            this.labelTarifActivite.Text = "Tarif :";
            // 
            // textBoxTarifActivite
            // 
            this.textBoxTarifActivite.Location = new System.Drawing.Point(67, 47);
            this.textBoxTarifActivite.Name = "textBoxTarifActivite";
            this.textBoxTarifActivite.Size = new System.Drawing.Size(113, 20);
            this.textBoxTarifActivite.TabIndex = 8;
            // 
            // textBoxHeureActivite
            // 
            this.textBoxHeureActivite.Location = new System.Drawing.Point(80, 127);
            this.textBoxHeureActivite.Name = "textBoxHeureActivite";
            this.textBoxHeureActivite.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeureActivite.TabIndex = 16;
            // 
            // labelNbPlacesActivite
            // 
            this.labelNbPlacesActivite.AutoSize = true;
            this.labelNbPlacesActivite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNbPlacesActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNbPlacesActivite.Location = new System.Drawing.Point(10, 72);
            this.labelNbPlacesActivite.Name = "labelNbPlacesActivite";
            this.labelNbPlacesActivite.Size = new System.Drawing.Size(76, 13);
            this.labelNbPlacesActivite.TabIndex = 10;
            this.labelNbPlacesActivite.Text = "Nb de places :";
            // 
            // textBoxDateActivite
            // 
            this.textBoxDateActivite.Location = new System.Drawing.Point(79, 100);
            this.textBoxDateActivite.Name = "textBoxDateActivite";
            this.textBoxDateActivite.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateActivite.TabIndex = 15;
            // 
            // labelDateActivite
            // 
            this.labelDateActivite.AutoSize = true;
            this.labelDateActivite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDateActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDateActivite.Location = new System.Drawing.Point(10, 103);
            this.labelDateActivite.Name = "labelDateActivite";
            this.labelDateActivite.Size = new System.Drawing.Size(36, 13);
            this.labelDateActivite.TabIndex = 11;
            this.labelDateActivite.Text = "Date :";
            // 
            // textBoxNbPlacesActivite
            // 
            this.textBoxNbPlacesActivite.Location = new System.Drawing.Point(92, 72);
            this.textBoxNbPlacesActivite.Name = "textBoxNbPlacesActivite";
            this.textBoxNbPlacesActivite.Size = new System.Drawing.Size(88, 20);
            this.textBoxNbPlacesActivite.TabIndex = 14;
            // 
            // labelHeureActivite
            // 
            this.labelHeureActivite.AutoSize = true;
            this.labelHeureActivite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeureActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHeureActivite.Location = new System.Drawing.Point(10, 127);
            this.labelHeureActivite.Name = "labelHeureActivite";
            this.labelHeureActivite.Size = new System.Drawing.Size(42, 13);
            this.labelHeureActivite.TabIndex = 12;
            this.labelHeureActivite.Text = "Heure :";
            // 
            // BtnSupprimerHotel
            // 
            this.BtnSupprimerHotel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSupprimerHotel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSupprimerHotel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSupprimerHotel.Location = new System.Drawing.Point(220, 216);
            this.BtnSupprimerHotel.Name = "BtnSupprimerHotel";
            this.BtnSupprimerHotel.Size = new System.Drawing.Size(102, 36);
            this.BtnSupprimerHotel.TabIndex = 22;
            this.BtnSupprimerHotel.Text = "Supprimer une activité";
            this.BtnSupprimerHotel.UseVisualStyleBackColor = false;
            // 
            // BtnAjouterHebergement
            // 
            this.BtnAjouterHebergement.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnAjouterHebergement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAjouterHebergement.Location = new System.Drawing.Point(26, 215);
            this.BtnAjouterHebergement.Name = "BtnAjouterHebergement";
            this.BtnAjouterHebergement.Size = new System.Drawing.Size(98, 37);
            this.BtnAjouterHebergement.TabIndex = 2;
            this.BtnAjouterHebergement.Text = "Ajouter une activité";
            this.BtnAjouterHebergement.UseVisualStyleBackColor = false;
            this.BtnAjouterHebergement.Click += new System.EventHandler(this.BtnAjouterHebergement_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.comboBoxIdHotel);
            this.groupBox2.Controls.Add(this.BtnValiderModifActivite);
            this.groupBox2.Controls.Add(this.BtnAnnulerModifActivite);
            this.groupBox2.Location = new System.Drawing.Point(514, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 162);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier";
            // 
            // comboBoxIdHotel
            // 
            this.comboBoxIdHotel.FormattingEnabled = true;
            this.comboBoxIdHotel.Location = new System.Drawing.Point(17, 18);
            this.comboBoxIdHotel.Name = "comboBoxIdHotel";
            this.comboBoxIdHotel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdHotel.TabIndex = 26;
            // 
            // BtnValiderModifActivite
            // 
            this.BtnValiderModifActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnValiderModifActivite.Location = new System.Drawing.Point(16, 63);
            this.BtnValiderModifActivite.Name = "BtnValiderModifActivite";
            this.BtnValiderModifActivite.Size = new System.Drawing.Size(122, 37);
            this.BtnValiderModifActivite.TabIndex = 24;
            this.BtnValiderModifActivite.Text = "Valider";
            this.BtnValiderModifActivite.UseVisualStyleBackColor = true;
            // 
            // BtnAnnulerModifActivite
            // 
            this.BtnAnnulerModifActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAnnulerModifActivite.Location = new System.Drawing.Point(16, 113);
            this.BtnAnnulerModifActivite.Name = "BtnAnnulerModifActivite";
            this.BtnAnnulerModifActivite.Size = new System.Drawing.Size(122, 34);
            this.BtnAnnulerModifActivite.TabIndex = 25;
            this.BtnAnnulerModifActivite.Text = "Annuler";
            this.BtnAnnulerModifActivite.UseVisualStyleBackColor = true;
            // 
            // BtnModifierActivite
            // 
            this.BtnModifierActivite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnModifierActivite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModifierActivite.Location = new System.Drawing.Point(397, 216);
            this.BtnModifierActivite.Name = "BtnModifierActivite";
            this.BtnModifierActivite.Size = new System.Drawing.Size(95, 36);
            this.BtnModifierActivite.TabIndex = 23;
            this.BtnModifierActivite.Text = "Modifier une activité";
            this.BtnModifierActivite.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tarif";
            this.dataGridViewTextBoxColumn1.HeaderText = "tarif";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nbPlaces";
            this.dataGridViewTextBoxColumn2.HeaderText = "nbPlaces";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "libelle";
            this.dataGridViewTextBoxColumn3.HeaderText = "libelle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "heure";
            this.dataGridViewTextBoxColumn5.HeaderText = "heure";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.BtnSupprimerHotel);
            this.Controls.Add(this.BtnAjouterHebergement);
            this.Controls.Add(this.BtnModifierActivite);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActivite";
            this.Text = "FrmActivite";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivite)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridActivite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSupprimerHotel;
        private System.Windows.Forms.Button BtnAjouterHebergement;
        private System.Windows.Forms.Label labelLibelleActivite;
        private System.Windows.Forms.Button BtnAnnulerActivite;
        private System.Windows.Forms.TextBox textBoxLibelleActivite;
        private System.Windows.Forms.Button BtnValiderActivite;
        private System.Windows.Forms.Label labelTarifActivite;
        private System.Windows.Forms.TextBox textBoxTarifActivite;
        private System.Windows.Forms.TextBox textBoxHeureActivite;
        private System.Windows.Forms.Label labelNbPlacesActivite;
        private System.Windows.Forms.TextBox textBoxDateActivite;
        private System.Windows.Forms.Label labelDateActivite;
        private System.Windows.Forms.TextBox textBoxNbPlacesActivite;
        private System.Windows.Forms.Label labelHeureActivite;
        private System.Windows.Forms.BindingSource bindSrcActivite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxIdHotel;
        private System.Windows.Forms.Button BtnValiderModifActivite;
        private System.Windows.Forms.Button BtnModifierActivite;
        private System.Windows.Forms.Button BtnAnnulerModifActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn numActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}