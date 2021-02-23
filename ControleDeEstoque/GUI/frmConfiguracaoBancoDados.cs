using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using DAL;
using Ferramentas;


namespace GUI
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                //Arquivo fica dentro C:\Marco\Controle de Estoque\ControleDeEstoque\GUI\bin\Debug

                arquivo.WriteLine(txtServidor_Configuracao.Text);
                arquivo.WriteLine(txtBanco_Configuracao.Text);
                arquivo.WriteLine(txtUsuario_Configuracao.Text);
                arquivo.WriteLine(txtSenha_Configuracao.Text);
                arquivo.Close();

                MessageBox.Show("Arquivo atualizado com sucesso!");

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void frmConfiguracaoBandoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");

                txtServidor_Configuracao.Text = arquivo.ReadLine();
                txtBanco_Configuracao.Text = arquivo.ReadLine();
                txtUsuario_Configuracao.Text = arquivo.ReadLine();
                txtSenha_Configuracao.Text = arquivo.ReadLine();

                arquivo.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor_Configuracao.Text;
                DadosDaConexao.banco = txtBanco_Configuracao.Text;
                DadosDaConexao.usuario = txtUsuario_Configuracao.Text;
                DadosDaConexao.senha = txtSenha_Configuracao.Text;

                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();

                MessageBox.Show("Conexão efetuada com sucesso!");
            }
            catch (MySqlException)
            {
                MessageBox.Show(Validacao.MensagemErroSQL());
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }
    }
}
