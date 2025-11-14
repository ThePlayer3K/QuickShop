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
                foreach (int id in ids_Produtos)
                {
                    if (txtCod.Text == id.ToString())
                    {
                        MessageBox.Show("Já existe um produto cadastrado (ou que foi removido anteriormente) com esse código!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Produto novoProduto = new Produto(int.Parse(txtCod.Text), txtNome.Text, decimal.Parse(txtPreco.Text), int.Parse(txtQtd.Text));
                Program.produtos.Add(novoProduto);
                Program.produtos_historicos.Add(novoProduto);
                novoProduto.adicionarProduto(); 
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
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
