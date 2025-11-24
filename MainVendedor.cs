using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickShop
{
    public partial class MainVendedor : Form
    {
        string nomeConta;
        public MainVendedor(string NomeConta)
        {
            InitializeComponent();
            this.nomeConta = NomeConta;
            lblLog.Text = String.Format("Você está logado como: {0}", nomeConta);
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarProduto visualizarProduto = new VisualizarProduto();
            visualizarProduto.Show();
        }

        private void MainVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Isso fechará todo o sistema. Tem certeza que quer sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarConta alterarConta = new AlterarConta(this);
            alterarConta.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVendas cadastroVendas = new CadastroVendas();
            cadastroVendas.Show();
        }
        public void mudarLabel(string nome)
        {
            lblLog.Text = "Você está logado em: " + nome;
        }
    }
}
