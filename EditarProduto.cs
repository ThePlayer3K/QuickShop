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
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codProduto = 0;
            try
            {
                codProduto = int.Parse(txt_cod.Text);
            } catch
            {
                MessageBox.Show("Código do produto inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                decimal preco = decimal.Parse(txt_preco.Text);
            } catch
            {
                if (txt_preco.Text != "")
                    MessageBox.Show("Preço inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                int qtd = int.Parse(text_qtd.Text);
                if (qtd < 0)
                {
                    MessageBox.Show("A quantidade em estoque não pode ser negativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                if (text_qtd.Text != "")
                    MessageBox.Show("Quantidade em estoque inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                bool encontrado = false;

            
            foreach (Produto prod in Program.produtos)
            {
                if (prod.getId() == codProduto)
                {
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Produto não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
            foreach (Produto prod in Program.produtos)
            {
                if (prod.getId() == codProduto)
                {
                    if (txt_nome.Text != "")
                    {
                        prod.setNome(txt_nome.Text);
                    }
                    if(txt_preco.Text != "")
                    {
                        prod.setPreco(decimal.Parse(txt_preco.Text));
                    }
                    if(text_qtd.Text != "")
                    {
                        prod.setQtdEstoque(int.Parse(text_qtd.Text));
                    }
                }
            }
            foreach (Produto prod in Program.produtos_historicos)
            {
                if (prod.getId() == codProduto)
                {
                    if (txt_nome.Text != "")
                    {
                        prod.setNome(txt_nome.Text);
                    }
                    if (txt_preco.Text != "")
                    {
                        prod.setPreco(decimal.Parse(txt_preco.Text));
                    }
                    if (text_qtd.Text != "")
                    {
                        prod.setQtdEstoque(int.Parse(text_qtd.Text));
                    }
                }
            }
            MessageBox.Show("Produto editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
