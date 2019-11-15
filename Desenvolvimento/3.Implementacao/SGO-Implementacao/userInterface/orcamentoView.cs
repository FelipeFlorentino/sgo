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
    public partial class orcamentoView : Form
    {
        private Thread nf;
        public orcamentoView()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(menuInicial);
            nf.Start();
        }
        private void menuInicial()
        {
            Application.Run(new menuInicialView());
        }
    }
}