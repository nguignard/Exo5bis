namespace Exo5bis
{
    partial class frmChrono
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
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Location = new System.Drawing.Point(13, 13);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(41, 13);
            this.lblChrono.TabIndex = 0;
            this.lblChrono.Text = "Chrono";
            // 
            // txtChrono
            // 
            this.txtChrono.Location = new System.Drawing.Point(100, 10);
            this.txtChrono.Name = "txtChrono";
            this.txtChrono.ReadOnly = true;
            this.txtChrono.Size = new System.Drawing.Size(100, 20);
            this.txtChrono.TabIndex = 1;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(27, 52);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 2;
            this.btnActualiser.Text = "&Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(125, 52);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // frmChrono
            // 
            this.AcceptButton = this.btnActualiser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(215, 85);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.txtChrono);
            this.Controls.Add(this.lblChrono);
            this.Name = "frmChrono";
            this.Text = "frmChrono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.TextBox txtChrono;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;
    }
}