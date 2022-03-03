using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DAL;
using System.IO;
using Ferramentas;


namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria subcategoria = new frmCadastroSubCategoria();
            subcategoria.ShowDialog();
            subcategoria.Dispose();
        }


        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria categoria = new frmCadastroCategoria();
            categoria.ShowDialog();
            categoria.Dispose();
        }


        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria categoria = new frmConsultaCategoria();
            categoria.ShowDialog();
            categoria.Dispose();
        }


        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria subcategoria = new frmConsultaSubCategoria();
            subcategoria.ShowDialog();
            subcategoria.Dispose();
        }


        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida unidadedemedida = new frmCadastroUnidadeDeMedida();
            unidadedemedida.ShowDialog();
            unidadedemedida.Dispose();
        }


        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida unidadedemedida = new frmConsultaUnidadeDeMedida();
            unidadedemedida.ShowDialog();
            unidadedemedida.Dispose();
        }


        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto produto = new frmCadastroProduto();
            produto.ShowDialog();
            produto.Dispose();
        }


        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto produto = new frmConsultaProduto();
            produto.ShowDialog();
            produto.Dispose();
        }


        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados configuracao = new frmConfiguracaoBancoDados();
            configuracao.ShowDialog();
            configuracao.Dispose();
        }


        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }


        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }


        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }


        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }


        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();

                //Testando conexão
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
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


        private void backupDoBandoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBancoDeDados backup = new frmBackupBancoDeDados();
            backup.ShowDialog();
            backup.Dispose();
        }


        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento tipoPagamento = new frmCadastroTipoPagamento();
            tipoPagamento.ShowDialog();
            tipoPagamento.Dispose();
        }


        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsutaTipoPagamento tipoPagamento = new frmConsutaTipoPagamento();
            tipoPagamento.ShowDialog();
            tipoPagamento.Dispose();
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cliente = new frmCadastroCliente();
            cliente.ShowDialog();
            cliente.Dispose();
        }


        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente cliente = new frmConsultaCliente();
            cliente.ShowDialog();
            cliente.Dispose();
        }


        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor fornec = new frmCadastroFornecedor();
            fornec.ShowDialog();
            fornec.Dispose();
        }


        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor fornec = new frmConsultaFornecedor();
            fornec.ShowDialog();
            fornec.Dispose();
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
            sobre.Dispose();
        }


        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCompra compra = new frmMovimentacaoCompra();
            compra.ShowDialog();
            compra.Dispose();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCompra compra = new frmConsultaCompra();
            compra.ShowDialog();
            compra.Dispose();
        }


        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentoCompra pagamento = new frmPagamentoCompra();
            pagamento.ShowDialog();
            pagamento.Dispose();
        }


        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVenda venda = new frmMovimentacaoVenda();
            venda.ShowDialog();
            venda.Dispose();
        }


        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVenda venda = new frmConsultaVenda();
            venda.ShowDialog();
            venda.Dispose();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecebimentoVenda venda = new frmRecebimentoVenda();
            venda.ShowDialog();
            venda.Dispose();
        }
    }
}
