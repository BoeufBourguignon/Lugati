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
    public partial class FrmParticipant : Form
    {
        public FrmParticipant()
        {
            InitializeComponent();

            this.comboBoxGenre.DataSource = new List<char> { 'H', 'F' };

            this.InitializeData();
        }

        private void InitializeData()
        {
            this.bindingSourceLigue.DataSource = Passerelle.GetLesLigues();
            this.bindingSourceHebergement.DataSource = Passerelle.GetLesHebergements();
            this.bindingSourceParticipant.DataSource = Passerelle.GetLesParticipants();

            foreach (Participant unP in this.bindingSourceParticipant)
            {
                int i = 0;
                while (i < this.bindingSourceLigue.Count - 1 && unP.idLigue != ((Ligue)this.bindingSourceLigue[i]).idLigue)
                {
                    i++;
                }
                unP.ligue = (Ligue)this.bindingSourceLigue[i];

                int j = 0;
                while (j < this.bindingSourceHebergement.Count - 1 && unP.idHebergement != ((Hebergement)this.bindingSourceHebergement[j]).idHebergement)
                {
                    j++;
                }
                unP.hebergement = (Hebergement)this.bindingSourceHebergement[j];
            }
        }

        private void EnableModif(bool autoriserModif)
        {
            //pouvoir changer d'hotel dans la data grid view
            this.dataGridParticipant.Enabled = !autoriserModif;
            //pouvoir changer les infos de l'hotel 
            this.grpInfos.Enabled = autoriserModif;
            //pouvoir annuler ou enregistrer
            this.grpBtnsSaveCancel.Visible = autoriserModif;
            //ne pas pouvoir ajouter, supprimer ou modifier un hotel
            this.grpBoutons.Enabled = !autoriserModif;
        }

        private void btnAjouterParticipant_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
            this.bindingSourceParticipant.AddNew();
        }

        private void btnSupprimerParticipant_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce participant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Passerelle.SupprimerParticipant((int)((Participant)this.bindingSourceParticipant.Current).idParticipant) == false)
                    {
                        MessageBox.Show("Le participant ne peut pas être supprimée car il participe à des activités ou à des sessions", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindingSourceParticipant.RemoveCurrent();
                        MessageBox.Show("Le participant sélectionnée a été supprimée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifierParticipant_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
        }

        private void btnEnregistrerParticipant_Click(object sender, EventArgs e)
        {
            //On vérifie que les champs soient bien remplis
            bool canSave = true;
            if (string.IsNullOrWhiteSpace(textBoxNom.Text) || textBoxNom.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("Le nom du participant ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(textBoxAdresse.Text) || textBoxAdresse.Text.Length > 50)
            {
                canSave = false;
                MessageBox.Show("L'adresse du participant ne doit pas être vide et ne doit pas faire plus de 50 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(textBoxPrenom.Text) || textBoxPrenom.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("Le prénom du participant ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(textBoxVille.Text) || textBoxVille.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("La ville du participant ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(comboBoxGenre.Text) || (comboBoxGenre.Text != "F" && comboBoxGenre.Text != "H")) 
            {
                canSave = false;
                MessageBox.Show("Le genre du participant est invalide",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxCP.Text) || maskedTextBoxCP.Text.Length != 5)
            {
                canSave = false;
                MessageBox.Show("Le code postal doit être composé de 5 chiffres",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (canSave)
            {
                this.bindingSourceParticipant.EndEdit();
                Participant p = (Participant)this.bindingSourceParticipant.Current;
                p.idHebergement = p.hebergement.idHebergement;
                p.idLigue = p.ligue.idLigue;

                try
                {
                    if (p.idParticipant == 0)
                    {
                        p.idParticipant = Passerelle.AjouterParticipant(p);
                    }
                    else
                    {
                        Passerelle.ModifierParticipant(p);
                    }
                    MessageBox.Show("Les modifications ont été enregistrées", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.InitializeData();
                }
                this.EnableModif(false);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.bindingSourceParticipant.ResetBindings(false);
            this.bindingSourceParticipant.CancelEdit();
            this.EnableModif(false);
        }

        private void bindingSourceParticipant_CurrentChanged(object sender, EventArgs e)
        {
            Participant p = (Participant)this.bindingSourceParticipant.Current;
            if (p != null)
            {
                this.lblTitreInscriptions.Text = "Inscriptions de " + p.prenom + " " + p.nom;
                try
                {
                    this.bindingSourceSessionsDispo.DataSource = Passerelle.GetLesSessionsDisponibles(p.idParticipant);
                    this.bindingSourceSessionsInscrites.DataSource = Passerelle.GetLesSessionsInscrites(p.idParticipant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}
