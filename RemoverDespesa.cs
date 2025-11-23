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
    public partial class RemoverDespesa : Form
    {
        public RemoverDespesa()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text.Trim() == "")
            {
                MessageBox.Show("Insira o código da despesa a ser removida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int codigo;
            try
            {
                codigo = int.Parse(txt_cod.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Código inválido. Insira um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nome_antigo;
            string nomearDespesa = "SELECT nome FROM despesas WHERE id = @id";
            MySqlCommand comandoNomear = new MySqlCommand(nomearDespesa, Program.conexao);
            comandoNomear.Parameters.AddWithValue("@id", txt_cod.Text);
            nome_antigo = (string)comandoNomear.ExecuteScalar();
            if (nome_antigo == null)
            {
                MessageBox.Show("Nenhuma despesa foi encontrada com este ID! Tente novamente");
                return;
            }
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir a despesa " + nome_antigo + "? Esta ação é irreversível.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                string queryDeletar = "DELETE FROM despesas WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(queryDeletar, Program.conexao);
                comando.Parameters.AddWithValue("@id", codigo);
                try
                {
                    int linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Despesa removida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma despesa encontrada com o código fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao remover despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }
}
