using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramentas;


namespace GUI
{
    public partial class frmBackupBancoDeDados : Form
    {
        public frmBackupBancoDeDados()
        {
            InitializeComponent();
        }


        private void txtBackup_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();

                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string conexao = "SERVER=" + DadosDaConexao.servidor + ";DATABASE=" + DadosDaConexao.banco + ";UID=" + DadosDaConexao.usuario + ";PASSWORD=" + DadosDaConexao.senha + ";";

                    MySqlBackupBancoDados.BackupDataBase(conexao, d.FileName);

                    MessageBox.Show("Backup realizado com sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void txtRestaurar_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();

                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string conexao = "SERVER=" + DadosDaConexao.servidor + ";DATABASE=" + DadosDaConexao.banco + ";UID=" + DadosDaConexao.usuario + ";PASSWORD=" + DadosDaConexao.senha + ";";

                    MySqlBackupBancoDados.RestauraDatabase(conexao, d.FileName);

                    MessageBox.Show("Backup restaurado com sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }
    }
}
