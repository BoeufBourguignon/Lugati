using System;
using System.Windows.Forms;

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

        private void InitializeData()
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
            //D'abord on vérifie que les champs sont bien remplis
            bool canSave = true;
            if (string.IsNullOrWhiteSpace(textBoxNomHotel.Text) || textBoxNomHotel.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("Le nom de l'hébergement ne doit pas être vide et ne doit pas faire plus de 30 caractères", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(maskedTextBoxPrix.Text) == 0)
            {
                canSave = false;
                MessageBox.Show("Le prix ne doit pas être égal à 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxTel.Text) || maskedTextBoxTel.Text.Length != 10)
            {
                canSave = false;
                MessageBox.Show("Le numéro de téléphone doit être composé de 10 chiffres",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(maskedTextBoxNbEtoileHotel.Text) < 1 && int.Parse(maskedTextBoxNbEtoileHotel.Text) > 3)
            {
                canSave = false;
                MessageBox.Show("L'hébergement doit avoir entre 1 et 3 étoiles",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(textBoxAdresseHotel.Text) || textBoxAdresseHotel.Text.Length > 50)
            {
                canSave = false;
                MessageBox.Show("L'adresse de l'hébergement ne doit pas être vide et ne doit pas faire plus de 50 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(textBoxVilleHotel.Text) || textBoxVilleHotel.Text.Length > 50)
            {
                canSave = false;
                MessageBox.Show("La ville de l'hébergement ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxCPHotel.Text) || maskedTextBoxCPHotel.Text.Length != 5)
            {
                canSave = false;
                MessageBox.Show("Le code postal doit être composé de 5 chiffres",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (canSave)
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
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.bindSrcHebergement.ResetBindings(false);
            this.bindSrcHebergement.CancelEdit();
            this.EnableModif(false);
        }
    }
}
