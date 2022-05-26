using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Lugati;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmParticipant : Form
    {
        public FrmParticipant()
        {
            InitializeComponent();

            this.InitializeData();
        }

        private void InitializeData()
        {
            this.bindingSourceLigue.DataSource = Passerelle.GetLesLigues();
            this.bindingSourceParticipant.DataSource = Passerelle.GetLesParticipants();

            foreach(Participant unP in this.bindingSourceParticipant)
            {
                int i = 0;
                while (i < this.bindingSourceLigue.Count - 1 && unP.idLigue != ((Ligue)this.bindingSourceLigue[i]).idLigue)
                {
                    i++;
                }
                unP.ligue = (Ligue)this.bindingSourceLigue[i];
            }
        }

        private void buttonAjouterInscriptionActivite_Click(object sender, EventArgs e)
        {
            try
            {
                Participer c = (Participer)this.bindingSourceParticiper.Current;
                c.idParticipant = Passerelle.AjouterParticiper(c);
                this.bindingSourceParticiper.EndEdit();
                MessageBox.Show("La a été enregistré", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.bindingSourceParticiper.AddNew();
        }

        private void buttonSupprimerActivite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette activité pour ce participant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Passerelle.SupprimerParticiper((int)((Participer)this.bindingSourceParticiper.Current).idParticipant);
                    this.bindingSourceParticiper.EndEdit();
                    MessageBox.Show("Le Participant a été supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSupprimerSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette activité pour ce participant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Passerelle.SupprimerInscrire((int)((Inscrire)this.bindingSourceInscrire.Current).idParticipant);
                    this.bindingSourceInscrire.EndEdit();
                    MessageBox.Show("Le Participant a été supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAjouterInscriptionSession_Click(object sender, EventArgs e)
        {
            try
            {
                Inscrire c = (Inscrire)this.bindingSourceInscrire.Current;
                c.idParticipant = Passerelle.AjouterInscription(c);
                this.bindingSourceInscrire.EndEdit();
                MessageBox.Show("La a été enregistré", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.bindingSourceInscrire.AddNew();
        }
    }
}
