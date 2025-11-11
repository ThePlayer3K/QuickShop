using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickShop
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        public static List<Conta> contas;
        public static List<Produto> produtos;
        public static MySqlConnection conexao;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            contas = new List<Conta>();
            produtos = new List<Produto>();
            string stringConexao;
            try
            {
                stringConexao = @"server=127.0.0.1;port=3306;uid=root;pwd=ifsp;database=quickshop;ConnectionTimeout=2";
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados. Verifique se o servidor está ativo e tente novamente.\n\nDetalhes do erro:\n" + e.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            string localizarContas;
            try
            {
                localizarContas = "SELECT ID, Nome, Senha_Hash, Palavra_Rec_1_Hash, Palavra_Rec_2_Hash, Palavra_Rec_3_Hash, Tipo_Conta FROM usuarios";
                MySqlCommand comandoConta = new MySqlCommand(localizarContas, conexao);
                MySqlDataReader lerContas = comandoConta.ExecuteReader();
                while (lerContas.Read())
                {
                    int id = lerContas.GetInt32(0);
                    string nome = lerContas.GetString(1);
                    string senha_hash = lerContas.GetString(2);
                    string p1_hash = lerContas.GetString(3);
                    string p2_hash = lerContas.GetString(4);
                    string p3_hash = lerContas.GetString(5);
                    char tipo = lerContas.GetChar(6);
                    Conta conta = new Conta(id, nome, senha_hash, p1_hash, p2_hash, p3_hash, tipo);
                    contas.Add(conta);
                }
                lerContas.Close();

            } catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar as contas do banco de dados.\n\nDetalhes do erro:\n" + e.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            string localizarProdutos;
            try
            {
                localizarProdutos = "SELECT id, nome, preco, quantidade_estoque FROM produtos WHERE ativo = true;";
                MySqlCommand comandoProduto = new MySqlCommand(localizarProdutos, conexao);
                MySqlDataReader lerProdutos = comandoProduto.ExecuteReader();
                while (lerProdutos.Read())
                {
                    int id = lerProdutos.GetInt32(0);
                    string nome = lerProdutos.GetString(1);
                    decimal preco = lerProdutos.GetDecimal(2);
                    int qtd_estoque = lerProdutos.GetInt32(3);
                    Produto produto = new Produto(id, nome, preco, qtd_estoque);
                    produtos.Add(produto);
                }
                lerProdutos.Close();
            } catch
            {
                MessageBox.Show("Não foi possível carregar os produtos do banco de dados.\n\nDetalhes do erro:\n", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
                Application.Run(new login());

        }
    }
}
