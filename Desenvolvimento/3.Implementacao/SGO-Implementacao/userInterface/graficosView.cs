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
using System.Windows.Forms.DataVisualization.Charting;

namespace sgo.userInterface
{
    public partial class graficosView : Form
    {
        private int obraCodigo;
        private Thread nf;
        public graficosView(int codigo)
        {
            InitializeComponent();
            this.obraCodigo = codigo;
        }
        private void GraficosView_Load(object sender, EventArgs e)
        {
            this.cmbGrafico.Items.Add("Gastos por Etapa");
            this.cmbGrafico.Items.Add("Gastos por Tipo");
            this.cmbGrafico.Items.Add("Gastos por Mês");
            this.cmbGrafico.Items.Add("Gastos Estimados x Gastos Reais");
        }
        private void BtnGerar_Click(object sender, EventArgs e)
        {
            GastoCtrl objGastoCtrl;
            DataTable tabela;
            try
            {
                objGastoCtrl = new GastoCtrl();
                string tipo = this.cmbGrafico.Text;
                if (tipo == "Gastos por Etapa")
                {
                    this.chGrafico.Series.Clear();
                    this.chGrafico.Series.Add(new Series());
                    this.chGrafico.Series[0].Name = "Gráfico";
                    this.chGrafico.Series[0].IsVisibleInLegend = false;
                    this.chGrafico.Titles.Clear();
                    this.chGrafico.Titles.Add(this.cmbGrafico.Text);
                    this.chGrafico.ChartAreas[0].AxisY.Title = "Total";
                    this.chGrafico.ChartAreas[0].AxisX.Interval = 1;
                    this.chGrafico.ChartAreas[0].AxisY.Interval = 1000;
                    this.chGrafico.Series[0].ChartType = SeriesChartType.Column;
                    this.chGrafico.Series[0].Points.Clear();
                    tabela = objGastoCtrl.gastosEtapas();
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        this.chGrafico.Series[0].Points.Add(new DataPoint
                        {
                            YValues = new double[] { (Convert.ToInt32(tabela.Rows[i][1])) },
                            AxisLabel = tabela.Rows[i][0].ToString()
                        });
                    }
                }
                else if (tipo == "Gastos por Tipo")
                {
                    this.chGrafico.Series.Clear();
                    this.chGrafico.Series.Add(new Series());
                    this.chGrafico.Series[0].Name = "Gráfico";
                    this.chGrafico.Series[0].IsVisibleInLegend = false;
                    this.chGrafico.Titles.Clear();
                    this.chGrafico.Titles.Add(this.cmbGrafico.Text);
                    this.chGrafico.ChartAreas[0].AxisY.Title = "Total";
                    this.chGrafico.ChartAreas[0].AxisX.Interval = 1;
                    this.chGrafico.ChartAreas[0].AxisY.Interval = 1000;
                    this.chGrafico.Series[0].ChartType = SeriesChartType.Column;
                    this.chGrafico.Series[0].Points.Clear();
                    tabela = objGastoCtrl.gastosTipo();
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        this.chGrafico.Series[0].Points.Add(new DataPoint
                        {
                            YValues = new double[] { (Convert.ToInt32(tabela.Rows[i][1])) },
                            AxisLabel = tabela.Rows[i][0].ToString()
                        });
                    }
                }
                else if (tipo == "Gastos por Mês")
                {
                    this.chGrafico.Series.Clear();
                    this.chGrafico.Series.Add(new Series());
                    this.chGrafico.Series[0].Name = "Gráfico";
                    this.chGrafico.Series[0].IsVisibleInLegend = false;
                    this.chGrafico.Titles.Clear();
                    this.chGrafico.Titles.Add(this.cmbGrafico.Text);
                    this.chGrafico.ChartAreas[0].AxisY.Title = "Total";
                    this.chGrafico.ChartAreas[0].AxisX.Interval = 1;
                    this.chGrafico.ChartAreas[0].AxisY.Interval = 1000;
                    this.chGrafico.Series[0].ChartType = SeriesChartType.Column;
                    this.chGrafico.Series[0].Points.Clear();
                    tabela = objGastoCtrl.gastosMes();
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        this.chGrafico.Series[0].Points.Add(new DataPoint
                        {
                            YValues = new double[] { (Convert.ToInt32(tabela.Rows[i][1])) },
                            AxisLabel = tabela.Rows[i][0].ToString()
                        });
                    }
                }
                else if (tipo == "Gastos Estimados x Gastos Reais")
                {
                    this.chGrafico.Series.Clear();
                    this.chGrafico.Series.Add(new Series());
                    this.chGrafico.Series[0].Name = "Gráfico";
                    this.chGrafico.Series[0].IsVisibleInLegend = false;
                    this.chGrafico.Titles.Clear();
                    this.chGrafico.Titles.Add(this.cmbGrafico.Text);
                    this.chGrafico.ChartAreas[0].AxisY.Title = "Total";
                    this.chGrafico.ChartAreas[0].AxisX.Interval = 1;
                    this.chGrafico.ChartAreas[0].AxisY.Interval = 1000;
                    this.chGrafico.Series[0].ChartType = SeriesChartType.Column;
                    this.chGrafico.Series[0].Points.Clear();
                    tabela = objGastoCtrl.comparativoGastos();
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        this.chGrafico.Series[0].Points.Add(new DataPoint
                        {
                            YValues = new double[] { (Convert.ToInt32(tabela.Rows[i][0])) },
                        });
                    }
                }
                else if (tipo == "Planejamento Estimado x Planejamento Real")
                {
                    this.chGrafico.Series.Clear();
                    this.chGrafico.Series.Add(new Series());
                    this.chGrafico.Series[0].Name = "Gráfico";
                    this.chGrafico.Series[0].IsVisibleInLegend = false;
                    this.chGrafico.Titles.Clear();
                    this.chGrafico.Titles.Add(this.cmbGrafico.Text);
                    this.chGrafico.Series[0].ChartType = SeriesChartType.Line;
                    this.chGrafico.Series[0].Points.Clear();
                    tabela = objGastoCtrl.comparativoPrazos();
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        this.chGrafico.Series[0].Points.Add(new DataPoint
                        {
                            YValues = new double[] { (Convert.ToInt32(tabela.Rows[i][0])) },
                            AxisLabel = tabela.Rows[i][1].ToString()
                        });
                        this.chGrafico.Series[0].Points.Add(new DataPoint
                        {
                            YValues = new double[] { (Convert.ToInt32(tabela.Rows[i][2])) },
                            AxisLabel = tabela.Rows[i][3].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
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