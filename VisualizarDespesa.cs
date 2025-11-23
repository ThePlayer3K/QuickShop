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
    public partial class VisualizarDespesas : Form
    {
        public VisualizarDespesas()
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
            string procurarDespesas = "SELECT id, nome, valor, data FROM despesas WHERE data BETWEEN @dataInicio AND @dataFim";
            MySqlCommand comandoDespesas = new MySqlCommand(procurarDespesas, Program.conexao);
            comandoDespesas.Parameters.AddWithValue("@dataInicio", dataInicio);
            comandoDespesas.Parameters.AddWithValue("@dataFim", dataFim);
            lista_despesas.Items.Clear();
            decimal total_despesas = 0;
            try
            {
                MySqlDataReader leitorDespesas = comandoDespesas.ExecuteReader();
                while (leitorDespesas.Read())
                {
                    int idDespesa = leitorDespesas.GetInt32(0);
                    string nomeDespesa = leitorDespesas.GetString(1);
                    decimal valorDespesa = leitorDespesas.GetDecimal(2);
                    DateTime dataDespesa = leitorDespesas.GetDateTime(3);
                    total_despesas += valorDespesa;
                    ListViewItem item = new ListViewItem(idDespesa.ToString());
                    item.SubItems.Add(nomeDespesa);
                    item.SubItems.Add("R$" + valorDespesa.ToString("F2"));
                    item.SubItems.Add(dataDespesa.ToString("dd/MM/yyyy"));
                    lista_despesas.Items.Add(item);
                }
                leitorDespesas.Close();
                lbl_total.Text = "Total de Despesas: R$ " + total_despesas.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar despesas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
