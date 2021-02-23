namespace GUI
{
    partial class frmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCliente));
            this.btnLocalizar_ConsultaCli = new System.Windows.Forms.Button();
            this.dtgDados_ConsultaCli = new System.Windows.Forms.DataGridView();
            this.txtValor_ConsultaCli = new System.Windows.Forms.TextBox();
            this.lblValor_ConsultaCli = new System.Windows.Forms.Label();
            this.gpbConsultaPor_ConsultaCli = new System.Windows.Forms.GroupBox();
            this.rdbCpfCnpj_ConsultaCli = new System.Windows.Forms.RadioButton();
            this.rdbNome_ConsultaCli = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaCli)).BeginInit();
            this.gpbConsultaPor_ConsultaCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLocalizar_ConsultaCli
            // 
            this.btnLocalizar_ConsultaCli.Location = new System.Drawing.Point(638, 58);
            this.btnLocalizar_ConsultaCli.Name = "btnLocalizar_ConsultaCli";
            this.btnLocalizar_ConsultaCli.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaCli.TabIndex = 8;
            this.btnLocalizar_ConsultaCli.Text = "Localizar";
            this.btnLocalizar_ConsultaCli.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaCli.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dtgDados_ConsultaCli
            // 
            this.dtgDados_ConsultaCli.AllowUserToAddRows = false;
            this.dtgDados_ConsultaCli.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaCli.Location = new System.Drawing.Point(14, 96);
            this.dtgDados_ConsultaCli.Name = "dtgDados_ConsultaCli";
            this.dtgDados_ConsultaCli.ReadOnly = true;
            this.dtgDados_ConsultaCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaCli.Size = new System.Drawing.Size(760, 454);
            this.dtgDados_ConsultaCli.TabIndex = 7;
            this.dtgDados_ConsultaCli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // txtValor_ConsultaCli
            // 
            this.txtValor_ConsultaCli.Location = new System.Drawing.Point(163, 25);
            this.txtValor_ConsultaCli.Name = "txtValor_ConsultaCli";
            this.txtValor_ConsultaCli.Size = new System.Drawing.Size(592, 20);
            this.txtValor_ConsultaCli.TabIndex = 6;
            // 
            // lblValor_ConsultaCli
            // 
            this.lblValor_ConsultaCli.AutoSize = true;
            this.lblValor_ConsultaCli.Location = new System.Drawing.Point(163, 9);
            this.lblValor_ConsultaCli.Name = "lblValor_ConsultaCli";
            this.lblValor_ConsultaCli.Size = new System.Drawing.Size(31, 13);
            this.lblValor_ConsultaCli.TabIndex = 5;
            this.lblValor_ConsultaCli.Text = "Valor";
            // 
            // gpbConsultaPor_ConsultaCli
            // 
            this.gpbConsultaPor_ConsultaCli.Controls.Add(this.rdbCpfCnpj_ConsultaCli);
            this.gpbConsultaPor_ConsultaCli.Controls.Add(this.rdbNome_ConsultaCli);
            this.gpbConsultaPor_ConsultaCli.Location = new System.Drawing.Point(14, 5);
            this.gpbConsultaPor_ConsultaCli.Name = "gpbConsultaPor_ConsultaCli";
            this.gpbConsultaPor_ConsultaCli.Size = new System.Drawing.Size(143, 76);
            this.gpbConsultaPor_ConsultaCli.TabIndex = 9;
            this.gpbConsultaPor_ConsultaCli.TabStop = false;
            this.gpbConsultaPor_ConsultaCli.Text = "Consultar por:";
            // 
            // rdbCpfCnpj_ConsultaCli
            // 
            this.rdbCpfCnpj_ConsultaCli.AutoSize = true;
            this.rdbCpfCnpj_ConsultaCli.Location = new System.Drawing.Point(6, 44);
            this.rdbCpfCnpj_ConsultaCli.Name = "rdbCpfCnpj_ConsultaCli";
            this.rdbCpfCnpj_ConsultaCli.Size = new System.Drawing.Size(77, 17);
            this.rdbCpfCnpj_ConsultaCli.TabIndex = 11;
            this.rdbCpfCnpj_ConsultaCli.Text = "CPF/CNPJ";
            this.rdbCpfCnpj_ConsultaCli.UseVisualStyleBackColor = true;
            // 
            // rdbNome_ConsultaCli
            // 
            this.rdbNome_ConsultaCli.AutoSize = true;
            this.rdbNome_ConsultaCli.Checked = true;
            this.rdbNome_ConsultaCli.Location = new System.Drawing.Point(6, 21);
            this.rdbNome_ConsultaCli.Name = "rdbNome_ConsultaCli";
            this.rdbNome_ConsultaCli.Size = new System.Drawing.Size(53, 17);
            this.rdbNome_ConsultaCli.TabIndex = 10;
            this.rdbNome_ConsultaCli.TabStop = true;
            this.rdbNome_ConsultaCli.Text = "Nome";
            this.rdbNome_ConsultaCli.UseVisualStyleBackColor = true;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbConsultaPor_ConsultaCli);
            this.Controls.Add(this.btnLocalizar_ConsultaCli);
            this.Controls.Add(this.dtgDados_ConsultaCli);
            this.Controls.Add(this.txtValor_ConsultaCli);
            this.Controls.Add(this.lblValor_ConsultaCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaCli)).EndInit();
            this.gpbConsultaPor_ConsultaCli.ResumeLayout(false);
            this.gpbConsultaPor_ConsultaCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar_ConsultaCli;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaCli;
        private System.Windows.Forms.TextBox txtValor_ConsultaCli;
        private System.Windows.Forms.Label lblValor_ConsultaCli;
        private System.Windows.Forms.GroupBox gpbConsultaPor_ConsultaCli;
        private System.Windows.Forms.RadioButton rdbCpfCnpj_ConsultaCli;
        private System.Windows.Forms.RadioButton rdbNome_ConsultaCli;
    }
}