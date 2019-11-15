namespace sgo.userInterface
{
    partial class etapaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etapaView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblPrevisto = new System.Windows.Forms.Label();
            this.lblRealizado = new System.Windows.Forms.Label();
            this.dgvRealizado = new System.Windows.Forms.DataGridView();
            this.dgvPrevisto = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnFotos = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisto)).BeginInit();
            this.panelMenu.SuspendLayout();
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
            this.panelCabecalho.Size = new System.Drawing.Size(1315, 51);
            this.panelCabecalho.TabIndex = 28;
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
            this.btnMinimizar.Location = new System.Drawing.Point(1132, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciar Etapas";
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
            this.btnMaximizar.Location = new System.Drawing.Point(1175, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 50);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1218, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(50, 50);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(1265, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblPrevisto
            // 
            this.lblPrevisto.AutoSize = true;
            this.lblPrevisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisto.Location = new System.Drawing.Point(233, 429);
            this.lblPrevisto.Name = "lblPrevisto";
            this.lblPrevisto.Size = new System.Drawing.Size(60, 16);
            this.lblPrevisto.TabIndex = 32;
            this.lblPrevisto.Text = "Previsto:";
            // 
            // lblRealizado
            // 
            this.lblRealizado.AutoSize = true;
            this.lblRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizado.Location = new System.Drawing.Point(233, 52);
            this.lblRealizado.Name = "lblRealizado";
            this.lblRealizado.Size = new System.Drawing.Size(73, 16);
            this.lblRealizado.TabIndex = 31;
            this.lblRealizado.Text = "Realizado:";
            // 
            // dgvRealizado
            // 
            this.dgvRealizado.AllowUserToAddRows = false;
            this.dgvRealizado.AllowUserToDeleteRows = false;
            this.dgvRealizado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRealizado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRealizado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRealizado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRealizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRealizado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRealizado.Location = new System.Drawing.Point(236, 71);
            this.dgvRealizado.MultiSelect = false;
            this.dgvRealizado.Name = "dgvRealizado";
            this.dgvRealizado.RowHeadersVisible = false;
            this.dgvRealizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRealizado.Size = new System.Drawing.Size(1079, 351);
            this.dgvRealizado.TabIndex = 30;
            // 
            // dgvPrevisto
            // 
            this.dgvPrevisto.AllowUserToAddRows = false;
            this.dgvPrevisto.AllowUserToDeleteRows = false;
            this.dgvPrevisto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrevisto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrevisto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrevisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrevisto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrevisto.Location = new System.Drawing.Point(236, 445);
            this.dgvPrevisto.Name = "dgvPrevisto";
            this.dgvPrevisto.ReadOnly = true;
            this.dgvPrevisto.RowHeadersVisible = false;
            this.dgvPrevisto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPrevisto.Size = new System.Drawing.Size(1079, 346);
            this.dgvPrevisto.TabIndex = 29;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMenu.Controls.Add(this.btnAnotacoes);
            this.panelMenu.Controls.Add(this.btnGerenciar);
            this.panelMenu.Controls.Add(this.btnFotos);
            this.panelMenu.Controls.Add(this.btnGastos);
            this.panelMenu.Controls.Add(this.btnFinalizar);
            this.panelMenu.Controls.Add(this.btnAtualizar);
            this.panelMenu.Location = new System.Drawing.Point(0, 52);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 739);
            this.panelMenu.TabIndex = 33;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGerenciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGerenciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciar.Image")));
            this.btnGerenciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciar.Location = new System.Drawing.Point(-3, 206);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(233, 47);
            this.btnGerenciar.TabIndex = 7;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.BtnGerenciar_Click);
            // 
            // btnFotos
            // 
            this.btnFotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnFotos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFotos.FlatAppearance.BorderSize = 0;
            this.btnFotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotos.ForeColor = System.Drawing.Color.White;
            this.btnFotos.Image = ((System.Drawing.Image)(resources.GetObject("btnFotos.Image")));
            this.btnFotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFotos.Location = new System.Drawing.Point(0, 124);
            this.btnFotos.Name = "btnFotos";
            this.btnFotos.Size = new System.Drawing.Size(230, 47);
            this.btnFotos.TabIndex = 5;
            this.btnFotos.Text = "Fotos";
            this.btnFotos.UseVisualStyleBackColor = false;
            this.btnFotos.Click += new System.EventHandler(this.BtnFotos_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGastos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.ForeColor = System.Drawing.Color.White;
            this.btnGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnGastos.Image")));
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(0, 164);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(230, 47);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.BtnGastos_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(0, 82);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(230, 47);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(230, 47);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAnotacoes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnotacoes.FlatAppearance.BorderSize = 0;
            this.btnAnotacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnotacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotacoes.ForeColor = System.Drawing.Color.White;
            this.btnAnotacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAnotacoes.Image")));
            this.btnAnotacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnotacoes.Location = new System.Drawing.Point(0, 42);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(230, 47);
            this.btnAnotacoes.TabIndex = 8;
            this.btnAnotacoes.Text = "Anotações";
            this.btnAnotacoes.UseVisualStyleBackColor = false;
            this.btnAnotacoes.Click += new System.EventHandler(this.btnAnotacoes_Click);
            // 
            // etapaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 788);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblPrevisto);
            this.Controls.Add(this.lblRealizado);
            this.Controls.Add(this.dgvRealizado);
            this.Controls.Add(this.dgvPrevisto);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "etapaView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EtapaView_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisto)).EndInit();
            this.panelMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPrevisto;
        private System.Windows.Forms.Label lblRealizado;
        private System.Windows.Forms.DataGridView dgvRealizado;
        private System.Windows.Forms.DataGridView dgvPrevisto;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFotos;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnAnotacoes;
    }
}