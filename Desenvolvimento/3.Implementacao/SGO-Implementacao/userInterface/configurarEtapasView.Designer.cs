namespace sgo.userInterface
{
    partial class configurarEtapasView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configurarEtapasView));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvEtapas = new System.Windows.Forms.DataGridView();
            this.grbEtapas = new System.Windows.Forms.GroupBox();
            this.txtDataFimPrevisto = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicioPrevisto = new System.Windows.Forms.MaskedTextBox();
            this.lblFimPrevisto = new System.Windows.Forms.Label();
            this.lblInicioPrevisto = new System.Windows.Forms.Label();
            this.txtGastosPrevistos = new System.Windows.Forms.TextBox();
            this.lblGastosPrevistos = new System.Windows.Forms.Label();
            this.cmbEtapas = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            this.grbEtapas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Gold;
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.lblTitulo);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(981, 51);
            this.panelCabecalho.TabIndex = 29;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(798, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Configurar Etapas";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(841, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 50);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(884, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(50, 50);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.UseVisualStyleBackColor = true;
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
            this.btnFechar.Location = new System.Drawing.Point(931, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelMenu.Controls.Add(this.btnRemover);
            this.panelMenu.Controls.Add(this.btnAlterar);
            this.panelMenu.Controls.Add(this.btnCadastrar);
            this.panelMenu.Location = new System.Drawing.Point(0, 49);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 617);
            this.panelMenu.TabIndex = 30;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(0, 86);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(230, 47);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(0, 44);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(230, 47);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(230, 47);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            this.dgvEtapas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEtapas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Location = new System.Drawing.Point(236, 82);
            this.dgvEtapas.MultiSelect = false;
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.RowHeadersVisible = false;
            this.dgvEtapas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEtapas.Size = new System.Drawing.Size(722, 262);
            this.dgvEtapas.TabIndex = 39;
            this.dgvEtapas.DoubleClick += new System.EventHandler(this.DgvEtapas_DoubleClick);
            // 
            // grbEtapas
            // 
            this.grbEtapas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEtapas.Controls.Add(this.txtDataFimPrevisto);
            this.grbEtapas.Controls.Add(this.txtDataInicioPrevisto);
            this.grbEtapas.Controls.Add(this.lblFimPrevisto);
            this.grbEtapas.Controls.Add(this.lblInicioPrevisto);
            this.grbEtapas.Controls.Add(this.txtGastosPrevistos);
            this.grbEtapas.Controls.Add(this.lblGastosPrevistos);
            this.grbEtapas.Controls.Add(this.cmbEtapas);
            this.grbEtapas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEtapas.Location = new System.Drawing.Point(236, 350);
            this.grbEtapas.Name = "grbEtapas";
            this.grbEtapas.Size = new System.Drawing.Size(438, 316);
            this.grbEtapas.TabIndex = 38;
            this.grbEtapas.TabStop = false;
            this.grbEtapas.Text = "Etapa";
            // 
            // txtDataFimPrevisto
            // 
            this.txtDataFimPrevisto.Location = new System.Drawing.Point(6, 253);
            this.txtDataFimPrevisto.Mask = "00/00/0000";
            this.txtDataFimPrevisto.Name = "txtDataFimPrevisto";
            this.txtDataFimPrevisto.Size = new System.Drawing.Size(189, 26);
            this.txtDataFimPrevisto.TabIndex = 10;
            this.txtDataFimPrevisto.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataInicioPrevisto
            // 
            this.txtDataInicioPrevisto.Location = new System.Drawing.Point(6, 182);
            this.txtDataInicioPrevisto.Mask = "00/00/0000";
            this.txtDataInicioPrevisto.Name = "txtDataInicioPrevisto";
            this.txtDataInicioPrevisto.Size = new System.Drawing.Size(189, 26);
            this.txtDataInicioPrevisto.TabIndex = 9;
            this.txtDataInicioPrevisto.ValidatingType = typeof(System.DateTime);
            // 
            // lblFimPrevisto
            // 
            this.lblFimPrevisto.AutoSize = true;
            this.lblFimPrevisto.Location = new System.Drawing.Point(4, 228);
            this.lblFimPrevisto.Name = "lblFimPrevisto";
            this.lblFimPrevisto.Size = new System.Drawing.Size(165, 22);
            this.lblFimPrevisto.TabIndex = 8;
            this.lblFimPrevisto.Text = "Data de Fim Previsto:";
            // 
            // lblInicioPrevisto
            // 
            this.lblInicioPrevisto.AutoSize = true;
            this.lblInicioPrevisto.Location = new System.Drawing.Point(2, 157);
            this.lblInicioPrevisto.Name = "lblInicioPrevisto";
            this.lblInicioPrevisto.Size = new System.Drawing.Size(178, 22);
            this.lblInicioPrevisto.TabIndex = 7;
            this.lblInicioPrevisto.Text = "Data de Início Previsto:";
            // 
            // txtGastosPrevistos
            // 
            this.txtGastosPrevistos.Location = new System.Drawing.Point(6, 110);
            this.txtGastosPrevistos.Name = "txtGastosPrevistos";
            this.txtGastosPrevistos.Size = new System.Drawing.Size(189, 26);
            this.txtGastosPrevistos.TabIndex = 4;
            // 
            // lblGastosPrevistos
            // 
            this.lblGastosPrevistos.AutoSize = true;
            this.lblGastosPrevistos.Location = new System.Drawing.Point(2, 85);
            this.lblGastosPrevistos.Name = "lblGastosPrevistos";
            this.lblGastosPrevistos.Size = new System.Drawing.Size(193, 22);
            this.lblGastosPrevistos.TabIndex = 3;
            this.lblGastosPrevistos.Text = "Total de Gastos Previstos:";
            // 
            // cmbEtapas
            // 
            this.cmbEtapas.FormattingEnabled = true;
            this.cmbEtapas.Location = new System.Drawing.Point(6, 38);
            this.cmbEtapas.Name = "cmbEtapas";
            this.cmbEtapas.Size = new System.Drawing.Size(189, 30);
            this.cmbEtapas.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(232, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(151, 22);
            this.lblDescricao.TabIndex = 36;
            this.lblDescricao.Text = "Etapas Cadastradas:";
            // 
            // configurarEtapasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 668);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.grbEtapas);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "configurarEtapasView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConfigurarEtapasView_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            this.grbEtapas.ResumeLayout(false);
            this.grbEtapas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvEtapas;
        private System.Windows.Forms.GroupBox grbEtapas;
        private System.Windows.Forms.MaskedTextBox txtDataFimPrevisto;
        private System.Windows.Forms.MaskedTextBox txtDataInicioPrevisto;
        private System.Windows.Forms.Label lblFimPrevisto;
        private System.Windows.Forms.Label lblInicioPrevisto;
        private System.Windows.Forms.TextBox txtGastosPrevistos;
        private System.Windows.Forms.Label lblGastosPrevistos;
        private System.Windows.Forms.ComboBox cmbEtapas;
        private System.Windows.Forms.Label lblDescricao;
    }
}