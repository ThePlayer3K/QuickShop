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
    public partial class VisualizarProduto : Form
    {
        public VisualizarProduto()
        {
            InitializeComponent();
            foreach (Produto prod in Program.produtos)
            {
                ListViewItem item = new ListViewItem(prod.getId().ToString());
                item.SubItems.Add(prod.getNome());
                item.SubItems.Add(prod.getPreco().ToString("F2"));
                item.SubItems.Add(prod.getQtdEstoque().ToString());
                listaProdutos.Items.Add(item);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaProdutos_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
        }

        private void listaProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listaProdutos.Columns[e.ColumnIndex].Width;
        }
    }
}
