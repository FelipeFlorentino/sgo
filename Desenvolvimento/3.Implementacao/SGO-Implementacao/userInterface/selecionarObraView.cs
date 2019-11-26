using sgo.controller;
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
    public partial class selecionarObraView : Form
    {
        private Thread nf;
        private int codigo;
        public selecionarObraView()
        {
            InitializeComponent();
        }
        private void SelecionarObraView_Load(object sender, EventArgs e)
        {
            ObraCtrl objObraCtrl = new ObraCtrl();
            this.dgvObras.DataSource = objObraCtrl.consultar("");
            personalizarDGV();
            preencherCombo();
        }
        private void personalizarDGV()
        {
            this.dgvObras.Columns[0].Visible = false;
            this.dgvObras.Columns[1].Width = 225;
            this.dgvObras.Columns[1].HeaderText = "Status";
            this.dgvObras.Columns[2].Width = 150;
            this.dgvObras.Columns[2].HeaderText = "Data Início";
            this.dgvObras.Columns[3].Width = 150;
            this.dgvObras.Columns[3].HeaderText = "Data Fim";
            this.dgvObras.Columns[4].Width = 250;
            this.dgvObras.Columns[4].HeaderText = "Cliente";
            this.dgvObras.Columns[5].HeaderText = "Endereço da Obra";
            this.dgvObras.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);
        }
        private void preencherCombo()
        {
            this.cmbStatus.Items.Add("Não Iniciada");
            this.cmbStatus.Items.Add("Em Andamento");
            this.cmbStatus.Items.Add("Finalizada");
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            ObraCtrl objObraCtrl = new ObraCtrl();
            this.dgvObras.DataSource = objObraCtrl.consultar(this.cmbStatus.Text);
            personalizarDGV();
        }
        private void DgvObras_DoubleClick(object sender, EventArgs e)
        {
            int linha = this.dgvObras.SelectedCells[0].RowIndex;
            this.codigo = Convert.ToInt32(dgvObras.Rows[linha].Cells[0].Value);
            this.Close();
            this.nf = new Thread(menuObra);
            this.nf.Start();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nf = new Thread(menuInicial);
            nf.SetApartmentState(ApartmentState.STA);
            this.nf.Start();
        }
        private void menuInicial()
        {
            Application.Run(new menuInicialView());
        }
        private void menuObra()
        {
            Application.Run(new menuObraView(codigo));
        }
    }
}