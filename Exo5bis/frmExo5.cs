﻿using System;
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

    public partial class frmExo5 : Form
    {

        private Random random = new Random();


        public frmExo5()
        {
            InitializeComponent();
            Donnees.Temps = 0;
            Donnees.Nombre = 0;
            this.affiche();
        }

        private void frmExo5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        // CREATION DU Chrono et du random
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.affiche();
        }

        //
        public void affiche()
        {
            Donnees.Temps++;
            this.txtChrono.Text = Donnees.Temps.ToString();

            Donnees.Nombre = random.NextDouble();
            this.txtRandom.Text = Donnees.Nombre.ToString();
        }

    }
}
