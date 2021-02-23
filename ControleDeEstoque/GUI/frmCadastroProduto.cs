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
    public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtCodigo_Produto.Clear();
            txtNome_Produto.Clear();
            txtDescricao_Produto.Clear();
            txtValorPago_Produto.Text = "0.00";
            txtValorVenda_Produto.Text = "0.00";
            txtQuantidade_Produto.Text = "0";

            cmbUnidadeMedida_Produto.SelectedIndex = 18;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "inserir";
        }


        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                this.AlteraBotoes(1);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);

                #region //Combo Categoria

                BLLCategoria bllCategoria = new BLLCategoria(conexao);

                cmbCategoria_Produto.DataSource = bllCategoria.Localizar("");
                cmbCategoria_Produto.DisplayMember = "cat_nome";
                cmbCategoria_Produto.ValueMember = "cat_cod";
                cmbCategoria_Produto.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbCategoria_Produto.AutoCompleteSource = AutoCompleteSource.ListItems;

                #endregion

                #region //Combo SubCategoria

                BLLSubCategoria bllSubCategoria = new BLLSubCategoria(conexao);

                cmbSubCategoria_Produto.DataSource = bllSubCategoria.LocalizarPorCategoria((int)cmbCategoria_Produto.SelectedValue);
                cmbSubCategoria_Produto.DisplayMember = "scat_nome";
                cmbSubCategoria_Produto.ValueMember = "scat_cod";

                #endregion

                #region //Combo Unidade de Medida

                BLLUnidadeDeMedida bllUnidadeMedida = new BLLUnidadeDeMedida(conexao);

                cmbUnidadeMedida_Produto.DataSource = bllUnidadeMedida.Localizar("");
                cmbUnidadeMedida_Produto.DisplayMember = "umed_nome";
                cmbUnidadeMedida_Produto.ValueMember = "umed_cod";

                #endregion

                cmbUnidadeMedida_Produto.SelectedIndex = 18;
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorVenda_Produto.Text.Contains(","))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorPago_Produto.Text.Contains(","))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtValorPago_Produto.Text.Contains(",") == false)
                {
                    txtValorPago_Produto.Text += ",00";
                }
                else
                {
                    if (txtValorPago_Produto.Text.IndexOf(",") == txtValorPago_Produto.Text.Length - 1)
                    {
                        txtValorPago_Produto.Text += "00";
                    }
                }
                try
                {
                    double d = Convert.ToDouble(txtValorPago_Produto.Text);
                }
                catch
                {
                    txtValorPago_Produto.Text = "0,00";
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtValorVenda_Produto.Text.Contains(",") == false)
                {
                    txtValorVenda_Produto.Text += ",00";
                }
                else
                {
                    if (txtValorVenda_Produto.Text.IndexOf(",") == txtValorVenda_Produto.Text.Length - 1)
                    {
                        txtValorVenda_Produto.Text += "00";
                    }
                }
                try
                {
                    double d = Convert.ToDouble(txtValorVenda_Produto.Text);
                }
                catch
                {
                    txtValorVenda_Produto.Text = "0,00";
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bllSubCategoria = new BLLSubCategoria(conexao);

                cmbSubCategoria_Produto.Text = "";

                if (cmbCategoria_Produto.SelectedValue != null)
                {
                    int value = 0;

                    value = Convert.ToInt32(cmbCategoria_Produto.SelectedValue.GetHashCode());

                    cmbSubCategoria_Produto.DataSource = bllSubCategoria.LocalizarPorCategoria(value);
                    cmbSubCategoria_Produto.DisplayMember = "scat_nome";
                    cmbSubCategoria_Produto.ValueMember = "scat_cod";
                }
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaTela();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloProduto modelo = new ModeloProduto();

                modelo.Pro_Nome = txtNome_Produto.Text;
                modelo.Pro_Descricao = txtDescricao_Produto.Text;
                modelo.Pro_Qtde = Convert.ToInt32(txtQuantidade_Produto.Text);
                modelo.Pro_ValorPago = Convert.ToDouble(txtValorPago_Produto.Text);
                modelo.Pro_ValorVenda = Convert.ToDouble(txtValorVenda_Produto.Text);
                modelo.Cat_Cod = Convert.ToInt32(cmbCategoria_Produto.SelectedValue);
                modelo.Umed_Cod = Convert.ToInt32(cmbUnidadeMedida_Produto.SelectedValue);
                modelo.Scat_Cod = Convert.ToInt32(cmbSubCategoria_Produto.SelectedValue);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(conexao);

                if (this.operacao.Equals("inserir"))
                {
                    bll.Incluir(modelo);

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
                else
                {
                    modelo.Pro_Cod = Convert.ToInt32(txtCodigo_Produto.Text);

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
                    BLLProduto bll = new BLLProduto(conexao);

                    bll.Excluir(Convert.ToInt32(txtCodigo_Produto.Text));

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
                frmConsultaProduto f = new frmConsultaProduto();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(conexao);
                    ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);

                    txtCodigo_Produto.Text = modelo.Pro_Cod.ToString();
                    txtNome_Produto.Text = modelo.Pro_Nome;
                    txtDescricao_Produto.Text = modelo.Pro_Descricao;
                    txtQuantidade_Produto.Text = modelo.Pro_Qtde.ToString();
                    txtValorPago_Produto.Text = modelo.Pro_ValorPago.ToString();
                    txtValorVenda_Produto.Text = modelo.Pro_ValorVenda.ToString();
                    cmbUnidadeMedida_Produto.SelectedValue = modelo.Umed_Cod;
                    cmbCategoria_Produto.SelectedValue = modelo.Cat_Cod;
                    cmbSubCategoria_Produto.SelectedValue = modelo.Scat_Cod;

                    txtValorPago_Leave(sender, e);
                    txtValorVenda_Leave(sender, e);

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


        private void btnAddUnidadeMedida_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroUnidadeDeMedida unidadeMedida = new frmCadastroUnidadeDeMedida();
                unidadeMedida.ShowDialog();
                unidadeMedida.Dispose();

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida umedbll = new BLLUnidadeDeMedida(conexao);

                cmbUnidadeMedida_Produto.DataSource = umedbll.Localizar("");
                cmbUnidadeMedida_Produto.DisplayMember = "umed_nome";
                cmbUnidadeMedida_Produto.ValueMember = "umed_cod";
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCategoria categoria = new frmCadastroCategoria();
                categoria.ShowDialog();
                categoria.Dispose();

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria sbll = new BLLSubCategoria(conexao);

                cmbSubCategoria_Produto.DataSource = sbll.LocalizarPorCategoria((int)cmbCategoria_Produto.SelectedValue);
                cmbSubCategoria_Produto.DisplayMember = "scat_nome";
                cmbSubCategoria_Produto.ValueMember = "scat_cod";
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnAddSubCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroSubCategoria subCategoria = new frmCadastroSubCategoria();
                subCategoria.ShowDialog();
                subCategoria.Dispose();

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(conexao);

                cmbCategoria_Produto.DataSource = bll.Localizar("");
                cmbCategoria_Produto.DisplayMember = "cat_nome";
                cmbCategoria_Produto.ValueMember = "cat_cod";
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }


        private void cmbUnidadeMedida_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
