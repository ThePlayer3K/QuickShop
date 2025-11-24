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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string p1 = BCrypt.Net.BCrypt.HashPassword(txt_rec1.Text, workFactor: 12);
            string p2 = BCrypt.Net.BCrypt.HashPassword(txt_rec2.Text, workFactor: 12);
            string p3 = BCrypt.Net.BCrypt.HashPassword(txt_rec3.Text, workFactor: 12);
            if (txt_senha.Text != txt_confirmar.Text)
            {
                MessageBox.Show("As senhas não correspondem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string senha = BCrypt.Net.BCrypt.HashPassword(txt_senha.Text, workFactor: 12);
            string adicionarUsuario = "INSERT INTO usuarios (nome, senha_hash, palavra_rec_1_hash, palavra_rec_2_hash, palavra_rec_3_hash, tipo_conta, ativo) VALUES (@nome, @senha_hash, @p1, @p2, @p3, 'V', true)";
            MySqlCommand comandoAdicionar = new MySqlCommand(adicionarUsuario, Program.conexao);
            comandoAdicionar.Parameters.AddWithValue("@nome", nome);
            comandoAdicionar.Parameters.AddWithValue("@p1", p1);
            comandoAdicionar.Parameters.AddWithValue("@p2", p2);
            comandoAdicionar.Parameters.AddWithValue("@p3", p3);
            comandoAdicionar.Parameters.AddWithValue("@senha_hash", senha);
            comandoAdicionar.ExecuteNonQuery();
            int id_novo = (int)comandoAdicionar.LastInsertedId;
            MessageBox.Show("Vendedor adicionado com sucesso no sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Conta conta = new Conta(id_novo, nome, senha, p1, p2, p3, 'V');
            Program.contas.Add(conta);
            this.Hide();
        }
    }
}
