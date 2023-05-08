using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_02
{
    public partial class Form1 : Form
    {
        ArrayList VetorAluno = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (VetorAluno.Count != 0)
            {
                CarregarGrid();
            }
        }

        public void CarregarGrid()
        {
            DGVAluno.DataSource = null;

            DGVAluno.DataSource = VetorAluno;

            DGVAluno.ClearSelection();

            DGVAluno.Columns[0].Width = 190;            
            DGVAluno.Columns[1].Width = 190;            
            DGVAluno.Columns[2].Width = 65;            
            DGVAluno.Columns[3].Width = 110;            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Aluno x = new Aluno();

            x.Nome = "Digite os dados do Aluno...";
            x.Endereco = "";
            x.Telefone = "";
            x.Mail = "";

            VetorAluno.Add(x);

            CarregarGrid();

            DGVAluno.CurrentCell = DGVAluno.Rows[DGVAluno.RowCount - 1].Cells[0];   //Incluir registro na ultima posição
        }

        private void DGVAluno_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Aluno x = new Aluno();

            x.Nome = DGVAluno.CurrentRow.Cells[0].Value.ToString();     //Capturar o que tá escrito na celula
            x.Endereco = DGVAluno.CurrentRow.Cells[1].Value.ToString();     
            x.Telefone = DGVAluno.CurrentRow.Cells[2].Value.ToString();     
            x.Mail = DGVAluno.CurrentRow.Cells[3].Value.ToString();

            VetorAluno[DGVAluno.CurrentRow.Index] = x;      // Salvar dados no Arraylist
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            VetorAluno.RemoveAt(DGVAluno.CurrentRow.Index);

            CarregarGrid();
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            string Nome = txtProcura.Text;

            txtProcura.Text = "";

            DGVAluno.ClearSelection();

            for(int i = 0; i < DGVAluno.RowCount; i++)
            {
                if (DGVAluno.Rows[i].Cells[0].Value.ToString() == Nome)
                {
                    DGVAluno.CurrentCell = DGVAluno.Rows[i].Cells[0];
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);

            //Application.Exit(); 
        }
    }
}
