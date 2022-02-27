using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;
using Ferramentas;


namespace GUI
{
    public partial class frmCadastroUnidadeDeMedida : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtCodigo_UnidadeMedida.Clear();
            txtNome_UnidadeMedida.Clear();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
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
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);

                    bll.Excluir(Convert.ToInt32(txtCodigo_UnidadeMedida.Text));

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


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = txtNome_UnidadeMedida.Text;

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);

                if (this.operacao.Equals("inserir"))
                {
                    bll.Incluir(modelo);

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
                else
                {
                    modelo.UmedCod = Convert.ToInt32(txtCodigo_UnidadeMedida.Text);

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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(conexao);
                    ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(f.codigo);

                    txtCodigo_UnidadeMedida.Text = modelo.UmedCod.ToString();
                    txtNome_UnidadeMedida.Text = modelo.UmedNome;

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


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
