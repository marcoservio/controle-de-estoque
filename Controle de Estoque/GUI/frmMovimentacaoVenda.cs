using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;
using Ferramentas;


namespace GUI
{
    public partial class frmMovimentacaoVenda : GUI.frmModeloDeFormularioDeCadastro
    {
        #region //Variaveis

        public double totalVenda = 0;

        #endregion


        public frmMovimentacaoVenda()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtVenCod.Clear();
            txtNfiscal.Clear();
            txtCliCod.Clear();
            txtProcod.Clear();
            lblCliente.Text = "Informe o código do fornecedor ou clique em localizar";
            lblProduto.Text = "Informe o código do fornecedor ou clique em localizar";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalVenda.Text = "0.00";
            dgvItensVenda.Rows.Clear();
            dgvParcelas.Rows.Clear();
            DateTimePicker dt = new DateTimePicker();
            dt.Value = DateTime.Now;
            dtpDataVenda.Value = dt.Value;
            cmbNparcelas.SelectedIndex = 0;
            cmbTipoPagamento.SelectedIndex = 2;
            lblMsgVenda.Visible = false;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            this.totalVenda = 0;
            cmbNparcelas.SelectedIndex = 0;
            chkVenAvista.Checked = false;
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaVenda f = new frmConsultaVenda();

                f.ShowDialog();

                if(f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(conexao);
                    ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);

                    txtVenCod.Text = modelo.VenCod.ToString();
                    txtNfiscal.Text = modelo.VenNfiscal.ToString();
                    dtpDataVenda.Value = modelo.VenData;
                    txtCliCod.Text = modelo.CliCod.ToString();
                    txtCliCod_Leave(sender, e);
                    txtTotalVenda.Text = modelo.VenTotal.ToString();
                    this.totalVenda = modelo.VenTotal;
                    cmbTipoPagamento.SelectedValue = modelo.TpaCod;
                    cmbNparcelas.Text = modelo.VenNparcelas.ToString();
                    if(modelo.VenAvista == 1)
                    {
                        chkVenAvista.Checked = true;
                    }
                    else
                    {
                        chkVenAvista.Checked = false;
                    }

                    BLLItensVenda bllItens = new BLLItensVenda(conexao);
                    DataTable tabela = bllItens.Localizar(modelo.VenCod);

                    for(int i = 0; i < tabela.Rows.Count; i++)
                    {
                        string icod = tabela.Rows[i]["pro_cod"].ToString();
                        string inome = tabela.Rows[i]["pro_nome"].ToString();
                        string iqtde = tabela.Rows[i]["itv_qtde"].ToString();
                        string ivu = tabela.Rows[i]["itv_valor"].ToString();
                        double totalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);

                        String[] it = new String[] { icod, inome, iqtde, ivu, totalLocal.ToString() };

                        this.dgvItensVenda.Rows.Add(it);
                    }

                    this.AlteraBotoes(3);
                    btnAlterar.Enabled = false;
                    cmbTipoPagamento.SelectedIndex = modelo.TpaCod - 1;
                    lblMsgVenda.Visible = false;

