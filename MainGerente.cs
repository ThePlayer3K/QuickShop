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
    public partial class MainGerente : Form
    {

        string nomeConta;
        public MainGerente(string nomeConta)
        {
            InitializeComponent();
            this.nomeConta = nomeConta;
            lblLog.Text = String.Format("Você está logado como: {0}", nomeConta);
        }

        private void MainGerente_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainGerente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CadastroProduto cadastroProduto = new CadastroProduto();
              cadastroProduto.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarProduto visualizarProduto = new VisualizarProduto();
            visualizarProduto.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto editarProduto = new EditarProduto();
            editarProduto.Show();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarProduto deletarProduto = new DeletarProduto();
            deletarProduto.Show();
        }

        private void MainGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroVendas cadastroVendas = new CadastroVendas();
            cadastroVendas.Show();
        }
    }
}
