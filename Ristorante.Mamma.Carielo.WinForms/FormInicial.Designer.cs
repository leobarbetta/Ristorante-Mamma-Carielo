namespace Ristorante.Mamma.Carielo.WinForms
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFincancasMes = new System.Windows.Forms.Label();
            this.lblEntradaGeral = new System.Windows.Forms.Label();
            this.lblResultadoGeral = new System.Windows.Forms.Label();
            this.lblSaidageral = new System.Windows.Forms.Label();
            this.lblSaidaMes = new System.Windows.Forms.Label();
            this.lblResultadoMes = new System.Windows.Forms.Label();
            this.lblEntradaMes = new System.Windows.Forms.Label();
            this.faturamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturamentoToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.mercadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            this.faturamentoToolStripMenuItem.Click += new System.EventHandler(this.FaturamentoToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.despesasToolStripMenuItem.Text = "Despesas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.DespesasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // mercadosToolStripMenuItem
            // 
            this.mercadosToolStripMenuItem.Name = "mercadosToolStripMenuItem";
            this.mercadosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.mercadosToolStripMenuItem.Text = "Mercados";
            this.mercadosToolStripMenuItem.Click += new System.EventHandler(this.MercadosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(214, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 287);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Finanças geral";
            // 
            // lblFincancasMes
            // 
            this.lblFincancasMes.AutoSize = true;
            this.lblFincancasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFincancasMes.Location = new System.Drawing.Point(260, 38);
            this.lblFincancasMes.Name = "lblFincancasMes";
            this.lblFincancasMes.Size = new System.Drawing.Size(74, 20);
            this.lblFincancasMes.TabIndex = 3;
            this.lblFincancasMes.Text = "Finanças";
            // 
            // lblEntradaGeral
            // 
            this.lblEntradaGeral.AutoSize = true;
            this.lblEntradaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaGeral.ForeColor = System.Drawing.Color.Green;
            this.lblEntradaGeral.Location = new System.Drawing.Point(12, 89);
            this.lblEntradaGeral.Name = "lblEntradaGeral";
            this.lblEntradaGeral.Size = new System.Drawing.Size(74, 20);
            this.lblEntradaGeral.TabIndex = 4;
            this.lblEntradaGeral.Text = "Entrada: ";
            // 
            // lblResultadoGeral
            // 
            this.lblResultadoGeral.AutoSize = true;
            this.lblResultadoGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoGeral.Location = new System.Drawing.Point(12, 181);
            this.lblResultadoGeral.Name = "lblResultadoGeral";
            this.lblResultadoGeral.Size = new System.Drawing.Size(90, 20);
            this.lblResultadoGeral.TabIndex = 5;
            this.lblResultadoGeral.Text = "Resultado: ";
            // 
            // lblSaidageral
            // 
            this.lblSaidageral.AutoSize = true;
            this.lblSaidageral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidageral.ForeColor = System.Drawing.Color.Red;
            this.lblSaidageral.Location = new System.Drawing.Point(12, 132);
            this.lblSaidageral.Name = "lblSaidageral";
            this.lblSaidageral.Size = new System.Drawing.Size(58, 20);
            this.lblSaidageral.TabIndex = 6;
            this.lblSaidageral.Text = "Saída: ";
            // 
            // lblSaidaMes
            // 
            this.lblSaidaMes.AutoSize = true;
            this.lblSaidaMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaMes.ForeColor = System.Drawing.Color.Red;
            this.lblSaidaMes.Location = new System.Drawing.Point(231, 132);
            this.lblSaidaMes.Name = "lblSaidaMes";
            this.lblSaidaMes.Size = new System.Drawing.Size(58, 20);
            this.lblSaidaMes.TabIndex = 9;
            this.lblSaidaMes.Text = "Saída: ";
            // 
            // lblResultadoMes
            // 
            this.lblResultadoMes.AutoSize = true;
            this.lblResultadoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoMes.Location = new System.Drawing.Point(231, 181);
            this.lblResultadoMes.Name = "lblResultadoMes";
            this.lblResultadoMes.Size = new System.Drawing.Size(90, 20);
            this.lblResultadoMes.TabIndex = 8;
            this.lblResultadoMes.Text = "Resultado: ";
            // 
            // lblEntradaMes
            // 
            this.lblEntradaMes.AutoSize = true;
            this.lblEntradaMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaMes.ForeColor = System.Drawing.Color.Green;
            this.lblEntradaMes.Location = new System.Drawing.Point(231, 89);
            this.lblEntradaMes.Name = "lblEntradaMes";
            this.lblEntradaMes.Size = new System.Drawing.Size(74, 20);
            this.lblEntradaMes.TabIndex = 7;
            this.lblEntradaMes.Text = "Entrada: ";
            // 
            // faturamentoToolStripMenuItem1
            // 
            this.faturamentoToolStripMenuItem1.Name = "faturamentoToolStripMenuItem1";
            this.faturamentoToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.faturamentoToolStripMenuItem1.Text = "Faturamento";
            // 
            // despesasToolStripMenuItem1
            // 
            this.despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            this.despesasToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.despesasToolStripMenuItem1.Text = "Despesas";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // mercadosToolStripMenuItem1
            // 
            this.mercadosToolStripMenuItem1.Name = "mercadosToolStripMenuItem1";
            this.mercadosToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.mercadosToolStripMenuItem1.Text = "Mercados";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblLoading);
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(434, 287);
            this.panel.TabIndex = 10;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(101, 108);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(233, 24);
            this.lblLoading.TabIndex = 15;
            this.lblLoading.Text = "Carregando informações...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Os indicadores consideram apenas valores com pagamento confirmado.";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaidaMes);
            this.Controls.Add(this.lblResultadoMes);
            this.Controls.Add(this.lblEntradaMes);
            this.Controls.Add(this.lblSaidageral);
            this.Controls.Add(this.lblResultadoGeral);
            this.Controls.Add(this.lblEntradaGeral);
            this.Controls.Add(this.lblFincancasMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ristorante Mamma Carielo";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFincancasMes;
        private System.Windows.Forms.Label lblEntradaGeral;
        private System.Windows.Forms.Label lblResultadoGeral;
        private System.Windows.Forms.Label lblSaidageral;
        private System.Windows.Forms.Label lblSaidaMes;
        private System.Windows.Forms.Label lblResultadoMes;
        private System.Windows.Forms.Label lblEntradaMes;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mercadosToolStripMenuItem1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label label3;
    }
}