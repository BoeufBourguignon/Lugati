
namespace WinLugati
{
    partial class FrmHebergement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridHebergement = new System.Windows.Forms.DataGridView();
            this.idHebergement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomHebergement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbEtoile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAjouterHebergement = new System.Windows.Forms.Button();
            this.labelNomHotel = new System.Windows.Forms.Label();
            this.textBoxNomHotel = new System.Windows.Forms.TextBox();
            this.labelAdresseHotel = new System.Windows.Forms.Label();
            this.textBoxAdresseHotel = new System.Windows.Forms.TextBox();
            this.labelPrixHotel = new System.Windows.Forms.Label();
            this.labelVilleHotel = new System.Windows.Forms.Label();
            this.labelCPHotel = new System.Windows.Forms.Label();
            this.labelTelHotel = new System.Windows.Forms.Label();
            this.textBoxPrixHotel = new System.Windows.Forms.TextBox();
            this.textBoxVilleHotel = new System.Windows.Forms.TextBox();
            this.textBoxCPHotel = new System.Windows.Forms.TextBox();
            this.textBoxTelHotel = new System.Windows.Forms.TextBox();
            this.labelNbEtoileHotel = new System.Windows.Forms.Label();
            this.textBoxNbEtoileHotel = new System.Windows.Forms.TextBox();
            this.BtnValiderHotel = new System.Windows.Forms.Button();
            this.BtnAnnulerHotel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridHebergement);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Hebergements :";
            // 
            // dataGridHebergement
            // 
            this.dataGridHebergement.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridHebergement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHebergement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHebergement,
            this.nomHebergement,
            this.adresse,
            this.ville,
            this.CP,
            this.tel,
            this.nbEtoile,
            this.prix});
            this.dataGridHebergement.Location = new System.Drawing.Point(12, 19);
            this.dataGridHebergement.Name = "dataGridHebergement";
            this.dataGridHebergement.Size = new System.Drawing.Size(554, 181);
            this.dataGridHebergement.TabIndex = 0;
            // 
            // idHebergement
            // 
            this.idHebergement.HeaderText = "idHebergement";
            this.idHebergement.Name = "idHebergement";
            // 
            // nomHebergement
            // 
            this.nomHebergement.HeaderText = "nomHebergement";
            this.nomHebergement.Name = "nomHebergement";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.Name = "adresse";
            // 
            // ville
            // 
            this.ville.HeaderText = "ville";
            this.ville.Name = "ville";
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            // 
            // tel
            // 
            this.tel.HeaderText = "tel";
            this.tel.Name = "tel";
            // 
            // nbEtoile
            // 
            this.nbEtoile.HeaderText = "nbEtoile";
            this.nbEtoile.Name = "nbEtoile";
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.Name = "prix";
            // 
            // BtnAjouterHebergement
            // 
            this.BtnAjouterHebergement.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnAjouterHebergement.Location = new System.Drawing.Point(18, 235);
            this.BtnAjouterHebergement.Name = "BtnAjouterHebergement";
            this.BtnAjouterHebergement.Size = new System.Drawing.Size(98, 37);
            this.BtnAjouterHebergement.TabIndex = 2;
            this.BtnAjouterHebergement.Text = "Ajouter un Hotel";
            this.BtnAjouterHebergement.UseVisualStyleBackColor = false;
            this.BtnAjouterHebergement.Click += new System.EventHandler(this.BtnAjouterHebergement_Click);
            // 
            // labelNomHotel
            // 
            this.labelNomHotel.AutoSize = true;
            this.labelNomHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNomHotel.Location = new System.Drawing.Point(7, 285);
            this.labelNomHotel.Name = "labelNomHotel";
            this.labelNomHotel.Size = new System.Drawing.Size(63, 13);
            this.labelNomHotel.TabIndex = 4;
            this.labelNomHotel.Text = "Nom Hotel :";
            // 
            // textBoxNomHotel
            // 
            this.textBoxNomHotel.Location = new System.Drawing.Point(76, 285);
            this.textBoxNomHotel.Name = "textBoxNomHotel";
            this.textBoxNomHotel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomHotel.TabIndex = 6;
            // 
            // labelAdresseHotel
            // 
            this.labelAdresseHotel.AutoSize = true;
            this.labelAdresseHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdresseHotel.Location = new System.Drawing.Point(7, 311);
            this.labelAdresseHotel.Name = "labelAdresseHotel";
            this.labelAdresseHotel.Size = new System.Drawing.Size(50, 13);
            this.labelAdresseHotel.TabIndex = 7;
            this.labelAdresseHotel.Text = "adresse :";
            // 
            // textBoxAdresseHotel
            // 
            this.textBoxAdresseHotel.Location = new System.Drawing.Point(63, 311);
            this.textBoxAdresseHotel.Name = "textBoxAdresseHotel";
            this.textBoxAdresseHotel.Size = new System.Drawing.Size(113, 20);
            this.textBoxAdresseHotel.TabIndex = 8;
            // 
            // labelPrixHotel
            // 
            this.labelPrixHotel.AutoSize = true;
            this.labelPrixHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrixHotel.Location = new System.Drawing.Point(7, 339);
            this.labelPrixHotel.Name = "labelPrixHotel";
            this.labelPrixHotel.Size = new System.Drawing.Size(30, 13);
            this.labelPrixHotel.TabIndex = 9;
            this.labelPrixHotel.Text = "Prix :";
            // 
            // labelVilleHotel
            // 
            this.labelVilleHotel.AutoSize = true;
            this.labelVilleHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVilleHotel.Location = new System.Drawing.Point(7, 365);
            this.labelVilleHotel.Name = "labelVilleHotel";
            this.labelVilleHotel.Size = new System.Drawing.Size(32, 13);
            this.labelVilleHotel.TabIndex = 10;
            this.labelVilleHotel.Text = "Ville :";
            // 
            // labelCPHotel
            // 
            this.labelCPHotel.AutoSize = true;
            this.labelCPHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCPHotel.Location = new System.Drawing.Point(7, 390);
            this.labelCPHotel.Name = "labelCPHotel";
            this.labelCPHotel.Size = new System.Drawing.Size(70, 13);
            this.labelCPHotel.TabIndex = 11;
            this.labelCPHotel.Text = "Code Postal :";
            // 
            // labelTelHotel
            // 
            this.labelTelHotel.AutoSize = true;
            this.labelTelHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTelHotel.Location = new System.Drawing.Point(7, 414);
            this.labelTelHotel.Name = "labelTelHotel";
            this.labelTelHotel.Size = new System.Drawing.Size(64, 13);
            this.labelTelHotel.TabIndex = 12;
            this.labelTelHotel.Text = "Telephone :";
            // 
            // textBoxPrixHotel
            // 
            this.textBoxPrixHotel.Location = new System.Drawing.Point(43, 339);
            this.textBoxPrixHotel.Name = "textBoxPrixHotel";
            this.textBoxPrixHotel.Size = new System.Drawing.Size(133, 20);
            this.textBoxPrixHotel.TabIndex = 13;
            // 
            // textBoxVilleHotel
            // 
            this.textBoxVilleHotel.Location = new System.Drawing.Point(43, 365);
            this.textBoxVilleHotel.Name = "textBoxVilleHotel";
            this.textBoxVilleHotel.Size = new System.Drawing.Size(134, 20);
            this.textBoxVilleHotel.TabIndex = 14;
            // 
            // textBoxCPHotel
            // 
            this.textBoxCPHotel.Location = new System.Drawing.Point(76, 387);
            this.textBoxCPHotel.Name = "textBoxCPHotel";
            this.textBoxCPHotel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPHotel.TabIndex = 15;
            // 
            // textBoxTelHotel
            // 
            this.textBoxTelHotel.Location = new System.Drawing.Point(77, 414);
            this.textBoxTelHotel.Name = "textBoxTelHotel";
            this.textBoxTelHotel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelHotel.TabIndex = 16;
            // 
            // labelNbEtoileHotel
            // 
            this.labelNbEtoileHotel.AutoSize = true;
            this.labelNbEtoileHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNbEtoileHotel.Location = new System.Drawing.Point(201, 285);
            this.labelNbEtoileHotel.Name = "labelNbEtoileHotel";
            this.labelNbEtoileHotel.Size = new System.Drawing.Size(91, 13);
            this.labelNbEtoileHotel.TabIndex = 17;
            this.labelNbEtoileHotel.Text = "Nombre d\'étoiles :";
            // 
            // textBoxNbEtoileHotel
            // 
            this.textBoxNbEtoileHotel.Location = new System.Drawing.Point(293, 282);
            this.textBoxNbEtoileHotel.Name = "textBoxNbEtoileHotel";
            this.textBoxNbEtoileHotel.Size = new System.Drawing.Size(112, 20);
            this.textBoxNbEtoileHotel.TabIndex = 19;
            // 
            // BtnValiderHotel
            // 
            this.BtnValiderHotel.Location = new System.Drawing.Point(204, 327);
            this.BtnValiderHotel.Name = "BtnValiderHotel";
            this.BtnValiderHotel.Size = new System.Drawing.Size(122, 37);
            this.BtnValiderHotel.TabIndex = 20;
            this.BtnValiderHotel.Text = "Valider";
            this.BtnValiderHotel.UseVisualStyleBackColor = true;
            this.BtnValiderHotel.Click += new System.EventHandler(this.BtnValiderHotel_Click);
            // 
            // BtnAnnulerHotel
            // 
            this.BtnAnnulerHotel.Location = new System.Drawing.Point(204, 377);
            this.BtnAnnulerHotel.Name = "BtnAnnulerHotel";
            this.BtnAnnulerHotel.Size = new System.Drawing.Size(122, 34);
            this.BtnAnnulerHotel.TabIndex = 21;
            this.BtnAnnulerHotel.Text = "Annuler";
            this.BtnAnnulerHotel.UseVisualStyleBackColor = true;
            this.BtnAnnulerHotel.Click += new System.EventHandler(this.BtnAnnulerHotel_Click);
            // 
            // FrmHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(590, 489);
            this.Controls.Add(this.BtnAnnulerHotel);
            this.Controls.Add(this.BtnValiderHotel);
            this.Controls.Add(this.textBoxNbEtoileHotel);
            this.Controls.Add(this.labelNbEtoileHotel);
            this.Controls.Add(this.textBoxTelHotel);
            this.Controls.Add(this.textBoxCPHotel);
            this.Controls.Add(this.textBoxVilleHotel);
            this.Controls.Add(this.textBoxPrixHotel);
            this.Controls.Add(this.labelTelHotel);
            this.Controls.Add(this.labelCPHotel);
            this.Controls.Add(this.labelVilleHotel);
            this.Controls.Add(this.labelPrixHotel);
            this.Controls.Add(this.textBoxAdresseHotel);
            this.Controls.Add(this.labelAdresseHotel);
            this.Controls.Add(this.textBoxNomHotel);
            this.Controls.Add(this.labelNomHotel);
            this.Controls.Add(this.BtnAjouterHebergement);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHebergement";
            this.Text = "FrmHebergements";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbEtoile;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.Button BtnAjouterHebergement;
        private System.Windows.Forms.Label labelNomHotel;
        private System.Windows.Forms.TextBox textBoxNomHotel;
        private System.Windows.Forms.Label labelAdresseHotel;
        private System.Windows.Forms.TextBox textBoxAdresseHotel;
        private System.Windows.Forms.Label labelPrixHotel;
        private System.Windows.Forms.Label labelVilleHotel;
        private System.Windows.Forms.Label labelCPHotel;
        private System.Windows.Forms.Label labelTelHotel;
        private System.Windows.Forms.TextBox textBoxPrixHotel;
        private System.Windows.Forms.TextBox textBoxVilleHotel;
        private System.Windows.Forms.TextBox textBoxCPHotel;
        private System.Windows.Forms.TextBox textBoxTelHotel;
        private System.Windows.Forms.Label labelNbEtoileHotel;
        private System.Windows.Forms.TextBox textBoxNbEtoileHotel;
        private System.Windows.Forms.Button BtnValiderHotel;
        private System.Windows.Forms.Button BtnAnnulerHotel;
    }
}

