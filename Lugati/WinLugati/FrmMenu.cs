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

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
          if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
              e.Cancel = true;
        }

        private void frmParticipantToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmActiviteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmActivite"] == null)
            {
                FrmActivite frmA = new FrmActivite();
                frmA.MdiParent = this;
                frmA.Show();
            }
            else
            {
                Application.OpenForms["FrmActivite"].BringToFront();

            }
        }

        private void frmLigueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmLigue"] == null)
            {
                FrmLigue frmL = new FrmLigue();
                frmL.MdiParent = this;
                frmL.Show();
            }
            else
            {
                Application.OpenForms["FrmLigue"].BringToFront();

            }
        }
    }
}
