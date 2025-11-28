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
    public partial class HistoricoFluxos : Form
    {
        public HistoricoFluxos()
        {
            InitializeComponent();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            if (picker_inicial.Value == null || picker_final.Value == null)
            {
                MessageBox.Show("Por favor, selecione ambas as datas para realizar a busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picker_inicial.Value > picker_final.Value)
            {
                MessageBox.Show("A data de início deve vir antes da data do fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime data_inicio = picker_inicial.Value;
            DateTime data_final = picker_final.Value;
            string procurarFluxos = "SELECT id, data_inicio, data_fim, entradas_brutas, entradas_liquidas, saidas, total FROM fluxo_caixa WHERE data_inicio BETWEEN @data_inicial AND @data_final OR data_fim BETWEEN @data_inicial AND @data_final";
            MySqlCommand comandoProcurar = new MySqlCommand(procurarFluxos, Program.conexao);
            comandoProcurar.Parameters.AddWithValue("@data_inicial", data_inicio.Date);
            comandoProcurar.Parameters.AddWithValue("@data_final", data_final.Date);
            lista_fluxos.Items.Clear();
            try
            {
                MySqlDataReader lerFluxos = comandoProcurar.ExecuteReader();
                while (lerFluxos.Read())
                {
                    string codigo = lerFluxos.GetInt32(0).ToString();
                    string fluxo_inicio = lerFluxos.GetDateTime(1).ToString("dd/MM/yyyy");
                    string fluxo_fim = lerFluxos.GetDateTime(2).ToString("dd/MM/yyyy");
                    string entradas_brutas = "R$" + lerFluxos.GetDecimal(3).ToString("F2");
                    string entradas_liquidas = "R$" + lerFluxos.GetDecimal(4).ToString("F2");
                    string saidas = "R$" + lerFluxos.GetDecimal(5).ToString("F2");
                    string total = "R$" + lerFluxos.GetDecimal(6).ToString("F2");
                    ListViewItem item = new ListViewItem(codigo);
                    item.SubItems.Add(fluxo_inicio);
                    item.SubItems.Add(fluxo_fim);
                    item.SubItems.Add(entradas_brutas);
                    item.SubItems.Add(entradas_liquidas);
                    item.SubItems.Add(saidas);
                    item.SubItems.Add(total);
                    lista_fluxos.Items.Add(item);

                }
                lerFluxos.Close();

            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os fluxos do período: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
