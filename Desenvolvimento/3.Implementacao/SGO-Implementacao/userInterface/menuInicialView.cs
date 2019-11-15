﻿using System;
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
    public partial class menuInicialView : Form
    {
        Thread nf;
        public menuInicialView()
        {
            InitializeComponent();
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(clienteForm);
            nf.Start();
        }
        private void BtnGerenciarObra_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(obraForm);
            nf.Start();
        }
        private void BtnNovaObra_Click(object sender, EventArgs e)
        {
            cadastrarObraView objObraForm = new cadastrarObraView();
            objObraForm.ShowDialog();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(loginForm);
            nf.Start();
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
            nf = new Thread(loginForm);
            nf.Start();
        }
        private void loginForm()
        {
            Application.Run(new loginView());
        }
        private void novaObraForm()
        {
            Application.Run(new cadastrarObraView());
        }
        private void obraForm()
        {
            Application.Run(new selecionarObraView());
        }
        private void clienteForm()
        {
            Application.Run(new menuClienteView());
        }
    }
}