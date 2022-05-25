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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuLugatiItemParticipant_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmParticipant"] == null)
            {
                FrmParticipant frmParticipant = new FrmParticipant();
                frmParticipant.MdiParent = this;
                frmParticipant.Show();
            }
            else
            {
                Application.OpenForms["FrmParticipant"].BringToFront();

            }
        }

        private void frmHebergementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmHebergement"] == null)
            {
                FrmHebergement frmH = new FrmHebergement();
                frmH.MdiParent = this;
                frmH.Show();
            }
            else
            {
                Application.OpenForms["FrmHebergement"].BringToFront();

            }
        }

        private void frmSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmSession"] == null)
            {
                FrmSession frmS = new FrmSession();
                frmS.MdiParent = this;
                frmS.Show();
            }
            else
            {
                Application.OpenForms["FrmSession"].BringToFront();

            }
        }

        private void menuLugatiItemActivite_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmActivite"] == null)
            {
                FrmActivite frmS = new FrmActivite();
                frmS.MdiParent = this;
                frmS.Show();
            }
            else
            {
                Application.OpenForms["FrmActivite"].BringToFront();

            }
        }
    }
}
