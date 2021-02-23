using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using Modelo;
using BLL;
using Ferramentas;


namespace GUI
{
    public partial class frmCadastroTipoPagamento : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroTipoPagamento()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtCodigo_TipoPagamento.Clear();
            txtNome_TipoPagamento.Clear();
        }


        private void CadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsutaTipoPagamento f = new frmConsutaTipoPagamento();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoPagamento bll = new BLLTipoPagamento(conexao);
                    ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(f.codigo);

                    txtCodigo_TipoPagamento.Text = modelo.TpaCod.ToString();
                    txtNome_TipoPagamento.Text = modelo.TpaNome;

                    this.AlteraBotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }

                f.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoPagamento bll = new BLLTipoPagamento(conexao);

                    bll.Excluir(Convert.ToInt32(txtCodigo_TipoPagamento.Text));

                    MessageBox.Show("Exclusão efetuada com sucesso!");

                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                this.AlteraBotoes(3);
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TpaNome = txtNome_TipoPagamento.Text;

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(conexao);

                if (this.operacao.Equals("inserir"))
                {
                    bll.Incluir(modelo);

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
                else
                {
                    modelo.TpaCod = Convert.ToInt32(txtCodigo_TipoPagamento.Text);

                    bll.Alterar(modelo);

                    MessageBox.Show("Cadastro alterado com sucesso!");
                }

                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
