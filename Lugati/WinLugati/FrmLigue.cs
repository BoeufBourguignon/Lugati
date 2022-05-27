using Lugati.dll;
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
    public partial class FrmLigue : Form
    {
        public FrmLigue()
        {
            InitializeComponent();

            this.InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                this.bindingSourceLigue.DataSource = Passerelle.GetLesLigues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
