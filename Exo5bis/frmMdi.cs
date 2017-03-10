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










    }
}
