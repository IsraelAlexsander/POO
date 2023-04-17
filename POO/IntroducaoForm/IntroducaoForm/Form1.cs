using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoForm
{
    public delegate double Operacao(double a, double b);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

        public double Soma(double a, double b)
        {
            return a + b;
        }
        public double Subtracao(double a, double b)
        {
            return a - b;
        }
        public double Multiplicacao(double a, double b)
        {
            return a * b;
        }
        public double Divisao(double a, double b)
        {
            return a / b;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double x, y;
            double Result;

            Operacao Somar = new Operacao(Soma);

            x = double.Parse(txtA.Text);
            y = double.Parse(txtB.Text);

            Result = Somar(x, y);

            txtResult.Text = Result.ToString("N2");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double x, y;
            double Result;

            Operacao Subtrair = new Operacao(Subtracao);

            x = double.Parse(txtA.Text);
            y = double.Parse(txtB.Text);

            Result = Subtrair(x, y);

            txtResult.Text = Result.ToString("N2");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double x, y;
            double Result;

            Operacao Multiplicar = new Operacao(Multiplicacao);

            x = double.Parse(txtA.Text);
            y = double.Parse(txtB.Text);

            Result = Multiplicar(x, y);

            txtResult.Text = Result.ToString("N2");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double x, y;
            double Result;

            Operacao Dividir = new Operacao(Divisao);

            x = double.Parse(txtA.Text);
            y = double.Parse(txtB.Text);

            Result = Dividir(x, y);

            txtResult.Text = Result.ToString("N2");
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtB.Focus();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text != "" && txtB.Text != "")
            {
                btnSomar.Enabled = true;
                btnDividir.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplicar.Enabled = true;
            }
            else
            {
                btnSomar.Enabled = false;
                btnDividir.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text != "" && txtB.Text != "")
            {
                btnSomar.Enabled = true;
                btnDividir.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplicar.Enabled = true;
            }
            else
            {
                btnSomar.Enabled = false;
                btnDividir.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
            }
        }
    }
}
