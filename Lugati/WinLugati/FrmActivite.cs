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
        }

        private void FrmActivite_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Activite uneActivite in Passerelle.Passerelle.GetLesActivites())
                {
                    string[] row = { uneActivite.numActivite.ToString(), uneActivite.libelle, uneActivite.tarif.ToString(), uneActivite.nbPlaces.ToString(), uneActivite.date.ToString(), uneActivite.heure };
                    dataGridActivite.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
