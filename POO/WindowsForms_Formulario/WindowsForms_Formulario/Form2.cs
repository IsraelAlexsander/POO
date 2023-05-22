using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Formulario
{
    public partial class frmIncremento : Form
    {
        FrmContagem FormContagem;

        public frmIncremento(FrmContagem F)
        {
            InitializeComponent();
            FormContagem = F;

            lblContagem.Text = FormContagem.txtContagem.Text;
        }

        private void btnFechaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int Valor = int.Parse(FormContagem.txtContagem.Text);
            Valor++;

            FormContagem.txtContagem.Text = Valor.ToString();

            lblContagem.Text = Valor.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int Valor = int.Parse(FormContagem.txtContagem.Text);
            Valor--;

            FormContagem.txtContagem.Text = Valor.ToString();

            lblContagem.Text = Valor.ToString();
        }
    }
}
