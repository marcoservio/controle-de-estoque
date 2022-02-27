namespace GUI
{
    partial class frmCadastroCliente
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
            this.lblCodigo_Cliente = new System.Windows.Forms.Label();
            this.lblNome_Cliente = new System.Windows.Forms.Label();
            this.lblRsocial_Cliente = new System.Windows.Forms.Label();
            this.lblCpfCnpj_Cliente = new System.Windows.Forms.Label();
            this.lblRgie_Cliente = new System.Windows.Forms.Label();
            this.lblCep_Cliente = new System.Windows.Forms.Label();
            this.lblEstado_Cliente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome_Cliente = new System.Windows.Forms.TextBox();
            this.gpbTipo_Cliente = new System.Windows.Forms.GroupBox();
            this.rdbJuridica_Cliente = new System.Windows.Forms.RadioButton();
            this.rdbFisica_Cliente = new System.Windows.Forms.RadioButton();
            this.txtRsocial_Cliente = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj_Cliente = new System.Windows.Forms.TextBox();
            this.txtRgIe_Cliente = new System.Windows.Forms.TextBox();
            this.txtCep_Cliente = new System.Windows.Forms.TextBox();
            this.txtEstado_Cliente = new System.Windows.Forms.TextBox();
            this.txtCidade_Cliente = new System.Windows.Forms.TextBox();
            this.lblCidade_Cliente = new System.Windows.Forms.Label();
            this.lblRua_Cliente = new System.Windows.Forms.Label();
            this.lblBairro_Cliente = new System.Windows.Forms.Label();
            this.lblNumero_Cliente = new System.Windows.Forms.Label();
            this.txtRua_Cliente = new System.Windows.Forms.TextBox();
            this.txtNumero_Cliente = new System.Windows.Forms.TextBox();
            this.txtBairro_Cliente = new System.Windows.Forms.TextBox();
            this.lblEmail_Cliente = new System.Windows.Forms.Label();
            this.txtEmail_Cliente = new System.Windows.Forms.TextBox();
            this.txtTelefone_Cliente = new System.Windows.Forms.TextBox();
            this.txtCelular_Cliente = new System.Windows.Forms.TextBox();
            this.lblTelefone_Cliente = new System.Windows.Forms.Label();
            this.lblCelular_Cliente = new System.Windows.Forms.Label();
            this.lblValorIncorreto_Cliente = new System.Windows.Forms.Label();
            this.lblEmailIncorreto_Cliente = new System.Windows.Forms.Label();
            this.lblCepIncorreto_Cliente = new System.Windows.Forms.Label();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.gpbTipo_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lblCepIncorreto_Cliente);
            this.pnlDados.Controls.Add(this.lblEmailIncorreto_Cliente);
            this.pnlDados.Controls.Add(this.lblValorIncorreto_Cliente);
            this.pnlDados.Controls.Add(this.lblCelular_Cliente);
            this.pnlDados.Controls.Add(this.lblTelefone_Cliente);
            this.pnlDados.Controls.Add(this.txtCelular_Cliente);
            this.pnlDados.Controls.Add(this.txtTelefone_Cliente);
            this.pnlDados.Controls.Add(this.txtEmail_Cliente);
            this.pnlDados.Controls.Add(this.lblEmail_Cliente);
            this.pnlDados.Controls.Add(this.txtBairro_Cliente);
            this.pnlDados.Controls.Add(this.txtNumero_Cliente);
            this.pnlDados.Controls.Add(this.txtRua_Cliente);
            this.pnlDados.Controls.Add(this.lblNumero_Cliente);
            this.pnlDados.Controls.Add(this.lblBairro_Cliente);
            this.pnlDados.Controls.Add(this.lblRua_Cliente);
            this.pnlDados.Controls.Add(this.lblCidade_Cliente);
            this.pnlDados.Controls.Add(this.txtCidade_Cliente);
            this.pnlDados.Controls.Add(this.txtEstado_Cliente);
            this.pnlDados.Controls.Add(this.txtCep_Cliente);
            this.pnlDados.Controls.Add(this.txtRgIe_Cliente);
            this.pnlDados.Controls.Add(this.txtCpfCnpj_Cliente);
            this.pnlDados.Controls.Add(this.txtRsocial_Cliente);
            this.pnlDados.Controls.Add(this.gpbTipo_Cliente);
            this.pnlDados.Controls.Add(this.txtNome_Cliente);
            this.pnlDados.Controls.Add(this.txtCodigo);
            this.pnlDados.Controls.Add(this.lblEstado_Cliente);
            this.pnlDados.Controls.Add(this.lblCep_Cliente);
            this.pnlDados.Controls.Add(this.lblRgie_Cliente);
            this.pnlDados.Controls.Add(this.lblCpfCnpj_Cliente);
            this.pnlDados.Controls.Add(this.lblRsocial_Cliente);
            this.pnlDados.Controls.Add(this.lblNome_Cliente);
            this.pnlDados.Controls.Add(this.lblCodigo_Cliente);
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
            // lblCodigo_Cliente
            // 
            this.lblCodigo_Cliente.AutoSize = true;
            this.lblCodigo_Cliente.Location = new System.Drawing.Point(13, 35);
            this.lblCodigo_Cliente.Name = "lblCodigo_Cliente";
            this.lblCodigo_Cliente.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo_Cliente.TabIndex = 0;
            this.lblCodigo_Cliente.Text = "Código";
            // 
            // lblNome_Cliente
            // 
            this.lblNome_Cliente.AutoSize = true;
            this.lblNome_Cliente.Location = new System.Drawing.Point(13, 83);
            this.lblNome_Cliente.Name = "lblNome_Cliente";
            this.lblNome_Cliente.Size = new System.Drawing.Size(85, 13);
            this.lblNome_Cliente.TabIndex = 1;
            this.lblNome_Cliente.Text = "Nome do Cliente";
            // 
            // lblRsocial_Cliente
            // 
            this.lblRsocial_Cliente.AutoSize = true;
            this.lblRsocial_Cliente.Location = new System.Drawing.Point(13, 122);
            this.lblRsocial_Cliente.Name = "lblRsocial_Cliente";
            this.lblRsocial_Cliente.Size = new System.Drawing.Size(70, 13);
            this.lblRsocial_Cliente.TabIndex = 2;
            this.lblRsocial_Cliente.Text = "Razão Social";
            this.lblRsocial_Cliente.Visible = false;
            // 
            // lblCpfCnpj_Cliente
            // 
            this.lblCpfCnpj_Cliente.AutoSize = true;
            this.lblCpfCnpj_Cliente.Location = new System.Drawing.Point(14, 161);
            this.lblCpfCnpj_Cliente.Name = "lblCpfCnpj_Cliente";
            this.lblCpfCnpj_Cliente.Size = new System.Drawing.Size(27, 13);
            this.lblCpfCnpj_Cliente.TabIndex = 3;
            this.lblCpfCnpj_Cliente.Text = "CPF";
            // 
            // lblRgie_Cliente
            // 
            this.lblRgie_Cliente.AutoSize = true;
            this.lblRgie_Cliente.Location = new System.Drawing.Point(401, 161);
            this.lblRgie_Cliente.Name = "lblRgie_Cliente";
            this.lblRgie_Cliente.Size = new System.Drawing.Size(23, 13);
            this.lblRgie_Cliente.TabIndex = 4;
            this.lblRgie_Cliente.Text = "RG";
            // 
            // lblCep_Cliente
            // 
            this.lblCep_Cliente.AutoSize = true;
            this.lblCep_Cliente.Location = new System.Drawing.Point(13, 200);
            this.lblCep_Cliente.Name = "lblCep_Cliente";
            this.lblCep_Cliente.Size = new System.Drawing.Size(28, 13);
            this.lblCep_Cliente.TabIndex = 5;
            this.lblCep_Cliente.Text = "CEP";
            // 
            // lblEstado_Cliente
            // 
            this.lblEstado_Cliente.AutoSize = true;
            this.lblEstado_Cliente.Location = new System.Drawing.Point(159, 200);
            this.lblEstado_Cliente.Name = "lblEstado_Cliente";
            this.lblEstado_Cliente.Size = new System.Drawing.Size(40, 13);
            this.lblEstado_Cliente.TabIndex = 6;
            this.lblEstado_Cliente.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(16, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNome_Cliente
            // 
            this.txtNome_Cliente.Location = new System.Drawing.Point(16, 99);
            this.txtNome_Cliente.Name = "txtNome_Cliente";
            this.txtNome_Cliente.Size = new System.Drawing.Size(728, 20);
            this.txtNome_Cliente.TabIndex = 8;
            // 
            // gpbTipo_Cliente
            // 
            this.gpbTipo_Cliente.Controls.Add(this.rdbJuridica_Cliente);
            this.gpbTipo_Cliente.Controls.Add(this.rdbFisica_Cliente);
            this.gpbTipo_Cliente.Location = new System.Drawing.Point(162, 35);
            this.gpbTipo_Cliente.Name = "gpbTipo_Cliente";
            this.gpbTipo_Cliente.Size = new System.Drawing.Size(279, 42);
            this.gpbTipo_Cliente.TabIndex = 9;
            this.gpbTipo_Cliente.TabStop = false;
            this.gpbTipo_Cliente.Text = "Tipo de Cliente";
            // 
            // rdbJuridica_Cliente
            // 
            this.rdbJuridica_Cliente.AutoSize = true;
            this.rdbJuridica_Cliente.Location = new System.Drawing.Point(167, 19);
            this.rdbJuridica_Cliente.Name = "rdbJuridica_Cliente";
            this.rdbJuridica_Cliente.Size = new System.Drawing.Size(99, 17);
            this.rdbJuridica_Cliente.TabIndex = 1;
            this.rdbJuridica_Cliente.Text = "Pessoa Juridica";
            this.rdbJuridica_Cliente.UseVisualStyleBackColor = true;
            // 
            // rdbFisica_Cliente
            // 
            this.rdbFisica_Cliente.AutoSize = true;
            this.rdbFisica_Cliente.Checked = true;
            this.rdbFisica_Cliente.Location = new System.Drawing.Point(23, 19);
            this.rdbFisica_Cliente.Name = "rdbFisica_Cliente";
            this.rdbFisica_Cliente.Size = new System.Drawing.Size(90, 17);
            this.rdbFisica_Cliente.TabIndex = 0;
            this.rdbFisica_Cliente.TabStop = true;
            this.rdbFisica_Cliente.Text = "Pessoa Fisica";
            this.rdbFisica_Cliente.UseVisualStyleBackColor = true;
            this.rdbFisica_Cliente.CheckedChanged += new System.EventHandler(this.rdbFisica_CheckedChanged);
            // 
            // txtRsocial_Cliente
            // 
            this.txtRsocial_Cliente.Location = new System.Drawing.Point(16, 138);
            this.txtRsocial_Cliente.Name = "txtRsocial_Cliente";
            this.txtRsocial_Cliente.Size = new System.Drawing.Size(728, 20);
            this.txtRsocial_Cliente.TabIndex = 10;
            this.txtRsocial_Cliente.Visible = false;
            // 
            // txtCpfCnpj_Cliente
            // 
            this.txtCpfCnpj_Cliente.Location = new System.Drawing.Point(17, 177);
            this.txtCpfCnpj_Cliente.Name = "txtCpfCnpj_Cliente";
            this.txtCpfCnpj_Cliente.Size = new System.Drawing.Size(344, 20);
            this.txtCpfCnpj_Cliente.TabIndex = 11;
            this.txtCpfCnpj_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfCnpj_KeyPress);
            this.txtCpfCnpj_Cliente.Leave += new System.EventHandler(this.txtCpfCnpj_Leave);
            // 
            // txtRgIe_Cliente
            // 
            this.txtRgIe_Cliente.Location = new System.Drawing.Point(404, 177);
            this.txtRgIe_Cliente.Name = "txtRgIe_Cliente";
            this.txtRgIe_Cliente.Size = new System.Drawing.Size(340, 20);
            this.txtRgIe_Cliente.TabIndex = 12;
            this.txtRgIe_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgIe_Cliente_KeyPress);
            // 
            // txtCep_Cliente
            // 
            this.txtCep_Cliente.Location = new System.Drawing.Point(16, 216);
            this.txtCep_Cliente.Name = "txtCep_Cliente";
            this.txtCep_Cliente.Size = new System.Drawing.Size(114, 20);
            this.txtCep_Cliente.TabIndex = 13;
            this.txtCep_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep_Cliente.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtEstado_Cliente
            // 
            this.txtEstado_Cliente.Location = new System.Drawing.Point(162, 216);
            this.txtEstado_Cliente.Name = "txtEstado_Cliente";
            this.txtEstado_Cliente.Size = new System.Drawing.Size(198, 20);
            this.txtEstado_Cliente.TabIndex = 14;
            // 
            // txtCidade_Cliente
            // 
            this.txtCidade_Cliente.Location = new System.Drawing.Point(404, 216);
            this.txtCidade_Cliente.Name = "txtCidade_Cliente";
            this.txtCidade_Cliente.Size = new System.Drawing.Size(340, 20);
            this.txtCidade_Cliente.TabIndex = 15;
            // 
            // lblCidade_Cliente
            // 
            this.lblCidade_Cliente.AutoSize = true;
            this.lblCidade_Cliente.Location = new System.Drawing.Point(401, 200);
            this.lblCidade_Cliente.Name = "lblCidade_Cliente";
            this.lblCidade_Cliente.Size = new System.Drawing.Size(40, 13);
            this.lblCidade_Cliente.TabIndex = 16;
            this.lblCidade_Cliente.Text = "Cidade";
            // 
            // lblRua_Cliente
            // 
            this.lblRua_Cliente.AutoSize = true;
            this.lblRua_Cliente.Location = new System.Drawing.Point(13, 239);
            this.lblRua_Cliente.Name = "lblRua_Cliente";
            this.lblRua_Cliente.Size = new System.Drawing.Size(27, 13);
            this.lblRua_Cliente.TabIndex = 17;
            this.lblRua_Cliente.Text = "Rua";
            // 
            // lblBairro_Cliente
            // 
            this.lblBairro_Cliente.AutoSize = true;
            this.lblBairro_Cliente.Location = new System.Drawing.Point(13, 278);
            this.lblBairro_Cliente.Name = "lblBairro_Cliente";
            this.lblBairro_Cliente.Size = new System.Drawing.Size(34, 13);
            this.lblBairro_Cliente.TabIndex = 18;
            this.lblBairro_Cliente.Text = "Bairro";
            // 
            // lblNumero_Cliente
            // 
            this.lblNumero_Cliente.AutoSize = true;
            this.lblNumero_Cliente.Location = new System.Drawing.Point(578, 239);
            this.lblNumero_Cliente.Name = "lblNumero_Cliente";
            this.lblNumero_Cliente.Size = new System.Drawing.Size(44, 13);
            this.lblNumero_Cliente.TabIndex = 19;
            this.lblNumero_Cliente.Text = "Número";
            // 
            // txtRua_Cliente
            // 
            this.txtRua_Cliente.Location = new System.Drawing.Point(17, 255);
            this.txtRua_Cliente.Name = "txtRua_Cliente";
            this.txtRua_Cliente.Size = new System.Drawing.Size(559, 20);
            this.txtRua_Cliente.TabIndex = 20;
            // 
            // txtNumero_Cliente
            // 
            this.txtNumero_Cliente.Location = new System.Drawing.Point(582, 255);
            this.txtNumero_Cliente.Name = "txtNumero_Cliente";
            this.txtNumero_Cliente.Size = new System.Drawing.Size(163, 20);
            this.txtNumero_Cliente.TabIndex = 21;
            // 
            // txtBairro_Cliente
            // 
            this.txtBairro_Cliente.Location = new System.Drawing.Point(17, 294);
            this.txtBairro_Cliente.Name = "txtBairro_Cliente";
            this.txtBairro_Cliente.Size = new System.Drawing.Size(728, 20);
            this.txtBairro_Cliente.TabIndex = 22;
            // 
            // lblEmail_Cliente
            // 
            this.lblEmail_Cliente.AutoSize = true;
            this.lblEmail_Cliente.Location = new System.Drawing.Point(13, 317);
            this.lblEmail_Cliente.Name = "lblEmail_Cliente";
            this.lblEmail_Cliente.Size = new System.Drawing.Size(35, 13);
            this.lblEmail_Cliente.TabIndex = 23;
            this.lblEmail_Cliente.Text = "E-mail";
            // 
            // txtEmail_Cliente
            // 
            this.txtEmail_Cliente.Location = new System.Drawing.Point(16, 333);
            this.txtEmail_Cliente.Name = "txtEmail_Cliente";
            this.txtEmail_Cliente.Size = new System.Drawing.Size(728, 20);
            this.txtEmail_Cliente.TabIndex = 24;
            this.txtEmail_Cliente.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelefone_Cliente
            // 
            this.txtTelefone_Cliente.Location = new System.Drawing.Point(16, 376);
            this.txtTelefone_Cliente.Name = "txtTelefone_Cliente";
            this.txtTelefone_Cliente.Size = new System.Drawing.Size(345, 20);
            this.txtTelefone_Cliente.TabIndex = 25;
            this.txtTelefone_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtCelular_Cliente
            // 
            this.txtCelular_Cliente.Location = new System.Drawing.Point(407, 376);
            this.txtCelular_Cliente.Name = "txtCelular_Cliente";
            this.txtCelular_Cliente.Size = new System.Drawing.Size(337, 20);
            this.txtCelular_Cliente.TabIndex = 26;
            this.txtCelular_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblTelefone_Cliente
            // 
            this.lblTelefone_Cliente.AutoSize = true;
            this.lblTelefone_Cliente.Location = new System.Drawing.Point(13, 360);
            this.lblTelefone_Cliente.Name = "lblTelefone_Cliente";
            this.lblTelefone_Cliente.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone_Cliente.TabIndex = 27;
            this.lblTelefone_Cliente.Text = "Telefone";
            // 
            // lblCelular_Cliente
            // 
            this.lblCelular_Cliente.AutoSize = true;
            this.lblCelular_Cliente.Location = new System.Drawing.Point(404, 360);
            this.lblCelular_Cliente.Name = "lblCelular_Cliente";
            this.lblCelular_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lblCelular_Cliente.TabIndex = 28;
            this.lblCelular_Cliente.Text = "Celular";
            // 
            // lblValorIncorreto_Cliente
            // 
            this.lblValorIncorreto_Cliente.AutoSize = true;
            this.lblValorIncorreto_Cliente.ForeColor = System.Drawing.Color.Red;
            this.lblValorIncorreto_Cliente.Location = new System.Drawing.Point(284, 161);
            this.lblValorIncorreto_Cliente.Name = "lblValorIncorreto_Cliente";
            this.lblValorIncorreto_Cliente.Size = new System.Drawing.Size(76, 13);
            this.lblValorIncorreto_Cliente.TabIndex = 29;
            this.lblValorIncorreto_Cliente.Text = "Valor Incorreto";
            this.lblValorIncorreto_Cliente.Visible = false;
            // 
            // lblEmailIncorreto_Cliente
            // 
            this.lblEmailIncorreto_Cliente.AutoSize = true;
            this.lblEmailIncorreto_Cliente.ForeColor = System.Drawing.Color.Red;
            this.lblEmailIncorreto_Cliente.Location = new System.Drawing.Point(669, 317);
            this.lblEmailIncorreto_Cliente.Name = "lblEmailIncorreto_Cliente";
            this.lblEmailIncorreto_Cliente.Size = new System.Drawing.Size(77, 13);
            this.lblEmailIncorreto_Cliente.TabIndex = 30;
            this.lblEmailIncorreto_Cliente.Text = "Email Incorreto";
            this.lblEmailIncorreto_Cliente.Visible = false;
            // 
            // lblCepIncorreto_Cliente
            // 
            this.lblCepIncorreto_Cliente.AutoSize = true;
            this.lblCepIncorreto_Cliente.ForeColor = System.Drawing.Color.Red;
            this.lblCepIncorreto_Cliente.Location = new System.Drawing.Point(57, 200);
            this.lblCepIncorreto_Cliente.Name = "lblCepIncorreto_Cliente";
            this.lblCepIncorreto_Cliente.Size = new System.Drawing.Size(73, 13);
            this.lblCepIncorreto_Cliente.TabIndex = 31;
            this.lblCepIncorreto_Cliente.Text = "CEP Incorreto";
            this.lblCepIncorreto_Cliente.Visible = false;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.gpbTipo_Cliente.ResumeLayout(false);
            this.gpbTipo_Cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstado_Cliente;
        private System.Windows.Forms.Label lblCep_Cliente;
        private System.Windows.Forms.Label lblRgie_Cliente;
        private System.Windows.Forms.Label lblCpfCnpj_Cliente;
        private System.Windows.Forms.Label lblRsocial_Cliente;
        private System.Windows.Forms.Label lblNome_Cliente;
        private System.Windows.Forms.Label lblCodigo_Cliente;
        private System.Windows.Forms.GroupBox gpbTipo_Cliente;
        private System.Windows.Forms.RadioButton rdbJuridica_Cliente;
        private System.Windows.Forms.RadioButton rdbFisica_Cliente;
        private System.Windows.Forms.TextBox txtNome_Cliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtRgIe_Cliente;
        private System.Windows.Forms.TextBox txtCpfCnpj_Cliente;
        private System.Windows.Forms.TextBox txtRsocial_Cliente;
        private System.Windows.Forms.Label lblCelular_Cliente;
        private System.Windows.Forms.Label lblTelefone_Cliente;
        private System.Windows.Forms.TextBox txtCelular_Cliente;
        private System.Windows.Forms.TextBox txtTelefone_Cliente;
        private System.Windows.Forms.TextBox txtEmail_Cliente;
        private System.Windows.Forms.Label lblEmail_Cliente;
        private System.Windows.Forms.TextBox txtBairro_Cliente;
        private System.Windows.Forms.TextBox txtNumero_Cliente;
        private System.Windows.Forms.TextBox txtRua_Cliente;
        private System.Windows.Forms.Label lblNumero_Cliente;
        private System.Windows.Forms.Label lblBairro_Cliente;
        private System.Windows.Forms.Label lblRua_Cliente;
        private System.Windows.Forms.Label lblCidade_Cliente;
        private System.Windows.Forms.TextBox txtCidade_Cliente;
        private System.Windows.Forms.TextBox txtEstado_Cliente;
        private System.Windows.Forms.TextBox txtCep_Cliente;
        private System.Windows.Forms.Label lblValorIncorreto_Cliente;
        private System.Windows.Forms.Label lblEmailIncorreto_Cliente;
        private System.Windows.Forms.Label lblCepIncorreto_Cliente;
    }
}
