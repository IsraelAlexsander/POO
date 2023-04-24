using System;
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
    public partial class trkVolume : Form
    {
        public trkVolume()
        {
            InitializeComponent();
        }

        private void rdoMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMasculino.Checked)
            {
                MessageBox.Show("Marcada a Opção " + rdoMasculino.Text,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdoFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFeminino.Checked)
            {
                MessageBox.Show("Marcada a Opção " + rdoFeminino.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkBackup_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBackup.Checked)
            {
                MessageBox.Show("Backup Ativo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Backup Desativado pelo Usário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Cidade Escolhida: " + cboEstados.Text, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkPUCMINAS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkPUCMINAS.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.pucminas.br");
        }

        private void mthCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Data Selecionada: " + e.Start.ToShortDateString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nmcVolume_ValueChanged(object sender, EventArgs e)
        {
            trVolume.Value = (int)nmcVolume.Value;
            pgsVolume.Value = (int)nmcVolume.Value;
        }

        private void trVolume_Scroll(object sender, EventArgs e)
        {
            pgsVolume.Value = trVolume.Value;
            nmcVolume.Value = trVolume.Value;
        }
    }
}
