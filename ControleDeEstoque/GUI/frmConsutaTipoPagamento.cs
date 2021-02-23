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
using Modelo;
using Ferramentas;


namespace GUI
{
    public partial class frmConsutaTipoPagamento : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsutaTipoPagamento()
        {
            InitializeComponent();
        }


        private void frmConsutaTipoPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaTip.Columns[0].HeaderText = "Código";
                dtgDados_ConsultaTip.Columns[0].Width = 50;
                dtgDados_ConsultaTip.Columns[1].HeaderText = "Tipo Pagamento";
                dtgDados_ConsultaTip.Columns[1].Width = 200;
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(conexao);

                dtgDados_ConsultaTip.DataSource = bll.Localizar(txtTipoPagamento_ConsultaTip.Text);
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaTip.Rows[e.RowIndex].Cells[0].Value);
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
