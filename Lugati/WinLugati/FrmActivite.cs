using System;
using System.Windows.Forms;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmActivite : Form
    {
        public FrmActivite()
        {
            InitializeComponent();

            this.InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                this.bindSrcActivite.DataSource = Passerelle.GetLesActivites();
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
            this.dgvActivite.Enabled = !autoriserModif;
            //pouvoir changer les infos de l'hotel 
            this.grpInfos.Enabled = autoriserModif;
            //pouvoir annuler ou enregistrer
            this.grpBtnsSaveCancel.Visible = autoriserModif;
            //ne pas pouvoir ajouter, supprimer ou modifier un hotel
            this.grpBoutons.Enabled = !autoriserModif;
        }

        private void btnAjouterActivite_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
            this.bindSrcActivite.AddNew();
            ((Activite)this.bindSrcActivite.Current).date = DateTime.Today;
        }

        private void btnSupprimerActivite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette activite ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Passerelle.SupprimerActivite((int)((Activite)this.bindSrcActivite.Current).numActivite) == false)
                    {
                        MessageBox.Show("L'activité ne peut pas être supprimée car elle contient des participants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindSrcActivite.RemoveCurrent();
                        MessageBox.Show("L'activité sélectionnée a été supprimée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifierActivite_Click(object sender, EventArgs e)
        {
            this.EnableModif(true);
        }

        private void btnEnregistrerActivite_Click(object sender, EventArgs e)
        {
            //On vérifie que les champs sont bien remplis
            bool canSave = true;
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) || txtLibelle.Text.Length > 100)
            {
                canSave = false;
                MessageBox.Show("Le nom de l'activité ne doit pas être vide et ne doit pas faire plus de 100 caractères",
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
                this.bindSrcActivite.EndEdit();
                Activite a = (Activite)this.bindSrcActivite.Current;

                try
                {
                    if (a.numActivite == 0)
                    {
                        a.numActivite = Passerelle.AjouterActivite(a);
                    }
                    else
                    {
                        Passerelle.ModifierActivite(a);
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
            this.bindSrcActivite.ResetBindings(false);
            this.bindSrcActivite.CancelEdit();
            this.EnableModif(false);
        }

        private void bindingSourceActivite_CurrentChanged(object sender, EventArgs e)
        {
            Activite a = (Activite)this.bindSrcActivite.Current;
            if(a != null)
            {
                try
                {
                    //On récupère la liste des personnes inscrites à l'activité sélectionnée
                    this.bindSrcParticipants.DataSource = Passerelle.GetLesParticipations(a.numActivite);
                    //On récupère le nombre de places restantes
                    this.txtNbPlacesRestantes.Text = Passerelle.GetNbPlaceByActivite(a.numActivite).ToString();
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
