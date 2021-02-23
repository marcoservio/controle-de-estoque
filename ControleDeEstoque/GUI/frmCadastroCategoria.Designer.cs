namespace GUI
{
    partial class frmCadastroCategoria
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
            this.lblCodigo_Categoria = new System.Windows.Forms.Label();
            this.lblNome_Categoria = new System.Windows.Forms.Label();
            this.txtCodigo_Categoria = new System.Windows.Forms.TextBox();
            this.txtNome_Categoria = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtNome_Categoria);
            this.pnlDados.Controls.Add(this.txtCodigo_Categoria);
            this.pnlDados.Controls.Add(this.lblNome_Categoria);
            this.pnlDados.Controls.Add(this.lblCodigo_Categoria);
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
            // lblCodigo_Categoria
            // 
            this.lblCodigo_Categoria.AutoSize = true;
            this.lblCodigo_Categoria.Location = new System.Drawing.Point(15, 23);
            this.lblCodigo_Categoria.Name = "lblCodigo_Categoria";
            this.lblCodigo_Categoria.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo_Categoria.TabIndex = 0;
            this.lblCodigo_Categoria.Text = "Código";
            // 
            // lblNome_Categoria
            // 
            this.lblNome_Categoria.AutoSize = true;
            this.lblNome_Categoria.Location = new System.Drawing.Point(15, 98);
            this.lblNome_Categoria.Name = "lblNome_Categoria";
            this.lblNome_Categoria.Size = new System.Drawing.Size(98, 13);
            this.lblNome_Categoria.TabIndex = 1;
            this.lblNome_Categoria.Text = "Nome da Categoria";
            // 
            // txtCodigo_Categoria
            // 
            this.txtCodigo_Categoria.Enabled = false;
            this.txtCodigo_Categoria.Location = new System.Drawing.Point(18, 39);
            this.txtCodigo_Categoria.Name = "txtCodigo_Categoria";
            this.txtCodigo_Categoria.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_Categoria.TabIndex = 2;
            // 
            // txtNome_Categoria
            // 
            this.txtNome_Categoria.Location = new System.Drawing.Point(18, 114);
            this.txtNome_Categoria.Name = "txtNome_Categoria";
            this.txtNome_Categoria.Size = new System.Drawing.Size(725, 20);
            this.txtNome_Categoria.TabIndex = 3;
            // 
            // frmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroCategoria";
            this.Text = "Cadastro de Categoria";
            this.Load += new System.EventHandler(this.frmCadastroCategoria_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome_Categoria;
        private System.Windows.Forms.TextBox txtCodigo_Categoria;
        private System.Windows.Forms.Label lblNome_Categoria;
        private System.Windows.Forms.Label lblCodigo_Categoria;
    }
}
