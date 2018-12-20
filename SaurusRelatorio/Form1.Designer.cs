namespace SaurusRelatorio
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVendaCupomTrib = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaixa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVendaCupomTrib
            // 
            this.btnVendaCupomTrib.BackColor = System.Drawing.Color.DarkBlue;
            this.btnVendaCupomTrib.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendaCupomTrib.ForeColor = System.Drawing.Color.White;
            this.btnVendaCupomTrib.Location = new System.Drawing.Point(0, 0);
            this.btnVendaCupomTrib.Name = "btnVendaCupomTrib";
            this.btnVendaCupomTrib.Size = new System.Drawing.Size(152, 100);
            this.btnVendaCupomTrib.TabIndex = 0;
            this.btnVendaCupomTrib.Text = "Vendas Tributação";
            this.btnVendaCupomTrib.UseVisualStyleBackColor = false;
            this.btnVendaCupomTrib.Click += new System.EventHandler(this.btnVendaCupomTrib_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1270, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Navy;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Location = new System.Drawing.Point(0, 0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(152, 100);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Gerar PDF";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbQuery.Location = new System.Drawing.Point(152, 100);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(1270, 155);
            this.tbQuery.TabIndex = 4;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(95, 12);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(113, 26);
            this.dtpInicial.TabIndex = 5;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Periodo:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(214, 12);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(113, 26);
            this.dtpFinal.TabIndex = 7;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caixa:";
            // 
            // tbCaixa
            // 
            this.tbCaixa.Location = new System.Drawing.Point(95, 52);
            this.tbCaixa.Name = "tbCaixa";
            this.tbCaixa.Size = new System.Drawing.Size(100, 26);
            this.tbCaixa.TabIndex = 9;
            this.tbCaixa.TextChanged += new System.EventHandler(this.tbCaixa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Navy;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1270, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 100);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTeste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeste.ForeColor = System.Drawing.Color.White;
            this.btnTeste.Location = new System.Drawing.Point(0, 100);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(152, 96);
            this.btnTeste.TabIndex = 11;
            this.btnTeste.Text = "Liberar para Leitura";
            this.btnTeste.UseVisualStyleBackColor = false;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnPrincipal.Controls.Add(this.dataGridView1);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(152, 255);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1270, 398);
            this.pnPrincipal.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 653);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 100);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTeste);
            this.panel2.Controls.Add(this.btnVendaCupomTrib);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 653);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnExecutar);
            this.panel3.Controls.Add(this.dtpFinal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbCaixa);
            this.panel3.Controls.Add(this.dtpInicial);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(152, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1270, 100);
            this.panel3.TabIndex = 15;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.Navy;
            this.btnExecutar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExecutar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExecutar.Location = new System.Drawing.Point(1118, 0);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(152, 100);
            this.btnExecutar.TabIndex = 10;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1422, 753);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saurus Relatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendaCupomTrib;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExecutar;
    }
}

