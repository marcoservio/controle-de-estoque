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
using BLL;
using Ferramentas;
using Modelo;

namespace GUI
{
    public partial class frmConsultaVenda : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion

        public frmConsultaVenda()
        {
            InitializeComponent();
        }


        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            try
            {
                rdbGeral_ConsultaVenda_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        public void AtualizaCabecalhoGridVenda(int op)
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
                            dtgDados_ConsultaVenda.Columns[0].HeaderText = "Código Venda";
                            dtgDados_ConsultaVenda.Columns[0].Width = 120;
                            dtgDados_ConsultaVenda.Columns[1].HeaderText = "Código Cliente";
                            dtgDados_ConsultaVenda.Columns[1].Width = 150;
                            dtgDados_ConsultaVenda.Columns[2].HeaderText = "Cliente";
                            dtgDados_ConsultaVenda.Columns[2].Width = 300;
                            dtgDados_ConsultaVenda.Columns[3].HeaderText = "Data da Venda";
                            dtgDados_ConsultaVenda.Columns[3].Width = 150;
                            dtgDados_ConsultaVenda.Columns[4].HeaderText = "Número da Nota Fiscal";
                            dtgDados_ConsultaVenda.Columns[4].Width = 150;
                            dtgDados_ConsultaVenda.Columns[5].HeaderText = "Total";
                            dtgDados_ConsultaVenda.Columns[5].Width = 100;
                            dtgDados_ConsultaVenda.Columns[6].HeaderText = "Venda A Vista";
                            dtgDados_ConsultaVenda.Columns[6].Width = 100;
                            dtgDados_ConsultaVenda.Columns[7].HeaderText = "Número de Parcelas";
                            dtgDados_ConsultaVenda.Columns[7].Width = 130;
                            dtgDados_ConsultaVenda.Columns[8].HeaderText = "Código Tipo Pagamento";
                            dtgDados_ConsultaVenda.Columns[8].Width = 170;
                            dtgDados_ConsultaVenda.Columns[9].HeaderText = "Tipo Pagamento";
                            dtgDados_ConsultaVenda.Columns[9].Width = 120;
                            dtgDados_ConsultaVenda.Columns[10].HeaderText = "Status da Venda";
                            dtgDados_ConsultaVenda.Columns[10].Width = 120;

                            dtgDados_ConsultaVenda.Columns[1].Visible = false;
                            dtgDados_ConsultaVenda.Columns[6].Visible = false;
                            dtgDados_ConsultaVenda.Columns[8].Visible = false;
                            dtgDados_ConsultaVenda.Columns[10].Visible = false;

                            break;
                        }
                    case 2:
                        {
                            dtgDados_ConsultaVenda.Columns[0].HeaderText = "Código Venda";
                            dtgDados_ConsultaVenda.Columns[0].Width = 120;
                            dtgDados_ConsultaVenda.Columns[1].HeaderText = "Código Cliente";
                            dtgDados_ConsultaVenda.Columns[1].Width = 150;
                            dtgDados_ConsultaVenda.Columns[2].HeaderText = "Cliente";
                            dtgDados_ConsultaVenda.Columns[2].Width = 300;
                            dtgDados_ConsultaVenda.Columns[3].HeaderText = "Data da Venda";
                            dtgDados_ConsultaVenda.Columns[3].Width = 150;
                            dtgDados_ConsultaVenda.Columns[4].HeaderText = "Número da Nota Fiscal";
                            dtgDados_ConsultaVenda.Columns[4].Width = 150;
                            dtgDados_ConsultaVenda.Columns[5].HeaderText = "Total";
                            dtgDados_ConsultaVenda.Columns[5].Width = 100;
                            dtgDados_ConsultaVenda.Columns[6].HeaderText = "Venda A Vista";
                            dtgDados_ConsultaVenda.Columns[6].Width = 100;
                            dtgDados_ConsultaVenda.Columns[7].HeaderText = "Número de Parcelas";
                            dtgDados_ConsultaVenda.Columns[7].Width = 130;
                            dtgDados_ConsultaVenda.Columns[8].HeaderText = "Código Tipo Pagamento";
                            dtgDados_ConsultaVenda.Columns[8].Width = 170;
                            dtgDados_ConsultaVenda.Columns[9].HeaderText = "Tipo Pagamento";
                            dtgDados_ConsultaVenda.Columns[9].Width = 120;
                            dtgDados_ConsultaVenda.Columns[10].HeaderText = "Status da Venda";
                            dtgDados_ConsultaVenda.Columns[10].Width = 120;

                            dtgDados_ConsultaVenda.Columns[1].Visible = false;
                            dtgDados_ConsultaVenda.Columns[8].Visible = false;

                            break;
                        }
                    case 3:
                        {
                            dtgItens_ConsultaVenda.Columns[0].HeaderText = "Codigo Itens Venda";
                            dtgItens_ConsultaVenda.Columns[0].Width = 120;
                            dtgItens_ConsultaVenda.Columns[1].HeaderText = "Quantidade";
                            dtgItens_ConsultaVenda.Columns[1].Width = 120;
                            dtgItens_ConsultaVenda.Columns[2].HeaderText = "Valor";
                            dtgItens_ConsultaVenda.Columns[2].Width = 120;
                            dtgItens_ConsultaVenda.Columns[3].HeaderText = "Código Venda";
                            dtgItens_ConsultaVenda.Columns[3].Width = 120;
                            dtgItens_ConsultaVenda.Columns[4].HeaderText = "Código Produto";
                            dtgItens_ConsultaVenda.Columns[4].Width = 120;
                            dtgItens_ConsultaVenda.Columns[5].HeaderText = "Nome do Produto";
                            dtgItens_ConsultaVenda.Columns[5].Width = 300;

                            dtgItens_ConsultaVenda.Columns[0].Visible = false;
                            dtgItens_ConsultaVenda.Columns[4].Visible = false;

                            break;
                        }
                    case 4:
                        {
                            dtgParcelas_ConsultaVenda.Columns[0].HeaderText = "Código Venda";
                            dtgParcelas_ConsultaVenda.Columns[0].Width = 120;
                            dtgParcelas_ConsultaVenda.Columns[1].HeaderText = "Código Parcela Venda";
                            dtgParcelas_ConsultaVenda.Columns[1].Width = 120;
                            dtgParcelas_ConsultaVenda.Columns[2].HeaderText = "Valor";
                            dtgParcelas_ConsultaVenda.Columns[2].Width = 120;
                            dtgParcelas_ConsultaVenda.Columns[3].HeaderText = "Data de Pagamento";
                            dtgParcelas_ConsultaVenda.Columns[3].Width = 170;
                            dtgParcelas_ConsultaVenda.Columns[4].HeaderText = "Data de Vencimento";
                            dtgParcelas_ConsultaVenda.Columns[4].Width = 170;


                            dtgParcelas_ConsultaVenda.Columns[0].Visible = false;
                            dtgParcelas_ConsultaVenda.Columns[1].Visible = false;

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


        private void rdbGeral_ConsultaVenda_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                #region //Ocutar Paineis

                pnlCliente.Visible = false;
                pnlData.Visible = false;

                #endregion

                txtCliente_ConsultaVenda.Clear();
                lblNome_ConsultaCliente.Text = "Nome do Cliente";

                dtgDados_ConsultaVenda.DataSource = null;
                dtgItens_ConsultaVenda.DataSource = null;
                dtgParcelas_ConsultaVenda.DataSource = null;

                tbcDados_ConsultaCom.SelectedIndex = 0;

                if (rdbGeral_ConsultaVenda.Checked == true)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(conexao);

                    dtgDados_ConsultaVenda.DataSource = bll.Localizar();

                    this.AtualizaCabecalhoGridVenda(2);
                }

