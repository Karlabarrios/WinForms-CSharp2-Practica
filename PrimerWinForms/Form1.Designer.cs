 
namespace PrimerWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Botón = new System.Windows.Forms.Button();
            this.labelPresentacion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelSuscripción = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Botón
            // 
            this.Botón.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Botón.Location = new System.Drawing.Point(177, 217);
            this.Botón.Name = "Botón";
            this.Botón.Size = new System.Drawing.Size(159, 51);
            this.Botón.TabIndex = 0;
            this.Botón.Text = "Suscribir";
            this.Botón.UseVisualStyleBackColor = false;
            this.Botón.Click += new System.EventHandler(this.Botón_Click);
            // 
            // labelPresentacion
            // 
            this.labelPresentacion.AutoSize = true;
            this.labelPresentacion.Location = new System.Drawing.Point(196, 74);
            this.labelPresentacion.Name = "labelPresentacion";
            this.labelPresentacion.Size = new System.Drawing.Size(129, 13);
            this.labelPresentacion.TabIndex = 1;
            this.labelPresentacion.Text = "Bienvenidx a mi formulario";
            this.labelPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(144, 113);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(144, 143);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(144, 170);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Correo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 258);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(199, 112);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(159, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(199, 140);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(158, 20);
            this.textBoxApellido.TabIndex = 7;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(199, 171);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(158, 20);
            this.textBoxCorreo.TabIndex = 8;
            // 
            // labelSuscripción
            // 
            this.labelSuscripción.AutoSize = true;
            this.labelSuscripción.BackColor = System.Drawing.Color.Pink;
            this.labelSuscripción.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelSuscripción.Location = new System.Drawing.Point(144, 308);
            this.labelSuscripción.Name = "labelSuscripción";
            this.labelSuscripción.Size = new System.Drawing.Size(68, 13);
            this.labelSuscripción.TabIndex = 9;
            this.labelSuscripción.Text = "Confirmación";
            this.labelSuscripción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 380);
            this.Controls.Add(this.labelSuscripción);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelPresentacion);
            this.Controls.Add(this.Botón);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botón;
        private System.Windows.Forms.Label labelPresentacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelSuscripción;
    }
}