                    //0 - Venda Ativa / 1 - Venda Inativa
                    if(modelo.VenStatus != 0)
                    {
                        lblMsgVenda.BackColor = Color.Red;
                        lblMsgVenda.Visible = true;
                        btnExcluir.Enabled = false;
                    }
                }
                else
                {
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }

                f.Dispose();
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocCli_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaCliente f = new frmConsultaCliente();

                f.ShowDialog();

                if(f.codigo != 0)
                {
                    txtCliCod.Text = f.codigo.ToString();
                    txtCliCod_Leave(sender, e);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCliCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(conexao);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCod.Text));

                if(modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    lblCliente.Text = "Informe o código do cliente ou clique em localizar";
                }
                else
                {
                    lblCliente.Text = modelo.CliNome;
                }
            }
            catch(Exception)
            {
                txtCliCod.Clear();
                lblCliente.Text = "Informe o código do cliente ou clique em localizar";
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocProd_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProduto f = new frmConsultaProduto();

                f.ShowDialog();

                if(f.codigo != 0)
                {
                    txtProcod.Text = f.codigo.ToString();
                    txtProcod_Leave(sender, e);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtProcod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(conexao);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProcod.Text));

                if(modelo.Pro_Cod <= 0)
                {
                    txtProcod.Clear();
                    lblProduto.Text = "Informe o código do produto ou clique em localizar";
                }
                else
                {
                    lblProduto.Text = modelo.Pro_Nome;
                }

                txtQtde.Text = "1";
                txtValor.Text = modelo.Pro_ValorVenda.ToString();
            }
            catch(Exception)
            {
                txtProcod.Clear();
                lblProduto.Text = "Informe o código do produto ou clique em localizar";
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if((txtProcod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    double totalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalVenda = this.totalVenda + totalLocal;
                    String[] i = new String[] { txtProcod.Text, lblProduto.Text, txtQtde.Text, txtValor.Text, totalLocal.ToString() };
                    this.dgvItensVenda.Rows.Add(i);

                    txtProcod.Clear();
                    lblProduto.Text = "Informe o código do produto ou clique em localizar";
                    txtQtde.Clear();
                    txtValor.Clear();

                    txtTotalVenda.Text = this.totalVenda.ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmMovimentacaoVenda_Load(object sender, EventArgs e)
        {
            try
            {
                this.AlteraBotoes(1);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(conexao);

                cmbNparcelas.SelectedIndex = 0;

                cmbTipoPagamento.DataSource = bll.Localizar("");
                cmbTipoPagamento.DisplayMember = "tpa_nome";
                cmbTipoPagamento.ValueMember = "tpa_cod";
                cmbTipoPagamento.SelectedIndex = 2;
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void chkVenAvista_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chkVenAvista.Checked)
                {
                    cmbNparcelas.SelectedIndex = 0;
                    cmbNparcelas.Enabled = false;
                    cmbTipoPagamento.SelectedIndex = 2;
                }
                else
                {
                    cmbNparcelas.Enabled = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(txtCliCod.Text) <= 0)
                {
                    throw new Exception();
                }
                if(Convert.ToInt32(txtNfiscal.Text) <= 0)
                {
                    throw new Exception();
                }
                if(totalVenda <= 0)
                {
                    throw new Exception();
                }

                dgvParcelas.Rows.Clear();

                int parcelas = Convert.ToInt32(cmbNparcelas.Text);

                double totalLocal = Convert.ToDouble(txtTotalVenda.Text);

                double valor = totalLocal / parcelas;

                DateTime dt = new DateTime();

                dt = dtPDataIni.Value;

                lblTotal.Text = txtTotalVenda.Text;

                int dia = 0;

                for(int i = 1; i <= parcelas; i++)
                {
                    string[] k = new string[] { i.ToString(), valor.ToString(), dt.Date.ToString() };

                    this.dgvParcelas.Rows.Add(k);

                    if(dt.Month != 12)
                    {
                        if(dt.Month + 1 == 2)
                        {
                            dia = dt.Day;

                            dt = new DateTime(dt.Year, dt.Month + 1, 28);
                        }
                        else
                        {
                            dia = dt.Day;

                            if(dia == 31)
                            {
                                dt = new DateTime(dt.Year, dt.Month + 1, dia - 1);
                            }
                            else
                            {
                                dt = new DateTime(dt.Year, dt.Month + 1, dia);
                            }
                        }
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }

                pnlFinalizaCompra.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            pnlFinalizaCompra.Visible = false;
        }


        private void btnSalvarParcelas_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);

            try
            {
                conexao.Conectar();
                conexao.IniciarTransacao();

                ModeloVenda modeloVenda = new ModeloVenda();

                modeloVenda.VenData = dtpDataVenda.Value;
                modeloVenda.VenNfiscal = Convert.ToInt32(txtNfiscal.Text);
                modeloVenda.VenNparcelas = Convert.ToInt32(cmbNparcelas.Text);
                modeloVenda.VenStatus = 0;
                modeloVenda.VenTotal = Convert.ToDouble(txtTotalVenda.Text);
                modeloVenda.CliCod = Convert.ToInt32(txtCliCod.Text);
                modeloVenda.TpaCod = Convert.ToInt32(cmbTipoPagamento.SelectedValue);
                if(chkVenAvista.Checked)
                {
                    modeloVenda.VenAvista = 0;
                }
                else
                {
                    modeloVenda.VenAvista = 1;
                }

                BLLVenda bllVenda = new BLLVenda(conexao);
                ModeloItensVenda modeloItensVendas = new ModeloItensVenda();
                BLLItensVenda bllItensVenda = new BLLItensVenda(conexao);
                ModeloParcelasVenda modeloParcelas = new ModeloParcelasVenda();
                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(conexao);

                if(this.operacao.Equals("inserir"))
                {
                    bllVenda.Incluir(modeloVenda);

                    for(int i = 0; i < dgvItensVenda.RowCount; i++)
                    {
                        modeloItensVendas.ItvCod = i + 1;
                        modeloItensVendas.VenCod = modeloVenda.VenCod;
                        modeloItensVendas.ProCod = Convert.ToInt32(dgvItensVenda.Rows[i].Cells[0].Value);
                        modeloItensVendas.ItvQtde = Convert.ToInt32(dgvItensVenda.Rows[i].Cells[2].Value);
                        modeloItensVendas.ItvValor = Convert.ToDouble(dgvItensVenda.Rows[i].Cells[3].Value);

                        bllItensVenda.Incluir(modeloItensVendas);
                    }
                    for(int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        modeloParcelas.VenCod = modeloVenda.VenCod;
                        modeloParcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        modeloParcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        modeloParcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        bllParcelas.Incluir(modeloParcelas);
                    }

                    MessageBox.Show("Venda efetuada com sucesso!");
                }

                this.LimpaTela();
                this.AlteraBotoes(1);

                pnlFinalizaCompra.Visible = false;

                conexao.TerminarTransacao();
            }
            catch(Exception)
            {
                conexao.CancelarTransacao();
                conexao.Desconectar();
                MessageBox.Show(Validacao.MensagemErro());
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
            this.totalVenda = 0;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Cancelamento da venda

            try
            {
                DialogResult d = MessageBox.Show("Deseja cancelar a venda?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(conexao);

                    if(bll.CancelarVenda(Convert.ToInt32(txtVenCod.Text)) == true)
                    {
                        MessageBox.Show("Venda Cancelada");
                        this.LimpaTela();
                        this.AlteraBotoes(1);
                        this.totalVenda = 0;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dgvItensVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    txtProcod.Text = dgvItensVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
                    lblProduto.Text = dgvItensVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtQtde.Text = dgvItensVenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtValor.Text = dgvItensVenda.Rows[e.RowIndex].Cells[3].Value.ToString();
                    double valor = Convert.ToDouble(dgvItensVenda.Rows[e.RowIndex].Cells[4].Value);

                    this.totalVenda = totalVenda - valor;

                    dgvItensVenda.Rows.RemoveAt(e.RowIndex);

                    txtTotalVenda.Text = this.totalVenda.ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtNfiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Ferramentas.Validacao.MensagemErro());
            }
        }
    }
}
