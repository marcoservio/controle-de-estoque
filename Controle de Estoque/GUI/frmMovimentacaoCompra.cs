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
    public partial class frmMovimentacaoCompra : GUI.frmModeloDeFormularioDeCadastro
    {
        #region //Variaveis

        public double totalCompra = 0;

        #endregion


        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtComCod_Compra.Clear();
            txtNfiscal_Compra.Clear();
            txtForCod_Compra.Clear();
            txtProCod_Compra.Clear();
            lblFornecedor_Compra.Text = "Informe o código do fornecedor ou clique em localizar";
            lblProduto_Compra.Text = "Informe o código do fornecedor ou clique em localizar";
            txtQuantidade_Compra.Clear();
            txtValorUnitario_Compra.Clear();
            txtTotal_Compra.Clear();
            dgvItensCompra.Rows.Clear();
            dgvParcelas_Compra.Rows.Clear();
            cmbNParcelas_Compra.SelectedIndex = 0;
            DateTimePicker dt = new DateTimePicker();
            dt.Value = DateTime.Now;
            dtpDataCompra_Compra.Value = dt.Value;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            this.totalCompra = 0;
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaCompra f = new frmConsultaCompra();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bll = new BLLCompra(conexao);
                    ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);

                    txtComCod_Compra.Text = modelo.ComCod.ToString();
                    txtNfiscal_Compra.Text = modelo.ComNfiscal.ToString();
                    dtpDataCompra_Compra.Value = modelo.ComData;
                    txtForCod_Compra.Text = modelo.ForCod.ToString();
                    txtForcod_Leave(sender, e);
                    txtTotal_Compra.Text = modelo.ComTotal.ToString();
                    this.totalCompra = modelo.ComTotal;
                    cmbTipoPagamento_Compra.SelectedValue = modelo.TpaCod;
                    cmbNParcelas_Compra.Text = modelo.ComNparcelas.ToString();

                    BLLItensCompra bllItens = new BLLItensCompra(conexao);

                    DataTable tabela = bllItens.Localizar(modelo.ComCod);

                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        string icod = tabela.Rows[i]["pro_cod"].ToString();
                        string inome = tabela.Rows[i]["pro_nome"].ToString();
                        string iqtde = tabela.Rows[i]["itc_qtde"].ToString();
                        string ivu = tabela.Rows[i]["itc_valor"].ToString();
                        double totalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);

                        String[] it = new String[] { icod, inome, iqtde, ivu, totalLocal.ToString() };

                        this.dgvItensCompra.Rows.Add(it);
                    }

                    this.AlteraBotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }

                f.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int qtde = Convert.ToInt32(cmbNParcelas_Compra.Text);
                int codigo = Convert.ToInt32(txtComCod_Compra.Text);
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllCompra = new BLLCompra(conexao);
                qtde -= bllCompra.QuantidadeParcelasNãoPagas(codigo);

                if (qtde == 0)
                {
                    this.operacao = "alterar";
                    this.AlteraBotoes(2);
                }
                else
                {
                    MessageBox.Show("Impossivel Excluir o registro.\nO registro possui parcelas pagas");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    int qtde = Convert.ToInt32(cmbNParcelas_Compra.Text);
                    int codigo = Convert.ToInt32(txtComCod_Compra.Text);

                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bllCompra = new BLLCompra(conexao);

                    qtde -= bllCompra.QuantidadeParcelasNãoPagas(codigo);

                    if (qtde == 0)
                    {
                        try
                        {
                            conexao.Conectar();

                            conexao.IniciarTransacao();

                            BLLParcelasCompras bll = new BLLParcelasCompras(conexao);
                            bll.ExcluirTodasParcelas(codigo);

                            BLLItensCompra bllItens = new BLLItensCompra(conexao);
                            bllItens.ExcluirTodosItens(codigo);

                            bllCompra.Excluir(codigo);

                            MessageBox.Show("Exclusão efetuada com sucesso!");

                            this.LimpaTela();
                            this.AlteraBotoes(1);
                            conexao.TerminarTransacao();
                        }
                        catch (Exception)
                        {
                            conexao.CancelarTransacao();
                        }
                        finally
                        {
                            conexao.Desconectar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossivel Excluir o registro.\nO registro possui parcelas pagas");
                    }
                }
            }
            catch
            {
                this.AlteraBotoes(3);
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvParcelas_Compra.Rows.Clear();

                int parcelas = Convert.ToInt32(cmbNParcelas_Compra.Text);

                double totalLocal = Convert.ToDouble(txtTotal_Compra.Text);

                double valor = totalLocal / parcelas;

                DateTime dt = new DateTime();

                dt = dtPDataIni_Compra.Value;

                lblTotal2_Compra.Text = txtTotal_Compra.Text;

                for (int i = 1; i <= parcelas; i++)
                {
                    string[] k = new string[] { i.ToString(), valor.ToString(), dt.Date.ToString() };

                    this.dgvParcelas_Compra.Rows.Add(k);

                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }

                pnlFinalizaCompra.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
            this.totalCompra = 0;
        }


        private void btnLocProd_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProduto f = new frmConsultaProduto();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    txtProCod_Compra.Text = f.codigo.ToString();
                    txtProcod_Leave(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocFor_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaFornecedor f = new frmConsultaFornecedor();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    txtForCod_Compra.Text = f.codigo.ToString();
                    txtForcod_Leave(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtForcod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod_Compra.Text));

                if (modelo.ForCod <= 0)
                {
                    txtForCod_Compra.Clear();
                    lblFornecedor_Compra.Text = "Informe o código do fornecedor ou clique em localizar";
                }
                else
                {
                    lblFornecedor_Compra.Text = modelo.ForNome;
                }
            }
            catch (Exception)
            {
                txtForCod_Compra.Clear();
                lblFornecedor_Compra.Text = "Informe o código do fornecedor ou clique em localizar";
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtProcod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(conexao);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod_Compra.Text));

                if (modelo.Pro_Cod <= 0)
                {
                    txtProCod_Compra.Clear();
                    lblProduto_Compra.Text = "Informe o código do produto ou clique em localizar";
                }
                else
                {
                    lblProduto_Compra.Text = modelo.Pro_Nome;
                }

                txtQuantidade_Compra.Text = "1";
                txtValorUnitario_Compra.Text = modelo.Pro_ValorVenda.ToString();
            }
            catch (Exception)
            {
                txtProCod_Compra.Clear();
                lblProduto_Compra.Text = "Informe o código do produto ou clique em localizar";
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod_Compra.Text != "") && (txtQuantidade_Compra.Text != "") && (txtValorUnitario_Compra.Text != ""))
                {
                    double totalLocal = Convert.ToDouble(txtQuantidade_Compra.Text) * Convert.ToDouble(txtValorUnitario_Compra.Text);
                    this.totalCompra = this.totalCompra + totalLocal;
                    String[] i = new String[] { txtProCod_Compra.Text, lblProduto_Compra.Text, txtQuantidade_Compra.Text, txtValorUnitario_Compra.Text, totalLocal.ToString() };
                    this.dgvItensCompra.Rows.Add(i);

                    txtProCod_Compra.Clear();
                    lblProduto_Compra.Text = "Informe o código do produto ou clique em localizar";
                    txtQuantidade_Compra.Clear();
                    txtValorUnitario_Compra.Clear();

                    txtTotal_Compra.Text = this.totalCompra.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            try
            {
                this.AlteraBotoes(1);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(conexao);

                cmbNParcelas_Compra.SelectedIndex = 0;

                cmbTipoPagamento_Compra.DataSource = bll.Localizar("");
                cmbTipoPagamento_Compra.DisplayMember = "tpa_nome";
                cmbTipoPagamento_Compra.ValueMember = "tpa_cod";
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dgvItensCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtProCod_Compra.Text = dgvItensCompra.Rows[e.RowIndex].Cells[0].Value.ToString();
                    lblProduto_Compra.Text = dgvItensCompra.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtQuantidade_Compra.Text = dgvItensCompra.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtValorUnitario_Compra.Text = dgvItensCompra.Rows[e.RowIndex].Cells[3].Value.ToString();
                    double valor = Convert.ToDouble(dgvItensCompra.Rows[e.RowIndex].Cells[4].Value);

                    this.totalCompra = totalCompra - valor;

                    dgvItensCompra.Rows.RemoveAt(e.RowIndex);

                    txtTotal_Compra.Text = this.totalCompra.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnSalvarParcelas_Click_1(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);

            try
            {
                conexao.Conectar();

                conexao.IniciarTransacao();

                ModeloCompra modelo = new ModeloCompra();
                modelo.ComData = dtpDataCompra_Compra.Value;
                modelo.ComNfiscal = Convert.ToInt32(txtNfiscal_Compra.Text);
                modelo.ComNparcelas = Convert.ToInt32(cmbNParcelas_Compra.Text);
                modelo.ComStatus = 0;
                modelo.ComTotal = Convert.ToDouble(txtTotal_Compra.Text);
                modelo.ForCod = Convert.ToInt32(txtForCod_Compra.Text);
                modelo.TpaCod = Convert.ToInt32(cmbTipoPagamento_Compra.SelectedValue);

                BLLCompra bll = new BLLCompra(conexao);

                ModeloItensCompra modeloItens = new ModeloItensCompra();
                BLLItensCompra bllItens = new BLLItensCompra(conexao);

                ModeloParcelasCompra modeloParcelas = new ModeloParcelasCompra();
                BLLParcelasCompras bllParcelas = new BLLParcelasCompras(conexao);

                if (this.operacao.Equals("inserir"))
                {
                    bll.Incluir(modelo);

                    for (int i = 0; i < dgvItensCompra.RowCount; i++)
                    {
                        modeloItens.ItcCod = i + 1;
                        modeloItens.ComCod = modelo.ComCod;
                        modeloItens.ProCod = Convert.ToInt32(dgvItensCompra.Rows[i].Cells[0].Value);
                        modeloItens.ItcQtde = Convert.ToInt32(dgvItensCompra.Rows[i].Cells[2].Value);
                        modeloItens.ItcValor = Convert.ToDouble(dgvItensCompra.Rows[i].Cells[3].Value);

                        bllItens.Incluir(modeloItens);
                    }

                    for (int i = 0; i < dgvParcelas_Compra.RowCount; i++)
                    {
                        modeloParcelas.ComCod = modelo.ComCod;
                        modeloParcelas.PcoCod = Convert.ToInt32(dgvParcelas_Compra.Rows[i].Cells[0].Value);
                        modeloParcelas.PcoValor = Convert.ToDouble(dgvParcelas_Compra.Rows[i].Cells[1].Value);
                        modeloParcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas_Compra.Rows[i].Cells[2].Value);

                        bllParcelas.Incluir(modeloParcelas);
                    }

                    MessageBox.Show("Compra efetuada com sucesso!");
                }
                else
                {
                    modelo.ComCod = Convert.ToInt32(txtComCod_Compra.Text);

                    bll.Alterar(modelo);

                    bllItens.ExcluirTodosItens(modelo.ComCod);

                    for (int i = 0; i < dgvItensCompra.RowCount; i++)
                    {
                        modeloItens.ItcCod = i + 1;
                        modeloItens.ComCod = modelo.ComCod;
                        modeloItens.ProCod = Convert.ToInt32(dgvItensCompra.Rows[i].Cells[0].Value);
                        modeloItens.ItcQtde = Convert.ToInt32(dgvItensCompra.Rows[i].Cells[2].Value);
                        modeloItens.ItcValor = Convert.ToDouble(dgvItensCompra.Rows[i].Cells[3].Value);

                        bllItens.Incluir(modeloItens);
                    }

                    bllParcelas.ExcluirTodasParcelas(modelo.ComCod);

                    for (int i = 0; i < dgvParcelas_Compra.RowCount; i++)
                    {
                        modeloParcelas.ComCod = modelo.ComCod;
                        modeloParcelas.PcoCod = Convert.ToInt32(dgvParcelas_Compra.Rows[i].Cells[0].Value);
                        modeloParcelas.PcoValor = Convert.ToDouble(dgvParcelas_Compra.Rows[i].Cells[1].Value);
                        modeloParcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas_Compra.Rows[i].Cells[2].Value);

                        bllParcelas.Incluir(modeloParcelas);
                    }

                    MessageBox.Show("Compra alterada com sucesso!");
                }

                this.LimpaTela();
                this.AlteraBotoes(1);
                pnlFinalizaCompra.Visible = false;
                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch (Exception)
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


        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            pnlFinalizaCompra.Visible = false;
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
