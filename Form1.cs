using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Pantalla.Text += 0;
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "+";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        void Calcular()
        {
            string Operacion = Pantalla.Text; //Guardamos en una variable de tipo string llamado operación el texto que está en pantalla
            DataTable mitable = new DataTable();
            Object resultadoDeComputar = mitable.Compute(Operacion, "");
            string resultadoATexto = resultadoDeComputar.ToString();
            Pantalla.Text = resultadoATexto;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "-";
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "*";
        }

        private void buttonDivir_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "/";
        }
    }
}
