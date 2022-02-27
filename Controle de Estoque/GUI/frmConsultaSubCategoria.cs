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
    public partial class frmConsultaSubCategoria : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);

                dtgDados_ConsultaSub.DataSource = bll.Localizar(txtValor_ConsultaSub.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaSub.Columns[0].HeaderText = "Código da SubCategoria";
                dtgDados_ConsultaSub.Columns[0].Width = 150;
                dtgDados_ConsultaSub.Columns[1].HeaderText = "Nome da SubCategoria";
                dtgDados_ConsultaSub.Columns[1].Width = 200;
                dtgDados_ConsultaSub.Columns[2].HeaderText = "Código da Categoria";
                dtgDados_ConsultaSub.Columns[2].Width = 130;
                dtgDados_ConsultaSub.Columns[3].HeaderText = "Nome da Categoria";
                dtgDados_ConsultaSub.Columns[3].Width = 200;
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaSub.Rows[e.RowIndex].Cells[0].Value);
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
