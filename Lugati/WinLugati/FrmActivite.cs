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
    public partial class FrmActivite : Form
    {
        public FrmActivite()
        {
            InitializeComponent();

            dataGridActivite.DataSource = Passerelle.GetLesActivites();
        }

        private void BtnAjouterHebergement_Click(object sender, EventArgs e)
        {
            labelLibelleActivite.Visible = true;
            labelTarifActivite.Visible = true;
            labelNbPlacesActivite.Visible = true;
            labelDateActivite.Visible = true;
            labelHeureActivite.Visible = true;

            textBoxLibelleActivite.Visible = true;
            textBoxTarifActivite.Visible = true;
            textBoxNbPlacesActivite.Visible = true;
            textBoxDateActivite.Visible = true;
            textBoxHeureActivite.Visible = true;

            BtnValiderActivite.Visible = true;
            BtnAnnulerActivite.Visible = true;
        }
    }
}
