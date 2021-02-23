namespace GUI
{
    partial class frmCadastroTipoPagamento
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
            this.lblCodigo_TipoPagamento = new System.Windows.Forms.Label();
            this.lblNome_TipoPagamento = new System.Windows.Forms.Label();
            this.txtCodigo_TipoPagamento = new System.Windows.Forms.TextBox();
            this.txtNome_TipoPagamento = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtNome_TipoPagamento);
            this.pnlDados.Controls.Add(this.txtCodigo_TipoPagamento);
            this.pnlDados.Controls.Add(this.lblNome_TipoPagamento);
            this.pnlDados.Controls.Add(this.lblCodigo_TipoPagamento);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodigo_TipoPagamento
            // 
            this.lblCodigo_TipoPagamento.AutoSize = true;
            this.lblCodigo_TipoPagamento.Location = new System.Drawing.Point(28, 27);
            this.lblCodigo_TipoPagamento.Name = "lblCodigo_TipoPagamento";
            this.lblCodigo_TipoPagamento.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo_TipoPagamento.TabIndex = 0;
            this.lblCodigo_TipoPagamento.Text = "Código";
            // 
            // lblNome_TipoPagamento
            // 
            this.lblNome_TipoPagamento.AutoSize = true;
            this.lblNome_TipoPagamento.Location = new System.Drawing.Point(28, 91);
            this.lblNome_TipoPagamento.Name = "lblNome_TipoPagamento";
            this.lblNome_TipoPagamento.Size = new System.Drawing.Size(100, 13);
            this.lblNome_TipoPagamento.TabIndex = 1;
            this.lblNome_TipoPagamento.Text = "Tipo de Pagamento";
            // 
            // txtCodigo_TipoPagamento
            // 
            this.txtCodigo_TipoPagamento.Enabled = false;
            this.txtCodigo_TipoPagamento.Location = new System.Drawing.Point(31, 44);
            this.txtCodigo_TipoPagamento.Name = "txtCodigo_TipoPagamento";
            this.txtCodigo_TipoPagamento.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_TipoPagamento.TabIndex = 2;
            // 
            // txtNome_TipoPagamento
            // 
            this.txtNome_TipoPagamento.Location = new System.Drawing.Point(31, 108);
            this.txtNome_TipoPagamento.Name = "txtNome_TipoPagamento";
            this.txtNome_TipoPagamento.Size = new System.Drawing.Size(701, 20);
            this.txtNome_TipoPagamento.TabIndex = 3;
            // 
            // frmCadastroTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroTipoPagamento";
            this.Text = "Cadastro Tipo Pagamento";
            this.Load += new System.EventHandler(this.CadastroTipoPagamento_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome_TipoPagamento;
        private System.Windows.Forms.TextBox txtCodigo_TipoPagamento;
        private System.Windows.Forms.Label lblCodigo_TipoPagamento;
        private System.Windows.Forms.Label lblNome_TipoPagamento;
    }
}
