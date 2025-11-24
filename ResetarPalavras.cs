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
    public partial class ResetarPalavras : Form
    {
        Conta conta;
        public ResetarPalavras(Conta conta)
        {
            InitializeComponent();
            this.conta = conta;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja resetar as palavras de recuperação desta conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                string nova_p1 = BCrypt.Net.BCrypt.HashPassword(txt_p1.Text, workFactor: 12);
                string nova_p2 = BCrypt.Net.BCrypt.HashPassword(txt_p2.Text, workFactor: 12);
                string nova_p3 = BCrypt.Net.BCrypt.HashPassword(txt_p3.Text, workFactor: 12);
                string atualizarPalavras = "UPDATE contas SET Palavra_Rec_1_Hash = @p1, Palavra_Rec_2_Hash = @p2, Palavra_Rec_3_Hash = @p3 WHERE Id = @id";
                MySqlCommand comandoAtualizar = new MySqlCommand(atualizarPalavras, Program.conexao);
                comandoAtualizar.Parameters.AddWithValue("@p1", nova_p1);
                comandoAtualizar.Parameters.AddWithValue("@p2", nova_p2);
                comandoAtualizar.Parameters.AddWithValue("@p3", nova_p3);
                comandoAtualizar.Parameters.AddWithValue("@id", conta.getId());
                comandoAtualizar.ExecuteNonQuery();
                MessageBox.Show("Palavras de recuperação resetadas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
