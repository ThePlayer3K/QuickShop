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
    public partial class CadastroVendas : Form
    {

        List<ProdutoVenda> produtosVenda;
        public CadastroVendas()
        {
            produtosVenda = new List<ProdutoVenda>();
            InitializeComponent();
            foreach (Produto prod in Program.produtos)
            {
                ListViewItem item = new ListViewItem(prod.getId().ToString());
                item.SubItems.Add(prod.getNome());
                item.SubItems.Add(prod.getPreco().ToString("F2"));
                item.SubItems.Add(prod.getQtdEstoque().ToString());
                listProdutos.Items.Add(item);
            }
        }

        private void CadastroVendas_Load(object sender, EventArgs e)
        {

        }

        private void listProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listProdutos.Columns[e.ColumnIndex].Width;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(listProdutos.SelectedItems[0].Text);
            int quantidade;
            try {
                quantidade = int.Parse(qtd.Text);
            } catch
            {
                MessageBox.Show("Quantidade Inválida! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nome = Program.produtos.FirstOrDefault(p => p.getId() == codigo).getNome();
            decimal preco_un = Program.produtos.FirstOrDefault(p => p.getId() == codigo).getPreco();
            if (Program.produtos.FirstOrDefault(p => p.getId() == codigo).getQtdEstoque() < quantidade)
            {
                MessageBox.Show("Não há produtos o suficiente para executar a venda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProdutoVenda pv = new ProdutoVenda(codigo, quantidade, nome, preco_un);
            bool produto_repetido = false;
            foreach (ProdutoVenda ProdVenda in produtosVenda)
            {
                if (ProdVenda.getId() == codigo)
                {
                    ProdVenda.setQuantidade(ProdVenda.getQuantidade() + quantidade);
                    produto_repetido = true;
                    foreach (ListViewItem item in produtosAtivos.Items)
                    {
                        if (item.Text == codigo.ToString())
                        {
                            item.SubItems[3].Text = ProdVenda.getQuantidade().ToString();
                        }
                    }

                }
            }
            if (!produto_repetido)
            {
                produtosVenda.Add(pv);
                ListViewItem item = new ListViewItem(pv.getId().ToString());
                item.SubItems.Add(pv.getNome());
                item.SubItems.Add(pv.getPreco().ToString("F2"));
                item.SubItems.Add(pv.getQuantidade().ToString());
                produtosAtivos.Items.Add(item);
            }
            decimal total = 0;
            foreach (ListViewItem item in produtosAtivos.Items)
            {
                total += decimal.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[3].Text);
            }
            total_vista.Text = "Total a vista: R$" + total.ToString("F2");

        }

        private void removerProd_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(produtosAtivos.SelectedItems[0].Text);
            foreach (ProdutoVenda ProdVenda in produtosVenda)
            {
                if (ProdVenda.getId() == codigo)
                {
                    produtosVenda.Remove(ProdVenda);
                    break;
                }
            }
            produtosAtivos.SelectedItems[0].Remove();
            decimal total = 0;
            foreach (ListViewItem item in produtosAtivos.Items)
            {
                total += decimal.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[3].Text);
            }
            total_vista.Text = "Total a vista: R$" + total.ToString("F2");
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            SelecionarMetodoVenda selecionarMetodoVenda = new SelecionarMetodoVenda(produtosVenda, this);
            selecionarMetodoVenda.ShowDialog();
        }
    }
}
