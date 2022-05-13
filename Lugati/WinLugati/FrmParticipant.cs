using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lugati;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmParticipant : Form
    {
        public FrmParticipant()
        {
            InitializeComponent();
        }

        private void FrmParticipant_Load(object sender, EventArgs e)
        {
            bindingSourceParticipant.DataSource = Passerelle.GetLesParticipants();

            //bindingSourceParticipant.DataSource = (Participant)comboBoxParticipant.SelectedItem;
        }

        private void btnValiderParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                Participant c = (Participant)this.bindingSourceParticipant.Current;
                if (c.idParticipant == 0)
                {
                    c.idParticipant = Passerelle.AjouterParticipant(c);
                }
                else
                {
                    Passerelle.ModifierParticipant(c);
                }
                this.bindingSourceParticipant.EndEdit();
                MessageBox.Show("La a été enregistré", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnulerParticipant_Click(object sender, EventArgs e)
        {
            this.bindingSourceParticipant.CancelEdit();
        }

        private void btnAjouterParticipant_Click(object sender, EventArgs e)
        {
            this.bindingSourceParticipant.AddNew();

        }

        private void btnSupprimerPart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce Participant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Passerelle.SupprimerParticipant((int)((Participant)this.bindingSourceParticipant.Current).idParticipant);
                    this.bindingSourceParticipant.EndEdit();
                    MessageBox.Show("Le Participant a été enregistré", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
