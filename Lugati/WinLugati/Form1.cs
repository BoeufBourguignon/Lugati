using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLugati
{
    public partial class FrmHebergement : Form
    {
        public FrmHebergement()
        {
            InitializeComponent();

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Permet de faire d'ajouter dans le datagrid chaque ligne de données liées à la Table Hebergement.
            try
            {
                foreach (Hebergement unHebergement in Passerelle.Passerelle.GetLesHebergements())
                {
                    string[] row = { unHebergement.idHebergement.ToString(), unHebergement.nomHebergement, unHebergement.adresse, unHebergement.ville, unHebergement.cp, unHebergement.tel, unHebergement.nbEtoile.ToString(), unHebergement.prix.ToString()};
                    dataGridHebergement.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    int idHotel = Passerelle.Passerelle.GetIdHebergement(textBoxNomHotel.Text, textBoxAdresseHotel.Text, textBoxVilleHotel.Text, textBoxCPHotel.Text, textBoxTelHotel.Text, int.Parse(textBoxNbEtoileHotel.Text), int.Parse(textBoxPrixHotel.Text));
                    if (idHotel == 0)
                    {
                        idHotel = Passerelle.Passerelle.AjouterHebergement(textBoxNomHotel.Text, textBoxAdresseHotel.Text, textBoxVilleHotel.Text, textBoxCPHotel.Text, textBoxTelHotel.Text, int.Parse(textBoxNbEtoileHotel.Text), int.Parse(textBoxPrixHotel.Text));
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
    }
}
