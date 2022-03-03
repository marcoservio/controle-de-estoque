using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRecebimentoVenda : Form
    {
        #region //Variaveis

        public int pvecod = 0;

        #endregion


        public frmRecebimentoVenda()
        {
            InitializeComponent();
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                btnReceber.Enabled = false;

                frmConsultaVenda f = new frmConsultaVenda();

                f.ShowDialog();

                if(f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(conexao);
                    ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);

                    txtCodigo.Text = modelo.VenCod.ToString();
                    dtpData.Value = modelo.VenData;
                    txtValor.Text = modelo.VenTotal.ToString();
                    BLLCliente bllCliente = new BLLCliente(conexao);
                    ModeloCliente modeloCliete = bllCliente.CarregaModeloCliente(modelo.CliCod);
                    txtCliente.Text = modeloCliete.CliNome;

                    BLLParcelasVenda bllParcelas = new BLLParcelasVenda(conexao);

                    dtgParcelas.DataSource = bllParcelas.Localizar(modelo.VenCod);

                    dtgParcelas.Columns[0].HeaderText = "Parcela";
                    dtgParcelas.Columns[0].Width = 50;
                    dtgParcelas.Columns[1].Visible = false;
                    dtgParcelas.Columns[2].HeaderText = "Valor da Parcela";
                    dtgParcelas.Columns[2].Width = 120;
                    dtgParcelas.Columns[3].HeaderText = "Recebido em";
                    dtgParcelas.Columns[3].Width = 120;
                    dtgParcelas.Columns[4].HeaderText = "Vencimento";
                    dtgParcelas.Columns[4].Width = 120;
                }

                f.Dispose();
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLParcelasVenda bll = new BLLParcelasVenda(conexao);

                int vencod = Convert.ToInt32(txtCodigo.Text);

                bll.EfetuarRecebimento(vencod, this.pvecod, dtpRecebimento.Value);

                MessageBox.Show("Parcela paga com sucesso!");

                BLLParcelasVenda bllPVenda = new BLLParcelasVenda(conexao);

                dtgParcelas.DataSource = bll.Localizar(vencod);

                dtgParcelas.Columns[0].HeaderText = "Parcela";
                dtgParcelas.Columns[0].Width = 50;
                dtgParcelas.Columns[1].Visible = false;
                dtgParcelas.Columns[2].HeaderText = "Valor da Parcela";
                dtgParcelas.Columns[2].Width = 120;
                dtgParcelas.Columns[3].HeaderText = "Recebido em";
                dtgParcelas.Columns[3].Width = 120;
                dtgParcelas.Columns[4].HeaderText = "Vencimento";
                dtgParcelas.Columns[4].Width = 120;

                btnReceber.Enabled = false;
                dtpRecebimento.Enabled = false;
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void dtgParcelas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnReceber.Enabled = false;
                dtpRecebimento.Enabled = false;

                this.pvecod = 0;

                if(e.RowIndex >= 0 && dtgParcelas.Rows[e.RowIndex].Cells[3].Value.ToString() == "")
                {
                    btnReceber.Enabled = true;
                    dtpRecebimento.Enabled = true;
                    this.pvecod = Convert.ToInt32(dtgParcelas.Rows[e.RowIndex].Cells[1].Value);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }
    }
}
