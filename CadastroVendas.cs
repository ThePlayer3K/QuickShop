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
            ProdutoVenda pv = new ProdutoVenda(codigo, quantidade, nome, preco_un);
            produtosVenda.Add(pv);
            foreach (ProdutoVenda ProdVenda in produtosVenda)
            {
                ListViewItem item = new ListViewItem(ProdVenda.getId().ToString());
                item.SubItems.Add(ProdVenda.getNome());
                item.SubItems.Add(ProdVenda.getPreco().ToString());
                item.SubItems.Add(ProdVenda.getQuantidade().ToString());
                produtosAtivos.Items.Add(item);
            }
        }
    }
}
