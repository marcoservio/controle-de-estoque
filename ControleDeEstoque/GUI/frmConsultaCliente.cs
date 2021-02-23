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
    public partial class frmConsultaCliente : Form
    {
        #region //Variaveis

        public int codigo = 0;

        #endregion


        public frmConsultaCliente()
        {
            InitializeComponent();
        }


        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                btnLocalizar_Click(sender, e);

                dtgDados_ConsultaCli.Columns[0].HeaderText = "Código";
                dtgDados_ConsultaCli.Columns[0].Width = 50;
                dtgDados_ConsultaCli.Columns[1].HeaderText = "Nome Cliente";
                dtgDados_ConsultaCli.Columns[1].Width = 300;
                dtgDados_ConsultaCli.Columns[2].HeaderText = "CPF/CNPJ";
                dtgDados_ConsultaCli.Columns[2].Width = 150;
                dtgDados_ConsultaCli.Columns[3].HeaderText = "RG/IE";
                dtgDados_ConsultaCli.Columns[3].Width = 150;
                dtgDados_ConsultaCli.Columns[4].HeaderText = "Razão Social";
                dtgDados_ConsultaCli.Columns[4].Width = 300;
                dtgDados_ConsultaCli.Columns[5].HeaderText = "Tipo do Cliente";
                dtgDados_ConsultaCli.Columns[5].Width = 120;
                dtgDados_ConsultaCli.Columns[6].HeaderText = "CEP";
                dtgDados_ConsultaCli.Columns[6].Width = 100;
                dtgDados_ConsultaCli.Columns[7].HeaderText = "Endereço";
                dtgDados_ConsultaCli.Columns[7].Width = 300;
                dtgDados_ConsultaCli.Columns[8].HeaderText = "Bairro";
                dtgDados_ConsultaCli.Columns[8].Width = 300;
                dtgDados_ConsultaCli.Columns[9].HeaderText = "Telefone";
                dtgDados_ConsultaCli.Columns[9].Width = 100;
                dtgDados_ConsultaCli.Columns[10].HeaderText = "Celular";
                dtgDados_ConsultaCli.Columns[10].Width = 100;
                dtgDados_ConsultaCli.Columns[11].HeaderText = "E-mail";
                dtgDados_ConsultaCli.Columns[11].Width = 300;
                dtgDados_ConsultaCli.Columns[12].HeaderText = "Número";
                dtgDados_ConsultaCli.Columns[12].Width = 70;
                dtgDados_ConsultaCli.Columns[13].HeaderText = "Cidade";
                dtgDados_ConsultaCli.Columns[13].Width = 300;
                dtgDados_ConsultaCli.Columns[14].HeaderText = "Estado";
                dtgDados_ConsultaCli.Columns[14].Width = 150;
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
                BLLCliente bll = new BLLCliente(conexao);

                if (rdbNome_ConsultaCli.Checked == true)
                {
                    dtgDados_ConsultaCli.DataSource = bll.LocalizarNome(txtValor_ConsultaCli.Text);
                }
                else
                {
                    dtgDados_ConsultaCli.DataSource = bll.LocalizarCPFCNPJ(txtValor_ConsultaCli.Text);
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
                    this.codigo = Convert.ToInt32(dtgDados_ConsultaCli.Rows[e.RowIndex].Cells[0].Value);
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
