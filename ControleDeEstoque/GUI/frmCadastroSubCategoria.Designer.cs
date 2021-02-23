namespace GUI
{
    partial class frmCadastroSubCategoria
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
            this.lblCodigo_SubCategoria = new System.Windows.Forms.Label();
            this.lblNome_SubCategoria = new System.Windows.Forms.Label();
            this.lblCategoria_SubCategoria = new System.Windows.Forms.Label();
            this.txtCodigo_SubCategoria = new System.Windows.Forms.TextBox();
            this.txtNome_SubCategoria = new System.Windows.Forms.TextBox();
            this.cmbCategoria_SubCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddCategoria_SubCategoria = new System.Windows.Forms.Button();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnAddCategoria_SubCategoria);
            this.pnlDados.Controls.Add(this.cmbCategoria_SubCategoria);
            this.pnlDados.Controls.Add(this.txtNome_SubCategoria);
            this.pnlDados.Controls.Add(this.txtCodigo_SubCategoria);
            this.pnlDados.Controls.Add(this.lblCategoria_SubCategoria);
            this.pnlDados.Controls.Add(this.lblNome_SubCategoria);
            this.pnlDados.Controls.Add(this.lblCodigo_SubCategoria);
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
            // lblCodigo_SubCategoria
            // 
            this.lblCodigo_SubCategoria.AutoSize = true;
            this.lblCodigo_SubCategoria.Location = new System.Drawing.Point(16, 17);
            this.lblCodigo_SubCategoria.Name = "lblCodigo_SubCategoria";
            this.lblCodigo_SubCategoria.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo_SubCategoria.TabIndex = 0;
            this.lblCodigo_SubCategoria.Text = "Código ";
            // 
            // lblNome_SubCategoria
            // 
            this.lblNome_SubCategoria.AutoSize = true;
            this.lblNome_SubCategoria.Location = new System.Drawing.Point(16, 81);
            this.lblNome_SubCategoria.Name = "lblNome_SubCategoria";
            this.lblNome_SubCategoria.Size = new System.Drawing.Size(117, 13);
            this.lblNome_SubCategoria.TabIndex = 1;
            this.lblNome_SubCategoria.Text = "Nome da SubCategoria";
            // 
            // lblCategoria_SubCategoria
            // 
            this.lblCategoria_SubCategoria.AutoSize = true;
            this.lblCategoria_SubCategoria.Location = new System.Drawing.Point(16, 150);
            this.lblCategoria_SubCategoria.Name = "lblCategoria_SubCategoria";
            this.lblCategoria_SubCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria_SubCategoria.TabIndex = 2;
            this.lblCategoria_SubCategoria.Text = "Categoria";
            // 
            // txtCodigo_SubCategoria
            // 
            this.txtCodigo_SubCategoria.Enabled = false;
            this.txtCodigo_SubCategoria.Location = new System.Drawing.Point(19, 33);
            this.txtCodigo_SubCategoria.Name = "txtCodigo_SubCategoria";
            this.txtCodigo_SubCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_SubCategoria.TabIndex = 4;
            // 
            // txtNome_SubCategoria
            // 
            this.txtNome_SubCategoria.Location = new System.Drawing.Point(19, 97);
            this.txtNome_SubCategoria.Name = "txtNome_SubCategoria";
            this.txtNome_SubCategoria.Size = new System.Drawing.Size(680, 20);
            this.txtNome_SubCategoria.TabIndex = 5;
            // 
            // cmbCategoria_SubCategoria
            // 
            this.cmbCategoria_SubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria_SubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria_SubCategoria.FormattingEnabled = true;
            this.cmbCategoria_SubCategoria.Location = new System.Drawing.Point(19, 166);
            this.cmbCategoria_SubCategoria.Name = "cmbCategoria_SubCategoria";
            this.cmbCategoria_SubCategoria.Size = new System.Drawing.Size(341, 21);
            this.cmbCategoria_SubCategoria.TabIndex = 6;
            // 
            // btnAddCategoria_SubCategoria
            // 
            this.btnAddCategoria_SubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategoria_SubCategoria.Location = new System.Drawing.Point(366, 166);
            this.btnAddCategoria_SubCategoria.Name = "btnAddCategoria_SubCategoria";
            this.btnAddCategoria_SubCategoria.Size = new System.Drawing.Size(33, 21);
            this.btnAddCategoria_SubCategoria.TabIndex = 7;
            this.btnAddCategoria_SubCategoria.Text = "+";
            this.btnAddCategoria_SubCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria_SubCategoria.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "Cadastro de SubCategorias";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria_SubCategoria;
        private System.Windows.Forms.TextBox txtNome_SubCategoria;
        private System.Windows.Forms.TextBox txtCodigo_SubCategoria;
        private System.Windows.Forms.Label lblCategoria_SubCategoria;
        private System.Windows.Forms.Label lblNome_SubCategoria;
        private System.Windows.Forms.Label lblCodigo_SubCategoria;
        private System.Windows.Forms.Button btnAddCategoria_SubCategoria;
    }
}
