using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_CarlosLucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            if(NumerotextBox.Text==string.Empty)
            {
                errorProvider1.SetError(NumerotextBox,"Ingresa un numero positivo o negativo");
                return;
            }else
            {

                int numero = Convert.ToInt32(NumerotextBox.Text);

                Informacionlabel.Text = "El numero ingresado es: " + numero;

            if(NumeroPar(numero))
            {
                Parlabel.Text = "Es un numero par";
     
            }else
            {
                Parlabel.Text = "Es un numero Impar";
            }

            if (NumeroPositivo(numero))
            {
                Positivolabel.Text = "Es un numero positivo";
            }
            else
            {
                Positivolabel.Text = "Es un numero negativo";
            }
                NumerotextBox.Text = string.Empty;
            }
        }

        //Funcion que determina si un numero es par
        private bool NumeroPar(int num)
        {
            bool Par = false;
            if(num%2==0)
            {
                Par = true;
            }
            return Par;
        }

        //Funcion que determina si un numero es positivo
        private bool NumeroPositivo(int num)
        {
            bool Positivo = false;
            if(num>=0)
            {
                Positivo = true;
            }
            return Positivo;
        }

        //Evento que permite entrada numerica en textBox unicamente y excepcion del signo menos
        private void NumerotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
