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
    public partial class FrmSession : Form
    {
        public FrmSession()
        {
            InitializeComponent();

            try
            {
                this.bindingSourceSession.DataSource = Passerelle.GetLesSessions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterSession_Click(object sender, EventArgs e)
        {
            this.bindingSourceSession.AddNew();
        }

        private void btnSupprimerSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette Session ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Passerelle.SupprimerSession((int)((Session)this.bindingSourceSession.Current).numSession);
                    this.bindingSourceSession.EndEdit();
                    this.Close();
                    MessageBox.Show("La Session sélectionner a été supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEnregistrerSession_Click(object sender, EventArgs e)
        {
            try
            {
                Session s = (Session)this.bindingSourceSession.Current;
                if (s.numSession == 0)
                {
                    Passerelle.AjouterSession(s);
                }
                else
                {
                    Passerelle.ModifierSession(s);
                }
                this.bindingSourceSession.EndEdit();
                MessageBox.Show("La Session a été enregistré", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            this.bindingSourceSession.CancelEdit();
        }
    }
}
