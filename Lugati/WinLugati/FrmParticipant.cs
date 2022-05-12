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
    public partial class FrmParticipant : Form
    {
        public FrmParticipant()
        {
            InitializeComponent();
        }

        private void FrmParticipant_Load(object sender, EventArgs e)
        {
            bindingSourceParticipant.DataSource = Passerelle.GetLesParticipants();
            comboBoxParticipant.DataSource = Passerelle.GetLesParticipants();
        }
    }
}
