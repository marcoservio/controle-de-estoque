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
            txtTotalVenda.Clear();
            dgvItensVenda.Rows.Clear();
            dgvParcelas.Rows.Clear();
            cmbNparcelas.SelectedIndex = 0;
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

        }


        private void btnLocCli_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaCliente f = new frmConsultaCliente();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    txtCliCod.Text = f.codigo.ToString();
                    txtCliCod_Leave(sender, e);
                }
            }
            catch (Exception)
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

                if (modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    lblCliente.Text = "Informe o código do cliente ou clique em localizar";
                }
                else
                {
                    lblCliente.Text = modelo.CliNome;
                }
            }
            catch (Exception)
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

                if (f.codigo != 0)
                {
                    txtProcod.Text = f.codigo.ToString();
                    txtProcod_Leave(sender, e);
                }
            }
            catch (Exception)
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

                if (modelo.Pro_Cod <= 0)
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
            catch (Exception)
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
                if ((txtProcod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
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
            catch (Exception)
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
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void chkVenAvista_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkVenAvista.Checked)
                {
                    cmbNparcelas.SelectedIndex = 0;
                    cmbNparcelas.Enabled = false;
                }
                else
                {
                    cmbNparcelas.Enabled = true;
                }
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
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvParcelas.Rows.Clear();

                int parcelas = Convert.ToInt32(cmbNparcelas.Text);

                double totalLocal = Convert.ToDouble(txtTotalVenda.Text);

                double valor = totalLocal / parcelas;

                DateTime dt = new DateTime();

                dt = dtPDataIni.Value;

                lblTotal.Text = txtTotalVenda.Text;

                int dia = 0;

                for (int i = 1; i <= parcelas; i++)
                {
                    string[] k = new string[] { i.ToString(), valor.ToString(), dt.Date.ToString() };

                    this.dgvParcelas.Rows.Add(k);

                    if (dt.Month != 12)
                    {
                        if (dt.Month + 1 == 2)
                        {
                            dia = dt.Day;

                            dt = new DateTime(dt.Year, dt.Month + 1, 28);
                        }
                        else
                        {
                            if (dia == 31)
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
            catch (Exception)
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

                ModeloVenda modelo = new ModeloVenda();
                BLLVenda bll = new BLLVenda(conexao);

                ModeloItensVenda modeloItens = new ModeloItensVenda();
                BLLItensVenda bllItens = new BLLItensVenda(conexao);

                ModeloParcelasVenda modeloParcelas = new ModeloParcelasVenda();
                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(conexao);

                modelo.VenData = dtpDataCompra.Value;
                modelo.VenNfiscal = Convert.ToInt32(txtNfiscal.Text);
                modelo.VenNparcelas = Convert.ToInt32(cmbNparcelas.Text);
                modelo.VenStatus = 0;
                modelo.VenTotal = Convert.ToDouble(txtTotalVenda.Text);
                modelo.CliCod = Convert.ToInt32(txtCliCod.Text);
                modelo.TpaCod = Convert.ToInt32(cmbTipoPagamento.SelectedValue);
                if (chkVenAvista.Checked)
                {
                    modelo.VenAvista = 0;
                }
                else
                {
                    modelo.VenAvista = 1;
                }

                if (this.operacao.Equals("inserir"))
                {
                    bll.Incluir(modelo);

                    for (int i = 0; i < dgvItensVenda.RowCount; i++)
                    {
                        modeloItens.ItvCod = i + 1;
                        modeloItens.VenCod = modelo.VenCod;
                        modeloItens.ProCod = Convert.ToInt32(dgvItensVenda.Rows[i].Cells[0].Value);
                        modeloItens.ItvQtde = Convert.ToInt32(dgvItensVenda.Rows[i].Cells[2].Value);
                        modeloItens.ItvValor = Convert.ToDouble(dgvItensVenda.Rows[i].Cells[3].Value);

                        bllItens.Incluir(modeloItens);
                    }

                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        modeloParcelas.VenCod = modelo.VenCod;
                        modeloParcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        modeloParcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        modeloParcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        bllParcelas.Incluir(modeloParcelas);
                    }

                    MessageBox.Show("Compra efetuada com sucesso!");
                }
                else
                {
                    //modelo.ComCod = Convert.ToInt32(txtComCod.Text);

                    //bll.Alterar(modelo);

                    //bllItens.ExcluirTodosItens(modelo.ComCod);

                    //for (int i = 0; i < dgvItensCompra.RowCount; i++)
                    //{
                    //    modeloItens.ItcCod = i + 1;
                    //    modeloItens.ComCod = modelo.ComCod;
                    //    modeloItens.ProCod = Convert.ToInt32(dgvItensCompra.Rows[i].Cells[0].Value);
                    //    modeloItens.ItcQtde = Convert.ToInt32(dgvItensCompra.Rows[i].Cells[2].Value);
                    //    modeloItens.ItcValor = Convert.ToDouble(dgvItensCompra.Rows[i].Cells[3].Value);

                    //    bllItens.Incluir(modeloItens);
                    //}

                    //bllParcelas.ExcluirTodasParcelas(modelo.ComCod);

                    //for (int i = 0; i < dgvParcelas.RowCount; i++)
                    //{
                    //    modeloParcelas.ComCod = modelo.ComCod;
                    //    modeloParcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                    //    modeloParcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                    //    modeloParcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                    //    bllParcelas.Incluir(modeloParcelas);
                    //}

                    //MessageBox.Show("Cadastro alterado com sucesso!");
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }


        private void PnlFinalizaCompra_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtProcod_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
