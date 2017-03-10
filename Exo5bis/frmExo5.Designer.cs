namespace Exo5bis
{
    partial class frmExo5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChrono = new System.Windows.Forms.Label();
            this.txtChrono = new System.Windows.Forms.TextBox();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.lblAleatoire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Location = new System.Drawing.Point(30, 26);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(41, 13);
            this.lblChrono.TabIndex = 0;
            this.lblChrono.Text = "Chrono";
            // 
            // txtChrono
            // 
            this.txtChrono.Location = new System.Drawing.Point(132, 23);
            this.txtChrono.Name = "txtChrono";
            this.txtChrono.ReadOnly = true;
            this.txtChrono.Size = new System.Drawing.Size(100, 20);
            this.txtChrono.TabIndex = 1;
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(132, 58);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.ReadOnly = true;
            this.txtRandom.Size = new System.Drawing.Size(100, 20);
            this.txtRandom.TabIndex = 3;
            // 
            // lblAleatoire
            // 
            this.lblAleatoire.AutoSize = true;
            this.lblAleatoire.Location = new System.Drawing.Point(30, 61);
            this.lblAleatoire.Name = "lblAleatoire";
            this.lblAleatoire.Size = new System.Drawing.Size(88, 13);
            this.lblAleatoire.TabIndex = 2;
            this.lblAleatoire.Text = "Nombre Aléatoire";
            // 
            // frmExo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 109);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.lblAleatoire);
            this.Controls.Add(this.txtChrono);
            this.Controls.Add(this.lblChrono);
            this.Name = "frmExo5";
            this.Text = "frmExo5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExo5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.TextBox txtChrono;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Label lblAleatoire;
    }
}