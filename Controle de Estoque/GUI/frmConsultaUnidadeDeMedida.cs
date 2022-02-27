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
    public partial class frmConsultaUnidadeDeMedida : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaUnidadeDeMedida()
        {
            InitializeComponent();
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);

                dtgDados_ConsultaUmed.DataSource = bll.Localizar(txtUnidadeMedida_ConsultaUmed.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmConsultaUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaUmed.Columns[0].HeaderText = "Código";
                dtgDados_ConsultaUmed.Columns[0].Width = 50;
                dtgDados_ConsultaUmed.Columns[1].HeaderText = "Unidade de Medida";
                dtgDados_ConsultaUmed.Columns[1].Width = 400;
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaUmed.Rows[e.RowIndex].Cells[0].Value);
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
