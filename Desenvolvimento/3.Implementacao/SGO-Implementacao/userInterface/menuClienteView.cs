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
    public partial class menuClienteView : Form
    {
        private Thread nf;
        public menuClienteView()
        {
            InitializeComponent();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            manterClienteView objManterCliente = new manterClienteView();
            objManterCliente.btnAlterar.Visible = false;
            objManterCliente.btnRemover.Visible = false;
            objManterCliente.ShowDialog();
        }
        private void BtnEmail_Click(object sender, EventArgs e)
        {
            emailView objEmail = new emailView();
            objEmail.ShowDialog();
        }
        private void BtnManter_Click(object sender, EventArgs e)
        {
            consultarClienteView objConsultarCliente = new consultarClienteView();
            objConsultarCliente.ShowDialog();
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
            nf = new Thread(menuInicial);
            nf.Start();
        }
        private void menuInicial()
        {
            Application.Run(new menuInicialView());
        }
    }
}