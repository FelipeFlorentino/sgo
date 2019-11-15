using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgo.userInterface
{
    public partial class menuFuncionarioView : Form
    {
        private int obraCodigo;
        private Thread nf;
        public menuFuncionarioView(int codigo)
        {
            InitializeComponent();
            this.obraCodigo = codigo;
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            manterFuncionarioView objManterFuncionario = new manterFuncionarioView(obraCodigo);
            objManterFuncionario.btnAlterar.Visible = false;
            objManterFuncionario.btnRemover.Visible = false;
            objManterFuncionario.ShowDialog();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarFuncionarioView objManterFuncionario = new consultarFuncionarioView(obraCodigo);
            objManterFuncionario.ShowDialog();
        }
        private void BtnEmail_Click(object sender, EventArgs e)
        {
            emailView objEmailView = new emailView();
            objEmailView.ShowDialog();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuObra);
            nf.Start();
        }
        private void menuObra()
        {
            Application.Run(new menuObraView(obraCodigo));
        }
    }
}