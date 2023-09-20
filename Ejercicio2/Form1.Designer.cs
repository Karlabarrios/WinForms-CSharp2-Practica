
namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPresentación = new System.Windows.Forms.Label();
            this.btnFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPresentación
            // 
            this.lblPresentación.AutoSize = true;
            this.lblPresentación.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPresentación.Location = new System.Drawing.Point(36, 28);
            this.lblPresentación.Name = "lblPresentación";
            this.lblPresentación.Size = new System.Drawing.Size(263, 26);
            this.lblPresentación.TabIndex = 0;
            this.lblPresentación.Text = "Da click aquí si amas vivir";
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(95, 82);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(154, 43);
            this.btnFinal.TabIndex = 1;
            this.btnFinal.Text = "Sí, amo la vida";
            this.btnFinal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 174);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.lblPresentación);
            this.Name = "Form1";
            this.Text = "aMAS VIVIR?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresentación;
        private System.Windows.Forms.Button btnFinal;
    }
}

