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
    public partial class emailView : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public emailView()
        {
            InitializeComponent();
        }
        private void BtnAnexo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        lstAttachments.Items.Add(file);
                    }
                }
            }
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string[] para;
            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("felipe.florentino01@gmail.com", "FeLiPe2k16");
                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new System.Net.Mail.MailAddress("felipe.florentino01@gmail.com");

                    if (!string.IsNullOrWhiteSpace(txtPara.Text))
                    {
                        para = this.txtPara.Text.Split(',');
                        for (int i = 0; i < para.Length; i++)
                        {
                            mail.To.Add(new System.Net.Mail.MailAddress(para[i]));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo 'para' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    mail.Subject = txtAssunto.Text;
                    mail.Body = txtCorpo.Text;
                    foreach (string file in lstAttachments.Items)
                    {
                        mail.Attachments.Add(new System.Net.Mail.Attachment(file));
                    }
                    smtp.Send(mail);
                }
            }
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