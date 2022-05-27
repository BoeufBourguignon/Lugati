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
                this.bindingSourceActivite.DataSource = Passerelle.GetLesActivites();
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
            this.dataGridActivite.Enabled = !autoriserModif;
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
            this.bindingSourceActivite.AddNew();
            ((Activite)this.bindingSourceActivite.Current).date = DateTime.Today;
        }

        private void btnSupprimerActivite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette activite ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Passerelle.SupprimerActivite((int)((Activite)this.bindingSourceActivite.Current).numActivite) == false)
                    {
                        MessageBox.Show("L'activité ne peut pas être supprimée car elle contient des participants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindingSourceActivite.RemoveCurrent();
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
            if (string.IsNullOrWhiteSpace(textBoxLibelleActivite.Text) || textBoxLibelleActivite.Text.Length > 100)
            {
                canSave = false;
                MessageBox.Show("Le nom de l'activité ne doit pas être vide et ne doit pas faire plus de 100 caractères",
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
                this.bindingSourceActivite.EndEdit();
                Activite a = (Activite)this.bindingSourceActivite.Current;

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
            this.bindingSourceActivite.ResetBindings(false);
            this.bindingSourceActivite.CancelEdit();
            this.EnableModif(false);
        }

        private void bindingSourceActivite_CurrentChanged(object sender, EventArgs e)
        {
            Activite a = (Activite)this.bindingSourceActivite.Current;
            if(a != null)
            {
                //On récupère la liste des personnes inscrites à l'activité sélectionnée
                this.bindingSourceParticipants.DataSource = Passerelle.GetLesParticipations(a.numActivite);
                //On récupère le nombre de places restantes
                this.txtNbPlacesRestantes.Text = Passerelle.GetNbPlaceByActivite(a.numActivite).ToString();
            }
        }
    }
}
