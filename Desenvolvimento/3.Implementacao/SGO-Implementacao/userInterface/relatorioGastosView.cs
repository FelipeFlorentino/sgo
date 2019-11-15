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
    public partial class relatorioGastosView : Form
    {
        private Thread nf;
        private int obraCodigo;
        public relatorioGastosView(int codigo)
        {
            InitializeComponent();
            this.obraCodigo = codigo;
        }
        private void RelatorioGastosView_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = new DateTime(2019, 01, 01);
            dtpFim.Value = new DateTime(2019, 12, 31);
            preencherCombo();
            GastoCtrl objGastoCtrl;
            try
            {
                objGastoCtrl = new GastoCtrl();
                this.dgvRelatorio.DataSource = objGastoCtrl.gastosObra(this.obraCodigo);
                this.dgvRelatorio.Columns[0].HeaderText = "Descrição";
                this.dgvRelatorio.Columns[1].HeaderText = "Tipo";
                this.dgvRelatorio.Columns[2].HeaderText = "Valor";
                this.dgvRelatorio.Columns[3].HeaderText = "Data";
                this.dgvRelatorio.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Gasto objGasto;
            GastoCtrl objGastoCtrl;
            try
            {
                objGasto = new Gasto();
                objGastoCtrl = new GastoCtrl();

                objGasto.setTipo(this.cmbTipo.Text);
                objGasto.setObraCodigo(this.obraCodigo.ToString());

                this.dgvRelatorio.DataSource = objGastoCtrl.filtrar(objGasto, dtpInicio.Value, dtpFim.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int h = 50;
            int w = 5;
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                page.Size = PdfSharp.PageSize.A4;
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 12);

                var titleFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                titleFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                titleFormatter.DrawString("Relatório de Gastos", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height));

                var descricao = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                descricao.DrawString("Descrição", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(0, 25, page.Width, page.Height));

                var tipo = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                tipo.DrawString("Tipo", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(175, 25, page.Width, page.Height));

                var val = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                val.DrawString("Valor", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(300, 25, page.Width, page.Height));

                var data = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                data.DrawString("Data", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(400, 25, page.Width, page.Height));

                for (int i = 0; i < this.dgvRelatorio.RowCount; i++)
                {
                    w = 0;
                    string[] valor = new string[4];
                    valor[0] = this.dgvRelatorio.Rows[i].Cells[0].Value.ToString();
                    valor[1] = this.dgvRelatorio.Rows[i].Cells[1].Value.ToString();
                    valor[2] = this.dgvRelatorio.Rows[i].Cells[2].Value.ToString();
                    valor[3] = this.dgvRelatorio.Rows[i].Cells[3].Value.ToString();
                    textFormatter.DrawString(valor[0], font, PdfSharp.Drawing.XBrushes.Black,
                            new PdfSharp.Drawing.XRect(0, h, page.Width, page.Height));
                    textFormatter.DrawString(valor[1], font, PdfSharp.Drawing.XBrushes.Black,
                            new PdfSharp.Drawing.XRect(w += 175, h, page.Width, page.Height));
                    textFormatter.DrawString(valor[2], font, PdfSharp.Drawing.XBrushes.Black,
                            new PdfSharp.Drawing.XRect(w += 125, h, page.Width, page.Height));
                    textFormatter.DrawString(valor[3], font, PdfSharp.Drawing.XBrushes.Black,
                            new PdfSharp.Drawing.XRect(w += 100, h, page.Width, page.Height));
                    h += 20;
                }
                doc.Save("pdf.pdf");
                System.Diagnostics.Process.Start("pdf.pdf");
            }
        }
        private void preencherCombo()
        {
            this.cmbTipo.Items.Add("Ferramenta");
            this.cmbTipo.Items.Add("Material");
            this.cmbTipo.Items.Add("Mão de Obra");
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
    }
}