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
    public partial class FrmAnimateur : Form
    {
        public FrmAnimateur()
        {
            InitializeComponent();
        }

        private void FrmAnimateur_Load(object sender, EventArgs e)
        {
            try
            {
                this.bindingSourceAnimateur.DataSource = Passerelle.GetLesAnimateurs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
