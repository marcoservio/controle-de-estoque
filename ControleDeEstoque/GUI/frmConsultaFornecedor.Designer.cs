namespace GUI
{
    partial class frmConsultaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFornecedor));
            this.gpbConsultaPor_ConsultaFor = new System.Windows.Forms.GroupBox();
            this.rdbCnpj_ConsultaFor = new System.Windows.Forms.RadioButton();
            this.rdbNome_ConsultaFor = new System.Windows.Forms.RadioButton();
            this.btnLocalizar_ConsultaFor = new System.Windows.Forms.Button();
            this.dtgDados_ConsultaFor = new System.Windows.Forms.DataGridView();
            this.txtValor_ConsultaFor = new System.Windows.Forms.TextBox();
            this.lblValor_ConsultaFor = new System.Windows.Forms.Label();
            this.gpbConsultaPor_ConsultaFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaFor)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultaPor_ConsultaFor
            // 
            this.gpbConsultaPor_ConsultaFor.Controls.Add(this.rdbCnpj_ConsultaFor);
            this.gpbConsultaPor_ConsultaFor.Controls.Add(this.rdbNome_ConsultaFor);
            this.gpbConsultaPor_ConsultaFor.Location = new System.Drawing.Point(12, 8);
            this.gpbConsultaPor_ConsultaFor.Name = "gpbConsultaPor_ConsultaFor";
            this.gpbConsultaPor_ConsultaFor.Size = new System.Drawing.Size(143, 76);
            this.gpbConsultaPor_ConsultaFor.TabIndex = 14;
            this.gpbConsultaPor_ConsultaFor.TabStop = false;
            this.gpbConsultaPor_ConsultaFor.Text = "Consultar por:";
            // 
            // rdbCnpj_ConsultaFor
            // 
            this.rdbCnpj_ConsultaFor.AutoSize = true;
            this.rdbCnpj_ConsultaFor.Location = new System.Drawing.Point(6, 44);
            this.rdbCnpj_ConsultaFor.Name = "rdbCnpj_ConsultaFor";
            this.rdbCnpj_ConsultaFor.Size = new System.Drawing.Size(52, 17);
            this.rdbCnpj_ConsultaFor.TabIndex = 11;
            this.rdbCnpj_ConsultaFor.Text = "CNPJ";
            this.rdbCnpj_ConsultaFor.UseVisualStyleBackColor = true;
            // 
            // rdbNome_ConsultaFor
            // 
            this.rdbNome_ConsultaFor.AutoSize = true;
            this.rdbNome_ConsultaFor.Checked = true;
            this.rdbNome_ConsultaFor.Location = new System.Drawing.Point(6, 21);
            this.rdbNome_ConsultaFor.Name = "rdbNome_ConsultaFor";
            this.rdbNome_ConsultaFor.Size = new System.Drawing.Size(53, 17);
            this.rdbNome_ConsultaFor.TabIndex = 10;
            this.rdbNome_ConsultaFor.TabStop = true;
            this.rdbNome_ConsultaFor.Text = "Nome";
            this.rdbNome_ConsultaFor.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar_ConsultaFor
            // 
            this.btnLocalizar_ConsultaFor.Location = new System.Drawing.Point(636, 61);
            this.btnLocalizar_ConsultaFor.Name = "btnLocalizar_ConsultaFor";
            this.btnLocalizar_ConsultaFor.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaFor.TabIndex = 13;
            this.btnLocalizar_ConsultaFor.Text = "Localizar";
            this.btnLocalizar_ConsultaFor.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaFor.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dtgDados_ConsultaFor
            // 
            this.dtgDados_ConsultaFor.AllowUserToAddRows = false;
            this.dtgDados_ConsultaFor.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaFor.Location = new System.Drawing.Point(12, 99);
            this.dtgDados_ConsultaFor.Name = "dtgDados_ConsultaFor";
            this.dtgDados_ConsultaFor.ReadOnly = true;
            this.dtgDados_ConsultaFor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaFor.Size = new System.Drawing.Size(760, 454);
            this.dtgDados_ConsultaFor.TabIndex = 12;
            this.dtgDados_ConsultaFor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // txtValor_ConsultaFor
            // 
            this.txtValor_ConsultaFor.Location = new System.Drawing.Point(161, 28);
            this.txtValor_ConsultaFor.Name = "txtValor_ConsultaFor";
            this.txtValor_ConsultaFor.Size = new System.Drawing.Size(592, 20);
            this.txtValor_ConsultaFor.TabIndex = 11;
            // 
            // lblValor_ConsultaFor
            // 
            this.lblValor_ConsultaFor.AutoSize = true;
            this.lblValor_ConsultaFor.Location = new System.Drawing.Point(161, 12);
            this.lblValor_ConsultaFor.Name = "lblValor_ConsultaFor";
            this.lblValor_ConsultaFor.Size = new System.Drawing.Size(31, 13);
            this.lblValor_ConsultaFor.TabIndex = 10;
            this.lblValor_ConsultaFor.Text = "Valor";
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbConsultaPor_ConsultaFor);
            this.Controls.Add(this.btnLocalizar_ConsultaFor);
            this.Controls.Add(this.dtgDados_ConsultaFor);
            this.Controls.Add(this.txtValor_ConsultaFor);
            this.Controls.Add(this.lblValor_ConsultaFor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Fornecedor";
            this.Load += new System.EventHandler(this.frmConsultaFornecedor_Load);
            this.gpbConsultaPor_ConsultaFor.ResumeLayout(false);
            this.gpbConsultaPor_ConsultaFor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaFor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultaPor_ConsultaFor;
        private System.Windows.Forms.RadioButton rdbCnpj_ConsultaFor;
        private System.Windows.Forms.RadioButton rdbNome_ConsultaFor;
        private System.Windows.Forms.Button btnLocalizar_ConsultaFor;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaFor;
        private System.Windows.Forms.TextBox txtValor_ConsultaFor;
        private System.Windows.Forms.Label lblValor_ConsultaFor;
    }
}