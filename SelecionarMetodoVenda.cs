using MySql.Data.MySqlClient;
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
    public partial class SelecionarMetodoVenda : Form
    {
        List<ProdutoVenda> produtosVenda;
        CadastroVendas cadastroVendas;
        decimal total = 0;
        public SelecionarMetodoVenda(List<ProdutoVenda> produtosVenda, CadastroVendas cadastroVendas)
        {
            InitializeComponent();
            this.produtosVenda = produtosVenda;
            foreach (ProdutoVenda pv in produtosVenda)
            {
                total += pv.getPreco() * pv.getQuantidade();
            }
            lbl_total_vista.Text = "TOTAL À VISTA: R$" + total.ToString("F2");
            foreach (MetPag metodo in Program.metodos_pag)
            {
                string nome = metodo.getNome();
                decimal entrada_liquida = metodo.ganhoLiquido(total);
                ListViewItem item = new ListViewItem(nome);
                item.SubItems.Add(entrada_liquida.ToString("F2"));
                lista_metodos.Items.Add(item);
            }

            this.cadastroVendas = cadastroVendas;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (lista_metodos.CheckedItems.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um método de pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string metodo_selecionado = lista_metodos.CheckedItems[0].Text;
            MetPag metodo = Program.metodos_pag.FirstOrDefault(m => m.getNome() == metodo_selecionado);
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja realizar esta venda de valor " + total.ToString("F2") + " utilizando o método de pagamento " + metodo.getNome() + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                string adicionarVenda = "INSERT INTO vendas (data, valor_bruto, valor_liquido, vendedor, metodo_pag) VALUES (@data, @valor_bruto, @valor_liquido, @vendedor, @metodo_pag)";
                DateTime data_atual = DateTime.Now.Date;
                MySqlCommand adicionandoVenda = new MySqlCommand(adicionarVenda, Program.conexao);
                adicionandoVenda.Parameters.AddWithValue("@data", data_atual);
                adicionandoVenda.Parameters.AddWithValue("@valor_bruto", total);
                adicionandoVenda.Parameters.AddWithValue("@valor_liquido", metodo.ganhoLiquido(total));
                adicionandoVenda.Parameters.AddWithValue("@vendedor", Program.conta_ativa);
                adicionandoVenda.Parameters.AddWithValue("@metodo_pag", metodo.getId());
                adicionandoVenda.ExecuteNonQuery();
                int venda_id = (int)adicionandoVenda.LastInsertedId;
                foreach (ProdutoVenda pv in produtosVenda)
                {
                    string adicionarProduto = "INSERT INTO produtos_venda (id_venda, id_produto, quantidade) VALUES (@id_venda, @id_produto, @quantidade)";
                    MySqlCommand adicionandoProduto = new MySqlCommand(adicionarProduto, Program.conexao);
                    adicionandoProduto.Parameters.AddWithValue("@id_venda", venda_id);
                    adicionandoProduto.Parameters.AddWithValue("@id_produto", pv.getId());
                    adicionandoProduto.Parameters.AddWithValue("@quantidade", pv.getQuantidade());
                    adicionandoProduto.ExecuteNonQuery();
                    string atualizarEstoque = "UPDATE produtos SET quantidade_estoque = quantidade_estoque - @qtd WHERE id = @id";
                    MySqlCommand comandoAtualizar = new MySqlCommand(atualizarEstoque, Program.conexao);
                    comandoAtualizar.Parameters.AddWithValue("@qtd", pv.getQuantidade());
                    comandoAtualizar.Parameters.AddWithValue("@id", pv.getId());
                    comandoAtualizar.ExecuteNonQuery();
                }
                MessageBox.Show("Venda realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cadastroVendas.Hide();
                this.Hide();
            }
        }
    }
}
