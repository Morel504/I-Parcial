using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace IParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }


        Cochce miCoche = null;
        List<Cochce> Listacoches = new List <Cochce>();

        private void button1_Click(object sender, EventArgs e)
        {
            //Cochce miCoche = new Cochce();
            //Cochce miCoche2= new Cochce("Toyota", "22R");

            string marca = MarcaTextBox1.Text;
            string modelo = ModeloTextBox5.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox2.Text);
            int km = Convert.ToInt32(PrecioTextBox2.Text);

            miCoche= new Cochce();
            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros= km;

            Listacoches.Add(miCoche);
            CochesDataGridView1.DataSource= null;
            CochesDataGridView1.DataSource = Listacoches;
            //MessageBox.Show("Objeto Cocche -->v Marca:" + miCoche.Marca + " Modelo: "+miCoche.Modelo);
            LimpiarControles();
            MarcaTextBox1.Focus();
        }

        private void LimpiarControles()
        {
            MarcaTextBox1.Clear();
            ModeloTextBox5.Clear();
            PrecioTextBox2.Clear();
            KilometrosTextBox3.Clear();
        }

    }
}
