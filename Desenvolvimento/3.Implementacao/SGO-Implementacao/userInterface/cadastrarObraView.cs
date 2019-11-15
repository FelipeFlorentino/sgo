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
    public partial class cadastrarObraView : Form
    {
        private Thread nf;
        private int codigo;
        public cadastrarObraView()
        {
            InitializeComponent();
        }
        private void CadastrarObraView_Load(object sender, EventArgs e)
        {
            preencherComboClientes();
        }
        private void preencherComboClientes()
        {
            ClienteCtrl objClienteCtrl;
            try
            {
                objClienteCtrl = new ClienteCtrl();
                if (objClienteCtrl.consultar("") != null)
                {
                    for (int i = 0; i < objClienteCtrl.consultar("").Rows.Count; i++)
                    {
                        this.cmbCliente.Items.Add(objClienteCtrl.consultar("").Rows[i]["nome"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Obra objObra;
            Endereco objEndereco;
            ObraCtrl objObraCtrl;
            try
            {
                objObra = new Obra();
                objEndereco = new Endereco();
                objObraCtrl = new ObraCtrl();

                string cliente = this.cmbCliente.Text;

                string cep = this.txtCEP.Text;
                string rua = this.txtRua.Text;
                string numero = this.txtNumero.Text;
                string bairro = this.txtBairro.Text;
                string cidade = this.txtCidade.Text;
                string uf = this.txtEstado.Text;

                objObra.setClienteNome(cliente);

                objEndereco.setCEP(cep);
                objEndereco.setRua(rua);
                objEndereco.setNumero(numero);
                objEndereco.setBairro(bairro);
                objEndereco.setCidade(cidade);
                objEndereco.setUF(uf);

                objObra.setEndereco(objEndereco);

                int resultado = objObraCtrl.cadastrar(objObra);

                if (resultado != 0)
                {
                    MessageBox.Show("Obra Cadastrada com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    this.codigo = resultado;
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Obra Não Cadastrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void limparCampos()
        {
            this.cmbCliente.Text = "";
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
            nf = new Thread(menuForm);
            nf.Start();
        }
        private void menuForm()
        {
            Application.Run(new menuInicialView());
        }
    }
}