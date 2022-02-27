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
    public partial class frmPagamentoCompra : Form
    {
        #region //Variaveis

        public int pcocod = 0;

        #endregion


        public frmPagamentoCompra()
        {
            InitializeComponent();
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

                    txtCodigo.Text = modelo.ComCod.ToString();
                    dtpData.Value = modelo.ComData;
                    txtValor.Text = modelo.ComTotal.ToString();
                    BLLFornecedor bllFornec = new BLLFornecedor(conexao);
                    ModeloFornecedor modeloFornec = bllFornec.CarregaModeloFornecedor(modelo.ForCod);
                    txtNome.Text = modeloFornec.ForNome;

                    BLLParcelasCompras bllParcelas = new BLLParcelasCompras(conexao);

                    dtgParcelas.DataSource = bllParcelas.Localizar(modelo.ComCod);

                    dtgParcelas.Columns[0].HeaderText = "Parcela";
                    dtgParcelas.Columns[0].Width = 50;
                    dtgParcelas.Columns[1].HeaderText = "Valor da Parcela";
                    dtgParcelas.Columns[1].Width = 120;
                    dtgParcelas.Columns[2].HeaderText = "Pago em";
                    dtgParcelas.Columns[2].Width = 120;
                    dtgParcelas.Columns[3].HeaderText = "Vencimento";
                    dtgParcelas.Columns[3].Width = 120;

                    dtgParcelas.Columns[4].Visible = false;

                    MessageBox.Show("Clicar em um item do Data Grid para pagar parcela!");
                }

                f.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLParcelasCompras bll = new BLLParcelasCompras(conexao);

                int comcod = Convert.ToInt32(txtCodigo.Text);

                bll.EfetuarPagamento(comcod, this.pcocod, dtpPagto.Value);

                MessageBox.Show("Parcela paga com sucesso!");

                dtgParcelas.DataSource = bll.Localizar(comcod);

                dtgParcelas.Columns[0].HeaderText = "Parcela";
                dtgParcelas.Columns[0].Width = 50;
                dtgParcelas.Columns[1].HeaderText = "Valor da Parcela";
                dtgParcelas.Columns[1].Width = 120;
                dtgParcelas.Columns[2].HeaderText = "Pago em";
                dtgParcelas.Columns[2].Width = 120;
                dtgParcelas.Columns[3].HeaderText = "Vencimento";
                dtgParcelas.Columns[3].Width = 120;

                dtgParcelas.Columns[4].Visible = false;

                btnPagar.Enabled = false;
                dtpPagto.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnPagar.Enabled = false;
                dtpPagto.Enabled = false;

                this.pcocod = 0;

                if (e.RowIndex >= 0 && dtgParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
                {
                    btnPagar.Enabled = true;
                    dtpPagto.Enabled = true;
                    this.pcocod = Convert.ToInt32(dtgParcelas.Rows[e.RowIndex].Cells[0].Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgParcelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
