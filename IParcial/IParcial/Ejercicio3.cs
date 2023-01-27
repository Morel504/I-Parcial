using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void LongitudTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EjecutarButton1_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox1.Text;
            LongitudTextBox1.Text = cadena.Length.ToString();

            PrimerCaracterTextBox.Text = cadena.Substring(0,1);
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);
            
            MayusculasTextBox1.Text = cadena.ToUpper();
            MinusculasTextBox1.Text = cadena.ToLower();
            ReemplazarTextBox1.Text = cadena.Replace("Ian Morel", "MUY GUAPOOOOO");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
