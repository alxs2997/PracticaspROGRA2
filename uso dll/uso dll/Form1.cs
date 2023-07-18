using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sumadll;
using restadll;

namespace uso_dll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            Class1 suma = new Class1();
            MessageBox.Show("El total de la suma es de " + suma.suma(x, y).ToString());
            rest operaciones = new rest();
            MessageBox.Show("El total de la resta es de " + operaciones.resta(x, y).ToString());
            MessageBox.Show("El total de la division es de " + operaciones.div(x, y).ToString());
            MessageBox.Show("El total de la multiplicacion es de " + operaciones.mul(x, y).ToString());
        }
    }
}