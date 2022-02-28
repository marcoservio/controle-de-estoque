namespace GUI
{
    partial class frmConsultaVenda
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
            this.dtgParcelas_ConsultaVenda = new System.Windows.Forms.DataGridView();
            this.dtgItens_ConsultaVenda = new System.Windows.Forms.DataGridView();
            this.tbpAbaVenda = new System.Windows.Forms.TabPage();
            this.dtgDados_ConsultaVenda = new System.Windows.Forms.DataGridView();
            this.tbpAbaItens = new System.Windows.Forms.TabPage();
            this.dtpFinal_ConsultaVenda = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial_ConsultaVenda = new System.Windows.Forms.DateTimePicker();
            this.btnLocData_ConsultaVenda = new System.Windows.Forms.Button();
            this.lblDataInicial_ConsultaVenda = new System.Windows.Forms.Label();
            this.lblNome_ConsultaCliente = new System.Windows.Forms.Label();
            this.btnLocCliente_ConsultaVenda = new System.Windows.Forms.Button();
            this.txtCliente_ConsultaVenda = new System.Windows.Forms.TextBox();
            this.lblDataFinal_ConsultaVenda = new System.Windows.Forms.Label();
            this.lblCodCliente_ConsutaVenda = new System.Windows.Forms.Label();
            this.tbpAbaParcelas = new System.Windows.Forms.TabPage();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.rdbGeral_ConsultaVenda = new System.Windows.Forms.RadioButton();
            this.rdbParcelas_ConsultaVenda = new System.Windows.Forms.RadioButton();
            this.rdbData_ConsultaVenda = new System.Windows.Forms.RadioButton();
            this.rdbCliente_ConsultaVenda = new System.Windows.Forms.RadioButton();
            this.tbcDados_ConsultaCom = new System.Windows.Forms.TabControl();
            this.pnlData = new System.Windows.Forms.Panel();
            this.gpbConsultaPor_ConsultaCom = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas_ConsultaVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens_ConsultaVenda)).BeginInit();
            this.tbpAbaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaVenda)).BeginInit();
            this.tbpAbaItens.SuspendLayout();
            this.tbpAbaParcelas.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.tbcDados_ConsultaCom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.gpbConsultaPor_ConsultaCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgParcelas_ConsultaVenda
            // 
            this.dtgParcelas_ConsultaVenda.AllowUserToAddRows = false;
            this.dtgParcelas_ConsultaVenda.AllowUserToDeleteRows = false;
            this.dtgParcelas_ConsultaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParcelas_ConsultaVenda.Location = new System.Drawing.Point(3, 3);
            this.dtgParcelas_ConsultaVenda.Name = "dtgParcelas_ConsultaVenda";
            this.dtgParcelas_ConsultaVenda.ReadOnly = true;
            this.dtgParcelas_ConsultaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParcelas_ConsultaVenda.Size = new System.Drawing.Size(746, 407);
            this.dtgParcelas_ConsultaVenda.TabIndex = 13;
            // 
            // dtgItens_ConsultaVenda
            // 
            this.dtgItens_ConsultaVenda.AllowUserToAddRows = false;
            this.dtgItens_ConsultaVenda.AllowUserToDeleteRows = false;
            this.dtgItens_ConsultaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItens_ConsultaVenda.Location = new System.Drawing.Point(3, 3);
            this.dtgItens_ConsultaVenda.Name = "dtgItens_ConsultaVenda";
            this.dtgItens_ConsultaVenda.ReadOnly = true;
            this.dtgItens_ConsultaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItens_ConsultaVenda.Size = new System.Drawing.Size(746, 407);
            this.dtgItens_ConsultaVenda.TabIndex = 13;
            // 
            // tbpAbaVenda
            // 
            this.tbpAbaVenda.Controls.Add(this.dtgDados_ConsultaVenda);
            this.tbpAbaVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpAbaVenda.Name = "tbpAbaVenda";
            this.tbpAbaVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbaVenda.Size = new System.Drawing.Size(752, 413);
            this.tbpAbaVenda.TabIndex = 0;
            this.tbpAbaVenda.Text = "Vendas";
            this.tbpAbaVenda.UseVisualStyleBackColor = true;
            // 
            // dtgDados_ConsultaVenda
            // 
            this.dtgDados_ConsultaVenda.AllowUserToAddRows = false;
            this.dtgDados_ConsultaVenda.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaVenda.Location = new System.Drawing.Point(3, 3);
            this.dtgDados_ConsultaVenda.Name = "dtgDados_ConsultaVenda";
            this.dtgDados_ConsultaVenda.ReadOnly = true;
            this.dtgDados_ConsultaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaVenda.Size = new System.Drawing.Size(746, 407);
            this.dtgDados_ConsultaVenda.TabIndex = 12;
            this.dtgDados_ConsultaVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_ConsultaVenda_CellClick);
            this.dtgDados_ConsultaVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_ConsultaVenda_CellDoubleClick);
            // 
            // tbpAbaItens
            // 
            this.tbpAbaItens.Controls.Add(this.dtgItens_ConsultaVenda);
            this.tbpAbaItens.Location = new System.Drawing.Point(4, 22);
            this.tbpAbaItens.Name = "tbpAbaItens";
            this.tbpAbaItens.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbaItens.Size = new System.Drawing.Size(752, 413);
            this.tbpAbaItens.TabIndex = 1;
            this.tbpAbaItens.Text = "Itens da Venda";
            this.tbpAbaItens.UseVisualStyleBackColor = true;
            // 
            // dtpFinal_ConsultaVenda
            // 
            this.dtpFinal_ConsultaVenda.Location = new System.Drawing.Point(306, 23);
            this.dtpFinal_ConsultaVenda.Name = "dtpFinal_ConsultaVenda";
            this.dtpFinal_ConsultaVenda.Size = new System.Drawing.Size(238, 20);
            this.dtpFinal_ConsultaVenda.TabIndex = 3;
            // 
            // dtpInicial_ConsultaVenda
            // 
            this.dtpInicial_ConsultaVenda.Location = new System.Drawing.Point(35, 23);
            this.dtpInicial_ConsultaVenda.Name = "dtpInicial_ConsultaVenda";
            this.dtpInicial_ConsultaVenda.Size = new System.Drawing.Size(233, 20);
            this.dtpInicial_ConsultaVenda.TabIndex = 2;
            // 
            // btnLocData_ConsultaVenda
            // 
            this.btnLocData_ConsultaVenda.Location = new System.Drawing.Point(586, 20);
            this.btnLocData_ConsultaVenda.Name = "btnLocData_ConsultaVenda";
            this.btnLocData_ConsultaVenda.Size = new System.Drawing.Size(138, 23);
            this.btnLocData_ConsultaVenda.TabIndex = 1;
            this.btnLocData_ConsultaVenda.Text = "Localizar";
            this.btnLocData_ConsultaVenda.UseVisualStyleBackColor = true;
            this.btnLocData_ConsultaVenda.Click += new System.EventHandler(this.btnLocData_ConsultaVenda_Click);
            // 
            // lblDataInicial_ConsultaVenda
            // 
            this.lblDataInicial_ConsultaVenda.AutoSize = true;
            this.lblDataInicial_ConsultaVenda.Location = new System.Drawing.Point(32, 7);
            this.lblDataInicial_ConsultaVenda.Name = "lblDataInicial_ConsultaVenda";
            this.lblDataInicial_ConsultaVenda.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicial_ConsultaVenda.TabIndex = 0;
            this.lblDataInicial_ConsultaVenda.Text = "Data Inicial";
            // 
            // lblNome_ConsultaCliente
            // 
            this.lblNome_ConsultaCliente.AutoSize = true;
            this.lblNome_ConsultaCliente.Location = new System.Drawing.Point(442, 27);
            this.lblNome_ConsultaCliente.Name = "lblNome_ConsultaCliente";
            this.lblNome_ConsultaCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNome_ConsultaCliente.TabIndex = 3;
            this.lblNome_ConsultaCliente.Text = "Nome do Cliente";
            // 
            // btnLocCliente_ConsultaVenda
            // 
            this.btnLocCliente_ConsultaVenda.Location = new System.Drawing.Point(210, 22);
            this.btnLocCliente_ConsultaVenda.Name = "btnLocCliente_ConsultaVenda";
            this.btnLocCliente_ConsultaVenda.Size = new System.Drawing.Size(149, 23);
            this.btnLocCliente_ConsultaVenda.TabIndex = 2;
            this.btnLocCliente_ConsultaVenda.Text = "Localizar Cliente";
            this.btnLocCliente_ConsultaVenda.UseVisualStyleBackColor = true;
            this.btnLocCliente_ConsultaVenda.Click += new System.EventHandler(this.btnLocalizar_ConsultaCliente_Click);
            // 
            // txtCliente_ConsultaVenda
            // 
            this.txtCliente_ConsultaVenda.Enabled = false;
            this.txtCliente_ConsultaVenda.Location = new System.Drawing.Point(18, 24);
            this.txtCliente_ConsultaVenda.Name = "txtCliente_ConsultaVenda";
            this.txtCliente_ConsultaVenda.Size = new System.Drawing.Size(186, 20);
            this.txtCliente_ConsultaVenda.TabIndex = 1;
            // 
            // lblDataFinal_ConsultaVenda
            // 
            this.lblDataFinal_ConsultaVenda.AutoSize = true;
            this.lblDataFinal_ConsultaVenda.Location = new System.Drawing.Point(303, 7);
            this.lblDataFinal_ConsultaVenda.Name = "lblDataFinal_ConsultaVenda";
            this.lblDataFinal_ConsultaVenda.Size = new System.Drawing.Size(55, 13);
            this.lblDataFinal_ConsultaVenda.TabIndex = 4;
            this.lblDataFinal_ConsultaVenda.Text = "Data Final";
            // 
            // lblCodCliente_ConsutaVenda
            // 
            this.lblCodCliente_ConsutaVenda.AutoSize = true;
            this.lblCodCliente_ConsutaVenda.Location = new System.Drawing.Point(15, 8);
            this.lblCodCliente_ConsutaVenda.Name = "lblCodCliente_ConsutaVenda";
            this.lblCodCliente_ConsutaVenda.Size = new System.Drawing.Size(90, 13);
            this.lblCodCliente_ConsutaVenda.TabIndex = 0;
            this.lblCodCliente_ConsutaVenda.Text = "Código do Cliente";
            // 
            // tbpAbaParcelas
            // 
            this.tbpAbaParcelas.Controls.Add(this.dtgParcelas_ConsultaVenda);
            this.tbpAbaParcelas.Location = new System.Drawing.Point(4, 22);
            this.tbpAbaParcelas.Name = "tbpAbaParcelas";
            this.tbpAbaParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbaParcelas.Size = new System.Drawing.Size(752, 413);
            this.tbpAbaParcelas.TabIndex = 2;
            this.tbpAbaParcelas.Text = "Parcelas da Venda";
            this.tbpAbaParcelas.UseVisualStyleBackColor = true;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblNome_ConsultaCliente);
            this.pnlCliente.Controls.Add(this.btnLocCliente_ConsultaVenda);
            this.pnlCliente.Controls.Add(this.txtCliente_ConsultaVenda);
            this.pnlCliente.Controls.Add(this.lblCodCliente_ConsutaVenda);
            this.pnlCliente.Location = new System.Drawing.Point(12, 53);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(760, 56);
            this.pnlCliente.TabIndex = 19;
            this.pnlCliente.Visible = false;
            // 
            // rdbGeral_ConsultaVenda
            // 
            this.rdbGeral_ConsultaVenda.AutoSize = true;
            this.rdbGeral_ConsultaVenda.Checked = true;
            this.rdbGeral_ConsultaVenda.Location = new System.Drawing.Point(6, 15);
            this.rdbGeral_ConsultaVenda.Name = "rdbGeral_ConsultaVenda";
            this.rdbGeral_ConsultaVenda.Size = new System.Drawing.Size(108, 17);
            this.rdbGeral_ConsultaVenda.TabIndex = 13;
            this.rdbGeral_ConsultaVenda.TabStop = true;
            this.rdbGeral_ConsultaVenda.Text = "Todas as Vendas";
            this.rdbGeral_ConsultaVenda.UseVisualStyleBackColor = true;
            this.rdbGeral_ConsultaVenda.CheckedChanged += new System.EventHandler(this.rdbGeral_ConsultaVenda_CheckedChanged);
            // 
            // rdbParcelas_ConsultaVenda
            // 
            this.rdbParcelas_ConsultaVenda.AutoSize = true;
            this.rdbParcelas_ConsultaVenda.Location = new System.Drawing.Point(636, 15);
            this.rdbParcelas_ConsultaVenda.Name = "rdbParcelas_ConsultaVenda";
            this.rdbParcelas_ConsultaVenda.Size = new System.Drawing.Size(117, 17);
            this.rdbParcelas_ConsultaVenda.TabIndex = 12;
            this.rdbParcelas_ConsultaVenda.Text = "Parcelas em Aberto";
            this.rdbParcelas_ConsultaVenda.UseVisualStyleBackColor = true;
            this.rdbParcelas_ConsultaVenda.CheckedChanged += new System.EventHandler(this.rdbGeral_ConsultaVenda_CheckedChanged);
            // 
            // rdbData_ConsultaVenda
            // 
            this.rdbData_ConsultaVenda.AutoSize = true;
            this.rdbData_ConsultaVenda.Location = new System.Drawing.Point(422, 15);
            this.rdbData_ConsultaVenda.Name = "rdbData_ConsultaVenda";
            this.rdbData_ConsultaVenda.Size = new System.Drawing.Size(97, 17);
            this.rdbData_ConsultaVenda.TabIndex = 11;
            this.rdbData_ConsultaVenda.Text = "Data da Venda";
            this.rdbData_ConsultaVenda.UseVisualStyleBackColor = true;
            this.rdbData_ConsultaVenda.CheckedChanged += new System.EventHandler(this.rdbGeral_ConsultaVenda_CheckedChanged);
            // 
            // rdbCliente_ConsultaVenda
            // 
            this.rdbCliente_ConsultaVenda.AutoSize = true;
            this.rdbCliente_ConsultaVenda.Location = new System.Drawing.Point(231, 15);
            this.rdbCliente_ConsultaVenda.Name = "rdbCliente_ConsultaVenda";
            this.rdbCliente_ConsultaVenda.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente_ConsultaVenda.TabIndex = 10;
            this.rdbCliente_ConsultaVenda.Text = "Cliente";
            this.rdbCliente_ConsultaVenda.UseVisualStyleBackColor = true;
            this.rdbCliente_ConsultaVenda.CheckedChanged += new System.EventHandler(this.rdbGeral_ConsultaVenda_CheckedChanged);
            // 
            // tbcDados_ConsultaCom
            // 
            this.tbcDados_ConsultaCom.Controls.Add(this.tbpAbaVenda);
            this.tbcDados_ConsultaCom.Controls.Add(this.tbpAbaItens);
            this.tbcDados_ConsultaCom.Controls.Add(this.tbpAbaParcelas);
            this.tbcDados_ConsultaCom.Location = new System.Drawing.Point(12, 112);
            this.tbcDados_ConsultaCom.Name = "tbcDados_ConsultaCom";
            this.tbcDados_ConsultaCom.SelectedIndex = 0;
            this.tbcDados_ConsultaCom.Size = new System.Drawing.Size(760, 439);
            this.tbcDados_ConsultaCom.TabIndex = 21;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblDataFinal_ConsultaVenda);
            this.pnlData.Controls.Add(this.dtpFinal_ConsultaVenda);
            this.pnlData.Controls.Add(this.dtpInicial_ConsultaVenda);
            this.pnlData.Controls.Add(this.btnLocData_ConsultaVenda);
            this.pnlData.Controls.Add(this.lblDataInicial_ConsultaVenda);
            this.pnlData.Location = new System.Drawing.Point(12, 52);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(760, 54);
            this.pnlData.TabIndex = 20;
            this.pnlData.Visible = false;
            // 
            // gpbConsultaPor_ConsultaCom
            // 
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbGeral_ConsultaVenda);
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbParcelas_ConsultaVenda);
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbData_ConsultaVenda);
            this.gpbConsultaPor_ConsultaCom.Controls.Add(this.rdbCliente_ConsultaVenda);
            this.gpbConsultaPor_ConsultaCom.Location = new System.Drawing.Point(12, 10);
            this.gpbConsultaPor_ConsultaCom.Name = "gpbConsultaPor_ConsultaCom";
            this.gpbConsultaPor_ConsultaCom.Size = new System.Drawing.Size(760, 37);
            this.gpbConsultaPor_ConsultaCom.TabIndex = 18;
            this.gpbConsultaPor_ConsultaCom.TabStop = false;
            this.gpbConsultaPor_ConsultaCom.Text = "Consultar por:";
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.tbcDados_ConsultaCom);
            this.Controls.Add(this.gpbConsultaPor_ConsultaCom);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Venda";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas_ConsultaVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens_ConsultaVenda)).EndInit();
            this.tbpAbaVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaVenda)).EndInit();
            this.tbpAbaItens.ResumeLayout(false);
            this.tbpAbaParcelas.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.tbcDados_ConsultaCom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.gpbConsultaPor_ConsultaCom.ResumeLayout(false);
            this.gpbConsultaPor_ConsultaCom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgParcelas_ConsultaVenda;
        private System.Windows.Forms.DataGridView dtgItens_ConsultaVenda;
        private System.Windows.Forms.TabPage tbpAbaVenda;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaVenda;
        private System.Windows.Forms.TabPage tbpAbaItens;
        private System.Windows.Forms.DateTimePicker dtpFinal_ConsultaVenda;
        private System.Windows.Forms.DateTimePicker dtpInicial_ConsultaVenda;
        private System.Windows.Forms.Button btnLocData_ConsultaVenda;
        private System.Windows.Forms.Label lblDataInicial_ConsultaVenda;
        private System.Windows.Forms.Label lblNome_ConsultaCliente;
        private System.Windows.Forms.Button btnLocCliente_ConsultaVenda;
        private System.Windows.Forms.TextBox txtCliente_ConsultaVenda;
        private System.Windows.Forms.Label lblDataFinal_ConsultaVenda;
        private System.Windows.Forms.Label lblCodCliente_ConsutaVenda;
        private System.Windows.Forms.TabPage tbpAbaParcelas;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.RadioButton rdbGeral_ConsultaVenda;
        private System.Windows.Forms.RadioButton rdbParcelas_ConsultaVenda;
        private System.Windows.Forms.RadioButton rdbData_ConsultaVenda;
        private System.Windows.Forms.RadioButton rdbCliente_ConsultaVenda;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.GroupBox gpbConsultaPor_ConsultaCom;
        private System.Windows.Forms.TabControl tbcDados_ConsultaCom;
    }
}