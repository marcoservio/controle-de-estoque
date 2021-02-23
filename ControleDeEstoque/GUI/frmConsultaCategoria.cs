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
    public partial class frmConsultaCategoria : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaCategoria()
        {
            InitializeComponent();
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(conexao);

                dtgDados_ConsultaCat.DataSource = bll.Localizar(txtValor_ConsultaCat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaCat.Columns[0].HeaderText = "Código";
                dtgDados_ConsultaCat.Columns[0].Width = 50;
                dtgDados_ConsultaCat.Columns[1].HeaderText = "Nome Categoria";
                dtgDados_ConsultaCat.Columns[1].Width = 400;
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaCat.Rows[e.RowIndex].Cells[0].Value);
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
