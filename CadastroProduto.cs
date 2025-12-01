using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickShop
{
    public partial class CadastroProduto : Form
    {

        List<int> ids_Produtos;
        public CadastroProduto()
        {
            InitializeComponent();
            string listaIds = "SELECT id FROM produtos";
            MySqlCommand comandoIds = new MySqlCommand(listaIds, Program.conexao);
            MySqlDataReader lerIds = comandoIds.ExecuteReader();
            ids_Produtos = new List<int>();
            while (lerIds.Read())
            {
                ids_Produtos.Add(lerIds.GetInt32(0));
            }
            lerIds.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int validacao = int.Parse(txtCod.Text);
            }
            catch
            {
                MessageBox.Show("ID inválido! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int validacao = int.Parse(txtQtd.Text);
            }
            catch
            {
                MessageBox.Show("Quantidade em estoque inválida! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                decimal validacao = decimal.Parse(txtPreco.Text);
            }
            catch
            {
                MessageBox.Show("Preço inválido! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCod.Text == "" || txtNome.Text == "" || txtPreco.Text == "" || txtQtd.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtQtd.Text) < 0)
                {
                    MessageBox.Show("A quantidade em estoque não pode ser negativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    foreach (int id in ids_Produtos)
                    {

                        if (txtCod.Text == id.ToString())
                        {
                            string ativo = "SELECT ativo FROM produtos WHERE id = @id";
                            MySqlCommand buscarStatus = new MySqlCommand(ativo, Program.conexao);
                            buscarStatus.Parameters.AddWithValue("@id", id);
                            bool status = (bool)buscarStatus.ExecuteScalar();
                            if (status)
                            {
                                throw new Exception("Um produto com esse id já existe! Tente novamente com outro id.");
                            }
                            else
                            {
                                throw new Exception("Um produto anteriormente deletado portava esse id. Será necessário selecionar outro id para este novo produto.");
                            }
                        }

                    }
                    Produto novoProduto = new Produto(int.Parse(txtCod.Text), txtNome.Text, decimal.Parse(txtPreco.Text), int.Parse(txtQtd.Text));
                    Program.produtos.Add(novoProduto);
                    novoProduto.adicionarProduto();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
