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

        private void participantToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void hebergementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["FrmHebergement"] == null)
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

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void activiteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
