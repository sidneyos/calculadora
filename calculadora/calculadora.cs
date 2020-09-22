using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresultado.Text = "";

        }

        private void btnadicao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 + num2;

            txtresultado.Text = resultado.ToString();
        }

        private void btnsubitracao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 - num2;

            txtresultado.Text = resultado.ToString();
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 * num2;

            txtresultado.Text = resultado.ToString();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 / num2;

            txtresultado.Text = resultado.ToString();
        }
    }
}
