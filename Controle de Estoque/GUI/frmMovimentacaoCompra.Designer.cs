namespace GUI
{
    partial class frmMovimentacaoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoCompra));
            this.lblComCod_Compra = new System.Windows.Forms.Label();
            this.txtComCod_Compra = new System.Windows.Forms.TextBox();
            this.txtNfiscal_Compra = new System.Windows.Forms.TextBox();
            this.lblNFiscal_Compra = new System.Windows.Forms.Label();
            this.dtpDataCompra_Compra = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompra_Compra = new System.Windows.Forms.Label();
            this.lblTotalGeral_Compra = new System.Windows.Forms.Label();
            this.txtTotal_Compra = new System.Windows.Forms.TextBox();
            this.cmbTipoPagamento_Compra = new System.Windows.Forms.ComboBox();
            this.lblTipoPagamento_Compra = new System.Windows.Forms.Label();
            this.cmbNParcelas_Compra = new System.Windows.Forms.ComboBox();
            this.lblNParcelas_Compra = new System.Windows.Forms.Label();
            this.dtPDataIni_Compra = new System.Windows.Forms.DateTimePicker();
            this.lblDataIni_Compra = new System.Windows.Forms.Label();
            this.dgvItensCompra = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtForCod_Compra = new System.Windows.Forms.TextBox();
            this.lblForCod_Compra = new System.Windows.Forms.Label();
            this.btnLocFor_Compra = new System.Windows.Forms.Button();
            this.lblFornecedor_Compra = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProCod_Compra = new System.Windows.Forms.Label();
            this.txtProCod_Compra = new System.Windows.Forms.TextBox();
            this.btnLocProd_Compra = new System.Windows.Forms.Button();
            this.lblProduto_Compra = new System.Windows.Forms.Label();
            this.lblQuantidade_Compra = new System.Windows.Forms.Label();
            this.txtQuantidade_Compra = new System.Windows.Forms.TextBox();
            this.txtValorUnitario_Compra = new System.Windows.Forms.TextBox();
            this.lblValorUnitario_Compra = new System.Windows.Forms.Label();
            this.lblItens_Compra = new System.Windows.Forms.Label();
            this.btnAddProd_Compra = new System.Windows.Forms.Button();
            this.lblDinheiro_Compra = new System.Windows.Forms.Label();
            this.pnlFinalizaCompra = new System.Windows.Forms.Panel();
            this.lblDinheiro3_Compra = new System.Windows.Forms.Label();
            this.lblTotal2_Compra = new System.Windows.Forms.Label();
            this.lblTotalGeral2_Compra = new System.Windows.Forms.Label();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnSalvarParcelas = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblParcelas_Compra = new System.Windows.Forms.Label();
            this.lblDadosPagamento_Compra = new System.Windows.Forms.Label();
            this.dgvParcelas_Compra = new System.Windows.Forms.DataGridView();
            this.pcoCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcoDataVecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDinheiro2_Compra = new System.Windows.Forms.Label();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).BeginInit();
            this.pnlFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas_Compra)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lblDinheiro2_Compra);
            this.pnlDados.Controls.Add(this.lblDinheiro_Compra);
            this.pnlDados.Controls.Add(this.btnAddProd_Compra);
            this.pnlDados.Controls.Add(this.lblItens_Compra);
            this.pnlDados.Controls.Add(this.lblValorUnitario_Compra);
            this.pnlDados.Controls.Add(this.txtValorUnitario_Compra);
            this.pnlDados.Controls.Add(this.txtQuantidade_Compra);
            this.pnlDados.Controls.Add(this.lblQuantidade_Compra);
            this.pnlDados.Controls.Add(this.lblProduto_Compra);
            this.pnlDados.Controls.Add(this.btnLocProd_Compra);
            this.pnlDados.Controls.Add(this.txtProCod_Compra);
            this.pnlDados.Controls.Add(this.lblProCod_Compra);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.lblFornecedor_Compra);
            this.pnlDados.Controls.Add(this.btnLocFor_Compra);
            this.pnlDados.Controls.Add(this.lblForCod_Compra);
            this.pnlDados.Controls.Add(this.txtForCod_Compra);
            this.pnlDados.Controls.Add(this.dgvItensCompra);
            this.pnlDados.Controls.Add(this.lblDataIni_Compra);
            this.pnlDados.Controls.Add(this.dtPDataIni_Compra);
            this.pnlDados.Controls.Add(this.lblNParcelas_Compra);
            this.pnlDados.Controls.Add(this.cmbNParcelas_Compra);
            this.pnlDados.Controls.Add(this.lblTipoPagamento_Compra);
            this.pnlDados.Controls.Add(this.cmbTipoPagamento_Compra);
            this.pnlDados.Controls.Add(this.txtTotal_Compra);
            this.pnlDados.Controls.Add(this.lblTotalGeral_Compra);
            this.pnlDados.Controls.Add(this.lblDataCompra_Compra);
            this.pnlDados.Controls.Add(this.dtpDataCompra_Compra);
            this.pnlDados.Controls.Add(this.lblNFiscal_Compra);
            this.pnlDados.Controls.Add(this.txtNfiscal_Compra);
            this.pnlDados.Controls.Add(this.txtComCod_Compra);
            this.pnlDados.Controls.Add(this.lblComCod_Compra);
            this.pnlDados.Location = new System.Drawing.Point(10, 12);
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
            // lblComCod_Compra
            // 
            this.lblComCod_Compra.AutoSize = true;
            this.lblComCod_Compra.Location = new System.Drawing.Point(13, 23);
            this.lblComCod_Compra.Name = "lblComCod_Compra";
            this.lblComCod_Compra.Size = new System.Drawing.Size(40, 13);
            this.lblComCod_Compra.TabIndex = 0;
            this.lblComCod_Compra.Text = "Código";
            // 
            // txtComCod_Compra
            // 
            this.txtComCod_Compra.Enabled = false;
            this.txtComCod_Compra.Location = new System.Drawing.Point(16, 40);
            this.txtComCod_Compra.Name = "txtComCod_Compra";
            this.txtComCod_Compra.Size = new System.Drawing.Size(100, 20);
            this.txtComCod_Compra.TabIndex = 1;
            // 
            // txtNfiscal_Compra
            // 
            this.txtNfiscal_Compra.Location = new System.Drawing.Point(156, 40);
            this.txtNfiscal_Compra.Name = "txtNfiscal_Compra";
            this.txtNfiscal_Compra.Size = new System.Drawing.Size(304, 20);
            this.txtNfiscal_Compra.TabIndex = 2;
            this.txtNfiscal_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNfiscal_Compra_KeyPress);
            // 
            // lblNFiscal_Compra
            // 
            this.lblNFiscal_Compra.AutoSize = true;
            this.lblNFiscal_Compra.Location = new System.Drawing.Point(153, 23);
            this.lblNFiscal_Compra.Name = "lblNFiscal_Compra";
            this.lblNFiscal_Compra.Size = new System.Drawing.Size(110, 13);
            this.lblNFiscal_Compra.TabIndex = 3;
            this.lblNFiscal_Compra.Text = "Número da nota fiscal";
            // 
            // dtpDataCompra_Compra
            // 
            this.dtpDataCompra_Compra.Location = new System.Drawing.Point(500, 40);
            this.dtpDataCompra_Compra.Name = "dtpDataCompra_Compra";
            this.dtpDataCompra_Compra.Size = new System.Drawing.Size(240, 20);
            this.dtpDataCompra_Compra.TabIndex = 4;
            // 
            // lblDataCompra_Compra
            // 
            this.lblDataCompra_Compra.AutoSize = true;
            this.lblDataCompra_Compra.Location = new System.Drawing.Point(497, 23);
            this.lblDataCompra_Compra.Name = "lblDataCompra_Compra";
            this.lblDataCompra_Compra.Size = new System.Drawing.Size(83, 13);
            this.lblDataCompra_Compra.TabIndex = 5;
            this.lblDataCompra_Compra.Text = "Data da compra";
            // 
            // lblTotalGeral_Compra
            // 
            this.lblTotalGeral_Compra.AutoSize = true;
            this.lblTotalGeral_Compra.BackColor = System.Drawing.Color.Red;
            this.lblTotalGeral_Compra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalGeral_Compra.Location = new System.Drawing.Point(609, 387);
            this.lblTotalGeral_Compra.Name = "lblTotalGeral_Compra";
            this.lblTotalGeral_Compra.Size = new System.Drawing.Size(31, 13);
            this.lblTotalGeral_Compra.TabIndex = 6;
            this.lblTotalGeral_Compra.Text = "Total";
            // 
            // txtTotal_Compra
            // 
            this.txtTotal_Compra.Enabled = false;
            this.txtTotal_Compra.Location = new System.Drawing.Point(612, 403);
            this.txtTotal_Compra.Name = "txtTotal_Compra";
            this.txtTotal_Compra.Size = new System.Drawing.Size(128, 20);
            this.txtTotal_Compra.TabIndex = 7;
            this.txtTotal_Compra.Text = "0.00";
            // 
            // cmbTipoPagamento_Compra
            // 
            this.cmbTipoPagamento_Compra.FormattingEnabled = true;
            this.cmbTipoPagamento_Compra.Location = new System.Drawing.Point(180, 403);
            this.cmbTipoPagamento_Compra.Name = "cmbTipoPagamento_Compra";
            this.cmbTipoPagamento_Compra.Size = new System.Drawing.Size(147, 21);
            this.cmbTipoPagamento_Compra.TabIndex = 8;
            // 
            // lblTipoPagamento_Compra
            // 
            this.lblTipoPagamento_Compra.AutoSize = true;
            this.lblTipoPagamento_Compra.Location = new System.Drawing.Point(177, 387);
            this.lblTipoPagamento_Compra.Name = "lblTipoPagamento_Compra";
            this.lblTipoPagamento_Compra.Size = new System.Drawing.Size(99, 13);
            this.lblTipoPagamento_Compra.TabIndex = 9;
            this.lblTipoPagamento_Compra.Text = "Tipo de pagamento";
            // 
            // cmbNParcelas_Compra
            // 
            this.cmbNParcelas_Compra.FormattingEnabled = true;
            this.cmbNParcelas_Compra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "10",
            "12",
            "15",
            "18",
            "24"});
            this.cmbNParcelas_Compra.Location = new System.Drawing.Point(16, 403);
            this.cmbNParcelas_Compra.Name = "cmbNParcelas_Compra";
            this.cmbNParcelas_Compra.Size = new System.Drawing.Size(158, 21);
            this.cmbNParcelas_Compra.TabIndex = 10;
            // 
            // lblNParcelas_Compra
            // 
            this.lblNParcelas_Compra.AutoSize = true;
            this.lblNParcelas_Compra.Location = new System.Drawing.Point(13, 387);
            this.lblNParcelas_Compra.Name = "lblNParcelas_Compra";
            this.lblNParcelas_Compra.Size = new System.Drawing.Size(102, 13);
            this.lblNParcelas_Compra.TabIndex = 11;
            this.lblNParcelas_Compra.Text = "Número de parcelas";
            // 
            // dtPDataIni_Compra
            // 
            this.dtPDataIni_Compra.Location = new System.Drawing.Point(333, 404);
            this.dtPDataIni_Compra.Name = "dtPDataIni_Compra";
            this.dtPDataIni_Compra.Size = new System.Drawing.Size(240, 20);
            this.dtPDataIni_Compra.TabIndex = 12;
            // 
            // lblDataIni_Compra
            // 
            this.lblDataIni_Compra.AutoSize = true;
            this.lblDataIni_Compra.Location = new System.Drawing.Point(331, 387);
            this.lblDataIni_Compra.Name = "lblDataIni_Compra";
            this.lblDataIni_Compra.Size = new System.Drawing.Size(130, 13);
            this.lblDataIni_Compra.TabIndex = 13;
            this.lblDataIni_Compra.Text = "Data inicial do pagamento";
            // 
            // dgvItensCompra
            // 
            this.dgvItensCompra.AllowUserToAddRows = false;
            this.dgvItensCompra.AllowUserToDeleteRows = false;
            this.dgvItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtd,
            this.proUnidade,
            this.proVTotal});
            this.dgvItensCompra.Location = new System.Drawing.Point(16, 186);
            this.dgvItensCompra.Name = "dgvItensCompra";
            this.dgvItensCompra.ReadOnly = true;
            this.dgvItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensCompra.Size = new System.Drawing.Size(724, 198);
            this.dgvItensCompra.TabIndex = 14;
            this.dgvItensCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensCompra_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Código";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 70;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 200;
            // 
            // forQtd
            // 
            this.forQtd.HeaderText = "Quantidade";
            this.forQtd.Name = "forQtd";
            this.forQtd.ReadOnly = true;
            // 
            // proUnidade
            // 
            this.proUnidade.HeaderText = "Valor Unitário";
            this.proUnidade.Name = "proUnidade";
            this.proUnidade.ReadOnly = true;
            // 
            // proVTotal
            // 
            this.proVTotal.HeaderText = "Valor Total";
            this.proVTotal.Name = "proVTotal";
            this.proVTotal.ReadOnly = true;
            // 
            // txtForCod_Compra
            // 
            this.txtForCod_Compra.Location = new System.Drawing.Point(16, 81);
            this.txtForCod_Compra.Multiline = true;
            this.txtForCod_Compra.Name = "txtForCod_Compra";
            this.txtForCod_Compra.Size = new System.Drawing.Size(121, 23);
            this.txtForCod_Compra.TabIndex = 15;
            this.txtForCod_Compra.Leave += new System.EventHandler(this.txtForcod_Leave);
            // 
            // lblForCod_Compra
            // 
            this.lblForCod_Compra.AutoSize = true;
            this.lblForCod_Compra.Location = new System.Drawing.Point(13, 63);
            this.lblForCod_Compra.Name = "lblForCod_Compra";
            this.lblForCod_Compra.Size = new System.Drawing.Size(112, 13);
            this.lblForCod_Compra.TabIndex = 16;
            this.lblForCod_Compra.Text = "Codigo do Fornecedor";
            // 
            // btnLocFor_Compra
            // 
            this.btnLocFor_Compra.Location = new System.Drawing.Point(143, 81);
            this.btnLocFor_Compra.Name = "btnLocFor_Compra";
            this.btnLocFor_Compra.Size = new System.Drawing.Size(75, 23);
            this.btnLocFor_Compra.TabIndex = 17;
            this.btnLocFor_Compra.Text = "Localizar";
            this.btnLocFor_Compra.UseVisualStyleBackColor = true;
            this.btnLocFor_Compra.Click += new System.EventHandler(this.btnLocFor_Click);
            // 
            // lblFornecedor_Compra
            // 
            this.lblFornecedor_Compra.AutoSize = true;
            this.lblFornecedor_Compra.Location = new System.Drawing.Point(224, 86);
            this.lblFornecedor_Compra.Name = "lblFornecedor_Compra";
            this.lblFornecedor_Compra.Size = new System.Drawing.Size(259, 13);
            this.lblFornecedor_Compra.TabIndex = 18;
            this.lblFornecedor_Compra.Text = "Informe o código do fornecedor ou clique em localizar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(727, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // lblProCod_Compra
            // 
            this.lblProCod_Compra.AutoSize = true;
            this.lblProCod_Compra.Location = new System.Drawing.Point(13, 128);
            this.lblProCod_Compra.Name = "lblProCod_Compra";
            this.lblProCod_Compra.Size = new System.Drawing.Size(95, 13);
            this.lblProCod_Compra.TabIndex = 20;
            this.lblProCod_Compra.Text = "Codigo do Produto";
            // 
            // txtProCod_Compra
            // 
            this.txtProCod_Compra.Location = new System.Drawing.Point(16, 144);
            this.txtProCod_Compra.Multiline = true;
            this.txtProCod_Compra.Name = "txtProCod_Compra";
            this.txtProCod_Compra.Size = new System.Drawing.Size(121, 23);
            this.txtProCod_Compra.TabIndex = 21;
            this.txtProCod_Compra.Leave += new System.EventHandler(this.txtProcod_Leave);
            // 
            // btnLocProd_Compra
            // 
            this.btnLocProd_Compra.Location = new System.Drawing.Point(143, 144);
            this.btnLocProd_Compra.Name = "btnLocProd_Compra";
            this.btnLocProd_Compra.Size = new System.Drawing.Size(75, 23);
            this.btnLocProd_Compra.TabIndex = 22;
            this.btnLocProd_Compra.Text = "Localizar";
            this.btnLocProd_Compra.UseVisualStyleBackColor = true;
            this.btnLocProd_Compra.Click += new System.EventHandler(this.btnLocProd_Click);
            // 
            // lblProduto_Compra
            // 
            this.lblProduto_Compra.AutoSize = true;
            this.lblProduto_Compra.Location = new System.Drawing.Point(224, 149);
            this.lblProduto_Compra.Name = "lblProduto_Compra";
            this.lblProduto_Compra.Size = new System.Drawing.Size(244, 13);
            this.lblProduto_Compra.TabIndex = 23;
            this.lblProduto_Compra.Text = "Informe o código do produto ou clique em localizar";
            // 
            // lblQuantidade_Compra
            // 
            this.lblQuantidade_Compra.AutoSize = true;
            this.lblQuantidade_Compra.BackColor = System.Drawing.Color.Red;
            this.lblQuantidade_Compra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantidade_Compra.Location = new System.Drawing.Point(479, 126);
            this.lblQuantidade_Compra.Name = "lblQuantidade_Compra";
            this.lblQuantidade_Compra.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade_Compra.TabIndex = 24;
            this.lblQuantidade_Compra.Text = "Quantidade";
            // 
            // txtQuantidade_Compra
            // 
            this.txtQuantidade_Compra.Location = new System.Drawing.Point(482, 142);
            this.txtQuantidade_Compra.Multiline = true;
            this.txtQuantidade_Compra.Name = "txtQuantidade_Compra";
            this.txtQuantidade_Compra.Size = new System.Drawing.Size(84, 23);
            this.txtQuantidade_Compra.TabIndex = 25;
            this.txtQuantidade_Compra.Text = "0";
            // 
            // txtValorUnitario_Compra
            // 
            this.txtValorUnitario_Compra.Location = new System.Drawing.Point(600, 142);
            this.txtValorUnitario_Compra.Multiline = true;
            this.txtValorUnitario_Compra.Name = "txtValorUnitario_Compra";
            this.txtValorUnitario_Compra.Size = new System.Drawing.Size(111, 23);
            this.txtValorUnitario_Compra.TabIndex = 26;
            this.txtValorUnitario_Compra.Text = "0.00";
            // 
            // lblValorUnitario_Compra
            // 
            this.lblValorUnitario_Compra.AutoSize = true;
            this.lblValorUnitario_Compra.BackColor = System.Drawing.Color.Red;
            this.lblValorUnitario_Compra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValorUnitario_Compra.Location = new System.Drawing.Point(597, 126);
            this.lblValorUnitario_Compra.Name = "lblValorUnitario_Compra";
            this.lblValorUnitario_Compra.Size = new System.Drawing.Size(68, 13);
            this.lblValorUnitario_Compra.TabIndex = 27;
            this.lblValorUnitario_Compra.Text = "Valor unitário";
            // 
            // lblItens_Compra
            // 
            this.lblItens_Compra.AutoSize = true;
            this.lblItens_Compra.Location = new System.Drawing.Point(13, 170);
            this.lblItens_Compra.Name = "lblItens_Compra";
            this.lblItens_Compra.Size = new System.Drawing.Size(84, 13);
            this.lblItens_Compra.TabIndex = 28;
            this.lblItens_Compra.Text = "Itens da Compra";
            // 
            // btnAddProd_Compra
            // 
            this.btnAddProd_Compra.Location = new System.Drawing.Point(717, 142);
            this.btnAddProd_Compra.Name = "btnAddProd_Compra";
            this.btnAddProd_Compra.Size = new System.Drawing.Size(23, 23);
            this.btnAddProd_Compra.TabIndex = 29;
            this.btnAddProd_Compra.Text = "+";
            this.btnAddProd_Compra.UseVisualStyleBackColor = true;
            this.btnAddProd_Compra.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // lblDinheiro_Compra
            // 
            this.lblDinheiro_Compra.AutoSize = true;
            this.lblDinheiro_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro_Compra.Location = new System.Drawing.Point(573, 147);
            this.lblDinheiro_Compra.Name = "lblDinheiro_Compra";
            this.lblDinheiro_Compra.Size = new System.Drawing.Size(23, 13);
            this.lblDinheiro_Compra.TabIndex = 30;
            this.lblDinheiro_Compra.Text = "R$";
            // 
            // pnlFinalizaCompra
            // 
            this.pnlFinalizaCompra.Controls.Add(this.lblDinheiro3_Compra);
            this.pnlFinalizaCompra.Controls.Add(this.lblTotal2_Compra);
            this.pnlFinalizaCompra.Controls.Add(this.lblTotalGeral2_Compra);
            this.pnlFinalizaCompra.Controls.Add(this.btnCancelarCompra);
            this.pnlFinalizaCompra.Controls.Add(this.btnSalvarParcelas);
            this.pnlFinalizaCompra.Controls.Add(this.label18);
            this.pnlFinalizaCompra.Controls.Add(this.lblParcelas_Compra);
            this.pnlFinalizaCompra.Controls.Add(this.lblDadosPagamento_Compra);
            this.pnlFinalizaCompra.Controls.Add(this.dgvParcelas_Compra);
            this.pnlFinalizaCompra.Location = new System.Drawing.Point(9, 8);
            this.pnlFinalizaCompra.Name = "pnlFinalizaCompra";
            this.pnlFinalizaCompra.Size = new System.Drawing.Size(760, 538);
            this.pnlFinalizaCompra.TabIndex = 36;
            this.pnlFinalizaCompra.Visible = false;
            // 
            // lblDinheiro3_Compra
            // 
            this.lblDinheiro3_Compra.AutoSize = true;
            this.lblDinheiro3_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro3_Compra.Location = new System.Drawing.Point(635, 12);
            this.lblDinheiro3_Compra.Name = "lblDinheiro3_Compra";
            this.lblDinheiro3_Compra.Size = new System.Drawing.Size(23, 13);
            this.lblDinheiro3_Compra.TabIndex = 39;
            this.lblDinheiro3_Compra.Text = "R$";
            // 
            // lblTotal2_Compra
            // 
            this.lblTotal2_Compra.AutoSize = true;
            this.lblTotal2_Compra.BackColor = System.Drawing.Color.Red;
            this.lblTotal2_Compra.Location = new System.Drawing.Point(662, 12);
            this.lblTotal2_Compra.Name = "lblTotal2_Compra";
            this.lblTotal2_Compra.Size = new System.Drawing.Size(28, 13);
            this.lblTotal2_Compra.TabIndex = 44;
            this.lblTotal2_Compra.Text = "0.00";
            // 
            // lblTotalGeral2_Compra
            // 
            this.lblTotalGeral2_Compra.AutoSize = true;
            this.lblTotalGeral2_Compra.Location = new System.Drawing.Point(541, 12);
            this.lblTotalGeral2_Compra.Name = "lblTotalGeral2_Compra";
            this.lblTotalGeral2_Compra.Size = new System.Drawing.Size(88, 13);
            this.lblTotalGeral2_Compra.TabIndex = 43;
            this.lblTotalGeral2_Compra.Text = "Total da Compra:";
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelarCompra.Location = new System.Drawing.Point(678, 458);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(72, 72);
            this.btnCancelarCompra.TabIndex = 42;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnSalvarParcelas
            // 
            this.btnSalvarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarParcelas.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btnSalvarParcelas.Location = new System.Drawing.Point(573, 458);
            this.btnSalvarParcelas.Name = "btnSalvarParcelas";
            this.btnSalvarParcelas.Size = new System.Drawing.Size(72, 72);
            this.btnSalvarParcelas.TabIndex = 41;
            this.btnSalvarParcelas.Text = "Salvar";
            this.btnSalvarParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarParcelas.UseVisualStyleBackColor = true;
            this.btnSalvarParcelas.Click += new System.EventHandler(this.btnSalvarParcelas_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(745, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // lblParcelas_Compra
            // 
            this.lblParcelas_Compra.AutoSize = true;
            this.lblParcelas_Compra.Location = new System.Drawing.Point(5, 49);
            this.lblParcelas_Compra.Name = "lblParcelas_Compra";
            this.lblParcelas_Compra.Size = new System.Drawing.Size(102, 13);
            this.lblParcelas_Compra.TabIndex = 38;
            this.lblParcelas_Compra.Text = "Parcelas da Compra";
            // 
            // lblDadosPagamento_Compra
            // 
            this.lblDadosPagamento_Compra.AutoSize = true;
            this.lblDadosPagamento_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPagamento_Compra.Location = new System.Drawing.Point(5, 9);
            this.lblDadosPagamento_Compra.Name = "lblDadosPagamento_Compra";
            this.lblDadosPagamento_Compra.Size = new System.Drawing.Size(140, 16);
            this.lblDadosPagamento_Compra.TabIndex = 37;
            this.lblDadosPagamento_Compra.Text = "Dados do Pagamento";
            // 
            // dgvParcelas_Compra
            // 
            this.dgvParcelas_Compra.AllowUserToAddRows = false;
            this.dgvParcelas_Compra.AllowUserToDeleteRows = false;
            this.dgvParcelas_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas_Compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcoCod,
            this.pcoValor,
            this.pcoDataVecto});
            this.dgvParcelas_Compra.Location = new System.Drawing.Point(5, 75);
            this.dgvParcelas_Compra.Name = "dgvParcelas_Compra";
            this.dgvParcelas_Compra.ReadOnly = true;
            this.dgvParcelas_Compra.Size = new System.Drawing.Size(750, 362);
            this.dgvParcelas_Compra.TabIndex = 36;
            // 
            // pcoCod
            // 
            this.pcoCod.HeaderText = "Parcela";
            this.pcoCod.Name = "pcoCod";
            this.pcoCod.ReadOnly = true;
            // 
            // pcoValor
            // 
            this.pcoValor.HeaderText = "Valor da Parcela";
            this.pcoValor.Name = "pcoValor";
            this.pcoValor.ReadOnly = true;
            this.pcoValor.Width = 150;
            // 
            // pcoDataVecto
            // 
            this.pcoDataVecto.HeaderText = "Data do Vencimento";
            this.pcoDataVecto.Name = "pcoDataVecto";
            this.pcoDataVecto.ReadOnly = true;
            this.pcoDataVecto.Width = 200;
            // 
            // lblDinheiro2_Compra
            // 
            this.lblDinheiro2_Compra.AutoSize = true;
            this.lblDinheiro2_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro2_Compra.Location = new System.Drawing.Point(583, 406);
            this.lblDinheiro2_Compra.Name = "lblDinheiro2_Compra";
            this.lblDinheiro2_Compra.Size = new System.Drawing.Size(23, 13);
            this.lblDinheiro2_Compra.TabIndex = 62;
            this.lblDinheiro2_Compra.Text = "R$";
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(777, 561);
            this.Controls.Add(this.pnlFinalizaCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Movimentação - Formulario de Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.Controls.SetChildIndex(this.pnlDados, 0);
            this.Controls.SetChildIndex(this.pnlBotoes, 0);
            this.Controls.SetChildIndex(this.pnlFinalizaCompra, 0);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).EndInit();
            this.pnlFinalizaCompra.ResumeLayout(false);
            this.pnlFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas_Compra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblComCod_Compra;
        private System.Windows.Forms.Label lblProduto_Compra;
        private System.Windows.Forms.Button btnLocProd_Compra;
        private System.Windows.Forms.TextBox txtProCod_Compra;
        private System.Windows.Forms.Label lblProCod_Compra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFornecedor_Compra;
        private System.Windows.Forms.Button btnLocFor_Compra;
        private System.Windows.Forms.Label lblForCod_Compra;
        private System.Windows.Forms.TextBox txtForCod_Compra;
        private System.Windows.Forms.DataGridView dgvItensCompra;
        private System.Windows.Forms.Label lblDataIni_Compra;
        private System.Windows.Forms.DateTimePicker dtPDataIni_Compra;
        private System.Windows.Forms.Label lblNParcelas_Compra;
        private System.Windows.Forms.ComboBox cmbNParcelas_Compra;
        private System.Windows.Forms.Label lblTipoPagamento_Compra;
        private System.Windows.Forms.ComboBox cmbTipoPagamento_Compra;
        private System.Windows.Forms.TextBox txtTotal_Compra;
        private System.Windows.Forms.Label lblTotalGeral_Compra;
        private System.Windows.Forms.Label lblDataCompra_Compra;
        private System.Windows.Forms.DateTimePicker dtpDataCompra_Compra;
        private System.Windows.Forms.Label lblNFiscal_Compra;
        private System.Windows.Forms.TextBox txtNfiscal_Compra;
        private System.Windows.Forms.TextBox txtComCod_Compra;
        private System.Windows.Forms.Label lblValorUnitario_Compra;
        private System.Windows.Forms.TextBox txtValorUnitario_Compra;
        private System.Windows.Forms.TextBox txtQuantidade_Compra;
        private System.Windows.Forms.Label lblQuantidade_Compra;
        private System.Windows.Forms.Button btnAddProd_Compra;
        private System.Windows.Forms.Label lblItens_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn proVTotal;
        private System.Windows.Forms.Label lblDinheiro_Compra;
        private System.Windows.Forms.Panel pnlFinalizaCompra;
        private System.Windows.Forms.Label lblDinheiro3_Compra;
        private System.Windows.Forms.Label lblTotal2_Compra;
        private System.Windows.Forms.Label lblTotalGeral2_Compra;
        protected System.Windows.Forms.Button btnCancelarCompra;
        protected System.Windows.Forms.Button btnSalvarParcelas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblParcelas_Compra;
        private System.Windows.Forms.Label lblDadosPagamento_Compra;
        private System.Windows.Forms.DataGridView dgvParcelas_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoDataVecto;
        private System.Windows.Forms.Label lblDinheiro2_Compra;
    }
}
