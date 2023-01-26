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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Sumabutton1_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Numero1textBox1);
            decimal numero2 = Convert.ToDecimal(Numero2textBox2);

            decimal resultado = numero1+ numero2;

            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}
