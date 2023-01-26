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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            if (Numero1textBox1.Text == "")
            {
                errorProvider1.SetError(OperacionescomboBox1, "Ingrese un valor");
                return;
            }
            if (Numero2textBox2.Text == "")
            {
                errorProvider1.SetError(OperacionescomboBox1, "Ingrese un valor");
                return;
            }

            if (OperacionescomboBox1.Text == "")
            {
                errorProvider1.SetError(OperacionescomboBox1, "Selecciones una opcion");
                return;
            }
            errorProvider1.Clear();
            Decimal resultado = Ejecutar(Convert.ToDecimal(Numero1textBox1), Convert.ToDecimal(Numero2textBox2));
            Resultadolabel.Text = Convert.ToString(resultado);
        }

        private decimal Ejecutar(decimal n1, Decimal n2)
        {
            string operacion = OperacionescomboBox1.Text;
            decimal resultado = 0;
            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicacion")
                {
                resultado = n1 * n2;
            }
            else if (operacion == "Division")
            {
                resultado = n1 / n2;
            }
            return resultado;
        }



    }
}
