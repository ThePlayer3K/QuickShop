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
    public partial class Comissoes : Form
    {
        public Comissoes()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            decimal taxa;
            try
            {
                taxa = (decimal.Parse(txt_comissao.Text) / 100);
            } catch
            {
                MessageBox.Show("Taxa inválida, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dataInicial = picker_inicial.Value;
            DateTime dataFinal = picker_final.Value;
            string procurarComissoes = "SELECT u.nome, SUM(v.valor_liquido) FROM usuarios AS u INNER JOIN vendas AS v ON u.id = v.vendedor WHERE data BETWEEN @data_inicial AND @data_final GROUP BY u.nome";
            MySqlCommand comandoProcurar = new MySqlCommand(procurarComissoes, Program.conexao);
            comandoProcurar.Parameters.AddWithValue("@data_inicial", dataInicial.Date);
            comandoProcurar.Parameters.AddWithValue("@data_final", dataFinal.Date);
            MySqlDataReader lerComissoes = comandoProcurar.ExecuteReader();
            while (lerComissoes.Read())
            {
                string nome = lerComissoes.GetString(0);
                decimal valor_total = lerComissoes.GetDecimal(1);
                decimal valor_comissao = valor_total * taxa;
                ListViewItem item = new ListViewItem(nome);
                item.SubItems.Add("R$" + valor_total.ToString("F2"));
                item.SubItems.Add("R$" + valor_comissao.ToString("F2"));
                lista_comissoes.Items.Add(item);
            }
            lerComissoes.Close();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lista_comissoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista_comissoes.SelectedItems.Count > 0)
            {
                btn_registrar.Enabled = true;
            } else
            {
                btn_registrar.Enabled = false;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string nome = lista_comissoes.SelectedItems[0].Text;
            string valor = lista_comissoes.SelectedItems[0].SubItems[1].Text.Substring(2);
            DateTime data = picker_final.Value;
            string nome_despesa = "Comissão para " + nome + " ( " + picker_inicial.Value.ToString("dd/MM/yyyy") + "-" + picker_final.Value.ToString("dd/MM/yyyy") + ")";
            CadastrarDespesa cadastrarDespesa = new CadastrarDespesa(nome_despesa, valor, data);
            cadastrarDespesa.Show();
        }
    }
}
