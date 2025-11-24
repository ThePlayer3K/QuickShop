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
    public partial class ResetarSenha : Form
    {
        Conta conta;
        public ResetarSenha(Conta conta)
        {
            InitializeComponent();
            this.conta = conta;
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            if (txt_nova.Text != txt_confirmar.Text)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja resetar a senha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    string nova_senha = BCrypt.Net.BCrypt.HashPassword(txt_nova.Text, workFactor: 12);
                    string mudarSenha = "UPDATE contas SET senha_hash = @senha_hash WHERE id = @id";
                    MySqlCommand comandoMudar = new MySqlCommand(mudarSenha, Program.conexao);
                    comandoMudar.Parameters.AddWithValue("@senha_hash", nova_senha);
                    comandoMudar.Parameters.AddWithValue("@id", conta.getId());
                    comandoMudar.ExecuteNonQuery();
                    MessageBox.Show("Senha alterada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
