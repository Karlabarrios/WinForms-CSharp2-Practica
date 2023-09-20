using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Botón_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string correo = textBoxCorreo.Text;

            labelSuscripción.Text = "Hola, " + nombre + " " + apellido + " te has suscrito al club de Hola Gata";
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por unirte :)");
        }
    }
}
