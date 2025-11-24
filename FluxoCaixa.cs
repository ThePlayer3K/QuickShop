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
    public partial class FluxoCaixa : Form
    {
        DateTime data_inicial, data_final;
        public FluxoCaixa(DateTime data_inicial, DateTime data_final)
        {
            this.data_inicial = data_inicial;
            this.data_final = data_final;
            InitializeComponent();
        }

        private void FluxoCaixa_Load(object sender, EventArgs e)
        {
            lbl_inicial.Text = "Data inicial: " + data_inicial.ToString("dd/MM/yyyy");
            lbl_final.Text = "Data final: " + data_final.ToString("dd/MM/yyyy");
            string procurarFluxo = "SELECT id FROM fluxo_caixa WHERE data_inicio = @data_inicio AND data_fim = @data_fim";
            MySqlCommand comandoProcurar = new MySqlCommand(procurarFluxo, Program.conexao);
            comandoProcurar.Parameters.AddWithValue("@data_inicio", data_inicial.Date);
            comandoProcurar.Parameters.AddWithValue("@data_fim", data_final.Date);
            object resultado = comandoProcurar.ExecuteScalar();
            int id_fluxo = Convert.ToInt32(resultado);
            int novo_fluxo = 0;

            if (resultado != null)
            {
                if (DateTime.Now.Date <= data_final.Date)
                {
                    string deletarDespesas = "DELETE FROM despesas_has_fluxo_caixa WHERE fluxo_caixa_id = @id_fluxo";
                    MySqlCommand comandoDeletarDespesas = new MySqlCommand(deletarDespesas, Program.conexao);
                    comandoDeletarDespesas.Parameters.AddWithValue("@id_fluxo", id_fluxo);
                    comandoDeletarDespesas.ExecuteNonQuery();
                    string deletarVendas = "DELETE FROM fluxo_caixa_has_vendas WHERE fluxo_caixa_id = @id_fluxo";
                    MySqlCommand comandoDeletarVendas = new MySqlCommand(deletarVendas, Program.conexao);
                    comandoDeletarVendas.Parameters.AddWithValue("@id_fluxo", id_fluxo);
                    comandoDeletarVendas.ExecuteNonQuery();
                    string deletarFluxo = "DELETE FROM fluxo_caixa WHERE id = @id_fluxo";
                    MySqlCommand comandoDeletar = new MySqlCommand(deletarFluxo, Program.conexao);
                    comandoDeletar.Parameters.AddWithValue("@id_fluxo", id_fluxo);
                    comandoDeletar.ExecuteNonQuery();
                    novo_fluxo = criarFluxo();
                }
            }
            else
            {
                novo_fluxo = criarFluxo();
            }
            string obterFluxoExistente = "SELECT id FROM fluxo_caixa WHERE data_inicio = @data_inicio AND data_fim = @data_fim";
            MySqlCommand comandoObter = new MySqlCommand(obterFluxoExistente, Program.conexao);
            comandoObter.Parameters.AddWithValue("@data_inicio", data_inicial);
            comandoObter.Parameters.AddWithValue("@data_fim", data_final);
            MySqlDataReader lerFluxo = comandoObter.ExecuteReader();
            while (lerFluxo.Read())
            {
                novo_fluxo = lerFluxo.GetInt32(0);
            }
            lerFluxo.Close();
            carregarFluxo(novo_fluxo);

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private int criarFluxo()
        {
            int id;
            string nome = data_inicial.ToString("dd-MM-yyyy") + " - " + data_final.ToString("dd-MM-yyyy");
            string criarFluxo = "INSERT INTO fluxo_caixa (nome, data_inicio, data_fim, entradas_brutas, entradas_liquidas, saidas, total) VALUES (@nome, @data_inicio, @data_fim, 0, 0, 0, 0)";
            MySqlCommand comandoCriar = new MySqlCommand(criarFluxo, Program.conexao);
            comandoCriar.Parameters.AddWithValue("@nome", nome);
            comandoCriar.Parameters.AddWithValue("@data_inicio", data_inicial.Date);
            comandoCriar.Parameters.AddWithValue("@data_fim", data_final.Date);
            comandoCriar.ExecuteNonQuery();
            id = (int)comandoCriar.LastInsertedId;
            List<int> vendas = new List<int>();
            decimal total_vendas_liquidas = 0;
            decimal total_vendas_brutas = 0;
            string obterVendas = "SELECT id, valor_bruto, valor_liquido FROM vendas WHERE data BETWEEN @data_inicio AND @data_fim";
            MySqlCommand comandoObterVendas = new MySqlCommand(obterVendas, Program.conexao);
            comandoObterVendas.Parameters.AddWithValue("@data_inicio", data_inicial.Date);
            comandoObterVendas.Parameters.AddWithValue("@data_fim", data_final.Date);
            MySqlDataReader lerVendas = comandoObterVendas.ExecuteReader();
            while (lerVendas.Read())
            {
                vendas.Add(lerVendas.GetInt32(0));
                total_vendas_brutas += lerVendas.GetDecimal(1);
                total_vendas_liquidas += lerVendas.GetDecimal(2);
            }
            lerVendas.Close();
            foreach (int venda in vendas)
            {
                string associarVenda = "INSERT INTO fluxo_caixa_has_vendas VALUES (@id_fluxo, @id_venda)";
                MySqlCommand comandoAssociar = new MySqlCommand(associarVenda, Program.conexao);
                comandoAssociar.Parameters.AddWithValue("@id_fluxo", id);
                comandoAssociar.Parameters.AddWithValue("@id_venda", venda);
                comandoAssociar.ExecuteNonQuery();
            }
            List<int> despesas = new List<int>();
            string obterDespesas = "SELECT id, valor FROM despesas WHERE data BETWEEN @data_inicio AND @data_fim";
            MySqlCommand comandoObterDespesas = new MySqlCommand(obterDespesas, Program.conexao);
            comandoObterDespesas.Parameters.AddWithValue("@data_inicio", data_inicial.Date);
            comandoObterDespesas.Parameters.AddWithValue("@data_fim", data_final.Date);
            MySqlDataReader lerDespesas = comandoObterDespesas.ExecuteReader();
            decimal total_despesas = 0;
            while (lerDespesas.Read())
            {
                despesas.Add(lerDespesas.GetInt32(0));
                total_despesas += lerDespesas.GetDecimal(1);

            }
            lerDespesas.Close();
            foreach (int despesa in despesas)
            {
                string associarDespesa = "INSERT INTO despesas_has_fluxo_caixa (despesas_id, fluxo_caixa_id) VALUES (@id_despesa, @id_fluxo)";
                MySqlCommand comandoAssociarDespesa = new MySqlCommand(associarDespesa, Program.conexao);
                comandoAssociarDespesa.Parameters.AddWithValue("@id_despesa", despesa);
                comandoAssociarDespesa.Parameters.AddWithValue("@id_fluxo", id);
                comandoAssociarDespesa.ExecuteNonQuery();
            }
            decimal total = total_vendas_liquidas - total_despesas;
            string atualizarFluxo = "UPDATE fluxo_caixa SET entradas_brutas = @entradas_brutas, entradas_liquidas = @entradas_liquidas, saidas = @saidas, total = @total WHERE id = @id_fluxo";
            MySqlCommand comandoAtualizar = new MySqlCommand(atualizarFluxo, Program.conexao);
            comandoAtualizar.Parameters.AddWithValue("@entradas_brutas", total_vendas_brutas);
            comandoAtualizar.Parameters.AddWithValue("@entradas_liquidas", total_vendas_liquidas);
            comandoAtualizar.Parameters.AddWithValue("@saidas", total_despesas);
            comandoAtualizar.Parameters.AddWithValue("@total", total);
            comandoAtualizar.Parameters.AddWithValue("@id_fluxo", id);
            comandoAtualizar.ExecuteNonQuery();
            return id;
        }

        private void carregarFluxo(int id)
        {
            string obterDespesas = "SELECT d.id, d.data, d.nome, d.valor FROM despesas AS d INNER JOIN despesas_has_fluxo_caixa AS ligacao ON d.id = ligacao.despesas_id WHERE ligacao.fluxo_caixa_id = @fluxo";
            MySqlCommand comandoObterDespesas = new MySqlCommand(obterDespesas, Program.conexao);
            comandoObterDespesas.Parameters.AddWithValue("@fluxo", id);
            MySqlDataReader lerDespesas = comandoObterDespesas.ExecuteReader();
            while (lerDespesas.Read())
            {
                int id_despesa = lerDespesas.GetInt32(0);
                DateTime data = lerDespesas.GetDateTime(1);
                string nome = lerDespesas.GetString(2);
                decimal valor = lerDespesas.GetDecimal(3);
                ListViewItem item = new ListViewItem(id_despesa.ToString());
                item.SubItems.Add(nome);
                item.SubItems.Add(valor.ToString());
                item.SubItems.Add(data.ToString("dd/MM/yyyy"));
                lista_despesas.Items.Add(item);
            }
            lerDespesas.Close();
            string obterProdutos = "SELECT p.id, p.nome, SUM(pv.quantidade) FROM produtos AS p INNER JOIN produtos_venda AS pv ON p.id = pv.id_produto WHERE pv.id_venda IN\r\n(SELECT vendas_id FROM fluxo_caixa_has_vendas WHERE fluxo_caixa_id = @fluxo) GROUP BY p.id, p.nome";
            MySqlCommand comandoObterProdutos = new MySqlCommand(obterProdutos, Program.conexao);
            comandoObterProdutos.Parameters.AddWithValue("@fluxo", id);
            MySqlDataReader lerProdutos = comandoObterProdutos.ExecuteReader();
            while (lerProdutos.Read())
            {
                int id_produto = lerProdutos.GetInt32(0);
                string nome = lerProdutos.GetString(1);
                int quantidade = lerProdutos.GetInt32(2);
                ListViewItem item = new ListViewItem(id_produto.ToString());
                item.SubItems.Add(nome);
                item.SubItems.Add(quantidade.ToString());
                lista_produtos.Items.Add(item);
            }
            lerProdutos.Close();
            string obterEntradas = "SELECT m.nome, SUM(v.valor_bruto), SUM(v.valor_liquido) FROM vendas AS v INNER JOIN metodo_pag AS m ON m.id = v.metodo_pag WHERE v.id IN\r\n(SELECT vendas_id FROM fluxo_caixa_has_vendas WHERE fluxo_caixa_id = @fluxo) GROUP BY m.id";
            MySqlCommand comandoObterEntradas = new MySqlCommand(obterEntradas, Program.conexao);
            comandoObterEntradas.Parameters.AddWithValue("@fluxo", id);
            MySqlDataReader lerEntradas = comandoObterEntradas.ExecuteReader();
            while (lerEntradas.Read())
            {
                string nome_metodo = lerEntradas.GetString(0);
                decimal valor_bruto = lerEntradas.GetDecimal(1);
                decimal valor_liquido = lerEntradas.GetDecimal(2);
                ListViewItem item = new ListViewItem(nome_metodo);
                item.SubItems.Add("R$ " + valor_bruto.ToString("F2"));
                item.SubItems.Add("R$ " + valor_liquido.ToString("F2"));
                lista_entradas.Items.Add(item);
            }
            lerEntradas.Close();
            string obterDadosGerais = "SELECT saidas, entradas_brutas, entradas_liquidas, total FROM fluxo_caixa WHERE id = @fluxo";
            MySqlCommand comandoObterDadosGerais = new MySqlCommand(obterDadosGerais, Program.conexao);
            comandoObterDadosGerais.Parameters.AddWithValue("@fluxo", id);
            MySqlDataReader lerDadosGerais = comandoObterDadosGerais.ExecuteReader();
            while (lerDadosGerais.Read())
            {
                decimal saidas = lerDadosGerais.GetDecimal(0);
                decimal entradas_brutas = lerDadosGerais.GetDecimal(1);
                decimal entradas_liquidas = lerDadosGerais.GetDecimal(2);
                decimal total = lerDadosGerais.GetDecimal(3);
                lbl_brutas.Text = "Entradas Brutas: R$ " + entradas_brutas.ToString("F2");
                lbl_liquidas.Text = "Entradas Líquidas: R$ " + entradas_liquidas.ToString("F2");
                lbl_despesas.Text = "Saídas: R$ " + saidas.ToString("F2");
                lbl_total.Text = "Total: R$ " + total.ToString("F2");

            }
            lerDadosGerais.Close();
        }
    }
}
