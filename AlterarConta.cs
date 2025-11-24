using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace QuickShop
{
    public partial class AlterarConta : Form
    {
        MainGerente mainGerente;
        MainVendedor mainVendedor;
        public AlterarConta(MainGerente mainGerente)
        {
            this.mainGerente = mainGerente;
            InitializeComponent();
        }

        public AlterarConta(MainVendedor mainVendedor)
        {
            this.mainVendedor = mainVendedor;
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AlterarConta_Load(object sender, EventArgs e)
        {
            txt_nome.Text = Program.contas.FirstOrDefault(c => c.getId() == Program.conta_ativa).getUsuario();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string nome, p1, p2, p3;
            string nova_senha = "";
            Conta conta_atual = Program.contas.FirstOrDefault(c => c.getId() == Program.conta_ativa);
            foreach (Conta c in Program.contas)
            {
                if (c.getUsuario() == txt_nome.Text && c.getId() != Program.conta_ativa)
                {
                    MessageBox.Show("Já existe uma conta com esse nome de usuário. Escolha outro nome.", "Erro ao alterar conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txt_nome.Text.Trim() != "")
            {
                nome = txt_nome.Text.Trim();
            } else
            {
                nome = conta_atual.getUsuario();
            }
            if (txt_rec1.Text != "")
            {
                p1 = BCrypt.Net.BCrypt.HashPassword(txt_rec1.Text, workFactor: 12);
            } else
            {
               p1 = conta_atual.getP1Hash();
            }
            if (txt_rec2.Text != "")
            {
                p2 = BCrypt.Net.BCrypt.HashPassword(txt_rec2.Text, workFactor: 12);
            } else
            {
                p2 = conta_atual.getP2Hash();
            }
            if (txt_rec3.Text != "")
            {
                p3 = BCrypt.Net.BCrypt.HashPassword(txt_rec3.Text, workFactor: 12);
            } else
            {
                p3 = conta_atual.getP3Hash();
            }
            if (BCrypt.Net.BCrypt.Verify(txt_senha_atual.Text, conta_atual.getSenhaHash()) == false)
            {
                MessageBox.Show("A senha atual está incorreta.", "Erro ao alterar conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_nova_senha.Text != null && txt_confirmar == null || txt_nova_senha.Text == null && txt_confirmar != null)
            {
                MessageBox.Show("Para alterar a senha, preencha ambos os campos de nova senha e confirmação.", "Erro ao alterar conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_nova_senha.Text != "" && txt_confirmar.Text != "")
            {
                if (txt_nova_senha.Text != txt_confirmar.Text)
                {
                    MessageBox.Show("A nova senha e a confirmação não coincidem.", "Erro ao alterar conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else
                {
                    nova_senha = BCrypt.Net.BCrypt.HashPassword(txt_nova_senha.Text, workFactor: 12);
                }
            } else
            {
                nova_senha = conta_atual.getSenhaHash();
            }
                string atualizarConta = "UPDATE usuarios SET nome = @nome, senha_hash = @senha_hash, palavra_rec_1_hash = @p1_hash, palavra_rec_2_hash = @p2_hash, palavra_rec_3_hash = @p3_hash WHERE id = @id";
            MySqlCommand comandoAtualizar = new MySqlCommand(atualizarConta, Program.conexao);
            comandoAtualizar.Parameters.AddWithValue("@nome", nome);
            comandoAtualizar.Parameters.AddWithValue("@senha_hash", nova_senha);
            comandoAtualizar.Parameters.AddWithValue("@p1_hash", p1);
            comandoAtualizar.Parameters.AddWithValue("@p2_hash", p2);
            comandoAtualizar.Parameters.AddWithValue("@p3_hash", p3);
            comandoAtualizar.Parameters.AddWithValue("@id", Program.conta_ativa);
            try
            {
                comandoAtualizar.ExecuteNonQuery();
                conta_atual.setUsuario(nome);
                if (conta_atual.getTipo() == 'G')
                {
                    mainGerente.mudarLabel(nome);
                }

                if (conta_atual.getTipo() == 'V')
                {
                    mainVendedor.mudarLabel(nome);
                }
                MessageBox.Show("Conta alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao alterar a conta. Tente novamente.\n\nDetalhes do erro:\n" + ex.Message, "Erro ao alterar conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
