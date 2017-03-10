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
    public partial class frmChrono : Form
    {
        public frmChrono()
        {
            InitializeComponent();
            this.affiche();
        }

        private void affiche()
        {
            this.txtChrono.Text = Donnees.Temps.ToString();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            this.affiche();
        }

        private void frmChrono_Activated(object sender, EventArgs e)
        {
            this.affiche();
        }
    }
}
