
namespace WinLugati
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridHebergement = new System.Windows.Forms.DataGridView();
            this.BindSourceHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceHebergement)).BeginInit();
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
            this.dataGridHebergement.AutoGenerateColumns = false;
            this.dataGridHebergement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHebergement.DataSource = this.BindSourceHebergement;
            this.dataGridHebergement.Location = new System.Drawing.Point(6, 19);
            this.dataGridHebergement.Name = "dataGridHebergement";
            this.dataGridHebergement.Size = new System.Drawing.Size(554, 181);
            this.dataGridHebergement.TabIndex = 0;
            // 
            // BindSourceHebergement
            // 
            this.BindSourceHebergement.DataSource = typeof(Passerelle.Hebergement);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FrmHebergements";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceHebergement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridHebergement;
        private System.Windows.Forms.BindingSource BindSourceHebergement;
    }
}

