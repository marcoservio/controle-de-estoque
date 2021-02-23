using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using BLL;
using DAL;
using Ferramentas;


namespace GUI
{
    public partial class frmConsultaFornecedor : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }


        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaFor.Columns[0].HeaderText = "Código";
                dtgDados_ConsultaFor.Columns[0].Width = 50;
                dtgDados_ConsultaFor.Columns[1].HeaderText = "Nome Cliente";
                dtgDados_ConsultaFor.Columns[1].Width = 300;
                dtgDados_ConsultaFor.Columns[2].HeaderText = "Razão Social";
                dtgDados_ConsultaFor.Columns[2].Width = 300;
                dtgDados_ConsultaFor.Columns[3].HeaderText = "IE";
                dtgDados_ConsultaFor.Columns[3].Width = 150;
                dtgDados_ConsultaFor.Columns[4].HeaderText = "CNPJ";
                dtgDados_ConsultaFor.Columns[4].Width = 150;
                dtgDados_ConsultaFor.Columns[5].HeaderText = "CEP";
                dtgDados_ConsultaFor.Columns[5].Width = 100;
                dtgDados_ConsultaFor.Columns[6].HeaderText = "Endereço";
                dtgDados_ConsultaFor.Columns[6].Width = 300;
                dtgDados_ConsultaFor.Columns[7].HeaderText = "Bairro";
                dtgDados_ConsultaFor.Columns[7].Width = 300;
                dtgDados_ConsultaFor.Columns[8].HeaderText = "Telefone";
                dtgDados_ConsultaFor.Columns[8].Width = 100;
                dtgDados_ConsultaFor.Columns[9].HeaderText = "Celular";
                dtgDados_ConsultaFor.Columns[9].Width = 100;
                dtgDados_ConsultaFor.Columns[10].HeaderText = "E-mail";
                dtgDados_ConsultaFor.Columns[10].Width = 300;
                dtgDados_ConsultaFor.Columns[11].HeaderText = "Número";
                dtgDados_ConsultaFor.Columns[11].Width = 70;
                dtgDados_ConsultaFor.Columns[12].HeaderText = "Cidade";
                dtgDados_ConsultaFor.Columns[12].Width = 300;
                dtgDados_ConsultaFor.Columns[13].HeaderText = "Estado";
                dtgDados_ConsultaFor.Columns[13].Width = 150;
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
                BLLFornecedor bll = new BLLFornecedor(conexao);

                if (rdbNome_ConsultaFor.Checked == true)
                {
                    dtgDados_ConsultaFor.DataSource = bll.LocalizarNome(txtValor_ConsultaFor.Text);
                }
                else
                {
                    dtgDados_ConsultaFor.DataSource = bll.LocalizarCNPJ(txtValor_ConsultaFor.Text);
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaFor.Rows[e.RowIndex].Cells[0].Value);
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
