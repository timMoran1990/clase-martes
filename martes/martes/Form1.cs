using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using operaciones;

namespace martes
{
    public partial class Form1 : Form
    {
        Operacion ingreso;
        resta ingreso2;
        multi ingreso3;
        div ingreso4;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(textBox1.Text);
            ingreso.V2 = double.Parse(textBox2.Text);
            label3.Text=ingreso.calcular().ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingreso2 = new resta();
            ingreso2.R1 = double.Parse(textBox1.Text);
            ingreso2.R2 = double.Parse(textBox2.Text);
            label3.Text = ingreso2.calcular().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingreso3 = new multi();
            ingreso3.M1 = double.Parse(textBox1.Text);
            ingreso3.M2 = double.Parse(textBox2.Text);
            label3.Text = ingreso3.calcular().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingreso4 = new div();
            ingreso4.D1 = double.Parse(textBox1.Text);
            ingreso4.D2 = double.Parse(textBox2.Text);
            label3.Text = ingreso4.calcular().ToString();
        }
    }
}
