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

            this.InitializeData();
        }

        public void InitializeData()
        {
            try
            {
                this.bindSrcHebergement.DataSource = Passerelle.GetLesHebergements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void EnableModif(bool autoriserModif)
        {
            //pouvoir changer d'hotel dans la data grid view
            this.dataGridHebergement.Enabled = !autoriserModif;
            //pouvoir changer les infos de l'hotel 
            this.grpInfos.Enabled = autoriserModif;
            //pouvoir annuler ou enregistrer
            this.grpBtnsSaveCancel.Visible = autoriserModif;
            //ne pas pouvoir ajouter, supprimer ou modifier un hotel
            this.grpBoutons.Enabled = !autoriserModif;
        }

        private void btnAjouterHotel_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
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
                        this.bindSrcHebergement.RemoveCurrent();
                        MessageBox.Show("L'hebergement a été supprimée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifierHotel_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
        }

        private void btnEnregistrerHotel_Click(object sender, EventArgs e)
        {
            this.bindSrcHebergement.EndEdit();
            Hebergement h = (Hebergement)this.bindSrcHebergement.Current;
            try
            {
                if (h.idHebergement == 0)
                {
                    h.idHebergement = Passerelle.AjouterHebergement(h);
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
                this.InitializeData();
            }
            this.EnableModif(false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.bindSrcHebergement.ResetBindings(false);
            this.bindSrcHebergement.CancelEdit();
            this.EnableModif(false);
        }
    }
}
