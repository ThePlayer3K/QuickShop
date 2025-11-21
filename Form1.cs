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
                string salt = BCrypt.Net.BCrypt.GenerateSalt(12);             
                foreach (Conta login in Program.contas)
                {
                    if (login.getUsuario() == usuario)
                    {
                        if (BCrypt.Net.BCrypt.Verify(txt_senha.Text, login.getSenhaHash()) == true)
                        {
                            if (login.getTipo() == 'G')
                            {
                                this.Hide();
                                Form MainGerente = new MainGerente(usuario);
                                MainGerente.Show();
                            }
                            Program.conta_ativa = login.getId();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