                if (rdbCliente_ConsultaVenda.Checked == true)
                {
                    pnlCliente.Visible = true;
                }

                if (rdbData_ConsultaVenda.Checked == true)
                {
                    pnlData.Visible = true;
                }

                if (rdbParcelas_ConsultaVenda.Checked == true)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bllVenda = new BLLVenda(conexao);

                    dtgDados_ConsultaVenda.DataSource = bllVenda.LocalizarParcelasEmAberto();

                    this.AtualizaCabecalhoGridVenda(2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocalizar_ConsultaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaCliente f = new frmConsultaCliente();

                f.ShowDialog();

                if(f.codigo != 0)
                {
                    txtCliente_ConsultaVenda.Text = f.codigo.ToString();

                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(conexao);
                    ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);

                    lblNome_ConsultaCliente.Text = "Nome do Cliente: " + modelo.CliNome;

                    BLLVenda bllVenda = new BLLVenda(conexao);

                    dtgDados_ConsultaVenda.DataSource = bllVenda.Localizar(f.codigo);

                    f.Dispose();

                    this.AtualizaCabecalhoGridVenda(1);
                }
                else
                {
                    txtCliente_ConsultaVenda.Text = "";
                    lblNome_ConsultaCliente.Text = "Nome do Cliente";

                    f.Dispose();
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgDados_ConsultaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);

                    BLLItensVenda bllItensVenda = new BLLItensVenda(conexao);
                    dtgItens_ConsultaVenda.DataSource = bllItensVenda.Localizar(Convert.ToInt32(dtgDados_ConsultaVenda.Rows[e.RowIndex].Cells[0].Value));
                    this.AtualizaCabecalhoGridVenda(3);

                    BLLParcelasVenda bllParcelasVenda = new BLLParcelasVenda(conexao);
                    dtgParcelas_ConsultaVenda.DataSource = bllParcelasVenda.Localizar(Convert.ToInt32(dtgDados_ConsultaVenda.Rows[e.RowIndex].Cells[0].Value));
                    this.AtualizaCabecalhoGridVenda(4);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocData_ConsultaVenda_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtIni = dtpInicial_ConsultaVenda.Value;
                DateTime dtFim = dtpFinal_ConsultaVenda.Value;

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllVenda = new BLLVenda(conexao);

                dtgDados_ConsultaVenda.DataSource = bllVenda.Localizar(dtIni, dtFim);

                this.AtualizaCabecalhoGridVenda(2);
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgDados_ConsultaVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaVenda.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }
    }
}
