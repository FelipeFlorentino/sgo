using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgo.userInterface
{
    public partial class etapaAnotacao : Form
    {
        public etapaAnotacao()
        {
            InitializeComponent();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s;
            int i = 0, linhas = 0;
            this.openFD.ShowDialog();
            if (this.openFD.FileName.Length > 0)
            {
                s = System.IO.File.ReadAllText(this.openFD.FileName);
                while (i < s.Length)
                {
                    if (s[i].CompareTo('\n') == 0)
                    {
                        linhas++;
                    }
                    i++;
                }
                this.txtTexto.Clear();
                this.txtTexto.AppendText(s);
            }
        }
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFD.Filter = "txt files(*.txt) | *.txt | All files(*.*) | *.* ";
            saveFD.Title = "Arquivo de Texto";
            this.saveFD.ShowDialog();
            if (this.saveFD.FileName.Length > 0)
            {
                System.IO.File.WriteAllLines(this.saveFD.FileName, this.txtTexto.Lines);
            }
            else
            {
                DialogResult result = MessageBox.Show("Não Salvou. Deseja salvar?", "Caixa de Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Tente de novo.");
                }
            }
        }
        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog.ShowDialog();
            this.txtTexto.Font = this.fontDialog.Font;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}