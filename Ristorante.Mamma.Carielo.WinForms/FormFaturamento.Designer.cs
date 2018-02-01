namespace Ristorante.Mamma.Carielo.WinForms
{
    partial class FormFaturamento
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdFaturamentos = new System.Windows.Forms.DataGridView();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(29, 29);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(191, 20);
            this.txtValor.TabIndex = 24;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cliente";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(226, 28);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(199, 21);
            this.cbxCliente.TabIndex = 22;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(147, 95);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(396, 23);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar Entrada";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(431, 13);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 20;
            this.lblObservacao.Text = "Observação";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(223, 53);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(26, 51);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(107, 13);
            this.lblFormaPagamento.TabIndex = 18;
            this.lblFormaPagamento.Text = "Forma de pagamento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(26, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 13);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor pago";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(431, 29);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(199, 60);
            this.txtObservacao.TabIndex = 16;
            this.txtObservacao.Text = "";
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(29, 68);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(191, 21);
            this.cbxFormaPagamento.TabIndex = 15;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(226, 69);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(199, 20);
            this.dtpData.TabIndex = 14;
            // 
            // grdFaturamentos
            // 
            this.grdFaturamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFaturamentos.Location = new System.Drawing.Point(12, 124);
            this.grdFaturamentos.Name = "grdFaturamentos";
            this.grdFaturamentos.Size = new System.Drawing.Size(643, 285);
            this.grdFaturamentos.TabIndex = 13;
            this.grdFaturamentos.Visible = false;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(12, 412);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 13);
            this.lblValorTotal.TabIndex = 25;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(222, 256);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(233, 24);
            this.lblLoading.TabIndex = 26;
            this.lblLoading.Text = "Carregando informações...";
            // 
            // FormFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.cbxFormaPagamento);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdFaturamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFaturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturamento";
            this.Load += new System.EventHandler(this.FormFaturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdFaturamentos;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblLoading;
    }
}