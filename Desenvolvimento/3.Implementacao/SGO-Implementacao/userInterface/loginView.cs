using sgo.controller;
using sgo.model.business;
using sgo.userInterface;
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

namespace sgo
{
    public partial class loginView : Form
    {
        Thread nf;
        public loginView()
        {
            InitializeComponent();
        }
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Login objLogin;
            LoginCtrl objLoginCtrl;
            try
            {
                objLogin = new Login();
                objLoginCtrl = new LoginCtrl();
                string login = this.txtLogin.Text;
                string senha = this.txtSenha.Text;
                objLogin.setLogin(login);
                objLogin.setSenha(senha);
                if (login == "")
                {
                    MessageBox.Show("Campo Login Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else if (senha == "")
                {
                    MessageBox.Show("Campo Senha Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    bool resultado = objLoginCtrl.logar(objLogin);
                    if (resultado)
                    {
                        this.Close();
                        nf = new Thread(newForm);
                        nf.SetApartmentState(ApartmentState.STA);
                        nf.Start();
                    }
                    else
                    {
                        MessageBox.Show("Login Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void newForm()
        {
            Application.Run(new menuInicialView());
        }
    }
}