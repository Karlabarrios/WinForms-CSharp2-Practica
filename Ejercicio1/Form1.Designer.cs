
namespace Ejercicio1
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
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNombreDeJuego = new System.Windows.Forms.Label();
            this.lstvRegistros = new System.Windows.Forms.ListView();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.RadBtnInternet = new System.Windows.Forms.RadioButton();
            this.RadBtnPublicidad = new System.Windows.Forms.RadioButton();
            this.gpBoxKnowledge = new System.Windows.Forms.GroupBox();
            this.RadBtnApp = new System.Windows.Forms.RadioButton();
            this.GrBoxnivel = new System.Windows.Forms.GroupBox();
            this.RadBtnNivelTop = new System.Windows.Forms.RadioButton();
            this.RadBtnNivelMedio = new System.Windows.Forms.RadioButton();
            this.RadBtnNivelBajo = new System.Windows.Forms.RadioButton();
            this.CmboBoxModoJuego = new System.Windows.Forms.ComboBox();
            this.lblModoJuego = new System.Windows.Forms.Label();
            this.lblDescripciónMedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gpBoxKnowledge.SuspendLayout();
            this.GrBoxnivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEjecutar.BackColor = System.Drawing.Color.Gold;
            this.BtnEjecutar.Font = new System.Drawing.Font("04b", 14F, System.Drawing.FontStyle.Bold);
            this.BtnEjecutar.ForeColor = System.Drawing.Color.Black;
            this.BtnEjecutar.Location = new System.Drawing.Point(476, 553);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(191, 67);
            this.BtnEjecutar.TabIndex = 6;
            this.BtnEjecutar.Text = "REGISTRAR";
            this.BtnEjecutar.UseVisualStyleBackColor = false;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Gold;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNombre.Location = new System.Drawing.Point(225, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxNombre.Location = new System.Drawing.Point(285, 103);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtBoxNombre.TabIndex = 0;
            this.TxtBoxNombre.Text = "Nombre o usuario";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Gotham XNarrow Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescription.Location = new System.Drawing.Point(294, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 19);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "BIENVENIDX A";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreDeJuego
            // 
            this.lblNombreDeJuego.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreDeJuego.AutoSize = true;
            this.lblNombreDeJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreDeJuego.Font = new System.Drawing.Font("04b", 20F);
            this.lblNombreDeJuego.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreDeJuego.Location = new System.Drawing.Point(219, 46);
            this.lblNombreDeJuego.Name = "lblNombreDeJuego";
            this.lblNombreDeJuego.Size = new System.Drawing.Size(252, 29);
            this.lblNombreDeJuego.TabIndex = 8;
            this.lblNombreDeJuego.Text = "GAME BOX 1";
            // 
            // lstvRegistros
            // 
            this.lstvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvRegistros.HideSelection = false;
            this.lstvRegistros.Location = new System.Drawing.Point(22, 548);
            this.lstvRegistros.Name = "lstvRegistros";
            this.lstvRegistros.Size = new System.Drawing.Size(165, 72);
            this.lstvRegistros.TabIndex = 9;
            this.lstvRegistros.UseCompatibleStateImageBehavior = false;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaNacimiento.Location = new System.Drawing.Point(285, 136);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNacimiento.TabIndex = 1;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Gold;
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(163, 139);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // RadBtnInternet
            // 
            this.RadBtnInternet.AutoSize = true;
            this.RadBtnInternet.ForeColor = System.Drawing.SystemColors.Control;
            this.RadBtnInternet.Location = new System.Drawing.Point(13, 29);
            this.RadBtnInternet.Name = "RadBtnInternet";
            this.RadBtnInternet.Size = new System.Drawing.Size(92, 17);
            this.RadBtnInternet.TabIndex = 12;
            this.RadBtnInternet.TabStop = true;
            this.RadBtnInternet.Text = "Internet / web";
            this.RadBtnInternet.UseVisualStyleBackColor = true;
            // 
            // RadBtnPublicidad
            // 
            this.RadBtnPublicidad.AutoSize = true;
            this.RadBtnPublicidad.ForeColor = System.Drawing.SystemColors.Control;
            this.RadBtnPublicidad.Location = new System.Drawing.Point(111, 29);
            this.RadBtnPublicidad.Name = "RadBtnPublicidad";
            this.RadBtnPublicidad.Size = new System.Drawing.Size(74, 17);
            this.RadBtnPublicidad.TabIndex = 13;
            this.RadBtnPublicidad.TabStop = true;
            this.RadBtnPublicidad.Text = "Publicidad";
            this.RadBtnPublicidad.UseVisualStyleBackColor = true;
            // 
            // gpBoxKnowledge
            // 
            this.gpBoxKnowledge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpBoxKnowledge.Controls.Add(this.RadBtnApp);
            this.gpBoxKnowledge.Controls.Add(this.RadBtnPublicidad);
            this.gpBoxKnowledge.Controls.Add(this.RadBtnInternet);
            this.gpBoxKnowledge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpBoxKnowledge.Location = new System.Drawing.Point(200, 177);
            this.gpBoxKnowledge.Name = "gpBoxKnowledge";
            this.gpBoxKnowledge.Size = new System.Drawing.Size(298, 68);
            this.gpBoxKnowledge.TabIndex = 2;
            this.gpBoxKnowledge.TabStop = false;
            this.gpBoxKnowledge.Text = "¿Cómo te enteraste del juego?";
            // 
            // RadBtnApp
            // 
            this.RadBtnApp.AutoSize = true;
            this.RadBtnApp.Checked = true;
            this.RadBtnApp.Location = new System.Drawing.Point(199, 29);
            this.RadBtnApp.Name = "RadBtnApp";
            this.RadBtnApp.Size = new System.Drawing.Size(83, 17);
            this.RadBtnApp.TabIndex = 14;
            this.RadBtnApp.TabStop = true;
            this.RadBtnApp.Text = "Es mi app :3";
            this.RadBtnApp.UseVisualStyleBackColor = true;
            // 
            // GrBoxnivel
            // 
            this.GrBoxnivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrBoxnivel.Controls.Add(this.RadBtnNivelTop);
            this.GrBoxnivel.Controls.Add(this.RadBtnNivelMedio);
            this.GrBoxnivel.Controls.Add(this.RadBtnNivelBajo);
            this.GrBoxnivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrBoxnivel.Location = new System.Drawing.Point(200, 267);
            this.GrBoxnivel.Name = "GrBoxnivel";
            this.GrBoxnivel.Size = new System.Drawing.Size(298, 68);
            this.GrBoxnivel.TabIndex = 3;
            this.GrBoxnivel.TabStop = false;
            this.GrBoxnivel.Text = "¿Cuál es tu nivel de juego?";
            // 
            // RadBtnNivelTop
            // 
            this.RadBtnNivelTop.AutoSize = true;
            this.RadBtnNivelTop.Checked = true;
            this.RadBtnNivelTop.Location = new System.Drawing.Point(199, 29);
            this.RadBtnNivelTop.Name = "RadBtnNivelTop";
            this.RadBtnNivelTop.Size = new System.Drawing.Size(76, 17);
            this.RadBtnNivelTop.TabIndex = 14;
            this.RadBtnNivelTop.TabStop = true;
            this.RadBtnNivelTop.Text = "Soy la más";
            this.RadBtnNivelTop.UseVisualStyleBackColor = true;
            // 
            // RadBtnNivelMedio
            // 
            this.RadBtnNivelMedio.AutoSize = true;
            this.RadBtnNivelMedio.ForeColor = System.Drawing.SystemColors.Control;
            this.RadBtnNivelMedio.Location = new System.Drawing.Point(111, 29);
            this.RadBtnNivelMedio.Name = "RadBtnNivelMedio";
            this.RadBtnNivelMedio.Size = new System.Drawing.Size(81, 17);
            this.RadBtnNivelMedio.TabIndex = 13;
            this.RadBtnNivelMedio.TabStop = true;
            this.RadBtnNivelMedio.Text = "Medio / mid";
            this.RadBtnNivelMedio.UseVisualStyleBackColor = true;
            // 
            // RadBtnNivelBajo
            // 
            this.RadBtnNivelBajo.AutoSize = true;
            this.RadBtnNivelBajo.ForeColor = System.Drawing.SystemColors.Control;
            this.RadBtnNivelBajo.Location = new System.Drawing.Point(13, 29);
            this.RadBtnNivelBajo.Name = "RadBtnNivelBajo";
            this.RadBtnNivelBajo.Size = new System.Drawing.Size(94, 17);
            this.RadBtnNivelBajo.TabIndex = 12;
            this.RadBtnNivelBajo.TabStop = true;
            this.RadBtnNivelBajo.Text = "¿Qué es esto?";
            this.RadBtnNivelBajo.UseVisualStyleBackColor = true;
            // 
            // CmboBoxModoJuego
            // 
            this.CmboBoxModoJuego.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmboBoxModoJuego.FormattingEnabled = true;
            this.CmboBoxModoJuego.Location = new System.Drawing.Point(285, 399);
            this.CmboBoxModoJuego.Name = "CmboBoxModoJuego";
            this.CmboBoxModoJuego.Size = new System.Drawing.Size(200, 21);
            this.CmboBoxModoJuego.TabIndex = 4;
            // 
            // lblModoJuego
            // 
            this.lblModoJuego.AutoSize = true;
            this.lblModoJuego.BackColor = System.Drawing.Color.Gold;
            this.lblModoJuego.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblModoJuego.Location = new System.Drawing.Point(158, 402);
            this.lblModoJuego.Name = "lblModoJuego";
            this.lblModoJuego.Size = new System.Drawing.Size(111, 13);
            this.lblModoJuego.TabIndex = 17;
            this.lblModoJuego.Text = "Elije tu modo de juego";
            // 
            // lblDescripciónMedia
            // 
            this.lblDescripciónMedia.AutoSize = true;
            this.lblDescripciónMedia.Font = new System.Drawing.Font("Gotham XNarrow", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciónMedia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescripciónMedia.Location = new System.Drawing.Point(221, 359);
            this.lblDescripciónMedia.Name = "lblDescripciónMedia";
            this.lblDescripciónMedia.Size = new System.Drawing.Size(254, 16);
            this.lblDescripciónMedia.TabIndex = 18;
            this.lblDescripciónMedia.Text = "Estamos por terminar, solo quedan algunos detalles...";
            this.lblDescripciónMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(201, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Elije tu rango";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(285, 435);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(694, 632);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescripciónMedia);
            this.Controls.Add(this.lblModoJuego);
            this.Controls.Add(this.CmboBoxModoJuego);
            this.Controls.Add(this.GrBoxnivel);
            this.Controls.Add(this.gpBoxKnowledge);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.lstvRegistros);
            this.Controls.Add(this.lblNombreDeJuego);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.TxtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnEjecutar);
            this.MaximumSize = new System.Drawing.Size(1086, 780);
            this.MinimumSize = new System.Drawing.Size(710, 671);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de ventana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBoxKnowledge.ResumeLayout(false);
            this.gpBoxKnowledge.PerformLayout();
            this.GrBoxnivel.ResumeLayout(false);
            this.GrBoxnivel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNombreDeJuego;
        private System.Windows.Forms.ListView lstvRegistros;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.RadioButton RadBtnInternet;
        private System.Windows.Forms.RadioButton RadBtnPublicidad;
        private System.Windows.Forms.GroupBox gpBoxKnowledge;
        private System.Windows.Forms.RadioButton RadBtnApp;
        private System.Windows.Forms.GroupBox GrBoxnivel;
        private System.Windows.Forms.RadioButton RadBtnNivelTop;
        private System.Windows.Forms.RadioButton RadBtnNivelMedio;
        private System.Windows.Forms.RadioButton RadBtnNivelBajo;
        private System.Windows.Forms.ComboBox CmboBoxModoJuego;
        private System.Windows.Forms.Label lblModoJuego;
        private System.Windows.Forms.Label lblDescripciónMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

