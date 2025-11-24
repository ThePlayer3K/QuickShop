using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuickShop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == ""|| txt_senha.Text == "")
            {
                MessageBox.Show("O usuário e/ou a senha não foram preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string usuario = txt_usuario.Text;
                bool encontrado = false;
                bool correto = false;
                foreach (Conta login in Program.contas)
                {
                    if (login.getUsuario() == usuario)
                    {
                        encontrado = true;
                        if (BCrypt.Net.BCrypt.Verify(txt_senha.Text, login.getSenhaHash()) == true)
                        {
                            correto = true;
                            if (login.getTipo() == 'G')
                            {
                                this.Hide();
                                Form MainGerente = new MainGerente(usuario);
                                MainGerente.Show();
                            }
                            if (login.getTipo() == 'V')
                            {
                                this.Hide();
                                Form MainVendedor = new MainVendedor(usuario);
                                MainVendedor.Show();
                            }
                            Program.conta_ativa = login.getId();
                        }
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("Usuário não encontrado. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (encontrado == true && correto == false)
                {
                    MessageBox.Show("Usuário e/ou senha incorretos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_esqueci_Click(object sender, EventArgs e)
        {
            EsqueciSenha esqueciSenha = new EsqueciSenha(this);
            esqueciSenha.Show();
        }
    }
}
