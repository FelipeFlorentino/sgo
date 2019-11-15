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
    public partial class consultarClienteView : Form
    {
        public consultarClienteView()
        {
            InitializeComponent();
        }
        private void consultarClienteView_Load(object sender, EventArgs e)
        {
            ClienteCtrl objClienteCtrl;
            try
            {
                objClienteCtrl = new ClienteCtrl();
                this.dgvCliente.DataSource = objClienteCtrl.consultar(""); 
                this.dgvCliente.Columns[0].HeaderText = "CPF";
                this.dgvCliente.Columns[1].Width = 100;
                this.dgvCliente.Columns[1].HeaderText = "Nome";
                this.dgvCliente.Columns[2].Width = 150;
                this.dgvCliente.Columns[2].HeaderText = "Email";
                this.dgvCliente.Columns[3].Width = 100;
                this.dgvCliente.Columns[3].HeaderText = "Telefone";
                this.dgvCliente.Columns[4].Visible = false;
                this.dgvCliente.Columns[5].Width = 75;
                this.dgvCliente.Columns[5].HeaderText = "CEP";
                this.dgvCliente.Columns[6].Width = 100;
                this.dgvCliente.Columns[6].HeaderText = "Rua";
                this.dgvCliente.Columns[7].Width = 50;
                this.dgvCliente.Columns[7].HeaderText = "Número";
                this.dgvCliente.Columns[8].Width = 100;
                this.dgvCliente.Columns[8].HeaderText = "Bairro";
                this.dgvCliente.Columns[9].Width = 75;
                this.dgvCliente.Columns[9].HeaderText = "Cidade";
                this.dgvCliente.Columns[10].Width = 50;
                this.dgvCliente.Columns[10].HeaderText = "UF";
                this.dgvCliente.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            ClienteCtrl objClienteCtrl;
            try
            {
                objClienteCtrl = new ClienteCtrl();
                this.dgvCliente.DataSource = objClienteCtrl.consultar(this.txtNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            Cliente objCliente;
            Endereco objEndereco;

            try
            {
                objCliente = new Cliente();
                objEndereco = new Endereco();
                
                int linha = this.dgvCliente.SelectedCells[0].RowIndex;

                objCliente.setCPF(dgvCliente.Rows[linha].Cells[0].Value.ToString());
                objCliente.setNome(dgvCliente.Rows[linha].Cells[1].Value.ToString());
                objCliente.setEmail(dgvCliente.Rows[linha].Cells[2].Value.ToString());
                objCliente.setTelefone(dgvCliente.Rows[linha].Cells[3].Value.ToString());
                objEndereco.setCodigo(dgvCliente.Rows[linha].Cells[4].Value.ToString());
                objEndereco.setCEP(dgvCliente.Rows[linha].Cells[5].Value.ToString());
                objEndereco.setRua(dgvCliente.Rows[linha].Cells[6].Value.ToString());
                objEndereco.setNumero(dgvCliente.Rows[linha].Cells[7].Value.ToString());
                objEndereco.setBairro(dgvCliente.Rows[linha].Cells[8].Value.ToString());
                objEndereco.setCidade(dgvCliente.Rows[linha].Cells[9].Value.ToString());
                objEndereco.setUF(dgvCliente.Rows[linha].Cells[10].Value.ToString());
                objCliente.setEndereco(objEndereco);

                manterClienteView objManterCliente = new manterClienteView();
                objManterCliente.lblTitulo.Text = "Manter Cliente";
                objManterCliente.btnCadastrar.Visible = false;
                objManterCliente.preencher(objCliente);
                objManterCliente.ShowDialog();
                carregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregaGrid()
        {
            ClienteCtrl objClienteCtrl;
            try
            {
                objClienteCtrl = new ClienteCtrl();
                this.dgvCliente.DataSource = objClienteCtrl.consultar("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}