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
    public partial class frmRandom : Form
    {
        public frmRandom()
        {
            InitializeComponent();
            this.affiche();
        }

        private void affiche()
        {
            this.txtRandom.Text = Donnees.Nombre.ToString();
        }

        
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            this.affiche();
        }

        private void frmRandom_Activated(object sender, EventArgs e)
        {
            this.affiche();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
