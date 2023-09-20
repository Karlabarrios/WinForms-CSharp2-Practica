using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CmboBoxModoJuego.Items.Add("Premium");
            CmboBoxModoJuego.Items.Add("Medio");
            CmboBoxModoJuego.Items.Add("HardCore");
            CmboBoxModoJuego.Items.Add("Subterraneo");
        }
        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            string usuario = TxtBoxNombre.Text;
            DateTime nacimiento = dtFechaNacimiento.Value;

            string Knowledge;
            if (RadBtnInternet.Checked)
                Knowledge = "Se entero por internet o vía web";
            else if (RadBtnPublicidad.Checked)
                Knowledge = "Se entero vía publicidad";
            else
                Knowledge = "Es mi App lmao";

            string Nivel;
            if (RadBtnNivelBajo.Checked)
                Nivel = "Es nivel bajo";
            else if (RadBtnNivelMedio.Checked)
                Nivel = "Es nivel medio";
            else
                Nivel = "Es nivel top";

            string ModoJuego = CmboBoxModoJuego.SelectedItem.ToString();
            string nroRango = numericUpDown1.Value.ToString();
            Registro r1 = new Registro();
            r1.Show();
        }

    }
}
