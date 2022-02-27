namespace GUI
{
    partial class frmMovimentacaoVenda
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
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnLocProd = new System.Windows.Forms.Button();
            this.txtProcod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnLocCli = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPDataIni = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNparcelas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNfiscal = new System.Windows.Forms.TextBox();
            this.txtVenCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVenAvista = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlFinalizaCompra = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnSalvarParcelas = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pcoCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcoDataVecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            this.pnlFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.label15);
            this.pnlDados.Controls.Add(this.chkVenAvista);
            this.pnlDados.Controls.Add(this.label14);
            this.pnlDados.Controls.Add(this.btnAddProd);
            this.pnlDados.Controls.Add(this.label11);
            this.pnlDados.Controls.Add(this.label13);
            this.pnlDados.Controls.Add(this.txtValor);
            this.pnlDados.Controls.Add(this.txtQtde);
            this.pnlDados.Controls.Add(this.label12);
            this.pnlDados.Controls.Add(this.lblProduto);
            this.pnlDados.Controls.Add(this.btnLocProd);
            this.pnlDados.Controls.Add(this.txtProcod);
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.lblCliente);
            this.pnlDados.Controls.Add(this.btnLocCli);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.txtCliCod);
            this.pnlDados.Controls.Add(this.dgvItensVenda);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.dtPDataIni);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.cmbNparcelas);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.cmbTipoPagamento);
            this.pnlDados.Controls.Add(this.txtTotalVenda);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.dtpDataCompra);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtNfiscal);
            this.pnlDados.Controls.Add(this.txtVenCod);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Location = new System.Drawing.Point(2, 2);
            this.pnlDados.Size = new System.Drawing.Size(780, 445);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Location = new System.Drawing.Point(2, 453);
            this.pnlBotoes.Size = new System.Drawing.Size(780, 105);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(568, 15);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(461, 15);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(354, 15);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(247, 15);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(140, 15);
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(33, 15);
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(675, 15);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(602, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "R$";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(746, 128);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(23, 23);
            this.btnAddProd.TabIndex = 60;
            this.btnAddProd.Text = "+";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Itens da Compra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(626, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Valor unitário";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(629, 128);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 23);
            this.txtValor.TabIndex = 57;
            this.txtValor.Text = "0.00";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(511, 128);
            this.txtQtde.Multiline = true;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(84, 23);
            this.txtQtde.TabIndex = 56;
            this.txtQtde.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(508, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(214, 133);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(244, 13);
            this.lblProduto.TabIndex = 54;
            this.lblProduto.Text = "Informe o código do produto ou clique em localizar";
            // 
            // btnLocProd
            // 
            this.btnLocProd.Location = new System.Drawing.Point(133, 128);
            this.btnLocProd.Name = "btnLocProd";
            this.btnLocProd.Size = new System.Drawing.Size(75, 23);
            this.btnLocProd.TabIndex = 53;
            this.btnLocProd.Text = "Localizar";
            this.btnLocProd.UseVisualStyleBackColor = true;
            this.btnLocProd.Click += new System.EventHandler(this.btnLocProd_Click);
            // 
            // txtProcod
            // 
            this.txtProcod.Location = new System.Drawing.Point(6, 128);
            this.txtProcod.Multiline = true;
            this.txtProcod.Name = "txtProcod";
            this.txtProcod.Size = new System.Drawing.Size(121, 23);
            this.txtProcod.TabIndex = 52;
            this.txtProcod.TextChanged += new System.EventHandler(this.txtProcod_TextChanged);
            this.txtProcod.Leave += new System.EventHandler(this.txtProcod_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Codigo do Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(727, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(214, 70);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(239, 13);
            this.lblCliente.TabIndex = 49;
            this.lblCliente.Text = "Informe o código do cliente ou clique em localizar";
            // 
            // btnLocCli
            // 
            this.btnLocCli.Location = new System.Drawing.Point(133, 65);
            this.btnLocCli.Name = "btnLocCli";
            this.btnLocCli.Size = new System.Drawing.Size(75, 23);
            this.btnLocCli.TabIndex = 48;
            this.btnLocCli.Text = "Localizar";
            this.btnLocCli.UseVisualStyleBackColor = true;
            this.btnLocCli.Click += new System.EventHandler(this.btnLocCli_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Codigo do Cliente";
            // 
            // txtCliCod
            // 
            this.txtCliCod.Location = new System.Drawing.Point(6, 65);
            this.txtCliCod.Multiline = true;
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(121, 23);
            this.txtCliCod.TabIndex = 46;
            this.txtCliCod.Leave += new System.EventHandler(this.txtCliCod_Leave);
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AllowUserToDeleteRows = false;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtd,
            this.proUnidade,
            this.proVTotal});
            this.dgvItensVenda.Location = new System.Drawing.Point(6, 170);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            this.dgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVenda.Size = new System.Drawing.Size(767, 227);
            this.dgvItensVenda.TabIndex = 45;
            this.dgvItensVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensCompra_CellDoubleClick);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Data inicial do pagamento";
            // 
            // dtPDataIni
            // 
            this.dtPDataIni.Location = new System.Drawing.Point(294, 417);
            this.dtPDataIni.Name = "dtPDataIni";
            this.dtPDataIni.Size = new System.Drawing.Size(233, 20);
            this.dtPDataIni.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Número de parcelas";
            // 
            // cmbNparcelas
            // 
            this.cmbNparcelas.FormattingEnabled = true;
            this.cmbNparcelas.Items.AddRange(new object[] {
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
            this.cmbNparcelas.Location = new System.Drawing.Point(6, 416);
            this.cmbNparcelas.Name = "cmbNparcelas";
            this.cmbNparcelas.Size = new System.Drawing.Size(121, 21);
            this.cmbNparcelas.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tipo de pagamento";
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Location = new System.Drawing.Point(136, 416);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoPagamento.TabIndex = 39;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(671, 416);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(102, 20);
            this.txtTotalVenda.TabIndex = 38;
            this.txtTotalVenda.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(670, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Data da compra";
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Location = new System.Drawing.Point(529, 24);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(240, 20);
            this.dtpDataCompra.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Número da nota fiscal";
            // 
            // txtNfiscal
            // 
            this.txtNfiscal.Location = new System.Drawing.Point(146, 24);
            this.txtNfiscal.Name = "txtNfiscal";
            this.txtNfiscal.Size = new System.Drawing.Size(349, 20);
            this.txtNfiscal.TabIndex = 33;
            // 
            // txtVenCod
            // 
            this.txtVenCod.Enabled = false;
            this.txtVenCod.Location = new System.Drawing.Point(6, 24);
            this.txtVenCod.Name = "txtVenCod";
            this.txtVenCod.Size = new System.Drawing.Size(100, 20);
            this.txtVenCod.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código";
            // 
            // chkVenAvista
            // 
            this.chkVenAvista.AutoSize = true;
            this.chkVenAvista.Location = new System.Drawing.Point(544, 418);
            this.chkVenAvista.Name = "chkVenAvista";
            this.chkVenAvista.Size = new System.Drawing.Size(92, 17);
            this.chkVenAvista.TabIndex = 62;
            this.chkVenAvista.Text = "Venda a Vista";
            this.chkVenAvista.UseVisualStyleBackColor = true;
            this.chkVenAvista.CheckedChanged += new System.EventHandler(this.chkVenAvista_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(642, 420);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "R$";
            // 
            // pnlFinalizaCompra
            // 
            this.pnlFinalizaCompra.Controls.Add(this.label19);
            this.pnlFinalizaCompra.Controls.Add(this.lblTotal);
            this.pnlFinalizaCompra.Controls.Add(this.label16);
            this.pnlFinalizaCompra.Controls.Add(this.btnCancelarCompra);
            this.pnlFinalizaCompra.Controls.Add(this.btnSalvarParcelas);
            this.pnlFinalizaCompra.Controls.Add(this.label18);
            this.pnlFinalizaCompra.Controls.Add(this.label17);
            this.pnlFinalizaCompra.Controls.Add(this.label20);
            this.pnlFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnlFinalizaCompra.Location = new System.Drawing.Point(2, 2);
            this.pnlFinalizaCompra.Name = "pnlFinalizaCompra";
            this.pnlFinalizaCompra.Size = new System.Drawing.Size(780, 556);
            this.pnlFinalizaCompra.TabIndex = 37;
            this.pnlFinalizaCompra.Visible = false;
            this.pnlFinalizaCompra.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFinalizaCompra_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(635, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(662, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(541, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Total da Venda:";
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelarCompra.Location = new System.Drawing.Point(698, 475);
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
            this.btnSalvarParcelas.Location = new System.Drawing.Point(593, 475);
            this.btnSalvarParcelas.Name = "btnSalvarParcelas";
            this.btnSalvarParcelas.Size = new System.Drawing.Size(72, 72);
            this.btnSalvarParcelas.TabIndex = 41;
            this.btnSalvarParcelas.Text = "Salvar";
            this.btnSalvarParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarParcelas.UseVisualStyleBackColor = true;
            this.btnSalvarParcelas.Click += new System.EventHandler(this.btnSalvarParcelas_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(763, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Parcelas da Venda";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcoCod,
            this.pcoValor,
            this.pcoDataVecto});
            this.dgvParcelas.Location = new System.Drawing.Point(5, 75);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.Size = new System.Drawing.Size(768, 385);
            this.dgvParcelas.TabIndex = 36;
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
            // frmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(788, 561);
            this.Controls.Add(this.pnlFinalizaCompra);
            this.Name = "frmMovimentacaoVenda";
            this.Text = "Movimentação - Formulario de Venda";
            this.Load += new System.EventHandler(this.frmMovimentacaoVenda_Load);
            this.Controls.SetChildIndex(this.pnlDados, 0);
            this.Controls.SetChildIndex(this.pnlBotoes, 0);
            this.Controls.SetChildIndex(this.pnlFinalizaCompra, 0);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            this.pnlFinalizaCompra.ResumeLayout(false);
            this.pnlFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnLocProd;
        private System.Windows.Forms.TextBox txtProcod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnLocCli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn proVTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtPDataIni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNparcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNfiscal;
        private System.Windows.Forms.TextBox txtVenCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkVenAvista;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlFinalizaCompra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Button btnCancelarCompra;
        protected System.Windows.Forms.Button btnSalvarParcelas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoDataVecto;
    }
}
