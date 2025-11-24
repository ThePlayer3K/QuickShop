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

        public void mudarLabel(string nome)
        {
            lblLog.Text = "Você está logado em: " + nome;
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

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarMetPag cadastrarMetPag = new CadastrarMetPag();
            cadastrarMetPag.Show();
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditarMetPag editarMetPag = new EditarMetPag();
            editarMetPag.Show();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisualizarMetPag visualizarMetPag = new VisualizarMetPag();
            visualizarMetPag.Show();
        }

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExcluirMetPag excluirMetPag = new ExcluirMetPag();
            excluirMetPag.Show();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizarVendas visualizarVendas = new VisualizarVendas();
            visualizarVendas.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarDespesa cadastrarDespesa = new CadastrarDespesa();
            cadastrarDespesa.Show();

        }

        private void visualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VisualizarDespesas visualizarDespesas = new VisualizarDespesas();
            visualizarDespesas.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarDespesa editarDespesa = new EditarDespesa();
            editarDespesa.Show();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoverDespesa removerDespesa = new RemoverDespesa();
            removerDespesa.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SelecionarFluxo selecionarFluxo = new SelecionarFluxo();
           selecionarFluxo.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarConta alterarConta = new AlterarConta(this);
            alterarConta.Show();
        }

        private void comissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comissoes comissoes = new Comissoes();
            comissoes.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerirContas gerirContas = new GerirContas();
            gerirContas.Show();
        }
    }
}
