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
    public partial class CadastrarDespesa : Form
    {
        public CadastrarDespesa()
        {
            InitializeComponent();
        }

        public CadastrarDespesa(string nome, string valor, DateTime data)
        {
            InitializeComponent();
            txt_nome.Text = nome;
            txt_valor.Text = valor;
            picker_data.Value = data;

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nome;
            decimal valor;
            DateTime data;
            try
            {
                codigo = int.Parse(txt_cod.Text);
            } catch
            {
                MessageBox.Show("Código inválido! Tente novamente com um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nome = txt_nome.Text;
            try
            {
                valor = decimal.Parse(txt_valor.Text);
            } catch
            {
                MessageBox.Show("Valor inválido! Tente novamente com um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            data = picker_data.Value;
            string adicionarDespesa = "INSERT INTO despesas (id, data, nome, valor, emissor) VALUES (@id, @data, @nome, @valor, @emissor)";
            MySqlCommand comandoAdicionar = new MySqlCommand(adicionarDespesa, Program.conexao);
            comandoAdicionar.Parameters.AddWithValue("@id", codigo);
            comandoAdicionar.Parameters.AddWithValue("@data", data.Date);
            comandoAdicionar.Parameters.AddWithValue("@nome", nome);
            comandoAdicionar.Parameters.AddWithValue("@valor", valor);
            comandoAdicionar.Parameters.AddWithValue("@emissor", Program.conta_ativa);
            try
            {
                comandoAdicionar.ExecuteNonQuery();
                MessageBox.Show("Despesa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            } catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Já existe uma despesa cadastrada com esse código! Tente novamente com outro código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar a despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CadastrarDespesa_Load(object sender, EventArgs e)
        {
            picker_data.Value = DateTime.Now;
        }
    }
}
