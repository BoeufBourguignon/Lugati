using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmParticipant : Form
    {
        Participant participant;

        public FrmParticipant()
        {
            InitializeComponent();

            this.comboGenre.DataSource = new List<char> { 'H', 'F' };

            this.InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                this.bindSrcLigue.DataSource = Passerelle.GetLesLigues();
                this.bindSrcHebergement.DataSource = Passerelle.GetLesHebergements();
                this.bindSrcParticipant.DataSource = Passerelle.GetLesParticipants();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            foreach (Participant unP in this.bindSrcParticipant)
            {
                int i = 0;
                while (i < this.bindSrcLigue.Count - 1 && unP.idLigue != ((Ligue)this.bindSrcLigue[i]).idLigue)
                {
                    i++;
                }
                unP.ligue = (Ligue)this.bindSrcLigue[i];

                int j = 0;
                while (j < this.bindSrcHebergement.Count - 1 && unP.idHebergement != ((Hebergement)this.bindSrcHebergement[j]).idHebergement)
                {
                    j++;
                }
                unP.hebergement = (Hebergement)this.bindSrcHebergement[j];
            }
        }

        private void EnableModif(bool autoriserModif)
        {
            //pouvoir changer d'hotel dans la data grid view
            this.dgvParticipants.Enabled = !autoriserModif;
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
            this.bindSrcParticipant.AddNew();
        }

        private void btnSupprimerParticipant_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce participant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Passerelle.SupprimerParticipant((int)((Participant)this.bindSrcParticipant.Current).idParticipant) == false)
                    {
                        MessageBox.Show("Le participant ne peut pas être supprimée car il participe à des activités ou à des sessions", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.bindSrcParticipant.RemoveCurrent();
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
            if (string.IsNullOrWhiteSpace(txtNom.Text) || txtNom.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("Le nom du participant ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(txtAdresse.Text) || txtAdresse.Text.Length > 50)
            {
                canSave = false;
                MessageBox.Show("L'adresse du participant ne doit pas être vide et ne doit pas faire plus de 50 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(txtPrenom.Text) || txtPrenom.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("Le prénom du participant ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(txtVille.Text) || txtVille.Text.Length > 30)
            {
                canSave = false;
                MessageBox.Show("La ville du participant ne doit pas être vide et ne doit pas faire plus de 30 caractères",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(comboGenre.Text) || (comboGenre.Text != "F" && comboGenre.Text != "H")) 
            {
                canSave = false;
                MessageBox.Show("Le genre du participant est invalide",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(maskTxtCP.Text) || maskTxtCP.Text.Length != 5)
            {
                canSave = false;
                MessageBox.Show("Le code postal doit être composé de 5 chiffres",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (canSave)
            {
                this.bindSrcParticipant.EndEdit();
                Participant p = (Participant)this.bindSrcParticipant.Current;
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
            this.bindSrcParticipant.ResetBindings(false);
            this.bindSrcParticipant.CancelEdit();
            this.EnableModif(false);
        }

        private void bindingSourceParticipant_CurrentChanged(object sender, EventArgs e)
        {
            this.participant = (Participant)this.bindSrcParticipant.Current;
            if (this.participant != null)
            {
                this.lblTitreInscriptions.Text = "Inscriptions de " + participant.prenom + " " + participant.nom;
                try
                {
                    //On récupère le montant total à régler
                    float montantTotal = Passerelle.GetLeMontantTotal(this.participant.idParticipant);
                    this.txtTotal.Text = montantTotal.ToString();
                    //On calcule le reste à payer
                    this.txtReste.Text = (montantTotal - this.participant.acompte).ToString();

                    //On récupère les sessions disponibles (places restantes & pas déjà inscrit)
                    this.bindSrcSessionsDispo.DataSource = Passerelle.GetLesSessionsDisponibles(this.participant.idParticipant);
                    //On récupère les sessions inscrites
                    this.bindSrcSessionsInscrites.DataSource = Passerelle.GetLesSessionsInscrites(this.participant.idParticipant);
                    //On récupère les activités disponibles (places restantes & pas déjà inscrit)
                    this.bindSrcActivitesDispo.DataSource = Passerelle.GetLesActivitesDisponibles(this.participant.idParticipant);
                    //On récupère les activités inscrites
                    this.bindSrcActivitesInscrites.DataSource = Passerelle.GetLesActivitesInsrites(this.participant.idParticipant);

                    this.CheckBoutonsEnabled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void CheckBoutonsEnabled()
        {
            //S'il n'y a pas de session dispo on désactive le bouton ajouter
            if (this.bindSrcSessionsDispo.Count == 0)
            {
                this.btnAjouterSession.Enabled = false;
            } 
            else
            {
                this.btnAjouterSession.Enabled = true;
            }
            //S'il n'y a pas de session inscrite on désactive le bouton supprimer
            if (this.bindSrcSessionsInscrites.Count == 0)
            {
                this.btnSupprimerSession.Enabled = false;
            }
            else
            {
                this.btnSupprimerSession.Enabled = true;
            }
            //S'il n'y a pas d'activité dispo on désactive le bouton ajouter
            if (this.bindSrcActivitesDispo.Count == 0)
            {
                this.btnAjouterActivite.Enabled = false;
            }
            else
            {
                this.btnAjouterActivite.Enabled = true;
            }
            //S'il n'y a pas d'activité inscrite on désactive le bouton supprimer
            if (this.bindSrcActivitesInscrites.Count == 0)
            {
                this.btnSupprimerActivite.Enabled = false;
            }
            else
            {
                this.btnSupprimerActivite.Enabled = true;
            }
        }

        private void btnAjouterSession_Click(object sender, EventArgs e)
        {
            Session sessionAAjouter = (Session)this.bindSrcSessionsDispo.Current;
            if (sessionAAjouter != null)
            {
                try
                {
                    Passerelle.AjouterInscription(this.participant.idParticipant, sessionAAjouter.numSession);
                    this.bindSrcSessionsInscrites.Add(sessionAAjouter);
                    this.bindSrcSessionsDispo.RemoveCurrent();

                    this.CheckBoutonsEnabled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnSupprimerSession_Click(object sender, EventArgs e)
        {
            Session sessionASupprimer = (Session)this.bindSrcSessionsInscrites.Current;
            if (sessionASupprimer != null)
            {
                try
                {
                    Passerelle.SupprimerInscription(this.participant.idParticipant, sessionASupprimer.numSession);
                    this.bindSrcSessionsDispo.Add(sessionASupprimer);
                    this.bindSrcSessionsInscrites.RemoveCurrent();

                    this.CheckBoutonsEnabled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnAjouterActivite_Click(object sender, EventArgs e)
        {
            Activite activiteAAjouter = (Activite)this.bindSrcActivitesDispo.Current;
            if (activiteAAjouter != null)
            {
                try
                {
                    Passerelle.AjouterParticipation(this.participant.idParticipant, activiteAAjouter.numActivite);
                    this.bindSrcActivitesInscrites.Add(activiteAAjouter);
                    this.bindSrcActivitesDispo.RemoveCurrent();

                    this.CheckBoutonsEnabled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnSupprimerActivite_Click(object sender, EventArgs e)
        {
            Activite activiteASupprimer = (Activite)this.bindSrcActivitesInscrites.Current;
            if (activiteASupprimer != null)
            {
                try
                {
                    Passerelle.SupprimerParticipation(this.participant.idParticipant, activiteASupprimer.numActivite);
                    this.bindSrcActivitesDispo.Add(activiteASupprimer);
                    this.bindSrcActivitesInscrites.RemoveCurrent();

                    this.CheckBoutonsEnabled();
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
