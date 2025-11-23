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
    public partial class EditarDespesa : Form
    {
        public EditarDespesa()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditarDespesa_Load(object sender, EventArgs e)
        {
            picker_data.Value = DateTime.Now;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
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
            DialogResult confirmacao = MessageBox.Show("Tem certeza de que quer editar a despesa " + nome_antigo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.No || confirmacao == DialogResult.Cancel)
            {
                return;
            }
            if (txt_cod.Text == "")
            {
                MessageBox.Show("Por favor, insira o código da despesa que deseja editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int codigo;
            string nome = "default";
            decimal valor = 0;
            DateTime data = DateTime.Now.Date;
            string procurarDespesa = "SELECT data, nome, valor FROM despesas WHERE id = @id";
            MySqlCommand comandoProcurar = new MySqlCommand(procurarDespesa, Program.conexao);
            comandoProcurar.Parameters.AddWithValue("@id", txt_cod.Text);
            MySqlDataReader leitorDespesa = comandoProcurar.ExecuteReader();
            if (!leitorDespesa.HasRows)
            {
                MessageBox.Show("Nenhuma despesa encontrada com o código fornecido. Verifique o código e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                leitorDespesa.Close();
                return;
            } else
            {
                while (leitorDespesa.Read())
                {
                    data = leitorDespesa.GetDateTime(0);
                    nome = leitorDespesa.GetString(1);
                    valor = leitorDespesa.GetDecimal(2);
                }
                leitorDespesa.Close();
            }
                try
                {
                    codigo = int.Parse(txt_cod.Text);
                }
                catch
                {
                    MessageBox.Show("Código inválido! Tente novamente com um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            if (txt_nome.Text.Trim() != "")
            {
                nome = txt_nome.Text.Trim();
            }
            if (txt_valor.Text.Trim() != "")
            {
                try
                {
                    valor = decimal.Parse(txt_valor.Text);
                }
                catch
                {
                    MessageBox.Show("Valor inválido! Tente novamente com um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            if (check_inalterar_data.Checked == false)
            {
                data = picker_data.Value;
            }
            string editarDespesa = "UPDATE despesas SET data = @data, nome = @nome, valor = @valor, emissor = @emissor WHERE id = @id";
            MySqlCommand comandoEditar = new MySqlCommand(editarDespesa, Program.conexao);
            comandoEditar.Parameters.AddWithValue("@id", codigo);
            comandoEditar.Parameters.AddWithValue("@data", data.Date);
            comandoEditar.Parameters.AddWithValue("@nome", nome);
            comandoEditar.Parameters.AddWithValue("@valor", valor);
            comandoEditar.Parameters.AddWithValue("@emissor", Program.conta_ativa);
            try
            {
                int linhasAfetadas = comandoEditar.ExecuteNonQuery();
                if (linhasAfetadas == 0)
                {
                    MessageBox.Show("Nenhuma despesa encontrada com o código fornecido. Verifique o código e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Despesa editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar a despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void check_inalterar_data_CheckedChanged(object sender, EventArgs e)
        {
            if (picker_data.Enabled == true)
            {
                picker_data.Enabled = false;
            }
            else
            {
                picker_data.Enabled = true;
            }
        }
    }
}
