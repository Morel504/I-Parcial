﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void HornearButton_Click(object sender, EventArgs e)
        {
            HornearPizza();
            MessageBox.Show("Mensaje Normal");
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void HornearAzincronoButton_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            MessageBox.Show("Mensaje Async");

        }

        private async void CalcularButton1_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal total = await SumarAsync(num1, num2);

            MessageBox.Show($"La suma es: {total}");
        }

        private async Task<decimal> SumarAsync(decimal n1, decimal n2)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;
            });
            return suma;
        }





    }
}
