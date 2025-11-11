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
    public partial class DeletarProduto : Form
    {
        public DeletarProduto()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codProduto = 0;
            try
            {
                codProduto = int.Parse(txt_Produto.Text);
            }
            catch
            {
                MessageBox.Show("Código do produto inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool encontrado = false;
            foreach (Produto prod in Program.produtos)
            {
                if (prod.getId() == codProduto)
                {
                    encontrado = true;
                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o produto " + prod.getNome() + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        prod.RemoverBanco();
                        Program.produtos.Remove(prod);
                        MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Produto não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }   
}
