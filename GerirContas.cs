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
    public partial class GerirContas : Form
    {
        public GerirContas()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GerirContas_Load(object sender, EventArgs e)
        {
            foreach (Conta c in Program.contas)
            {
                lista_contas.Items.Add(c.getUsuario());
            }
        }

        private void btn_resetar_palavras_Click(object sender, EventArgs e)
        {
            if (lista_contas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma conta para resetar as palavras de recuperação.", "Nenhuma conta selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nome_conta_selecionada = lista_contas.SelectedItem.ToString();
                Conta conta_selecionada = Program.contas.Find(c => c.getUsuario() == nome_conta_selecionada);
                ResetarPalavras resetarPalavras = new ResetarPalavras(conta_selecionada);
                resetarPalavras.ShowDialog();
            }
        }

        private void btn_resetar_senha_Click(object sender, EventArgs e)
        {
            string nome_conta_selecionada = lista_contas.SelectedItem.ToString();
            Conta conta_selecionada = Program.contas.Find(c => c.getUsuario() == nome_conta_selecionada);
            ResetarSenha resetarSenha = new ResetarSenha(conta_selecionada);
            resetarSenha.ShowDialog();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            CriarConta criarConta = new CriarConta();
            criarConta.Show();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string nome_conta_selecionada = lista_contas.SelectedItem.ToString();
            DialogResult confirmacao = MessageBox.Show("Tem certeza de que quer excluir a conta " + nome_conta_selecionada + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                Conta conta_selecionada = Program.contas.Find(c => c.getUsuario() == nome_conta_selecionada);
                if (conta_selecionada.getTipo() == 'G')
                {
                    MessageBox.Show("A conta gerente não pode ser removida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string desativarConta = "UPDATE usuarios SET ativo = false WHERE id = @id";
                MySqlCommand comandoDesativar = new MySqlCommand(desativarConta, Program.conexao);
                comandoDesativar.Parameters.AddWithValue("@id", conta_selecionada.getId());
                comandoDesativar.ExecuteNonQuery();
                Program.contas.Remove(conta_selecionada);
                MessageBox.Show("Conta removida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }

        }
    }
}
