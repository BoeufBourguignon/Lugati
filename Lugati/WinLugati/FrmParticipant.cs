using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lugati;

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

            //bindingSourceParticipant.DataSource = (Participant)comboBoxParticipant.SelectedItem;
        }

        private void btnValiderParticipant_Click(object sender, EventArgs e)
        {
            this.bindingSourceParticipant.EndEdit();

            Participant PartAAjouter = (Participant)this.bindingSourceParticipant.Current;

            try
            {
                Passerelle.AddPart(PartAAjouter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnulerParticipant_Click(object sender, EventArgs e)
        {
            this.bindingSourceParticipant.CancelEdit();
        }
    }
}
