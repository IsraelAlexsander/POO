using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result = new DialogResult();

            openFileDialog1.Filter = "Documentos do Word 2003|*.doc|Documentos do Word 2007|*.docx";

            Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                textBox1.Text = "Caixa de Diálogo - Arquivo Selecionado..." + Environment.NewLine;
                textBox1.Text += "Nome do Arquivo: " + openFileDialog1.SafeFileName + Environment.NewLine;                
            }
        }
    }
}
