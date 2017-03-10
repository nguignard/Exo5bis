using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo5bis
{
    public partial class frmMdi : Form
    {
        frmExo5 frmPrinc;
        frmChrono frmC;
        frmRandom frmR;


        public frmMdi()
        {
            InitializeComponent();

            this.frmPrinc = new frmExo5();
            this.frmPrinc.MdiParent = this;
            this.frmPrinc.Show();
        }

        //FERMETURE FENETRE MDI////////////////////////////////////////
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment fermer", "Exit", MessageBoxButtons.YesNo);

            if (rep == DialogResult.No) e.Cancel = true;
        }



        //OUVERTURE CHRONO ET RANDOMM///////////////////////////////////////
        private void chronoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmC == null)
            {
                this.frmC = new frmChrono();
                this.frmC.MdiParent = this;
                this.frmC.Show();
                this.frmC.FormClosing += new FormClosingEventHandler(fermeChrono);
            }
        }

        private void fermeChrono(object sender, FormClosingEventArgs e)
        {
            frmC = null;
        }



    }
}
