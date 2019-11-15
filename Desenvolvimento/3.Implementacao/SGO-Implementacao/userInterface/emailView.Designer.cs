namespace sgo.userInterface
{
    partial class emailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailView));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.txtCorpo = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Gold;
            this.panelCabecalho.Controls.Add(this.lblTitulo);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(624, 51);
            this.panelCabecalho.TabIndex = 7;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Email";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(574, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 22;
            this.lstAttachments.Location = new System.Drawing.Point(20, 97);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(582, 92);
            this.lstAttachments.TabIndex = 38;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexo.Location = new System.Drawing.Point(16, 514);
            this.btnAnexo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(128, 58);
            this.btnAnexo.TabIndex = 37;
            this.btnAnexo.Text = "Anexar Arquivos";
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.BtnAnexo_Click);
            // 
            // txtCorpo
            // 
            this.txtCorpo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpo.Location = new System.Drawing.Point(16, 245);
            this.txtCorpo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorpo.Multiline = true;
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(586, 265);
            this.txtCorpo.TabIndex = 35;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(84, 215);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(518, 26);
            this.txtAssunto.TabIndex = 33;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(18, 218);
            this.lblAssunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(62, 22);
            this.lblAssunto.TabIndex = 34;
            this.lblAssunto.Text = "Assunto";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(84, 56);
            this.txtPara.Margin = new System.Windows.Forms.Padding(2);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(518, 26);
            this.txtPara.TabIndex = 32;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(16, 59);
            this.lblPara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(40, 22);
            this.lblPara.TabIndex = 31;
            this.lblPara.Text = "Para";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(474, 514);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 58);
            this.btnEnviar.TabIndex = 36;
            this.btnEnviar.Text = "Enviar Email";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // emailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 578);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.txtCorpo);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.TextBox txtCorpo;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Button btnEnviar;
    }
}