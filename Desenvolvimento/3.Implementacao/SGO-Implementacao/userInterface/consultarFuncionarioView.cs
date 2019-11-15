using sgo.controller;
using sgo.model.business;
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
    public partial class consultarFuncionarioView : Form
    {
        private int obraCodigo;
        public consultarFuncionarioView(int codigo)
        {
            InitializeComponent();
            this.obraCodigo = codigo;
        }
        private void ManterFuncionarioView_Load(object sender, EventArgs e)
        {
            FuncionarioCtrl objFuncionarioCtrl;
            try
            {
                objFuncionarioCtrl = new FuncionarioCtrl();
                this.dgvFuncionarios.DataSource = objFuncionarioCtrl.consultar("");
                this.dgvFuncionarios.Columns[0].HeaderText = "CPF";
                this.dgvFuncionarios.Columns[1].HeaderText = "Nome";
                this.dgvFuncionarios.Columns[2].HeaderText = "Email";
                this.dgvFuncionarios.Columns[3].HeaderText = "Telefone";
                this.dgvFuncionarios.Columns[4].HeaderText = "Salário";
                this.dgvFuncionarios.Columns[5].HeaderText = "Função";
                this.dgvFuncionarios.Columns[6].Visible = false;
                this.dgvFuncionarios.Columns[7].HeaderText = "CEP";
                this.dgvFuncionarios.Columns[8].HeaderText = "Rua";
                this.dgvFuncionarios.Columns[9].HeaderText = "Número";
                this.dgvFuncionarios.Columns[10].HeaderText = "Bairro";
                this.dgvFuncionarios.Columns[11].HeaderText = "Cidade";
                this.dgvFuncionarios.Columns[12].HeaderText = "Estado";
                this.dgvFuncionarios.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            FuncionarioCtrl objFuncionarioCtrl;
            try
            {
                objFuncionarioCtrl = new FuncionarioCtrl();
                this.dgvFuncionarios.DataSource = objFuncionarioCtrl.consultar(this.txtNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            Funcionario objFuncionario;
            Endereco objEndereco;

            try
            {
                objFuncionario = new Funcionario();
                objEndereco = new Endereco();

                int linha = this.dgvFuncionarios.SelectedCells[0].RowIndex;

                objFuncionario.setCPF(dgvFuncionarios.Rows[linha].Cells[0].Value.ToString());
                objFuncionario.setNome(dgvFuncionarios.Rows[linha].Cells[1].Value.ToString());
                objFuncionario.setEmail(dgvFuncionarios.Rows[linha].Cells[2].Value.ToString());
                objFuncionario.setTelefone(dgvFuncionarios.Rows[linha].Cells[3].Value.ToString());
                objFuncionario.setSalario(dgvFuncionarios.Rows[linha].Cells[4].Value.ToString());
                objFuncionario.setFuncao(dgvFuncionarios.Rows[linha].Cells[5].Value.ToString());
                objEndereco.setCodigo(dgvFuncionarios.Rows[linha].Cells[6].Value.ToString());
                objEndereco.setCEP(dgvFuncionarios.Rows[linha].Cells[7].Value.ToString());
                objEndereco.setRua(dgvFuncionarios.Rows[linha].Cells[8].Value.ToString());
                objEndereco.setNumero(dgvFuncionarios.Rows[linha].Cells[9].Value.ToString());
                objEndereco.setBairro(dgvFuncionarios.Rows[linha].Cells[10].Value.ToString());
                objEndereco.setCidade(dgvFuncionarios.Rows[linha].Cells[11].Value.ToString());
                objEndereco.setUF(dgvFuncionarios.Rows[linha].Cells[12].Value.ToString());
                objFuncionario.setEndereco(objEndereco);

                manterFuncionarioView objManterFuncionario = new manterFuncionarioView(this.obraCodigo);
                objManterFuncionario.lblTitulo.Text = "Manter Funcionário";
                objManterFuncionario.btnCadastrar.Visible = false;
                objManterFuncionario.preencher(objFuncionario);
                objManterFuncionario.ShowDialog();
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregaGrid()
        {
            FuncionarioCtrl objFuncionarioCtrl;
            try
            {
                objFuncionarioCtrl = new FuncionarioCtrl();
                this.dgvFuncionarios.DataSource = objFuncionarioCtrl.consultar("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}