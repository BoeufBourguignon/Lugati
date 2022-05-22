using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmActivite : Form
    {
        public FrmActivite()
        {
            InitializeComponent();

            try
            {
                this.bindingSourceActivite.DataSource = Passerelle.GetLesActivites();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterActivite_Click(object sender, EventArgs e)
        {
            this.bindingSourceActivite.AddNew();

        }

        private void btnSupprimerActivite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette Activite ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Passerelle.SupprimerActivite((int)((Activite)this.bindingSourceActivite.Current).numActivite);
                    this.bindingSourceActivite.EndEdit();
                    this.Close();
                    MessageBox.Show("L'Activité sélectionner a été supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEnregistrerActivite_Click(object sender, EventArgs e)
        {
            try
            {
                Activite a = (Activite)this.bindingSourceActivite.Current;
                if (a.numActivite == 0)
                {
                    Passerelle.AjouterActivite(a);
                }
                else
                {
                    Passerelle.ModifierActivite(a);
                }
                this.bindingSourceActivite.EndEdit();
                MessageBox.Show("L'activité a été enregistré", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.bindingSourceActivite.CancelEdit();

        }
    }
}
