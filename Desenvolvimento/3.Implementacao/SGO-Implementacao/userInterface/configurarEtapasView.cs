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
    public partial class configurarEtapasView : Form
    {
        private Thread nf;
        private int etapaCodigo;
        private int obraCodigo;
        public configurarEtapasView(int codigo)
        {
            InitializeComponent();
            preencherComboEtapas();
            this.obraCodigo = codigo;
        }
        private void ConfigurarEtapasView_Load(object sender, EventArgs e)
        {
            EtapaCtrl objEtapaCtrl = new EtapaCtrl();
            this.dgvEtapas.DataSource = objEtapaCtrl.listar(this.obraCodigo);
            personalizarDGV();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Etapa objEtapa;
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapa = new Etapa();
                objEtapaCtrl = new EtapaCtrl();

                objEtapa.setNome(this.cmbEtapas.Text);
                objEtapa.setDataInicioPrevisto(this.txtDataInicioPrevisto.Text);
                objEtapa.setDataFimPrevisto(this.txtDataFimPrevisto.Text);
                objEtapa.setTotalGastosPrevisto(this.txtGastosPrevistos.Text);
                objEtapa.setObraCodigo(this.obraCodigo.ToString());

                bool mensagem = objEtapaCtrl.cadastrar(objEtapa);

                if (mensagem)
                {
                    MessageBox.Show("Etapa Inserida com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Etapa Não Inserida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Etapa objEtapa;
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapa = new Etapa();
                objEtapaCtrl = new EtapaCtrl();

                int linha = this.dgvEtapas.SelectedCells[0].RowIndex;
                this.etapaCodigo = Convert.ToInt32(this.dgvEtapas.Rows[linha].Cells[0].Value.ToString());

                objEtapa.setNome(this.cmbEtapas.Text);
                objEtapa.setDataInicioPrevisto(this.txtDataInicioPrevisto.Text);
                objEtapa.setDataFimPrevisto(this.txtDataFimPrevisto.Text);
                objEtapa.setTotalGastosPrevisto(this.txtGastosPrevistos.Text);
                objEtapa.setCodigo(this.etapaCodigo.ToString());
                objEtapa.setObraCodigo(this.obraCodigo.ToString());

                bool mensagem = objEtapaCtrl.alterar(objEtapa);

                if (mensagem)
                {
                    MessageBox.Show("Etapa Alterada com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Etapa Não Alterada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapaCtrl = new EtapaCtrl();
                int linha = this.dgvEtapas.SelectedCells[0].RowIndex;
                int codigoEtapa = Convert.ToInt32(dgvEtapas.Rows[linha].Cells[0].Value.ToString());
                if (MessageBox.Show("Deseja Confirmar a Remoção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool mensagem = objEtapaCtrl.remover(codigoEtapa, this.obraCodigo);
                    if (mensagem)
                    {
                        MessageBox.Show("Etapa Removida com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Etapa Não Removida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    }
                }
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DgvEtapas_DoubleClick(object sender, EventArgs e)
        {
            int linha = this.dgvEtapas.SelectedCells[0].RowIndex;
            this.cmbEtapas.Text = this.dgvEtapas.Rows[linha].Cells[1].Value.ToString();
            this.txtGastosPrevistos.Text = this.dgvEtapas.Rows[linha].Cells[2].Value.ToString();
            this.txtDataInicioPrevisto.Text = this.dgvEtapas.Rows[linha].Cells[3].Value.ToString();
            this.txtDataFimPrevisto.Text = this.dgvEtapas.Rows[linha].Cells[4].Value.ToString();
        }
        private void preencherComboEtapas()
        {
            this.cmbEtapas.Items.Add("Serviços Iniciais");
            this.cmbEtapas.Items.Add("Fundação");
            this.cmbEtapas.Items.Add("Estrutura");
            this.cmbEtapas.Items.Add("Paredes");
            this.cmbEtapas.Items.Add("Cobertura");
            this.cmbEtapas.Items.Add("Esquadrias");
            this.cmbEtapas.Items.Add("Elétrica");
            this.cmbEtapas.Items.Add("Hidráulica");
            this.cmbEtapas.Items.Add("Forro");
            this.cmbEtapas.Items.Add("Revestimentos");
            this.cmbEtapas.Items.Add("Pisos");
            this.cmbEtapas.Items.Add("Pinturas");
        }
        private void personalizarDGV()
        {
            this.dgvEtapas.Columns[0].Visible = false;
            this.dgvEtapas.Columns[1].HeaderText = "Nome";
            this.dgvEtapas.Columns[2].ValueType = typeof(Double);
            this.dgvEtapas.Columns[2].HeaderText = "Total de Gastos Previstos";
            this.dgvEtapas.Columns[3].HeaderText = "Data Início Previsto";
            this.dgvEtapas.Columns[4].HeaderText = "Data Fim Previsto";
            this.dgvEtapas.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);
        }
        private void carregaGrid()
        {
            EtapaCtrl objEtapaCtrl;
            try
            {
                objEtapaCtrl = new EtapaCtrl();
                this.dgvEtapas.DataSource = objEtapaCtrl.listar(this.obraCodigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limparCampos()
        {
            this.cmbEtapas.Items.Remove(cmbEtapas.SelectedItem);
            this.txtGastosPrevistos.Clear();
            this.txtDataInicioPrevisto.Clear();
            this.txtDataFimPrevisto.Clear();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuEtapa);
            nf.Start();
        }
        private void menuEtapa()
        {
            Application.Run(new etapaView(obraCodigo));
        }
    }
}