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
    public partial class EsqueciSenha : Form
    {
        login login;
        public EsqueciSenha(login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_rec1.Text == "" || txt_rec2.Text == "" || txt_rec3.Text == "")
            {
                MessageBox.Show("Todos os dados devem estar preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_nova.Text != txt_confirmar.Text)
            {
                MessageBox.Show("As senhas não correspondem. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool encontrado = false;
            foreach (Conta c in Program.contas)
            {
                if (txt_nome.Text == c.getUsuario())
                {
                    encontrado = true;
                    if (BCrypt.Net.BCrypt.Verify(txt_rec1.Text, c.getP1Hash()) == true && BCrypt.Net.BCrypt.Verify(txt_rec2.Text, c.getP2Hash()) == true && BCrypt.Net.BCrypt.Verify(txt_rec3.Text, c.getP3Hash()) == true)
                    {
                        string novaSenha = BCrypt.Net.BCrypt.HashPassword(txt_nova.Text, workFactor: 12);
                        string mudarSenha = "UPDATE usuarios SET senha_hash = @senha_hash WHERE id = @id";
                        MySqlCommand comandoMudar = new MySqlCommand(mudarSenha, Program.conexao);
                        comandoMudar.Parameters.AddWithValue("@senha_hash", novaSenha);
                        comandoMudar.Parameters.AddWithValue("@id", c.getId());
                        comandoMudar.ExecuteNonQuery();
                        MessageBox.Show("Senha alterada com suecesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login.Hide();
                        Program.conta_ativa = c.getId();
                        if (c.getTipo() == 'G')
                        {
                            MainGerente mainGerente = new MainGerente(c.getUsuario());
                            mainGerente.Show();
                        }
                        if (c.getTipo() == 'V')
                        {
                            MainVendedor mainVendedor = new MainVendedor(c.getUsuario());
                            mainVendedor.Show();
                        }
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Palavras erradas! Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Conta não encontrada! Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
