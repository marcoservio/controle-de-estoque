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
    public partial class frmCadastroFornecedor : GUI.frmModeloDeFormularioDeCadastro
    {
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
            TELEFONE = 4,
            CELULAR = 5,
            RG = 6,
            IE = 7,
        }


        public void Formatar(Campo valor, TextBox txtTexto)
        {
            try
            {
                switch (valor)
                {
                    case Campo.CPF:
                        {
                            txtTexto.MaxLength = 14;

                            if (txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 7)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 11)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.CNPJ:
                        {
                            txtTexto.MaxLength = 18;

                            if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 10)
                            {
                                txtTexto.Text = txtTexto.Text + "/";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 15)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.CEP:
                        {
                            txtTexto.MaxLength = 9;

                            if (txtTexto.Text.Length == 5)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.TELEFONE:
                        {
                            txtTexto.MaxLength = 13;

                            if (txtTexto.Text.Length == 0)
                            {
                                txtTexto.Text = txtTexto.Text + "(";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if (txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ")";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if (txtTexto.Text.Length == 8)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.CELULAR:
                        {
                            txtTexto.MaxLength = 14;

                            if (txtTexto.Text.Length == 0)
                            {
                                txtTexto.Text = txtTexto.Text + "(";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if (txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ")";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if (txtTexto.Text.Length == 9)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.RG:
                        {
                            txtTexto.MaxLength = 10;

                            if (txtTexto.Text.Length == 2)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 6)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.IE:
                        {
                            txtTexto.MaxLength = 15;

                            if (txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 7)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if (txtTexto.Text.Length == 11)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtCodigo_Fornecedor.Clear();
            txtNome_Fornecedor.Clear();
            txtRsocial.Clear();
            txtCnpj_Fornecedor.Clear();
            txtIe_Fornecedor.Clear();
            txtNumero_Fornecedor.Clear();
            txtCep_Fornecedor.Clear();
            txtEstado_Fornecedor.Clear();
            txtCidade_Fornecedor.Clear();
            txtRua_Fornecedor.Clear();
            txtBairro_Fornecedor.Clear();
            txtEmail_Fornecedor.Clear();
            txtTelefone_Fornecedor.Clear();
            txtCelular_Fornecedor.Clear();

            lblValorIncorreto_Fornecedor.Visible = false;
            lblEmailIncorreto_Fornecedor.Visible = false;
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
                frmConsultaFornecedor f = new frmConsultaFornecedor();

                f.ShowDialog();

                if (f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(conexao);
                    ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                    txtCodigo_Fornecedor.Text = modelo.ForCod.ToString();
                    txtNome_Fornecedor.Text = modelo.ForNome;
                    txtCnpj_Fornecedor.Text = modelo.ForCnpj;
                    txtIe_Fornecedor.Text = modelo.ForIe;
                    txtCep_Fornecedor.Text = modelo.ForCep;
                    txtCidade_Fornecedor.Text = modelo.ForCidade;
                    txtEstado_Fornecedor.Text = modelo.ForEstado;
                    txtRua_Fornecedor.Text = modelo.ForEndereco;
                    txtBairro_Fornecedor.Text = modelo.ForBairro;
                    txtNumero_Fornecedor.Text = modelo.ForEndNumero.ToString();
                    txtEmail_Fornecedor.Text = modelo.ForEmail;
                    txtTelefone_Fornecedor.Text = modelo.ForFone;
                    txtCelular_Fornecedor.Text = modelo.ForCel;
                    txtRsocial.Text = modelo.ForRsocial;

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
                    BLLFornecedor bll = new BLLFornecedor(conexao);

                    bll.Excluir(Convert.ToInt32(txtCodigo_Fornecedor.Text));

                    MessageBox.Show("Exclusão efetuada com sucesso!");

                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show(Validacao.MensagemErro());
                this.AlteraBotoes(3);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEmailIncorreto_Fornecedor.Visible == false || lblValorIncorreto_Fornecedor.Visible == false)
                {
                    ModeloFornecedor modelo = new ModeloFornecedor();

                    modelo.ForNome = txtNome_Fornecedor.Text;
                    modelo.ForCnpj = txtCnpj_Fornecedor.Text;
                    modelo.ForIe = txtIe_Fornecedor.Text;
                    modelo.ForCep = txtCep_Fornecedor.Text;
                    modelo.ForCidade = txtCidade_Fornecedor.Text;
                    modelo.ForEstado = txtEstado_Fornecedor.Text;
                    modelo.ForEndereco = txtRua_Fornecedor.Text;
                    modelo.ForBairro = txtBairro_Fornecedor.Text;
                    modelo.ForEndNumero = Convert.ToInt32(txtNumero_Fornecedor.Text);
                    modelo.ForEmail = txtEmail_Fornecedor.Text;
                    modelo.ForFone = txtTelefone_Fornecedor.Text;
                    modelo.ForCel = txtCelular_Fornecedor.Text;
                    modelo.ForRsocial = txtRsocial.Text;

                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(conexao);

                    if (this.operacao.Equals("inserir"))
                    {
                        bll.Incluir(modelo);

                        MessageBox.Show("Cadastro efetuado com sucesso!");
                    }
                    else
                    {
                        modelo.ForCod = Convert.ToInt32(txtCodigo_Fornecedor.Text);

                        bll.Alterar(modelo);

                        MessageBox.Show("Cadastro alterado com sucesso!");
                    }

                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
                else
                {
                    MessageBox.Show("Erro ao Salvar! Verificar os campos com observações.");
                }
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


        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }


        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Validacao.ValidaCep(txtCep_Fornecedor.Text) == false)
                {
                    txtBairro_Fornecedor.Clear();
                    txtEstado_Fornecedor.Clear();
                    txtCidade_Fornecedor.Clear();
                    txtRua_Fornecedor.Clear();

                    lblCepIncorreto_Fornecedor.Visible = true;
                }
                else
                {
                    if (BuscaEndereco.VerificaCEP(txtCep_Fornecedor.Text) == true)
                    {
                        txtBairro_Fornecedor.Text = BuscaEndereco.bairro;
                        txtEstado_Fornecedor.Text = BuscaEndereco.estado;
                        txtCidade_Fornecedor.Text = BuscaEndereco.cidade;
                        txtRua_Fornecedor.Text = BuscaEndereco.endereco;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            try
            {
                lblValorIncorreto_Fornecedor.Visible = false;

                if (Validacao.IsCnpj(txtCnpj_Fornecedor.Text) == false)
                {
                    lblValorIncorreto_Fornecedor.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != (char)8)
                {
                    Campo edit = Campo.CNPJ;

                    Formatar(edit, txtCnpj_Fornecedor);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != (char)8)
                {
                    Campo edit = Campo.CEP;

                    Formatar(edit, txtCep_Fornecedor);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != (char)8)
                {
                    Campo edit = Campo.TELEFONE;

                    Formatar(edit, txtTelefone_Fornecedor);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != (char)8)
                {
                    Campo edit = Campo.CELULAR;

                    Formatar(edit, txtCelular_Fornecedor);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail_Fornecedor.Text;

                lblEmailIncorreto_Fornecedor.Visible = false;

                if (!Validacao.ValidaEmail(email))
                {
                    lblEmailIncorreto_Fornecedor.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtIe_Fornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != (char)8)
                {
                    Campo edit = Campo.IE;

                    Formatar(edit, txtIe_Fornecedor);
                }
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
