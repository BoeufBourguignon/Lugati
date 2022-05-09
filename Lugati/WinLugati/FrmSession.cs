using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passerelle;

namespace WinLugati
{
    public partial class FrmSession : Form
    {
        public FrmSession()
        {
            InitializeComponent();
        }

        private void FrmSession_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Session uneSession in Passerelle.Passerelle.GetLesSessions())
                {
                    string[] row = { uneSession.numSession.ToString(), uneSession.libelle, uneSession.tarif.ToString(), uneSession.nbPlaces.ToString(), uneSession.date.ToString(), uneSession.heure };
                    dataGridSession.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    //On charge la comboBox avec tous les voyages de la base de données au chargement du formulaire
            //    //comboBoxIdHotel.DataSource = Passerelle.Passerelle.GetLesHebergements();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erreur au chargement des données :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}
        }
    }
}
