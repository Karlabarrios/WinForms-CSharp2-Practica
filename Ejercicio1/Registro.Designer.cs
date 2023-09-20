
namespace Ejercicio1
{
    partial class Registro
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
            this.btnFinal = new System.Windows.Forms.Button();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.Gold;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinal.Font = new System.Drawing.Font("04b", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.Location = new System.Drawing.Point(324, 115);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(66, 35);
            this.btnFinal.TabIndex = 0;
            this.btnFinal.Text = "Okay!";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // lvRegistro
            // 
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(12, 47);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(295, 103);
            this.lvRegistro.TabIndex = 1;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("04b", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistro.Location = new System.Drawing.Point(12, 21);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(299, 12);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Usted ha quedado registrado";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(403, 166);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.btnFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.Label lblRegistro;
    }
}