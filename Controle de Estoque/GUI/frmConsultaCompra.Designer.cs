namespace GUI
{
    partial class frmConsultaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCompra));
            this.gpbConsultaPor_ConsultaCom = new System.Windows.Forms.GroupBox();
            this.rdbGeral_ConsultaCom = new System.Windows.Forms.RadioButton();
            this.rdbParcelas_ConsultaCom = new System.Windows.Forms.RadioButton();
            this.rdbData_ConsultaCom = new System.Windows.Forms.RadioButton();
            this.rdbFornecedor_ConsultaCom = new System.Windows.Forms.RadioButton();
            this.dtgDados_ConsultaCom = new System.Windows.Forms.DataGridView();
            this.pnlFornecedor = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLocFornec = new System.Windows.Forms.Button();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblDataFinal_ConsultaCom = new System.Windows.Forms.Label();
            this.dtpFinal_ConsultaCom = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial_ConsultaCom = new System.Windows.Forms.DateTimePicker();
            this.btnLocData_ConsultaCom = new System.Windows.Forms.Button();
            this.lblDataInicial_ConsultaCom = new System.Windows.Forms.Label();
            this.tbcDados_ConsultaCom = new System.Windows.Forms.TabControl();
            this.tbpAbaCompra = new System.Windows.Forms.TabPage();
            this.tbpAbaItens = new System.Windows.Forms.TabPage();
            this.dtgItens_ConsultaCom = new System.Windows.Forms.DataGridView();
            this.tbpAbaParcelas = new System.Windows.Forms.TabPage();
            this.dtgParcelas_ConsultaCom = new System.Windows.Forms.DataGridView();
            this.gpbConsultaPor_ConsultaCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaCom)).BeginInit();
            this.pnlFornecedor.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tbcDados_ConsultaCom.SuspendLayout();
            this.tbpAbaCompra.SuspendLayout();
            this.tbpAbaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens_ConsultaCom)).BeginInit();
            this.tbpAbaParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas_ConsultaCom)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultaPor_ConsultaCom
            // 
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbGeral_ConsultaCom);
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbParcelas_ConsultaCom);
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbData_ConsultaCom);
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbFornecedor_ConsultaCom);
            this.gpbConsultaPor_ConsultaCom.Location = new System.Drawing.Point(12, 8);
            this.gpbConsultaPor_ConsultaCom.Name = "gpbConsultaPor_ConsultaCom";
            this.gpbConsultaPor_ConsultaCom.Size = new System.Drawing.Size(760, 37);
            this.gpbConsultaPor_ConsultaCom.TabIndex = 14;
            this.gpbConsultaPor_ConsultaCom.TabStop = false;
            this.gpbConsultaPor_ConsultaCom.Text = "Consultar por:";
            // 
            // rdbGeral_ConsultaCom
            // 
            this.rdbGeral_ConsultaCom.AutoSize = true;
            this.rdbGeral_ConsultaCom.Checked = true;
            this.rdbGeral_ConsultaCom.Location = new System.Drawing.Point(6, 15);
            this.rdbGeral_ConsultaCom.Name = "rdbGeral_ConsultaCom";
            this.rdbGeral_ConsultaCom.Size = new System.Drawing.Size(113, 17);
            this.rdbGeral_ConsultaCom.TabIndex = 13;
            this.rdbGeral_ConsultaCom.TabStop = true;
            this.rdbGeral_ConsultaCom.Text = "Todas as Compras";
            this.rdbGeral_ConsultaCom.UseVisualStyleBackColor = true;
            this.rdbGeral_ConsultaCom.CheckedChanged += new System.EventHandler(this.rdbGeral_CheckedChanged);
            // 
            // rdbParcelas_ConsultaCom
            // 
            this.rdbParcelas_ConsultaCom.AutoSize = true;
            this.rdbParcelas_ConsultaCom.Location = new System.Drawing.Point(636, 15);
            this.rdbParcelas_ConsultaCom.Name = "rdbParcelas_ConsultaCom";
            this.rdbParcelas_ConsultaCom.Size = new System.Drawing.Size(117, 17);
            this.rdbParcelas_ConsultaCom.TabIndex = 12;
            this.rdbParcelas_ConsultaCom.Text = "Parcelas em Aberto";
            this.rdbParcelas_ConsultaCom.UseVisualStyleBackColor = true;
            this.rdbParcelas_ConsultaCom.CheckedChanged += new System.EventHandler(this.rdbGeral_CheckedChanged);
            // 
            // rdbData_ConsultaCom
            // 
            this.rdbData_ConsultaCom.AutoSize = true;
            this.rdbData_ConsultaCom.Location = new System.Drawing.Point(422, 15);
            this.rdbData_ConsultaCom.Name = "rdbData_ConsultaCom";
            this.rdbData_ConsultaCom.Size = new System.Drawing.Size(102, 17);
            this.rdbData_ConsultaCom.TabIndex = 11;
            this.rdbData_ConsultaCom.Text = "Data da Compra";
            this.rdbData_ConsultaCom.UseVisualStyleBackColor = true;
            this.rdbData_ConsultaCom.CheckedChanged += new System.EventHandler(this.rdbGeral_CheckedChanged);
            // 
            // rdbFornecedor_ConsultaCom
            // 
            this.rdbFornecedor_ConsultaCom.AutoSize = true;
            this.rdbFornecedor_ConsultaCom.Location = new System.Drawing.Point(231, 15);
            this.rdbFornecedor_ConsultaCom.Name = "rdbFornecedor_ConsultaCom";
            this.rdbFornecedor_ConsultaCom.Size = new System.Drawing.Size(79, 17);
            this.rdbFornecedor_ConsultaCom.TabIndex = 10;
            this.rdbFornecedor_ConsultaCom.Text = "Fornecedor";
            this.rdbFornecedor_ConsultaCom.UseVisualStyleBackColor = true;
            this.rdbFornecedor_ConsultaCom.CheckedChanged += new System.EventHandler(this.rdbGeral_CheckedChanged);
            // 
            // dtgDados_ConsultaCom
            // 
            this.dtgDados_ConsultaCom.AllowUserToAddRows = false;
            this.dtgDados_ConsultaCom.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaCom.Location = new System.Drawing.Point(3, 3);
            this.dtgDados_ConsultaCom.Name = "dtgDados_ConsultaCom";
            this.dtgDados_ConsultaCom.ReadOnly = true;
            this.dtgDados_ConsultaCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaCom.Size = new System.Drawing.Size(746, 407);
            this.dtgDados_ConsultaCom.TabIndex = 12;
            this.dtgDados_ConsultaCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellClick);
            this.dtgDados_ConsultaCom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // pnlFornecedor
            // 
            this.pnlFornecedor.Controls.Add(this.lblNome);
            this.pnlFornecedor.Controls.Add(this.btnLocFornec);
            this.pnlFornecedor.Controls.Add(this.txtForCod);
            this.pnlFornecedor.Controls.Add(this.label1);
            this.pnlFornecedor.Location = new System.Drawing.Point(12, 51);
            this.pnlFornecedor.Name = "pnlFornecedor";
            this.pnlFornecedor.Size = new System.Drawing.Size(760, 53);
            this.pnlFornecedor.TabIndex = 15;
            this.pnlFornecedor.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(442, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(107, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome do Fornecedor";
            // 
            // btnLocFornec
            // 
            this.btnLocFornec.Location = new System.Drawing.Point(210, 22);
            this.btnLocFornec.Name = "btnLocFornec";
            this.btnLocFornec.Size = new System.Drawing.Size(149, 23);
            this.btnLocFornec.TabIndex = 2;
            this.btnLocFornec.Text = "Localizar Fornecedor";
            this.btnLocFornec.UseVisualStyleBackColor = true;
            this.btnLocFornec.Click += new System.EventHandler(this.btnLocFornec_Click);
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(18, 24);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(186, 20);
            this.txtForCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Fornecedor";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblDataFinal_ConsultaCom);
            this.pnlData.Controls.Add(this.dtpFinal_ConsultaCom);
            this.pnlData.Controls.Add(this.dtpInicial_ConsultaCom);
            this.pnlData.Controls.Add(this.btnLocData_ConsultaCom);
            this.pnlData.Controls.Add(this.lblDataInicial_ConsultaCom);
            this.pnlData.Location = new System.Drawing.Point(12, 50);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(760, 54);
            this.pnlData.TabIndex = 16;
            this.pnlData.Visible = false;
            // 
            // lblDataFinal_ConsultaCom
            // 
            this.lblDataFinal_ConsultaCom.AutoSize = true;
            this.lblDataFinal_ConsultaCom.Location = new System.Drawing.Point(303, 7);
            this.lblDataFinal_ConsultaCom.Name = "lblDataFinal_ConsultaCom";
            this.lblDataFinal_ConsultaCom.Size = new System.Drawing.Size(55, 13);
            this.lblDataFinal_ConsultaCom.TabIndex = 4;
            this.lblDataFinal_ConsultaCom.Text = "Data Final";
            // 
            // dtpFinal_ConsultaCom
            // 
            this.dtpFinal_ConsultaCom.Location = new System.Drawing.Point(306, 23);
            this.dtpFinal_ConsultaCom.Name = "dtpFinal_ConsultaCom";
            this.dtpFinal_ConsultaCom.Size = new System.Drawing.Size(238, 20);
            this.dtpFinal_ConsultaCom.TabIndex = 3;
            // 
            // dtpInicial_ConsultaCom
            // 
            this.dtpInicial_ConsultaCom.Location = new System.Drawing.Point(35, 23);
            this.dtpInicial_ConsultaCom.Name = "dtpInicial_ConsultaCom";
            this.dtpInicial_ConsultaCom.Size = new System.Drawing.Size(233, 20);
            this.dtpInicial_ConsultaCom.TabIndex = 2;
            // 
            // btnLocData_ConsultaCom
            // 
            this.btnLocData_ConsultaCom.Location = new System.Drawing.Point(586, 20);
            this.btnLocData_ConsultaCom.Name = "btnLocData_ConsultaCom";
            this.btnLocData_ConsultaCom.Size = new System.Drawing.Size(138, 23);
            this.btnLocData_ConsultaCom.TabIndex = 1;
            this.btnLocData_ConsultaCom.Text = "Localizar";
            this.btnLocData_ConsultaCom.UseVisualStyleBackColor = true;
            this.btnLocData_ConsultaCom.Click += new System.EventHandler(this.btnLocData_Click);
            // 
            // lblDataInicial_ConsultaCom
            // 
            this.lblDataInicial_ConsultaCom.AutoSize = true;
            this.lblDataInicial_ConsultaCom.Location = new System.Drawing.Point(32, 7);
            this.lblDataInicial_ConsultaCom.Name = "lblDataInicial_ConsultaCom";
            this.lblDataInicial_ConsultaCom.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicial_ConsultaCom.TabIndex = 0;
            this.lblDataInicial_ConsultaCom.Text = "Data Inicial";
            // 
            // tbcDados_ConsultaCom
            // 
            this.tbcDados_ConsultaCom.Controls.Add(this.tbpAbaCompra);
            this.tbcDados_ConsultaCom.Controls.Add(this.tbpAbaItens);
            this.tbcDados_ConsultaCom.Controls.Add(this.tbpAbaParcelas);
            this.tbcDados_ConsultaCom.Location = new System.Drawing.Point(12, 110);
            this.tbcDados_ConsultaCom.Name = "tbcDados_ConsultaCom";
            this.tbcDados_ConsultaCom.SelectedIndex = 0;
            this.tbcDados_ConsultaCom.Size = new System.Drawing.Size(760, 439);
            this.tbcDados_ConsultaCom.TabIndex = 17;
            // 
            // tbpAbaCompra
            // 
            this.tbpAbaCompra.Controls.Add(this.dtgDados_ConsultaCom);
            this.tbpAbaCompra.Location = new System.Drawing.Point(4, 22);
            this.tbpAbaCompra.Name = "tbpAbaCompra";
            this.tbpAbaCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbaCompra.Size = new System.Drawing.Size(752, 413);
            this.tbpAbaCompra.TabIndex = 0;
            this.tbpAbaCompra.Text = "Compra";
            this.tbpAbaCompra.UseVisualStyleBackColor = true;
            // 
            // tbpAbaItens
            // 
            this.tbpAbaItens.Controls.Add(this.dtgItens_ConsultaCom);
            this.tbpAbaItens.Location = new System.Drawing.Point(4, 22);
            this.tbpAbaItens.Name = "tbpAbaItens";
            this.tbpAbaItens.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbaItens.Size = new System.Drawing.Size(752, 413);
            this.tbpAbaItens.TabIndex = 1;
            this.tbpAbaItens.Text = "Itens da Compra";
            this.tbpAbaItens.UseVisualStyleBackColor = true;
            // 
            // dtgItens_ConsultaCom
            // 
            this.dtgItens_ConsultaCom.AllowUserToAddRows = false;
            this.dtgItens_ConsultaCom.AllowUserToDeleteRows = false;
            this.dtgItens_ConsultaCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItens_ConsultaCom.Location = new System.Drawing.Point(3, 3);
            this.dtgItens_ConsultaCom.Name = "dtgItens_ConsultaCom";
            this.dtgItens_ConsultaCom.ReadOnly = true;
            this.dtgItens_ConsultaCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItens_ConsultaCom.Size = new System.Drawing.Size(746, 407);
            this.dtgItens_ConsultaCom.TabIndex = 13;
            // 
            // tbpAbaParcelas
            // 
            this.tbpAbaParcelas.Controls.Add(this.dtgParcelas_ConsultaCom);
            this.tbpAbaParcelas.Location = new System.Drawing.Point(4, 22);
            this.tbpAbaParcelas.Name = "tbpAbaParcelas";
            this.tbpAbaParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbaParcelas.Size = new System.Drawing.Size(752, 413);
            this.tbpAbaParcelas.TabIndex = 2;
            this.tbpAbaParcelas.Text = "Parcelas da Compra";
            this.tbpAbaParcelas.UseVisualStyleBackColor = true;
            // 
            // dtgParcelas_ConsultaCom
            // 
            this.dtgParcelas_ConsultaCom.AllowUserToAddRows = false;
            this.dtgParcelas_ConsultaCom.AllowUserToDeleteRows = false;
            this.dtgParcelas_ConsultaCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParcelas_ConsultaCom.Location = new System.Drawing.Point(3, 3);
            this.dtgParcelas_ConsultaCom.Name = "dtgParcelas_ConsultaCom";
            this.dtgParcelas_ConsultaCom.ReadOnly = true;
            this.dtgParcelas_ConsultaCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParcelas_ConsultaCom.Size = new System.Drawing.Size(746, 407);
            this.dtgParcelas_ConsultaCom.TabIndex = 13;
            this.dtgParcelas_ConsultaCom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParcelas_ConsultaCom_CellContentClick);
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbcDados_ConsultaCom);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlFornecedor);
            this.Controls.Add(this.gpbConsultaPor_ConsultaCom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compras";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.gpbConsultaPor_ConsultaCom.ResumeLayout(false);
            this.gpbConsultaPor_ConsultaCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaCom)).EndInit();
            this.pnlFornecedor.ResumeLayout(false);
            this.pnlFornecedor.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.tbcDados_ConsultaCom.ResumeLayout(false);
            this.tbpAbaCompra.ResumeLayout(false);
            this.tbpAbaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens_ConsultaCom)).EndInit();
            this.tbpAbaParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas_ConsultaCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultaPor_ConsultaCom;
        private System.Windows.Forms.RadioButton rdbData_ConsultaCom;
        private System.Windows.Forms.RadioButton rdbFornecedor_ConsultaCom;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaCom;
        private System.Windows.Forms.RadioButton rdbParcelas_ConsultaCom;
        private System.Windows.Forms.RadioButton rdbGeral_ConsultaCom;
        private System.Windows.Forms.Panel pnlFornecedor;
        private System.Windows.Forms.Button btnLocFornec;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblDataFinal_ConsultaCom;
        private System.Windows.Forms.DateTimePicker dtpFinal_ConsultaCom;
        private System.Windows.Forms.DateTimePicker dtpInicial_ConsultaCom;
        private System.Windows.Forms.Button btnLocData_ConsultaCom;
        private System.Windows.Forms.Label lblDataInicial_ConsultaCom;
        private System.Windows.Forms.TabControl tbcDados_ConsultaCom;
        private System.Windows.Forms.TabPage tbpAbaCompra;
        private System.Windows.Forms.TabPage tbpAbaItens;
        private System.Windows.Forms.TabPage tbpAbaParcelas;
        private System.Windows.Forms.DataGridView dtgItens_ConsultaCom;
        private System.Windows.Forms.DataGridView dtgParcelas_ConsultaCom;
    }
}