namespace GUI
{
    partial class frmConfiguracaoBancoDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracaoBancoDados));
            this.lblServidor_Configuracao = new System.Windows.Forms.Label();
            this.lblBanco_Configuracao = new System.Windows.Forms.Label();
            this.lblUsuario_Configuracao = new System.Windows.Forms.Label();
            this.lblSenha_Configuracao = new System.Windows.Forms.Label();
            this.txtServidor_Configuracao = new System.Windows.Forms.TextBox();
            this.txtBanco_Configuracao = new System.Windows.Forms.TextBox();
            this.txtUsuario_Configuracao = new System.Windows.Forms.TextBox();
            this.txtSenha_Configuracao = new System.Windows.Forms.TextBox();
            this.btnSalvar_Configuracao = new System.Windows.Forms.Button();
            this.btnTestarConexao_Configuracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServidor_Configuracao
            // 
            this.lblServidor_Configuracao.AutoSize = true;
            this.lblServidor_Configuracao.Location = new System.Drawing.Point(9, 26);
            this.lblServidor_Configuracao.Name = "lblServidor_Configuracao";
            this.lblServidor_Configuracao.Size = new System.Drawing.Size(46, 13);
            this.lblServidor_Configuracao.TabIndex = 0;
            this.lblServidor_Configuracao.Text = "Servidor";
            // 
            // lblBanco_Configuracao
            // 
            this.lblBanco_Configuracao.AutoSize = true;
            this.lblBanco_Configuracao.Location = new System.Drawing.Point(9, 102);
            this.lblBanco_Configuracao.Name = "lblBanco_Configuracao";
            this.lblBanco_Configuracao.Size = new System.Drawing.Size(87, 13);
            this.lblBanco_Configuracao.TabIndex = 1;
            this.lblBanco_Configuracao.Text = "Banco de Dados";
            // 
            // lblUsuario_Configuracao
            // 
            this.lblUsuario_Configuracao.AutoSize = true;
            this.lblUsuario_Configuracao.Location = new System.Drawing.Point(9, 178);
            this.lblUsuario_Configuracao.Name = "lblUsuario_Configuracao";
            this.lblUsuario_Configuracao.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario_Configuracao.TabIndex = 2;
            this.lblUsuario_Configuracao.Text = "Usuario";
            // 
            // lblSenha_Configuracao
            // 
            this.lblSenha_Configuracao.AutoSize = true;
            this.lblSenha_Configuracao.Location = new System.Drawing.Point(9, 256);
            this.lblSenha_Configuracao.Name = "lblSenha_Configuracao";
            this.lblSenha_Configuracao.Size = new System.Drawing.Size(38, 13);
            this.lblSenha_Configuracao.TabIndex = 3;
            this.lblSenha_Configuracao.Text = "Senha";
            // 
            // txtServidor_Configuracao
            // 
            this.txtServidor_Configuracao.Location = new System.Drawing.Point(12, 42);
            this.txtServidor_Configuracao.Name = "txtServidor_Configuracao";
            this.txtServidor_Configuracao.Size = new System.Drawing.Size(525, 20);
            this.txtServidor_Configuracao.TabIndex = 4;
            // 
            // txtBanco_Configuracao
            // 
            this.txtBanco_Configuracao.Location = new System.Drawing.Point(12, 118);
            this.txtBanco_Configuracao.Name = "txtBanco_Configuracao";
            this.txtBanco_Configuracao.Size = new System.Drawing.Size(525, 20);
            this.txtBanco_Configuracao.TabIndex = 5;
            // 
            // txtUsuario_Configuracao
            // 
            this.txtUsuario_Configuracao.Location = new System.Drawing.Point(12, 194);
            this.txtUsuario_Configuracao.Name = "txtUsuario_Configuracao";
            this.txtUsuario_Configuracao.Size = new System.Drawing.Size(525, 20);
            this.txtUsuario_Configuracao.TabIndex = 6;
            // 
            // txtSenha_Configuracao
            // 
            this.txtSenha_Configuracao.Location = new System.Drawing.Point(12, 272);
            this.txtSenha_Configuracao.Name = "txtSenha_Configuracao";
            this.txtSenha_Configuracao.PasswordChar = '*';
            this.txtSenha_Configuracao.Size = new System.Drawing.Size(525, 20);
            this.txtSenha_Configuracao.TabIndex = 7;
            // 
            // btnSalvar_Configuracao
            // 
            this.btnSalvar_Configuracao.Location = new System.Drawing.Point(462, 371);
            this.btnSalvar_Configuracao.Name = "btnSalvar_Configuracao";
            this.btnSalvar_Configuracao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar_Configuracao.TabIndex = 8;
            this.btnSalvar_Configuracao.Text = "Salvar";
            this.btnSalvar_Configuracao.UseVisualStyleBackColor = true;
            this.btnSalvar_Configuracao.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnTestarConexao_Configuracao
            // 
            this.btnTestarConexao_Configuracao.Location = new System.Drawing.Point(295, 371);
            this.btnTestarConexao_Configuracao.Name = "btnTestarConexao_Configuracao";
            this.btnTestarConexao_Configuracao.Size = new System.Drawing.Size(128, 23);
            this.btnTestarConexao_Configuracao.TabIndex = 9;
            this.btnTestarConexao_Configuracao.Text = "Testar Conexão";
            this.btnTestarConexao_Configuracao.UseVisualStyleBackColor = true;
            this.btnTestarConexao_Configuracao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // frmConfiguracaoBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 406);
            this.Controls.Add(this.btnTestarConexao_Configuracao);
            this.Controls.Add(this.btnSalvar_Configuracao);
            this.Controls.Add(this.txtSenha_Configuracao);
            this.Controls.Add(this.txtUsuario_Configuracao);
            this.Controls.Add(this.txtBanco_Configuracao);
            this.Controls.Add(this.txtServidor_Configuracao);
            this.Controls.Add(this.lblSenha_Configuracao);
            this.Controls.Add(this.lblUsuario_Configuracao);
            this.Controls.Add(this.lblBanco_Configuracao);
            this.Controls.Add(this.lblServidor_Configuracao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracaoBancoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do Banco de Dados";
            this.Load += new System.EventHandler(this.frmConfiguracaoBandoDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor_Configuracao;
        private System.Windows.Forms.Label lblBanco_Configuracao;
        private System.Windows.Forms.Label lblUsuario_Configuracao;
        private System.Windows.Forms.Label lblSenha_Configuracao;
        private System.Windows.Forms.TextBox txtServidor_Configuracao;
        private System.Windows.Forms.TextBox txtBanco_Configuracao;
        private System.Windows.Forms.TextBox txtUsuario_Configuracao;
        private System.Windows.Forms.TextBox txtSenha_Configuracao;
        private System.Windows.Forms.Button btnSalvar_Configuracao;
        private System.Windows.Forms.Button btnTestarConexao_Configuracao;
    }
}