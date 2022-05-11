using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lugati.dll;

namespace WinLugati
{
    public partial class FrmHebergement : Form
    {
        public FrmHebergement()
        {
            InitializeComponent();

            dataGridHebergement.DataSource = Passerelle.GetLesHebergements();

            labelNomHotel.Visible = false;
            labelAdresseHotel.Visible = false;
            labelVilleHotel.Visible = false;
            labelCPHotel.Visible = false;
            labelTelHotel.Visible = false;
            labelNbEtoileHotel.Visible = false;
            labelPrixHotel.Visible = false;

            textBoxNomHotel.Visible = false;
            textBoxAdresseHotel.Visible = false;
            textBoxVilleHotel.Visible = false;
            textBoxCPHotel.Visible = false;
            textBoxTelHotel.Visible = false;
            textBoxNbEtoileHotel.Visible = false;
            textBoxPrixHotel.Visible = false;

            BtnValiderHotel.Visible = false;
            BtnAnnulerHotel.Visible = false;

            BtnValiderModifHotel.Visible = false;
            BtnAnnulerModifHotel.Visible = false;

            comboBoxIdHotel.Visible = false;
        }

        private void BtnAjouterHebergement_Click(object sender, EventArgs e)
        {

            labelNomHotel.Visible = true;
            labelAdresseHotel.Visible = true;
            labelVilleHotel.Visible = true;
            labelCPHotel.Visible = true;
            labelTelHotel.Visible = true;
            labelNbEtoileHotel.Visible = true;
            labelPrixHotel.Visible = true;

            textBoxNomHotel.Visible = true;
            textBoxAdresseHotel.Visible = true;
            textBoxVilleHotel.Visible = true;
            textBoxCPHotel.Visible = true;
            textBoxTelHotel.Visible = true;
            textBoxNbEtoileHotel.Visible = true;
            textBoxPrixHotel.Visible = true;

            BtnValiderHotel.Visible = true;
            BtnAnnulerHotel.Visible = true;
        }

        private void BtnAnnulerHotel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValiderHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresseHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxVilleHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxCPHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrixHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxNbEtoileHotel.Text)
            )
            {
                MessageBox.Show("Vous devez remplir toutes les informations !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int idHotel = Passerelle.GetIdHebergement(textBoxNomHotel.Text, textBoxAdresseHotel.Text, textBoxVilleHotel.Text, textBoxCPHotel.Text, textBoxTelHotel.Text, int.Parse(textBoxNbEtoileHotel.Text), int.Parse(textBoxPrixHotel.Text));
                    if (idHotel == 0)
                    {
                        idHotel = Passerelle.AjouterHebergement(textBoxNomHotel.Text, textBoxAdresseHotel.Text, textBoxVilleHotel.Text, textBoxCPHotel.Text, textBoxTelHotel.Text, int.Parse(textBoxNbEtoileHotel.Text), int.Parse(textBoxPrixHotel.Text));
                        this.Close();
                    }
                    else
                    { MessageBox.Show("Cet Hotel existe déjà : n°" + idHotel, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSupprimerHotel_Click(object sender, EventArgs e)
        {
            List<int> hotelsASupprimer = new List<int>();

            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le(s) hotel(s) sélectionné(s) définitivement, et tout ce qui les concerne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridHebergement.SelectedRows)
                {
                    hotelsASupprimer.Add(Convert.ToInt32(row.Cells[0].Value));
                }
                try
                {
                    Passerelle.SupprimerLesHebergements(hotelsASupprimer);

                    if (dataGridHebergement.SelectedRows.Count == 1)
                    {
                        dataGridHebergement.Rows.Remove(dataGridHebergement.SelectedRows[0]);
                    }
                    else
                    {
                        dataGridHebergement.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnModifierHotel_Click(object sender, EventArgs e)
        {
            labelNomHotel.Visible = true;
            labelAdresseHotel.Visible = true;
            labelVilleHotel.Visible = true;
            labelCPHotel.Visible = true;
            labelTelHotel.Visible = true;
            labelNbEtoileHotel.Visible = true;
            labelPrixHotel.Visible = true;

            textBoxNomHotel.Visible = true;
            textBoxAdresseHotel.Visible = true;
            textBoxVilleHotel.Visible = true;
            textBoxCPHotel.Visible = true;
            textBoxTelHotel.Visible = true;
            textBoxNbEtoileHotel.Visible = true;
            textBoxPrixHotel.Visible = true;

            BtnValiderModifHotel.Visible = true;
            BtnAnnulerModifHotel.Visible = true;

            comboBoxIdHotel.Visible = true;
        }

        private void BtnValiderModifHotel_Click(object sender, EventArgs e)
        {
            Hebergement hebergementSelectionne = (Hebergement)comboBoxIdHotel.SelectedItem;
            if (string.IsNullOrWhiteSpace(textBoxNomHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresseHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxVilleHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxCPHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrixHotel.Text) ||
                string.IsNullOrWhiteSpace(textBoxNbEtoileHotel.Text)
            )
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //On demande à l'utilisateur de confirmer la modification
                if (MessageBox.Show("Etes-vous sûr de vouloir modifier le hebergement ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //L'utilisateur confirme la modification des valeurs
                        Passerelle.ModifierHebergement(hebergementSelectionne.idHebergement, textBoxNomHotel.Text, textBoxAdresseHotel.Text, textBoxVilleHotel.Text, textBoxCPHotel.Text, textBoxTelHotel.Text, int.Parse(textBoxNbEtoileHotel.Text), int.Parse(textBoxPrixHotel.Text));

                        //On actualise la comboBox
                        int index = comboBoxIdHotel.SelectedIndex; //On sauvegarde l'index du hebergement modifié
                        comboBoxIdHotel.DataSource = Passerelle.GetLesHebergements(); //On recharge tous les hebergements dans la comboBox
                        comboBoxIdHotel.SelectedIndex = index; //On sélectionne l'index du hebergement modifié dans la comboBox
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //On affiche à nouveau le détail du hebergement
                    textBoxNomHotel.Text = hebergementSelectionne.nomHebergement;
                    textBoxAdresseHotel.Text = hebergementSelectionne.adresse;
                    textBoxVilleHotel.Text = hebergementSelectionne.ville;
                    textBoxCPHotel.Text = hebergementSelectionne.cp;
                    textBoxTelHotel.Text = hebergementSelectionne.tel;
                    textBoxNbEtoileHotel.Text = hebergementSelectionne.nbEtoile.ToString();
                    textBoxPrixHotel.Text = hebergementSelectionne.prix.ToString();
                }
            }
        }

        private void BtnAnnulerModifHotel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIdHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A chaque changement d'index dans la comboBox, on récupère le voyage selectionné
            Hebergement hotelSelectionne = (Hebergement)comboBoxIdHotel.SelectedItem;

            //On affiche son détail dans les TextBox
            AfficheDetailHotel(hotelSelectionne);
        }

        private void AfficheDetailHotel(Hebergement unHotel)
        {
            //On affiche dans les différents composants les données de l'objet voyage passé en paramètre
            textBoxNomHotel.Text = unHotel.nomHebergement;
            textBoxAdresseHotel.Text = unHotel.adresse;
            textBoxVilleHotel.Text = unHotel.ville;
            textBoxCPHotel.Text = unHotel.cp;
            textBoxTelHotel.Text = unHotel.tel;
            textBoxNbEtoileHotel.Text = unHotel.nbEtoile.ToString();
            textBoxPrixHotel.Text = unHotel.prix.ToString();
        }
    }
}
