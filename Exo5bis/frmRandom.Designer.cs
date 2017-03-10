namespace Exo5bis
{
    partial class frmRandom
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
            this.lblRandom = new System.Windows.Forms.Label();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(13, 13);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(68, 13);
            this.lblRandom.TabIndex = 0;
            this.lblRandom.Text = "Nbr Aléatoire";
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(107, 10);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.ReadOnly = true;
            this.txtRandom.Size = new System.Drawing.Size(100, 20);
            this.txtRandom.TabIndex = 1;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(43, 48);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 2;
            this.btnActualiser.Text = "&Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.Location = new System.Drawing.Point(137, 48);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmRandom
            // 
            this.AcceptButton = this.btnActualiser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(224, 83);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.lblRandom);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.Activated += new System.EventHandler(this.frmRandom_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;
    }
}