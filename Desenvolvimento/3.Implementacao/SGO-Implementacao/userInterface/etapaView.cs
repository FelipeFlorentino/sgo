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
    public partial class etapaView : Form
    {
        private Thread nf;
        private int etapaCodigo;
        private int obraCodigo;
        public etapaView(int codigoObra)
        {
            InitializeComponent();
            this.obraCodigo = codigoObra;
        }
        private void EtapaView_Load(object sender, EventArgs e)
        {
            personalizarDGV1();
            personalizarDGV2();
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Etapa objEtapa;
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapa = new Etapa();
                objEtapaCtrl = new EtapaCtrl();
                int linha = this.dgvRealizado.SelectedCells[0].RowIndex;
                objEtapa.setCodigo(dgvRealizado.Rows[linha].Cells[0].Value.ToString());
                objEtapa.setPercentualConclusao(dgvRealizado.Rows[linha].Cells[2].Value.ToString());
                objEtapa.setDataInicioReal(dgvRealizado.Rows[linha].Cells[3].Value.ToString());
                objEtapa.setDataFimReal(dgvRealizado.Rows[linha].Cells[4].Value.ToString());
                bool mensagem = objEtapaCtrl.atualizar(objEtapa);
                if (mensagem)
                {
                    MessageBox.Show("Etapa Atualizada com Sucesso");
                }
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuAnotacoes);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapaCtrl = new EtapaCtrl();
                int linha = this.dgvRealizado.SelectedCells[0].RowIndex;
                int codigo = Convert.ToInt32(dgvRealizado.Rows[linha].Cells[0].Value.ToString());
                bool mensagem = objEtapaCtrl.finalizar(codigo);
                if (mensagem)
                {
                    MessageBox.Show("Etapa Finalizada com Sucesso");
                }
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnGastos_Click(object sender, EventArgs e)
        {
            int linha = this.dgvRealizado.SelectedCells[0].RowIndex;
            this.etapaCodigo = Convert.ToInt32(dgvRealizado.Rows[linha].Cells[0].Value.ToString());
            this.Close();
            nf = new Thread(menuGastos);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void BtnFotos_Click(object sender, EventArgs e)
        {
            int linha = this.dgvRealizado.SelectedCells[0].RowIndex;
            this.etapaCodigo = Convert.ToInt32(dgvRealizado.Rows[linha].Cells[0].Value.ToString());
            this.Close();
            nf = new Thread(menuImagens);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void BtnGerenciar_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuEtapas);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }
        private void carregaGrid()
        {
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapaCtrl = new EtapaCtrl();
                this.dgvRealizado.DataSource = objEtapaCtrl.realizado(this.obraCodigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void personalizarDGV1()
        {
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapaCtrl = new EtapaCtrl();
                this.dgvPrevisto.DataSource = objEtapaCtrl.previsto(this.obraCodigo);
                this.dgvPrevisto.Columns[0].HeaderText = "Nome";
                this.dgvPrevisto.Columns[1].HeaderText = "Data Início";
                this.dgvPrevisto.Columns[2].HeaderText = "Data Fim";
                this.dgvPrevisto.Columns[3].HeaderText = "Prazo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void personalizarDGV2()
        {
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapaCtrl = new EtapaCtrl();
                this.dgvRealizado.DataSource = objEtapaCtrl.realizado(this.obraCodigo);
                this.dgvRealizado.Columns[0].Visible = false;
                this.dgvRealizado.Columns[1].HeaderText = "Nome";
                this.dgvRealizado.Columns[2].HeaderText = "Percentual de Conclusão";
                this.dgvRealizado.Columns[3].HeaderText = "Data Início";
                this.dgvRealizado.Columns[4].HeaderText = "Data Fim";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void menuGastos()
        {
            Application.Run(new etapaGastosView(this.etapaCodigo, this.obraCodigo));
        }
        private void menuAnotacoes()
        {
            Application.Run(new etapaAnotacao());
        }
        private void menuImagens()
        {
            Application.Run(new etapaImagemView(this.etapaCodigo, this.obraCodigo));
        }
        private void menuEtapas()
        {
            Application.Run(new configurarEtapasView(obraCodigo));
        }
    }
}