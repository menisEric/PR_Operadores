using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prOperadores2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double suma, resta, mult, div, pot, raiz;

            num1 = double.Parse(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);

            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            pot = Math.Pow(num1, num2);
            raiz = Math.Pow(num1, (1 / num2));

            txtsuma.Text = Convert.ToString(suma);
            txtresta.Text = Convert.ToString(resta);
            txtmulti.Text = Convert.ToString(mult);
            txtdivision.Text = Convert.ToString(div);
            txtpotencia.Text = Convert.ToString(pot);
            txtraiz.Text = Convert.ToString(raiz);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtsuma.Clear();
            txtresta.Clear();
            txtraiz.Clear();
            txtpotencia.Clear();
            txtmulti.Clear();
            txtdivision.Clear();
        }
    }
}
