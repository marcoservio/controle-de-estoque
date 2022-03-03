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
    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
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
                switch(valor)
                {
                    case Campo.CPF:
                        {
                            txtTexto.MaxLength = 14;

                            if(txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 7)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 11)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.CNPJ:
                        {
                            txtTexto.MaxLength = 18;

                            if(txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 10)
                            {
                                txtTexto.Text = txtTexto.Text + "/";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 15)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.CEP:
                        {
                            txtTexto.MaxLength = 9;

                            if(txtTexto.Text.Length == 5)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.TELEFONE:
                        {
                            txtTexto.MaxLength = 13;

                            if(txtTexto.Text.Length == 0)
                            {
                                txtTexto.Text = txtTexto.Text + "(";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if(txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ")";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if(txtTexto.Text.Length == 8)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.CELULAR:
                        {
                            txtTexto.MaxLength = 14;

                            if(txtTexto.Text.Length == 0)
                            {
                                txtTexto.Text = txtTexto.Text + "(";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if(txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ")";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            if(txtTexto.Text.Length == 9)
                            {
                                txtTexto.Text = txtTexto.Text + "-";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.RG:
                        {
                            txtTexto.MaxLength = 10;

                            if(txtTexto.Text.Length == 2)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 6)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }

                            break;
                        }
                    case Campo.IE:
                        {
                            txtTexto.MaxLength = 15;

                            if(txtTexto.Text.Length == 3)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 7)
                            {
                                txtTexto.Text = txtTexto.Text + ".";
                                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                            }
                            else if(txtTexto.Text.Length == 11)
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
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        public frmCadastroCliente()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome_Cliente.Clear();
            txtRsocial_Cliente.Clear();
            txtCpfCnpj_Cliente.Clear();
            txtRgIe_Cliente.Clear();
            txtNumero_Cliente.Clear();
            txtCep_Cliente.Clear();
            txtEstado_Cliente.Clear();
            txtCidade_Cliente.Clear();
            txtRua_Cliente.Clear();
            txtBairro_Cliente.Clear();
            txtEmail_Cliente.Clear();
            txtTelefone_Cliente.Clear();
            txtCelular_Cliente.Clear();

            lblEmailIncorreto_Cliente.Visible = false;
            lblValorIncorreto_Cliente.Visible = false;

            rdbFisica_Cliente.Checked = true;
        }


        private void frmCadastroCliente_Load(object sender, EventArgs e)
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
                frmConsultaCliente f = new frmConsultaCliente();

                f.ShowDialog();

                if(f.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(conexao);
                    ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);

                    txtCodigo.Text = modelo.CliCod.ToString();
                    txtNome_Cliente.Text = modelo.CliNome;
                    txtCpfCnpj_Cliente.Text = modelo.CliCpfCnpj;
                    txtRgIe_Cliente.Text = modelo.CliRgIe;
                    txtCep_Cliente.Text = modelo.CliCep;
                    txtCidade_Cliente.Text = modelo.CliCidade;
                    txtEstado_Cliente.Text = modelo.CliEstado;
                    txtRua_Cliente.Text = modelo.CliEndereco;
                    txtBairro_Cliente.Text = modelo.CliBairro;
                    txtNumero_Cliente.Text = modelo.CliEndNumero.ToString();
                    txtEmail_Cliente.Text = modelo.CliEmail;
                    txtTelefone_Cliente.Text = modelo.CliFone;
                    txtCelular_Cliente.Text = modelo.CliCel;
                    if(modelo.CliTipo == 0)
                    {
                        rdbFisica_Cliente.Checked = true;
                        txtRsocial_Cliente.Text = "";
                    }
                    else
                    {
                        rdbJuridica_Cliente.Checked = true;
                        txtRsocial_Cliente.Text = modelo.CliRsocial;
                    }

                    this.AlteraBotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }

                f.Dispose();
            }
            catch(Exception)
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

                if(d.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(conexao);

                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));

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
                if(lblEmailIncorreto_Cliente.Visible == false || lblValorIncorreto_Cliente.Visible == false)
                {
                    ModeloCliente modelo = new ModeloCliente();

                    modelo.CliNome = txtNome_Cliente.Text;
                    modelo.CliCpfCnpj = txtCpfCnpj_Cliente.Text;
                    modelo.CliRgIe = txtRgIe_Cliente.Text;
                    modelo.CliCep = txtCep_Cliente.Text;
                    modelo.CliCidade = txtCidade_Cliente.Text;
                    modelo.CliEstado = txtEstado_Cliente.Text;
                    modelo.CliEndereco = txtRua_Cliente.Text;
                    modelo.CliBairro = txtBairro_Cliente.Text;
                    modelo.CliEndNumero = Convert.ToInt32(txtNumero_Cliente.Text);
                    modelo.CliEmail = txtEmail_Cliente.Text;
                    modelo.CliFone = txtTelefone_Cliente.Text;
                    modelo.CliCel = txtCelular_Cliente.Text;
                    if(rdbFisica_Cliente.Checked == true)
                    {
                        modelo.CliTipo = 0;
                        modelo.CliRsocial = "";
                    }
                    else
                    {
                        modelo.CliTipo = 1;
                        modelo.CliRsocial = txtRsocial_Cliente.Text;
                    }

                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(conexao);

                    if(this.operacao.Equals("inserir"))
                    {
                        bll.Incluir(modelo);

                        MessageBox.Show("Cadastro efetuado com sucesso!");
                    }
                    else
                    {
                        modelo.CliCod = Convert.ToInt32(txtCodigo.Text);

                        bll.Alterar(modelo);

                        MessageBox.Show("Cadastro alterado com sucesso!");
                    }

                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
                else
                {
                    MessageBox.Show("Erro ao Salvar! Verificar os campos com observações");
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }


        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(rdbFisica_Cliente.Checked == true)
                {
                    lblRsocial_Cliente.Visible = false;
                    txtRsocial_Cliente.Visible = false;
                    lblCpfCnpj_Cliente.Text = "CPF";
                    lblRgie_Cliente.Text = "RG";
                }
                else
                {
                    lblRsocial_Cliente.Visible = true;
                    txtRsocial_Cliente.Visible = true;
                    lblCpfCnpj_Cliente.Text = "CNPJ";
                    lblRgie_Cliente.Text = "IE";
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                if(Validacao.ValidaCep(txtCep_Cliente.Text) == false)
                {
                    txtBairro_Cliente.Clear();
                    txtEstado_Cliente.Clear();
                    txtCidade_Cliente.Clear();
                    txtRua_Cliente.Clear();

                    lblCepIncorreto_Cliente.Visible = true;
                }
                else
                {
                    if(BuscaEndereco.VerificaCEP(txtCep_Cliente.Text) == true)
                    {
                        txtBairro_Cliente.Text = BuscaEndereco.bairro;
                        txtEstado_Cliente.Text = BuscaEndereco.estado;
                        txtCidade_Cliente.Text = BuscaEndereco.cidade;
                        txtRua_Cliente.Text = BuscaEndereco.endereco;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            try
            {
                lblValorIncorreto_Cliente.Visible = false;

                if(rdbFisica_Cliente.Checked == true)
                {
                    if(Validacao.IsCpf(txtCpfCnpj_Cliente.Text) == false)
                    {
                        lblValorIncorreto_Cliente.Visible = true;
                    }
                }
                else
                {
                    if(Validacao.IsCnpj(txtCpfCnpj_Cliente.Text) == false)
                    {
                        lblValorIncorreto_Cliente.Visible = true;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar != (char) 8)
                {
                    Campo edit = Campo.CPF;

                    if(rdbFisica_Cliente.Checked == false)
                    {
                        edit = Campo.CNPJ;
                    }

                    Formatar(edit, txtCpfCnpj_Cliente);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar != (char) 8)
                {
                    Campo edit = Campo.CEP;

                    Formatar(edit, txtCep_Cliente);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar != (char) 8)
                {
                    Campo edit = Campo.TELEFONE;

                    Formatar(edit, txtTelefone_Cliente);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar != (char) 8)
                {
                    Campo edit = Campo.CELULAR;

                    Formatar(edit, txtCelular_Cliente);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail_Cliente.Text;

                lblEmailIncorreto_Cliente.Visible = false;

                if(!Validacao.ValidaEmail(email))
                {
                    lblEmailIncorreto_Cliente.Visible = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtRgIe_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar != (char) 8)
                {
                    Campo edit;

                    if(lblRgie_Cliente.Text == "RG")
                    {
                        edit = Campo.RG;
                    }
                    else
                    {
                        edit = Campo.IE;
                    }

                    Formatar(edit, txtRgIe_Cliente);
                }
            }
            catch(Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
