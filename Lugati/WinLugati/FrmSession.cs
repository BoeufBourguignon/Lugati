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
                this.bindSrcSession.DataSource = Passerelle.GetLesSessions();
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
            this.dgvSessions.Enabled = !autoriserModif;
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
            this.bindSrcSession.AddNew();
            ((Session)this.bindSrcSession.Current).date = DateTime.Today;
        }

        private void btnSupprimerSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette session ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Passerelle.SupprimerSession((int)((Session)this.bindSrcSession.Current).numSession) == false)
                    {
                        MessageBox.Show("La session ne peut pas être supprimée car elle contient des participants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindSrcSession.RemoveCurrent();
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
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) || txtLibelle.Text.Length > 100)
            {
                canSave = false;
                MessageBox.Show("Le nom de la session ne doit pas être vide et ne doit pas faire plus de 100 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(maskTxtTarif.Text) == 0)
            {
                canSave = false;
                MessageBox.Show("Le tarif ne doit pas être égal à 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(maskTxtNbPlaces.Text) == 0)
            {
                canSave = false;
                MessageBox.Show("Le nombre de places ne doit pas être égal à 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(comboHeure.Text) || (comboHeure.Text != "09:00" && comboHeure.Text != "14:30"))
            {
                canSave = false;
                MessageBox.Show("L'heure doit être 09:00 ou 14:30",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtPickerDate.Value < new DateTime(1753, 01, 01) || dtPickerDate.Value > new DateTime(9999, 12, 31))
            {
                canSave = false;
                MessageBox.Show("La date est invalide",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (canSave)
            {
                this.bindSrcSession.EndEdit();
                Session s = (Session)this.bindSrcSession.Current;

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
            this.bindSrcSession.ResetBindings(false);
            this.bindSrcSession.CancelEdit();
            this.EnableModif(false);
        }

        private void bindingSourceSession_CurrentChanged(object sender, EventArgs e)
        {
            Session s = (Session)this.bindSrcSession.Current;
            if(s != null)
            {
                try
                {
                    //On récupère la liste des personnes inscrites à la session sélectionnée
                    this.bindSrcInscrits.DataSource = Passerelle.GetLesInscriptions(s.numSession);
                    //On récupère le nombre de places restantes
                    this.txtNbPlacesRestantes.Text = Passerelle.GetNbPlaceBySession(s.numSession).ToString();
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
