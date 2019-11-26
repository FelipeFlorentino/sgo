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
    public partial class manterFuncionarioView : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private int obraCodigo;
        public manterFuncionarioView(int codigo)
        {
            InitializeComponent();
            this.obraCodigo = codigo;
            this.txtCPF.Focus();
        }
        private void CadastrarFuncionarioView_Load(object sender, EventArgs e)
        {
            this.cmbFuncao.Items.Add("ARQUITETO");
            this.cmbFuncao.Items.Add("ELETRICISTA");
            this.cmbFuncao.Items.Add("ENCANADOR");
            this.cmbFuncao.Items.Add("ENGENHEIRO");
            this.cmbFuncao.Items.Add("PEDREIRO");
            this.cmbFuncao.Items.Add("PINTOR");
            this.cmbFuncao.Items.Add("SERVENTE");
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario;
            Endereco objEndereco;
            FuncionarioCtrl objFuncionarioCtrl;
            EnderecoCtrl objEnderecoCtrl;
            try
            {
                objFuncionario = new Funcionario();
                objEndereco = new Endereco();
                objFuncionarioCtrl = new FuncionarioCtrl();
                objEnderecoCtrl = new EnderecoCtrl();

                string cpf = this.txtCPF.Text;
                string nome = this.txtNome.Text;
                string email = this.txtEmail.Text;
                string telefone = this.txtTelefone.Text;
                string salario = this.txtSalario.Text;
                string funcao = this.cmbFuncao.Text;
                int obraCodigo = this.obraCodigo;
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

                objFuncionario.setCPF(cpf);
                objFuncionario.setNome(nome);
                objFuncionario.setEmail(email);
                objFuncionario.setTelefone(telefone);
                objFuncionario.setSalario(salario);
                objFuncionario.setFuncao(funcao);
                objFuncionario.setObraCodigo(obraCodigo.ToString());

                if (objEnderecoCtrl.validar(objEndereco))
                {
                    objFuncionario.setEndereco(objEndereco);
                
                    bool mensagem = objFuncionarioCtrl.cadastrar(objFuncionario);

                    if (mensagem)
                    {
                        MessageBox.Show("Funcionário Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Funcionário Não Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
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
            Funcionario objFuncionario;
            Endereco objEndereco;
            FuncionarioCtrl objFuncionarioCtrl;
            EnderecoCtrl objEnderecoCtrl;

            if (MessageBox.Show("Deseja Confirmar a Alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    objFuncionario = new Funcionario();
                    objEndereco = new Endereco();
                    objFuncionarioCtrl = new FuncionarioCtrl();
                    objEnderecoCtrl = new EnderecoCtrl();

                    string cpf = this.txtCPF.Text;
                    string nome = this.txtNome.Text;
                    string email = this.txtEmail.Text;
                    string telefone = this.txtTelefone.Text;
                    string salario = this.txtSalario.Text;
                    string funcao = this.cmbFuncao.Text;
                    int obraCodigo = this.obraCodigo;
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

                    objFuncionario.setCPF(cpf);
                    objFuncionario.setNome(nome);
                    objFuncionario.setEmail(email);
                    objFuncionario.setTelefone(telefone);
                    objFuncionario.setSalario(salario);
                    objFuncionario.setFuncao(funcao);
                    objFuncionario.setObraCodigo(obraCodigo.ToString());

                    if (objEnderecoCtrl.validar(objEndereco))
                    {
                        objFuncionario.setEndereco(objEndereco);

                        bool mensagem = objFuncionarioCtrl.alterar(objFuncionario);
                        if (mensagem)
                        {
                            MessageBox.Show("Funcionário Atualizado com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro na Atualização do Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FuncionarioCtrl objFuncionarioCtrl;
            try
            {
                objFuncionarioCtrl = new FuncionarioCtrl();
                int codigo = Convert.ToInt32(this.txtCodigo.Text);
                if (MessageBox.Show("Deseja Confirmar a Remoção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool resultado = objFuncionarioCtrl.remover(codigo);
                    if (resultado)
                    {
                        MessageBox.Show("Funcionário Removido com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Remover o Funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        public void preencher(Funcionario objFuncionario)
        {
            this.txtCPF.Text = objFuncionario.getCPF();
            this.txtNome.Text = objFuncionario.getNome();
            this.txtEmail.Text = objFuncionario.getEmail();
            this.txtTelefone.Text = objFuncionario.getTelefone();
            this.txtSalario.Text = objFuncionario.getSalario().ToString();
            this.cmbFuncao.Text = objFuncionario.getFuncao().ToString();
            this.txtCodigo.Text = objFuncionario.getEndereco().getCodigo().ToString();
            this.txtCEP.Text = objFuncionario.getEndereco().getCEP();
            this.txtRua.Text = objFuncionario.getEndereco().getRua();
            this.txtNumero.Text = objFuncionario.getEndereco().getNumero().ToString();
            this.txtBairro.Text = objFuncionario.getEndereco().getBairro();
            this.txtCidade.Text = objFuncionario.getEndereco().getCidade();
            this.txtEstado.Text = objFuncionario.getEndereco().getUF();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            this.txtCPF.Clear();
            this.txtNome.Clear();
            this.txtEmail.Clear();
            this.txtTelefone.Clear();
            this.txtSalario.Clear();
            this.cmbFuncao.Text = "";
            this.txtCEP.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtBairro.Clear();
            this.txtCidade.Clear();
            this.txtEstado.Clear();
        }
        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}