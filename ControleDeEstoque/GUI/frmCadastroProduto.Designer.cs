namespace GUI
{
    partial class frmCadastroProduto
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
            this.lblCodigo_Produto = new System.Windows.Forms.Label();
            this.lblNome_Produto = new System.Windows.Forms.Label();
            this.lblDescricao_Produto = new System.Windows.Forms.Label();
            this.lblCategoria_Produto = new System.Windows.Forms.Label();
            this.lblValorPago_Produto = new System.Windows.Forms.Label();
            this.lblSubCategoria_Produto = new System.Windows.Forms.Label();
            this.lblUnidadeMedida_Produto = new System.Windows.Forms.Label();
            this.lblQuantidade_Produto = new System.Windows.Forms.Label();
            this.lblValorVenda_Produto = new System.Windows.Forms.Label();
            this.txtCodigo_Produto = new System.Windows.Forms.TextBox();
            this.txtNome_Produto = new System.Windows.Forms.TextBox();
            this.txtDescricao_Produto = new System.Windows.Forms.TextBox();
            this.txtValorPago_Produto = new System.Windows.Forms.TextBox();
            this.txtValorVenda_Produto = new System.Windows.Forms.TextBox();
            this.txtQuantidade_Produto = new System.Windows.Forms.TextBox();
            this.cmbUnidadeMedida_Produto = new System.Windows.Forms.ComboBox();
            this.cmbCategoria_Produto = new System.Windows.Forms.ComboBox();
            this.cmbSubCategoria_Produto = new System.Windows.Forms.ComboBox();
            this.btnAddUnidadeMedida_Produto = new System.Windows.Forms.Button();
            this.btnAddCategoria_Produto = new System.Windows.Forms.Button();
            this.btnAddSubCategoria_Produto = new System.Windows.Forms.Button();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnAddSubCategoria_Produto);
            this.pnlDados.Controls.Add(this.btnAddCategoria_Produto);
            this.pnlDados.Controls.Add(this.btnAddUnidadeMedida_Produto);
            this.pnlDados.Controls.Add(this.cmbSubCategoria_Produto);
            this.pnlDados.Controls.Add(this.cmbCategoria_Produto);
            this.pnlDados.Controls.Add(this.cmbUnidadeMedida_Produto);
            this.pnlDados.Controls.Add(this.txtQuantidade_Produto);
            this.pnlDados.Controls.Add(this.txtValorVenda_Produto);
            this.pnlDados.Controls.Add(this.txtValorPago_Produto);
            this.pnlDados.Controls.Add(this.txtDescricao_Produto);
            this.pnlDados.Controls.Add(this.txtNome_Produto);
            this.pnlDados.Controls.Add(this.txtCodigo_Produto);
            this.pnlDados.Controls.Add(this.lblValorVenda_Produto);
            this.pnlDados.Controls.Add(this.lblQuantidade_Produto);
            this.pnlDados.Controls.Add(this.lblUnidadeMedida_Produto);
            this.pnlDados.Controls.Add(this.lblSubCategoria_Produto);
            this.pnlDados.Controls.Add(this.lblValorPago_Produto);
            this.pnlDados.Controls.Add(this.lblCategoria_Produto);
            this.pnlDados.Controls.Add(this.lblDescricao_Produto);
            this.pnlDados.Controls.Add(this.lblNome_Produto);
            this.pnlDados.Controls.Add(this.lblCodigo_Produto);
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
            // lblCodigo_Produto
            // 
            this.lblCodigo_Produto.AutoSize = true;
            this.lblCodigo_Produto.Location = new System.Drawing.Point(26, 16);
            this.lblCodigo_Produto.Name = "lblCodigo_Produto";
            this.lblCodigo_Produto.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo_Produto.TabIndex = 0;
            this.lblCodigo_Produto.Text = "Código";
            // 
            // lblNome_Produto
            // 
            this.lblNome_Produto.AutoSize = true;
            this.lblNome_Produto.Location = new System.Drawing.Point(26, 81);
            this.lblNome_Produto.Name = "lblNome_Produto";
            this.lblNome_Produto.Size = new System.Drawing.Size(90, 13);
            this.lblNome_Produto.TabIndex = 1;
            this.lblNome_Produto.Text = "Nome do Produto";
            // 
            // lblDescricao_Produto
            // 
            this.lblDescricao_Produto.AutoSize = true;
            this.lblDescricao_Produto.Location = new System.Drawing.Point(26, 144);
            this.lblDescricao_Produto.Name = "lblDescricao_Produto";
            this.lblDescricao_Produto.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao_Produto.TabIndex = 2;
            this.lblDescricao_Produto.Text = "Descrição";
            // 
            // lblCategoria_Produto
            // 
            this.lblCategoria_Produto.AutoSize = true;
            this.lblCategoria_Produto.Location = new System.Drawing.Point(515, 206);
            this.lblCategoria_Produto.Name = "lblCategoria_Produto";
            this.lblCategoria_Produto.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria_Produto.TabIndex = 3;
            this.lblCategoria_Produto.Text = "Categoria";
            // 
            // lblValorPago_Produto
            // 
            this.lblValorPago_Produto.AutoSize = true;
            this.lblValorPago_Produto.Location = new System.Drawing.Point(26, 354);
            this.lblValorPago_Produto.Name = "lblValorPago_Produto";
            this.lblValorPago_Produto.Size = new System.Drawing.Size(59, 13);
            this.lblValorPago_Produto.TabIndex = 4;
            this.lblValorPago_Produto.Text = "Valor Pago";
            // 
            // lblSubCategoria_Produto
            // 
            this.lblSubCategoria_Produto.AutoSize = true;
            this.lblSubCategoria_Produto.Location = new System.Drawing.Point(515, 273);
            this.lblSubCategoria_Produto.Name = "lblSubCategoria_Produto";
            this.lblSubCategoria_Produto.Size = new System.Drawing.Size(71, 13);
            this.lblSubCategoria_Produto.TabIndex = 5;
            this.lblSubCategoria_Produto.Text = "SubCategoria";
            // 
            // lblUnidadeMedida_Produto
            // 
            this.lblUnidadeMedida_Produto.AutoSize = true;
            this.lblUnidadeMedida_Produto.Location = new System.Drawing.Point(515, 144);
            this.lblUnidadeMedida_Produto.Name = "lblUnidadeMedida_Produto";
            this.lblUnidadeMedida_Produto.Size = new System.Drawing.Size(100, 13);
            this.lblUnidadeMedida_Produto.TabIndex = 6;
            this.lblUnidadeMedida_Produto.Text = "Unidade de Medida";
            // 
            // lblQuantidade_Produto
            // 
            this.lblQuantidade_Produto.AutoSize = true;
            this.lblQuantidade_Produto.Location = new System.Drawing.Point(347, 354);
            this.lblQuantidade_Produto.Name = "lblQuantidade_Produto";
            this.lblQuantidade_Produto.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade_Produto.TabIndex = 7;
            this.lblQuantidade_Produto.Text = "Quantidade";
            // 
            // lblValorVenda_Produto
            // 
            this.lblValorVenda_Produto.AutoSize = true;
            this.lblValorVenda_Produto.Location = new System.Drawing.Point(183, 354);
            this.lblValorVenda_Produto.Name = "lblValorVenda_Produto";
            this.lblValorVenda_Produto.Size = new System.Drawing.Size(80, 13);
            this.lblValorVenda_Produto.TabIndex = 8;
            this.lblValorVenda_Produto.Text = "Valor de Venda";
            // 
            // txtCodigo_Produto
            // 
            this.txtCodigo_Produto.Enabled = false;
            this.txtCodigo_Produto.Location = new System.Drawing.Point(29, 32);
            this.txtCodigo_Produto.Name = "txtCodigo_Produto";
            this.txtCodigo_Produto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_Produto.TabIndex = 9;
            // 
            // txtNome_Produto
            // 
            this.txtNome_Produto.Location = new System.Drawing.Point(29, 97);
            this.txtNome_Produto.Name = "txtNome_Produto";
            this.txtNome_Produto.Size = new System.Drawing.Size(447, 20);
            this.txtNome_Produto.TabIndex = 10;
            // 
            // txtDescricao_Produto
            // 
            this.txtDescricao_Produto.Location = new System.Drawing.Point(29, 160);
            this.txtDescricao_Produto.Multiline = true;
            this.txtDescricao_Produto.Name = "txtDescricao_Produto";
            this.txtDescricao_Produto.Size = new System.Drawing.Size(447, 147);
            this.txtDescricao_Produto.TabIndex = 11;
            // 
            // txtValorPago_Produto
            // 
            this.txtValorPago_Produto.Location = new System.Drawing.Point(29, 370);
            this.txtValorPago_Produto.Name = "txtValorPago_Produto";
            this.txtValorPago_Produto.Size = new System.Drawing.Size(115, 20);
            this.txtValorPago_Produto.TabIndex = 12;
            this.txtValorPago_Produto.Text = "0,00";
            this.txtValorPago_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago_Produto.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtValorVenda_Produto
            // 
            this.txtValorVenda_Produto.Location = new System.Drawing.Point(186, 370);
            this.txtValorVenda_Produto.Name = "txtValorVenda_Produto";
            this.txtValorVenda_Produto.Size = new System.Drawing.Size(134, 20);
            this.txtValorVenda_Produto.TabIndex = 13;
            this.txtValorVenda_Produto.Text = "0,00";
            this.txtValorVenda_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda_Produto.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // txtQuantidade_Produto
            // 
            this.txtQuantidade_Produto.Location = new System.Drawing.Point(350, 370);
            this.txtQuantidade_Produto.Name = "txtQuantidade_Produto";
            this.txtQuantidade_Produto.Size = new System.Drawing.Size(126, 20);
            this.txtQuantidade_Produto.TabIndex = 14;
            this.txtQuantidade_Produto.Text = "0";
            this.txtQuantidade_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // cmbUnidadeMedida_Produto
            // 
            this.cmbUnidadeMedida_Produto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUnidadeMedida_Produto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnidadeMedida_Produto.FormattingEnabled = true;
            this.cmbUnidadeMedida_Produto.Location = new System.Drawing.Point(518, 160);
            this.cmbUnidadeMedida_Produto.Name = "cmbUnidadeMedida_Produto";
            this.cmbUnidadeMedida_Produto.Size = new System.Drawing.Size(188, 21);
            this.cmbUnidadeMedida_Produto.TabIndex = 15;
            this.cmbUnidadeMedida_Produto.SelectedIndexChanged += new System.EventHandler(this.cmbUnidadeMedida_Produto_SelectedIndexChanged);
            // 
            // cmbCategoria_Produto
            // 
            this.cmbCategoria_Produto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria_Produto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria_Produto.FormattingEnabled = true;
            this.cmbCategoria_Produto.Location = new System.Drawing.Point(518, 223);
            this.cmbCategoria_Produto.Name = "cmbCategoria_Produto";
            this.cmbCategoria_Produto.Size = new System.Drawing.Size(188, 21);
            this.cmbCategoria_Produto.TabIndex = 16;
            this.cmbCategoria_Produto.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbSubCategoria_Produto
            // 
            this.cmbSubCategoria_Produto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategoria_Produto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubCategoria_Produto.FormattingEnabled = true;
            this.cmbSubCategoria_Produto.Location = new System.Drawing.Point(518, 288);
            this.cmbSubCategoria_Produto.Name = "cmbSubCategoria_Produto";
            this.cmbSubCategoria_Produto.Size = new System.Drawing.Size(188, 21);
            this.cmbSubCategoria_Produto.TabIndex = 17;
            // 
            // btnAddUnidadeMedida_Produto
            // 
            this.btnAddUnidadeMedida_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnidadeMedida_Produto.Location = new System.Drawing.Point(712, 160);
            this.btnAddUnidadeMedida_Produto.Name = "btnAddUnidadeMedida_Produto";
            this.btnAddUnidadeMedida_Produto.Size = new System.Drawing.Size(33, 21);
            this.btnAddUnidadeMedida_Produto.TabIndex = 18;
            this.btnAddUnidadeMedida_Produto.Text = "+";
            this.btnAddUnidadeMedida_Produto.UseVisualStyleBackColor = true;
            this.btnAddUnidadeMedida_Produto.Click += new System.EventHandler(this.btnAddUnidadeMedida_Click);
            // 
            // btnAddCategoria_Produto
            // 
            this.btnAddCategoria_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategoria_Produto.Location = new System.Drawing.Point(712, 223);
            this.btnAddCategoria_Produto.Name = "btnAddCategoria_Produto";
            this.btnAddCategoria_Produto.Size = new System.Drawing.Size(33, 21);
            this.btnAddCategoria_Produto.TabIndex = 19;
            this.btnAddCategoria_Produto.Text = "+";
            this.btnAddCategoria_Produto.UseVisualStyleBackColor = true;
            this.btnAddCategoria_Produto.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // btnAddSubCategoria_Produto
            // 
            this.btnAddSubCategoria_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubCategoria_Produto.Location = new System.Drawing.Point(712, 288);
            this.btnAddSubCategoria_Produto.Name = "btnAddSubCategoria_Produto";
            this.btnAddSubCategoria_Produto.Size = new System.Drawing.Size(33, 21);
            this.btnAddSubCategoria_Produto.TabIndex = 20;
            this.btnAddSubCategoria_Produto.Text = "+";
            this.btnAddSubCategoria_Produto.UseVisualStyleBackColor = true;
            this.btnAddSubCategoria_Produto.Click += new System.EventHandler(this.btnAddSubCategoria_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSubCategoria_Produto;
        private System.Windows.Forms.ComboBox cmbCategoria_Produto;
        private System.Windows.Forms.ComboBox cmbUnidadeMedida_Produto;
        private System.Windows.Forms.TextBox txtQuantidade_Produto;
        private System.Windows.Forms.TextBox txtValorVenda_Produto;
        private System.Windows.Forms.TextBox txtValorPago_Produto;
        private System.Windows.Forms.TextBox txtDescricao_Produto;
        private System.Windows.Forms.TextBox txtNome_Produto;
        private System.Windows.Forms.TextBox txtCodigo_Produto;
        private System.Windows.Forms.Label lblValorVenda_Produto;
        private System.Windows.Forms.Label lblQuantidade_Produto;
        private System.Windows.Forms.Label lblUnidadeMedida_Produto;
        private System.Windows.Forms.Label lblSubCategoria_Produto;
        private System.Windows.Forms.Label lblValorPago_Produto;
        private System.Windows.Forms.Label lblCategoria_Produto;
        private System.Windows.Forms.Label lblDescricao_Produto;
        private System.Windows.Forms.Label lblNome_Produto;
        private System.Windows.Forms.Label lblCodigo_Produto;
        private System.Windows.Forms.Button btnAddSubCategoria_Produto;
        private System.Windows.Forms.Button btnAddCategoria_Produto;
        private System.Windows.Forms.Button btnAddUnidadeMedida_Produto;
    }
}
