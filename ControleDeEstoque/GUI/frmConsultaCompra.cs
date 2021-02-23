using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Modelo;
using BLL;
using Ferramentas;


namespace GUI
{
    public partial class frmConsultaCompra : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaCompra()
        {
            InitializeComponent();
        }


        public void AtualizaCabecalhoGridCompra(int op)
        {
            // op = Consultas que serão realizadas
            // 1 = Editado
            // 2 = Geral
            // 3 = Itens
            // 4 = Parcelas

            try
            {
                switch (op)
                {
                    case 1:
                        {
                            dtgDados_ConsultaCom.Columns[0].HeaderText = "Código Compra";
                            dtgDados_ConsultaCom.Columns[0].Width = 120;
                            dtgDados_ConsultaCom.Columns[1].HeaderText = "Código Fornecedor";
                            dtgDados_ConsultaCom.Columns[1].Width = 150;
                            dtgDados_ConsultaCom.Columns[2].HeaderText = "Fornecedor";
                            dtgDados_ConsultaCom.Columns[2].Width = 300;
                            dtgDados_ConsultaCom.Columns[3].HeaderText = "Data da Compra";
                            dtgDados_ConsultaCom.Columns[3].Width = 150;
                            dtgDados_ConsultaCom.Columns[4].HeaderText = "Número da Nota Fiscal";
                            dtgDados_ConsultaCom.Columns[4].Width = 150;
                            dtgDados_ConsultaCom.Columns[5].HeaderText = "Total";
                            dtgDados_ConsultaCom.Columns[5].Width = 100;
                            dtgDados_ConsultaCom.Columns[6].HeaderText = "Número de Parcelas";
                            dtgDados_ConsultaCom.Columns[6].Width = 130;
                            dtgDados_ConsultaCom.Columns[7].HeaderText = "Código Tipo Pagamento";
                            dtgDados_ConsultaCom.Columns[7].Width = 170;
                            dtgDados_ConsultaCom.Columns[8].HeaderText = "Tipo Pagamento";
                            dtgDados_ConsultaCom.Columns[8].Width = 120;
                            dtgDados_ConsultaCom.Columns[9].HeaderText = "Status da Compra";
                            dtgDados_ConsultaCom.Columns[9].Width = 120;

                            dtgDados_ConsultaCom.Columns[1].Visible = false;
                            dtgDados_ConsultaCom.Columns[6].Visible = false;
                            dtgDados_ConsultaCom.Columns[7].Visible = false;
                            dtgDados_ConsultaCom.Columns[9].Visible = false;

                            break;
                        }
                    case 2:
                        {
                            dtgDados_ConsultaCom.Columns[0].HeaderText = "Código Compra";
                            dtgDados_ConsultaCom.Columns[0].Width = 120;
                            dtgDados_ConsultaCom.Columns[1].HeaderText = "Código Fornecedor";
                            dtgDados_ConsultaCom.Columns[1].Width = 150;
                            dtgDados_ConsultaCom.Columns[2].HeaderText = "Fornecedor";
                            dtgDados_ConsultaCom.Columns[2].Width = 300;
                            dtgDados_ConsultaCom.Columns[3].HeaderText = "Data da Compra";
                            dtgDados_ConsultaCom.Columns[3].Width = 150;
                            dtgDados_ConsultaCom.Columns[4].HeaderText = "Número da Nota Fiscal";
                            dtgDados_ConsultaCom.Columns[4].Width = 150;
                            dtgDados_ConsultaCom.Columns[5].HeaderText = "Total";
                            dtgDados_ConsultaCom.Columns[5].Width = 100;
                            dtgDados_ConsultaCom.Columns[6].HeaderText = "Número de Parcelas";
                            dtgDados_ConsultaCom.Columns[6].Width = 130;
                            dtgDados_ConsultaCom.Columns[7].HeaderText = "Código Tipo Pagamento";
                            dtgDados_ConsultaCom.Columns[7].Width = 170;
                            dtgDados_ConsultaCom.Columns[8].HeaderText = "Tipo Pagamento";
                            dtgDados_ConsultaCom.Columns[8].Width = 120;
                            dtgDados_ConsultaCom.Columns[9].HeaderText = "Status da Compra";
                            dtgDados_ConsultaCom.Columns[9].Width = 120;

                            dtgDados_ConsultaCom.Columns[1].Visible = false;
                            dtgDados_ConsultaCom.Columns[7].Visible = false;

                            break;
                        }
                    case 3:
                        {
                            dtgItens_ConsultaCom.Columns[1].HeaderText = "Quantidade";
                            dtgItens_ConsultaCom.Columns[1].Width = 120;
                            dtgItens_ConsultaCom.Columns[2].HeaderText = "Valor";
                            dtgItens_ConsultaCom.Columns[2].Width = 120;
                            dtgItens_ConsultaCom.Columns[3].HeaderText = "Código Compra";
                            dtgItens_ConsultaCom.Columns[3].Width = 120;
                            dtgItens_ConsultaCom.Columns[4].HeaderText = "Código Produto";
                            dtgItens_ConsultaCom.Columns[4].Width = 120;
                            dtgItens_ConsultaCom.Columns[5].HeaderText = "Nome do Produto";
                            dtgItens_ConsultaCom.Columns[5].Width = 300;

                            dtgItens_ConsultaCom.Columns[0].Visible = false;
                            dtgItens_ConsultaCom.Columns[4].Visible = false;

                            break;
                        }
                    case 4:
                        {
                            dtgParcelas_ConsultaCom.Columns[0].HeaderText = "Parcelas";
                            dtgParcelas_ConsultaCom.Columns[0].Width = 120;
                            dtgParcelas_ConsultaCom.Columns[1].HeaderText = "Valor";
                            dtgParcelas_ConsultaCom.Columns[1].Width = 120;
                            dtgParcelas_ConsultaCom.Columns[2].HeaderText = "Data de Pagamento";
                            dtgParcelas_ConsultaCom.Columns[2].Width = 170;
                            dtgParcelas_ConsultaCom.Columns[3].HeaderText = "Data de Vencimento";
                            dtgParcelas_ConsultaCom.Columns[3].Width = 170;
                            dtgParcelas_ConsultaCom.Columns[4].HeaderText = "Código Compra";
                            dtgParcelas_ConsultaCom.Columns[4].Width = 120;

                            dtgParcelas_ConsultaCom.Columns[4].Visible = false;

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            rdbGeral_CheckedChanged(sender, e);
        }


        private void btnLocFornec_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaFornecedor f = new frmConsultaFornecedor();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    txtForCod.Text = f.codigo.ToString();

                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(conexao);
                    ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                    lblNome.Text = "Nome do Fornecedor: " + modelo.ForNome;

                    BLLCompra bllCompra = new BLLCompra(conexao);

                    dtgDados_ConsultaCom.DataSource = bllCompra.Localizar(f.codigo);

                    f.Dispose();

                    this.AtualizaCabecalhoGridCompra(1);
                }
                else
                {
                    txtForCod.Text = "";
                    lblNome.Text = "Nome do Fornecedor";

                    f.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void rdbGeral_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                #region //Ocutar Paineis

                pnlFornecedor.Visible = false;
                pnlData.Visible = false;

                #endregion

                txtForCod.Clear();
                lblNome.Text = "Nome do Fornecedor";

                dtgDados_ConsultaCom.DataSource = null;
                dtgItens_ConsultaCom.DataSource = null;
                dtgParcelas_ConsultaCom.DataSource = null;

                tbcDados_ConsultaCom.SelectedIndex = 0;

                if (rdbGeral_ConsultaCom.Checked == true)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bll = new BLLCompra(conexao);

                    dtgDados_ConsultaCom.DataSource = bll.Localizar();

                    this.AtualizaCabecalhoGridCompra(2);
                }

                if (rdbFornecedor_ConsultaCom.Checked == true)
                {
                    pnlFornecedor.Visible = true;
                }

                if (rdbData_ConsultaCom.Checked == true)
                {
                    pnlData.Visible = true;
                }

                if (rdbParcelas_ConsultaCom.Checked == true)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bll = new BLLCompra(conexao);

                    dtgDados_ConsultaCom.DataSource = bll.LocalizarParcelasEmAberto();

                    this.AtualizaCabecalhoGridCompra(2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocData_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtIni = dtpInicial_ConsultaCom.Value;
                DateTime dtFim = dtpFinal_ConsultaCom.Value;

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(conexao);

                dtgDados_ConsultaCom.DataSource = bll.Localizar(dtIni, dtFim);

                this.AtualizaCabecalhoGridCompra(2);
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);

                    BLLItensCompra bllItens = new BLLItensCompra(conexao);
                    dtgItens_ConsultaCom.DataSource = bllItens.Localizar(Convert.ToInt32(dtgDados_ConsultaCom.Rows[e.RowIndex].Cells[0].Value));
                    this.AtualizaCabecalhoGridCompra(3);

                    BLLParcelasCompras bllParcelas = new BLLParcelasCompras(conexao);
                    dtgParcelas_ConsultaCom.DataSource = bllParcelas.Localizar(Convert.ToInt32(dtgDados_ConsultaCom.Rows[e.RowIndex].Cells[0].Value));
                    this.AtualizaCabecalhoGridCompra(4);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaCom.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }
    }
}
