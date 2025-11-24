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
    public partial class SelecionarFluxo : Form
    {
        public SelecionarFluxo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (picker_final.Value < picker_inicial.Value)
            {
                MessageBox.Show("A data final deve vir depois da inicial!");
            } else
            {
                FluxoCaixa fluxoCaixa = new FluxoCaixa(picker_inicial.Value, picker_final.Value);
                fluxoCaixa.Show();
                this.Hide();
            }
        }
    }
}
