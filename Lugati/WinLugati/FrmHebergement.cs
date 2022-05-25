using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmHebergement : Form
    {
        public FrmHebergement()
        {
            InitializeComponent();

            this.InitializeDataSource();
        }

        private void InitializeDataSource()
        {
            try
            {
                this.bindSrcHebergement.DataSource = Passerelle.GetLesHebergements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterHotel_Click(object sender, EventArgs e)
        {
            this.bindSrcHebergement.AddNew();
        }

        private void btnSupprimerHotel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes-vous sur de vouloir supprimer cet hôtel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if(Passerelle.SupprimerHebergement((int)((Hebergement)this.bindSrcHebergement.Current).idHebergement) == false)
                    {
                        MessageBox.Show("L'hebergement ne peut pas être supprimé car il héberge des participants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindSrcHebergement.EndEdit();
                        MessageBox.Show("L'hebergement a été supprimée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.InitializeDataSource();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.bindSrcHebergement.CancelEdit();
        }

        private void btnEnregistrerHotel_Click(object sender, EventArgs e)
        {
            Hebergement h = (Hebergement)this.bindSrcHebergement.Current;
            this.bindSrcHebergement.EndEdit();
            try
            {
                if (h.idHebergement == 0)
                {
                    Passerelle.AjouterHebergement(h);
                }
                else
                {
                    Passerelle.ModifierHebergement(h);
                }
                MessageBox.Show("Les modifications ont été enregistrées", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.InitializeDataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine((Hebergement)this.bindSrcHebergement.Current);
        }
    }
}
