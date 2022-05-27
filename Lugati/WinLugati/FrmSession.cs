using Lugati.dll;
using System;
using System.Windows.Forms;

namespace WinLugati
{
    public partial class FrmSession : Form
    {
        public FrmSession()
        {
            InitializeComponent();

            this.InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                this.bindingSourceSession.DataSource = Passerelle.GetLesSessions();
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
            this.dataGridSession.Enabled = !autoriserModif;
            //pouvoir changer les infos de l'hotel 
            this.grpInfos.Enabled = autoriserModif;
            //pouvoir annuler ou enregistrer
            this.grpBtnsSaveCancel.Visible = autoriserModif;
            //ne pas pouvoir ajouter, supprimer ou modifier un hotel
            this.grpBoutons.Enabled = !autoriserModif;
        }

        private void btnAjouterSession_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
            this.bindingSourceSession.AddNew();
            ((Session)this.bindingSourceSession.Current).date = DateTime.Today;
        }

        private void btnSupprimerSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette session ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Passerelle.SupprimerSession((int)((Session)this.bindingSourceSession.Current).numSession) == false)
                    {
                        MessageBox.Show("La session ne peut pas être supprimée car elle contient des participants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindingSourceSession.RemoveCurrent();
                        MessageBox.Show("L'activité sélectionnée a été supprimée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifierSession_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
        }

        private void btnEnregistrerSession_Click(object sender, EventArgs e)
        {
            //On vérifie que les champs sont bien remplis
            bool canSave = true;
            if (string.IsNullOrWhiteSpace(textBoxLibelleSession.Text) || textBoxLibelleSession.Text.Length > 100)
            {
                canSave = false;
                MessageBox.Show("Le nom de la session ne doit pas être vide et ne doit pas faire plus de 100 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(maskedTextBoxTarif.Text) == 0)
            {
                canSave = false;
                MessageBox.Show("Le tarif ne doit pas être égal à 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(maskedTextBoxNbPlaces.Text) == 0)
            {
                canSave = false;
                MessageBox.Show("Le nombre de places ne doit pas être égal à 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(comboBoxHeure.Text) || (comboBoxHeure.Text != "09:00" && comboBoxHeure.Text != "14:30"))
            {
                canSave = false;
                MessageBox.Show("L'heure doit être 09:00 ou 14:30",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dateTimePickerDate.Value < new DateTime(1753, 01, 01) || dateTimePickerDate.Value > new DateTime(9999, 12, 31))
            {
                canSave = false;
                MessageBox.Show("La date est invalide",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (canSave)
            {
                this.bindingSourceSession.EndEdit();
                Session s = (Session)this.bindingSourceSession.Current;

                try
                {
                    if (s.numSession == 0)
                    {
                        s.numSession = Passerelle.AjouterSession(s);
                    }
                    else
                    {
                        Passerelle.ModifierSession(s);
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
            this.bindingSourceSession.ResetBindings(false);
            this.bindingSourceSession.CancelEdit();
            this.EnableModif(false);
        }

        private void bindingSourceSession_CurrentChanged(object sender, EventArgs e)
        {
            Session s = (Session)this.bindingSourceSession.Current;
            if(s != null)
            {
                //On récupère la liste des personnes inscrites à la session sélectionnée
                this.bindingSourceInscris.DataSource = Passerelle.GetLesInscriptions(s.numSession);
                //On récupère le nombre de places restantes
                this.txtNbPlacesRestantes.Text = Passerelle.GetNbPlaceBySession(s.numSession).ToString();
            }
        }
    }
}
