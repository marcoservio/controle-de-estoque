namespace GUI
{
    partial class frmCadastroUnidadeDeMedida
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
            this.lblCodigo_UnidadeMedida = new System.Windows.Forms.Label();
            this.lblNome_UnidadeMedida = new System.Windows.Forms.Label();
            this.txtCodigo_UnidadeMedida = new System.Windows.Forms.TextBox();
            this.txtNome_UnidadeMedida = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtNome_UnidadeMedida);
            this.pnlDados.Controls.Add(this.txtCodigo_UnidadeMedida);
            this.pnlDados.Controls.Add(this.lblNome_UnidadeMedida);
            this.pnlDados.Controls.Add(this.lblCodigo_UnidadeMedida);
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
            // lblCodigo_UnidadeMedida
            // 
            this.lblCodigo_UnidadeMedida.AutoSize = true;
            this.lblCodigo_UnidadeMedida.Location = new System.Drawing.Point(20, 19);
            this.lblCodigo_UnidadeMedida.Name = "lblCodigo_UnidadeMedida";
            this.lblCodigo_UnidadeMedida.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo_UnidadeMedida.TabIndex = 0;
            this.lblCodigo_UnidadeMedida.Text = "Código";
            // 
            // lblNome_UnidadeMedida
            // 
            this.lblNome_UnidadeMedida.AutoSize = true;
            this.lblNome_UnidadeMedida.Location = new System.Drawing.Point(19, 89);
            this.lblNome_UnidadeMedida.Name = "lblNome_UnidadeMedida";
            this.lblNome_UnidadeMedida.Size = new System.Drawing.Size(100, 13);
            this.lblNome_UnidadeMedida.TabIndex = 1;
            this.lblNome_UnidadeMedida.Text = "Unidade de Medida";
            // 
            // txtCodigo_UnidadeMedida
            // 
            this.txtCodigo_UnidadeMedida.Enabled = false;
            this.txtCodigo_UnidadeMedida.Location = new System.Drawing.Point(22, 35);
            this.txtCodigo_UnidadeMedida.Name = "txtCodigo_UnidadeMedida";
            this.txtCodigo_UnidadeMedida.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_UnidadeMedida.TabIndex = 2;
            // 
            // txtNome_UnidadeMedida
            // 
            this.txtNome_UnidadeMedida.Location = new System.Drawing.Point(22, 105);
            this.txtNome_UnidadeMedida.Name = "txtNome_UnidadeMedida";
            this.txtNome_UnidadeMedida.Size = new System.Drawing.Size(705, 20);
            this.txtNome_UnidadeMedida.TabIndex = 3;
            // 
            // frmCadastroUnidadeDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroUnidadeDeMedida";
            this.Text = "Cadasro Unidade de Medida";
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome_UnidadeMedida;
        private System.Windows.Forms.TextBox txtCodigo_UnidadeMedida;
        private System.Windows.Forms.Label lblNome_UnidadeMedida;
        private System.Windows.Forms.Label lblCodigo_UnidadeMedida;
    }
}
