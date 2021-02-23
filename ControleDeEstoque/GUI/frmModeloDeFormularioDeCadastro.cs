using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferramentas;


namespace GUI
{
    public partial class frmModeloDeFormularioDeCadastro : Form
    {
        #region //Variaveis

        public string operacao;

        #endregion


        public frmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }


        public void AlteraBotoes(int op)
        {
            // op = Operaçãoes que são feitas com os botões.
            // 1 = Preparar os botões para inserir e localizar.
            // 2 = Preparar os para inserir/alterar um registro
            // 3 = Preparar a tela para excluir ou alterar

            try
            {
                pnlDados.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnLocalizar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;

                switch (op)
                {
                    case 1:
                        {
                            btnInserir.Enabled = true;
                            btnLocalizar.Enabled = true;

                            break;
                        }
                    case 2:
                        {
                            pnlDados.Enabled = true;
                            btnSalvar.Enabled = true;
                            btnCancelar.Enabled = true;

                            break;
                        }
                    case 3:
                        {
                            btnAlterar.Enabled = true;
                            btnExcluir.Enabled = true;
                            btnCancelar.Enabled = true;

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


        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }


        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Validacao.MensagemErro());
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
