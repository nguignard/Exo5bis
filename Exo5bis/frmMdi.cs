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
        public frmMdi()
        {
            InitializeComponent();

            frmExo5 frmPrinc = new frmExo5();
            frmPrinc.MdiParent = this;
            frmPrinc.Show();
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

            if (rep == DialogResult.No) e.Cancel=true;
        }
    }
}
