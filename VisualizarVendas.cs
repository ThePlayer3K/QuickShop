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
    public partial class VisualizarVendas : Form
    {
        public VisualizarVendas()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            if (picker_inicial.Value == null || picker_final.Value == null)
            {
                MessageBox.Show("Por favor, selecione ambas as datas para realizar a busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dataInicio = picker_inicial.Value.Date;
            DateTime dataFim = picker_final.Value.Date.AddDays(1).AddSeconds(-1);
            string procurarMetodos = "SELECT metodo_pag.nome, SUM(vendas.valor_bruto), SUM(vendas.valor_liquido) FROM metodo_pag INNER JOIN vendas ON metodo_pag.id = vendas.metodo_pag WHERE vendas.data BETWEEN @dataInicio AND @dataFim GROUP BY metodo_pag.nome";
            MySqlCommand comandoMetodos = new MySqlCommand(procurarMetodos, Program.conexao);
            comandoMetodos.Parameters.AddWithValue("@dataInicio", dataInicio);
            comandoMetodos.Parameters.AddWithValue("@dataFim", dataFim);
            lista_valores.Items.Clear();
            decimal total_bruto = 0;
            decimal total_liquido = 0;
            try
            {
                MySqlDataReader leitorMetodos = comandoMetodos.ExecuteReader();
                while (leitorMetodos.Read())
                {
                    string nomeMetodo = leitorMetodos.GetString(0);
                    decimal valorBruto = leitorMetodos.GetDecimal(1);
                    decimal valorLiquido = leitorMetodos.GetDecimal(2);
                    total_bruto += valorBruto;
                    total_liquido += valorLiquido;
                    ListViewItem item = new ListViewItem(nomeMetodo);
                    item.SubItems.Add("R$" + valorBruto.ToString("F2"));
                    item.SubItems.Add("R$" + valorLiquido.ToString("F2"));
                    lista_valores.Items.Add(item);
                }
                leitorMetodos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os dados de vendas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lbl_bruto.Text = "Total Bruto: R$ " + total_bruto.ToString("F2");
            lbl_liquido.Text = "Total Líquido: R$ " + total_liquido.ToString("F2");
            string procrurarProdutos = "SELECT produtos.id, produtos.nome, SUM(produtos_venda.quantidade) FROM produtos INNER JOIN produtos_venda ON produtos.id = produtos_venda.id_produto INNER JOIN vendas ON produtos_venda.id_venda = vendas.id WHERE vendas.data BETWEEN @dataInicio AND @dataFim GROUP BY produtos.id";
            MySqlCommand comandoProdutos = new MySqlCommand(procrurarProdutos, Program.conexao);
            comandoProdutos.Parameters.AddWithValue("@dataInicio", dataInicio);
            comandoProdutos.Parameters.AddWithValue("@dataFim", dataFim);
            lista_produtos.Items.Clear();
            try
            {
                MySqlDataReader leitorProdutos = comandoProdutos.ExecuteReader();
                while (leitorProdutos.Read())
                {
                    int idProduto = leitorProdutos.GetInt32(0);
                    string nomeProduto = leitorProdutos.GetString(1);
                    int quantidadeVendida = leitorProdutos.GetInt32(2);
                    ListViewItem item = new ListViewItem(idProduto.ToString());
                    item.SubItems.Add(nomeProduto);
                    item.SubItems.Add(quantidadeVendida.ToString());
                    lista_produtos.Items.Add(item);
                }
                leitorProdutos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os dados de produtos vendidos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
