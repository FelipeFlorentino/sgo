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
    public partial class etapaGastosView : Form
    {
        private Thread nf;
        private int etapaCodigo;
        private int obraCodigo;
        public etapaGastosView(int codigoEtapa, int codigoObra)
        {
            InitializeComponent();
            this.etapaCodigo = codigoEtapa;
            this.obraCodigo = codigoObra;
        }
        private void EtapaGastosView_Load(object sender, EventArgs e)
        {
            carregaGrid();
            this.cmbTipo.Items.Add("Ferramenta");
            this.cmbTipo.Items.Add("Material");
            this.cmbTipo.Items.Add("Mão de Obra");
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Gasto objGasto;
            GastoCtrl objGastoCtrl;
            try
            {
                objGasto = new Gasto();
                objGastoCtrl = new GastoCtrl();

                string descricao = this.txtDescricao.Text;
                string tipo = this.cmbTipo.Text;
                string valor = this.txtValor.Text;
                string data = this.txtData.Text;
                string codigoObra = this.obraCodigo.ToString();
                string codigoEtapa = this.etapaCodigo.ToString();

                objGasto.setDescricao(descricao);
                objGasto.setTipo(tipo);
                objGasto.setData(data);
                objGasto.setValor(valor);
                objGasto.setObraCodigo(codigoObra);
                objGasto.setEtapaCodigo(codigoEtapa);

                bool mensagem = objGastoCtrl.cadastrar(objGasto);

                if (mensagem)
                {
                    MessageBox.Show("Gasto Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    limparCampos();
                    carregaGrid();
                }
                else
                {
                    MessageBox.Show("Gasto Não Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Gasto objGasto;
            GastoCtrl objGastoCtrl;
            try
            {
                objGasto = new Gasto();
                objGastoCtrl = new GastoCtrl();

                int linha = this.dgvGastos.SelectedCells[0].RowIndex;
                string codigo = this.dgvGastos.Rows[linha].Cells[0].Value.ToString();
                string descricao = this.dgvGastos.Rows[linha].Cells[1].Value.ToString();
                string tipo = this.dgvGastos.Rows[linha].Cells[2].Value.ToString();
                string valor = this.dgvGastos.Rows[linha].Cells[3].Value.ToString();
                string data = this.dgvGastos.Rows[linha].Cells[4].Value.ToString();
                string codigoObra = this.dgvGastos.Rows[linha].Cells[5].Value.ToString();
                string codigoEtapa = this.dgvGastos.Rows[linha].Cells[6].Value.ToString();

                objGasto.setDescricao(descricao);
                objGasto.setTipo(tipo);
                objGasto.setValor(valor);
                objGasto.setData(data);
                objGasto.setObraCodigo(codigoObra);
                objGasto.setEtapaCodigo(codigoEtapa);
                objGasto.setCodigo(codigo);
                if (MessageBox.Show("Deseja Confirmar a Alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool mensagem = objGastoCtrl.alterar(objGasto);
                    if (mensagem)
                    {
                        MessageBox.Show("Gasto Atualizado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    }
                    carregaGrid();
                }
                else
                {
                    carregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            GastoCtrl objGastoCtrl;
            try
            {
                objGastoCtrl = new GastoCtrl();
                int linha = this.dgvGastos.SelectedCells[0].RowIndex;
                int codigo = Convert.ToInt32(dgvGastos.Rows[linha].Cells[0].Value.ToString());
                if (MessageBox.Show("Deseja Confirmar a Remoção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool mensagem = objGastoCtrl.remover(codigo);
                    if (mensagem)
                    {
                        MessageBox.Show("Gasto Removido com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    }
                    carregaGrid();
                }
                else
                {
                    carregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregaGrid()
        {
            GastoCtrl objGastoCtrl;
            try
            {
                objGastoCtrl = new GastoCtrl();
                this.dgvGastos.DataSource = objGastoCtrl.gastosEtapa(this.obraCodigo, this.etapaCodigo);
                this.dgvGastos.Columns[0].Visible = false;
                this.dgvGastos.Columns[1].HeaderText = "Descrição";
                this.dgvGastos.Columns[2].HeaderText = "Tipo";
                this.dgvGastos.Columns[3].HeaderText = "Valor";
                this.dgvGastos.Columns[4].HeaderText = "Data";
                this.dgvGastos.Columns[5].Visible = false;
                this.dgvGastos.Columns[6].Visible = false;
                this.dgvGastos.DefaultCellStyle.Font = new Font("Trebuchet MS", 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limparCampos()
        {
            this.txtDescricao.Clear();
            this.cmbTipo.Text = "";
            this.txtValor.Clear();
            this.txtData.Clear();
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