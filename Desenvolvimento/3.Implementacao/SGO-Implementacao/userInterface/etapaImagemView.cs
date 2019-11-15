using sgo.controller;
using sgo.model.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgo.userInterface
{
    public partial class etapaImagemView : Form
    {
        private Thread nf;
        private int etapaCodigo;
        private int obraCodigo;
        public etapaImagemView(int codigoEtapa, int codigoObra)
        {
            InitializeComponent();
            this.etapaCodigo = codigoEtapa;
            this.obraCodigo = codigoObra;
        }
        private void EtapaImagemView_Load(object sender, EventArgs e)
        {
            ImagemCtrl objImagemCtrl = new ImagemCtrl();
            this.dgvImagem.DataSource = objImagemCtrl.consultar(this.etapaCodigo);
            ((DataGridViewImageColumn)dgvImagem.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < dgvImagem.RowCount; i++)
            {
                DataGridViewRow row = dgvImagem.Rows[i];
                row.Height = 180;
            }
        }
        private void BtnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                pbImagem.ImageLocation = foto;
            }
        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Imagem objImagem;
            ImagemCtrl objImagemCtrl;
            try
            {
                objImagem = new Imagem();
                objImagemCtrl = new ImagemCtrl();

                string descricao = this.txtDescricao.Text;
                DateTime data = new DateTime();
                data = DateTime.Now;
                byte[] imagem_byte = null;
                FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagem_byte = br.ReadBytes((int)fstream.Length);

                objImagem.setDescricao(descricao);
                objImagem.setImagem(imagem_byte);
                objImagem.setData(data.ToString());
                objImagem.setEtapaCodigo(this.etapaCodigo.ToString());

                bool mensagem = objImagemCtrl.gravar(objImagem);

                if (mensagem)
                {
                    MessageBox.Show("Foto Gravada com Sucesso");
                }
                else
                {
                    MessageBox.Show("Foto Não Gravada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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