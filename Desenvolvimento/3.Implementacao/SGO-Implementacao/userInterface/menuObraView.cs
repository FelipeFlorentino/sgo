using sgo.controller;
using sgo.model.business;
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
    public partial class menuObraView : Form
    {
        private Thread nf;
        private int codigoObra;
        public menuObraView(int codigo)
        {
            InitializeComponent();
            codigoObra = codigo;
        }
        private void BtnEtapas_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuEtapas);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuFuncionarios);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void BtnGraficos_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuGraficos);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Obra objObra;
            ObraCtrl objObraCtrl;
            try
            {
                objObra = new Obra();
                objObraCtrl = new ObraCtrl();

                string mensagem = objObraCtrl.verificarStatus(this.codigoObra);
                if (mensagem == "Não Iniciada")
                {
                    if (MessageBox.Show("Deseja Iniciar a Obra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        try
                        {
                            objObra = new Obra();
                            objObraCtrl = new ObraCtrl();

                            DateTime dataAtual;
                            dataAtual = System.DateTime.Now;

                            bool resultado = objObraCtrl.iniciar(dataAtual, this.codigoObra);

                            if (resultado)
                            {
                                MessageBox.Show("Obra Iniciada com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("Obra Não Iniciada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (mensagem == "Em Andamento")
                {
                    MessageBox.Show("Obra Em Andamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button1);
                }
                else if (mensagem == "Finalizada")
                {
                    MessageBox.Show("Obra Já Finalizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                              MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Obra objObra;
            ObraCtrl objObraCtrl;
            try
            {
                objObra = new Obra();
                objObraCtrl = new ObraCtrl();

                string mensagem = objObraCtrl.verificarStatus(this.codigoObra);

                if (mensagem == "Em Andamento")
                {
                    if (MessageBox.Show("Deseja Finalizar a Obra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        try
                        {
                            objObra = new Obra();
                            objObraCtrl = new ObraCtrl();

                            DateTime dataAtual;
                            dataAtual = System.DateTime.Now;

                            bool resultado = objObraCtrl.finalizar(dataAtual, this.codigoObra);

                            if (resultado)
                            {
                                MessageBox.Show("Obra Finalizada com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("Obra Não Finalizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (mensagem == "Não Iniciada")
                {
                    MessageBox.Show("Obra Não Iniciada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                }
                else if (mensagem == "Finalizada")
                {
                    MessageBox.Show("Obra Já Finalizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuRelatorios);
            nf.SetApartmentState(ApartmentState.STA);
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
            nf = new Thread(menuInicial);
            nf.Start();
        }
        private void menuInicial()
        {
            Application.Run(new menuInicialView());
        }
        private void menuEtapas()
        {
            Application.Run(new etapaView(codigoObra));
        }
        private void menuFuncionarios()
        {
            Application.Run(new menuFuncionarioView(codigoObra));
        }
        private void menuGraficos()
        {
            Application.Run(new graficosView(codigoObra));
        }
        private void menuRelatorios()
        {
            Application.Run(new relatorioGastosView(codigoObra));
        }
    }
}