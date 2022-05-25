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
        }

        private void FrmLigue_Load(object sender, EventArgs e)
        {
            bindingSourceLigue.DataSource = Passerelle.GetLesLigues();
        }
    }
}
