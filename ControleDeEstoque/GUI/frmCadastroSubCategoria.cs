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
    public partial class frmCadastroSubCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtCodigo_SubCategoria.Clear();
            txtNome_SubCategoria.Clear();
        }


        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                this.AlteraBotoes(1);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(conexao);

                cmbCategoria_SubCategoria.DataSource = bll.Localizar("");
                cmbCategoria_SubCategoria.DisplayMember = "cat_nome";
                cmbCategoria_SubCategoria.ValueMember = "cat_cod";
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "inserir";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaTela();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "alterar";
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNome_SubCategoria.Text;
                modelo.CatCod = Convert.ToInt32(cmbCategoria_SubCategoria.SelectedValue);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);

                if (this.operacao.Equals("inserir"))
                {
                    bll.Incluir(modelo);

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
                else
                {
                    modelo.ScatCod = Convert.ToInt32(txtCodigo_SubCategoria.Text);

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


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(conexao);

                    bll.Excluir(Convert.ToInt32(txtCodigo_SubCategoria.Text));

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


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaSubCategoria f = new frmConsultaSubCategoria();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(conexao);
                    ModeloSubCategoria modelo = bll.CarregaModeloCategoria(f.codigo);

                    txtCodigo_SubCategoria.Text = modelo.ScatCod.ToString();
                    txtNome_SubCategoria.Text = modelo.ScatNome;
                    cmbCategoria_SubCategoria.SelectedValue = modelo.CatCod;

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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCategoria categoria = new frmCadastroCategoria();
                categoria.ShowDialog();
                categoria.Dispose();

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(conexao);

                cmbCategoria_SubCategoria.DataSource = bll.Localizar("");
                cmbCategoria_SubCategoria.DisplayMember = "cat_nome";
                cmbCategoria_SubCategoria.ValueMember = "cat_cod";
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
