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


namespace GUI
{
    public partial class frmConsultaProduto : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaProduto()
        {
            InitializeComponent();
        }


        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaPro.Columns[0].HeaderText = "Código";
                dtgDados_ConsultaPro.Columns[0].Width = 50;
                dtgDados_ConsultaPro.Columns[1].HeaderText = "Nome Categoria";
                dtgDados_ConsultaPro.Columns[1].Width = 200;
                dtgDados_ConsultaPro.Columns[2].HeaderText = "Descrição";
                dtgDados_ConsultaPro.Columns[2].Width = 700;
                dtgDados_ConsultaPro.Columns[3].HeaderText = "Quantidade";
                dtgDados_ConsultaPro.Columns[3].Width = 100;
                dtgDados_ConsultaPro.Columns[4].HeaderText = "Valor Pago";
                dtgDados_ConsultaPro.Columns[4].Width = 120;
                dtgDados_ConsultaPro.Columns[5].HeaderText = "Valor de Venda";
                dtgDados_ConsultaPro.Columns[5].Width = 150;
                dtgDados_ConsultaPro.Columns[6].HeaderText = "Unidade de Medida";
                dtgDados_ConsultaPro.Columns[6].Width = 150;
                dtgDados_ConsultaPro.Columns[7].HeaderText = "Unidade de Medida";
                dtgDados_ConsultaPro.Columns[7].Width = 200;
                dtgDados_ConsultaPro.Columns[8].HeaderText = "Categoria";
                dtgDados_ConsultaPro.Columns[8].Width = 100;
                dtgDados_ConsultaPro.Columns[9].HeaderText = "Categoria";
                dtgDados_ConsultaPro.Columns[9].Width = 200;
                dtgDados_ConsultaPro.Columns[10].HeaderText = "SubCategoria";
                dtgDados_ConsultaPro.Columns[10].Width = 100;
                dtgDados_ConsultaPro.Columns[11].HeaderText = "SubCategoria";
                dtgDados_ConsultaPro.Columns[11].Width = 200;

                dtgDados_ConsultaPro.Columns["cat_cod"].Visible = false;
                dtgDados_ConsultaPro.Columns["scat_cod"].Visible = false;
                dtgDados_ConsultaPro.Columns["umed_cod"].Visible = false;
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
                BLLProduto bll = new BLLProduto(conexao);

                dtgDados_ConsultaPro.DataSource = bll.Localizar(txtProduto_ConsultaPro.Text);
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaPro.Rows[e.RowIndex].Cells[0].Value);
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
