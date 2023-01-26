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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        decimal sumaTotal;
        private void Sumabutton_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Numero1textBox);
            decimal numero2 = Convert.ToDecimal(Numero2textBox);

            //decimal resultado = numero1+ numero2;

            //MessageBox.Show("El resultado es: " + resultado);

            Sumar(numero1, numero2);
            MessageBox.Show("La suma es: " +sumaTotal,"Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void Sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        }


    }
}
