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
    public partial class VisualizarMetPag : Form
    {
        public VisualizarMetPag()
        {
            InitializeComponent();
            foreach (MetPag metodo in Program.metodos_pag)
            {
                ListViewItem item = new ListViewItem(metodo.getId().ToString());
                item.SubItems.Add(metodo.getNome());
                item.SubItems.Add(metodo.getTaxa().ToString("F2"));
                lista_metodos.Items.Add(item);
            }
        }

        private void VisualizarMetPag_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
