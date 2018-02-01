namespace Ristorante.Mamma.Carielo.WinForms
{
    partial class FormMercado
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
            this.grdMercados = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTotalMercados = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMercados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMercados
            // 
            this.grdMercados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMercados.Location = new System.Drawing.Point(12, 80);
            this.grdMercados.Name = "grdMercados";
            this.grdMercados.Size = new System.Drawing.Size(397, 236);
            this.grdMercados.TabIndex = 5;
            this.grdMercados.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 51);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(397, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar Mercado";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome mercado";
            // 
            // lblTotalMercados
            // 
            this.lblTotalMercados.AutoSize = true;
            this.lblTotalMercados.Location = new System.Drawing.Point(12, 319);
            this.lblTotalMercados.Name = "lblTotalMercados";
            this.lblTotalMercados.Size = new System.Drawing.Size(0, 13);
            this.lblTotalMercados.TabIndex = 7;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(92, 172);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(233, 24);
            this.lblLoading.TabIndex = 8;
            this.lblLoading.Text = "Carregando informações...";
            // 
            // FormMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 341);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblTotalMercados);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.grdMercados);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercados";
            this.Load += new System.EventHandler(this.FormMercado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMercados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMercados;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTotalMercados;
        private System.Windows.Forms.Label lblLoading;
    }
}