using sgo.controller;
using sgo.model.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgo.userInterface
{
    public partial class manterClienteView : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public manterClienteView()
        {
            InitializeComponent();
            this.txtCPF.Focus();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente objCliente;
            Endereco objEndereco;
            ClienteCtrl objClienteCtrl;
            EnderecoCtrl objEnderecoCtrl;

            try
            {
                objCliente = new Cliente();
                objEndereco = new Endereco();
                objClienteCtrl = new ClienteCtrl();
                objEnderecoCtrl = new EnderecoCtrl();

                string cpf = this.txtCPF.Text;
                string nome = this.txtNome.Text;
                string email = this.txtEmail.Text;
                string telefone = this.txtTelefone.Text;
                string cep = this.txtCEP.Text;
                string rua = this.txtRua.Text;
                string numero = this.txtNumero.Text;
                string bairro = this.txtBairro.Text;
                string cidade = this.txtCidade.Text;
                string uf = this.txtEstado.Text;

                objEndereco.setCEP(cep);
                objEndereco.setRua(rua);
                objEndereco.setNumero(numero);
                objEndereco.setBairro(bairro);
                objEndereco.setCidade(cidade);
                objEndereco.setUF(uf);
                objCliente.setCPF(cpf);
                objCliente.setNome(nome);
                objCliente.setEmail(email);
                objCliente.setTelefone(telefone);

                if (objEnderecoCtrl.validar(objEndereco))
                {
                    objCliente.setEndereco(objEndereco);

                    bool mensagem = objClienteCtrl.cadastrar(objCliente);

                    if (mensagem)
                    {
                        MessageBox.Show("Cliente Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Cliente Não Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha Todas as Informações", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente objCliente;
            Endereco objEndereco;
            ClienteCtrl objClienteCtrl;
            EnderecoCtrl objEnderecoCtrl;

            if (MessageBox.Show("Deseja Confirmar a Alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    objCliente = new Cliente();
                    objEndereco = new Endereco();
                    objClienteCtrl = new ClienteCtrl();
                    objEnderecoCtrl = new EnderecoCtrl();

                    string cpf = this.txtCPF.Text;
                    string nome = this.txtNome.Text;
                    string email = this.txtEmail.Text;
                    string telefone = this.txtTelefone.Text;
                    string codigo = this.txtCodigo.Text;
                    string cep = this.txtCEP.Text;
                    string rua = this.txtRua.Text;
                    string numero = this.txtNumero.Text;
                    string bairro = this.txtBairro.Text;
                    string cidade = this.txtCidade.Text;
                    string uf = this.txtEstado.Text;

                    objCliente.setCPF(cpf);
                    objCliente.setNome(nome);
                    objCliente.setEmail(email);
                    objCliente.setTelefone(telefone);

                    objEndereco.setCodigo(codigo);
                    objEndereco.setCEP(cep);
                    objEndereco.setRua(rua);
                    objEndereco.setNumero(numero);
                    objEndereco.setBairro(bairro);
                    objEndereco.setCidade(cidade);
                    objEndereco.setUF(uf);

                    if (objEnderecoCtrl.validar(objEndereco))
                    {
                        objCliente.setEndereco(objEndereco);

                        bool mensagem = objClienteCtrl.alterar(objCliente);
                        if (mensagem)
                        {
                            MessageBox.Show("Cliente Atualizado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro na Atualização do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha Todas as Informações", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            ClienteCtrl objClienteCtrl;
            try
            {
                objClienteCtrl = new ClienteCtrl();
                int codigo = Convert.ToInt32(this.txtCodigo.Text);
                if (MessageBox.Show("Deseja Confirmar a Remoção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool resultado = objClienteCtrl.remover(codigo);
                    if (resultado)
                    {
                        MessageBox.Show("Cliente Removido com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Remover o Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void preencher(Cliente objCliente)
        {
            this.txtCPF.Text = objCliente.getCPF();
            this.txtNome.Text = objCliente.getNome();
            this.txtEmail.Text = objCliente.getEmail();
            this.txtTelefone.Text = objCliente.getTelefone();
            this.txtCodigo.Text = objCliente.getEndereco().getCodigo().ToString();
            this.txtCEP.Text = objCliente.getEndereco().getCEP();
            this.txtRua.Text = objCliente.getEndereco().getRua();
            this.txtNumero.Text = objCliente.getEndereco().getNumero().ToString();
            this.txtBairro.Text = objCliente.getEndereco().getBairro();
            this.txtCidade.Text = objCliente.getEndereco().getCidade();
            this.txtEstado.Text = objCliente.getEndereco().getUF();
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(this.txtCEP.Text);
                    this.txtRua.Text = resultado.end;
                    this.txtBairro.Text = resultado.bairro;
                    this.txtCidade.Text = resultado.cidade;
                    this.txtEstado.Text = resultado.uf;
                    this.txtNumero.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void limparCampos()
        {
            this.txtCodigo.Clear();
            this.txtCPF.Clear();
            this.txtNome.Clear();
            this.txtEmail.Clear();
            this.txtTelefone.Clear();
            this.txtCEP.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtBairro.Clear();
            this.txtCidade.Clear();
            this.txtEstado.Clear();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}