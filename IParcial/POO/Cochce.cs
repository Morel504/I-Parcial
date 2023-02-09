using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cochce
    {
        //Atrinutos
        private string marca;
        private string modelo;
        private decimal precio;

        //Propiedades
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get => modelo; set => modelo = value;
        }
        public decimal Precio { get;set }

        public int Kilometros { get;set; }

        //Constructores
        public Cochce() { }
        public Cochce(string _marca, string _modelo) 
        {
            Marca = _marca;
            Modelo = _modelo;
        }

        public Cochce(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }

        public string DevolverDatosBasicos ()
        {
            return "Marca: "+ Marca+ "Modelo:" + Modelo + "Precio" + Precio ;
        }


    }
}
