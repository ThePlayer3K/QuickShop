using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShop
{
    internal class Produto
    {
        private int id;
        private string nome;
        private decimal preco;
        private int qtd_estoque;

        public Produto(int id, string nome, decimal preco, int quantidade_estoque)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.qtd_estoque = quantidade_estoque;
        }
        public int getId()
        {
            return id;
        }
        public string getNome()
        {
            return nome;
        }
        public decimal getPreco()
        {
            return preco;
        }
        public int getQtdEstoque()
        {
            return qtd_estoque;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
            string comandoAlterarNome = "UPDATE produtos SET nome = @nome WHERE id = @id";
            MySqlCommand comandoNome = new MySqlCommand(comandoAlterarNome, Program.conexao);
            comandoNome.Parameters.AddWithValue("@nome", nome);
            comandoNome.Parameters.AddWithValue("@id", this.id);
            comandoNome.ExecuteNonQuery();
        }

        public void setPreco(decimal preco)
        {
            this.preco = preco;
            string comandoAlterarPreco = "UPDATE produtos SET preco = @preco WHERE id = @id";
            MySqlCommand comandoPreco = new MySqlCommand(comandoAlterarPreco, Program.conexao);
            comandoPreco.Parameters.AddWithValue("@preco", preco);
            comandoPreco.Parameters.AddWithValue("@id", this.id);
            comandoPreco.ExecuteNonQuery();
        }

        public void setQtdEstoque(int qtd_estoque)
        {
            this.qtd_estoque = qtd_estoque;
            string comandoAlterarQtd = "UPDATE produtos SET quantidade_estoque = @qtd_estoque WHERE id = @id";
            MySqlCommand comandoQtd = new MySqlCommand(comandoAlterarQtd, Program.conexao);
            comandoQtd.Parameters.AddWithValue("@qtd_estoque", qtd_estoque);
            comandoQtd.Parameters.AddWithValue("@id", this.id);
            comandoQtd.ExecuteNonQuery();
        }

        public void RemoverBanco()
        {
            string comandoRemover = "UPDATE produtos SET ativo = false WHERE id = @id";
            MySqlCommand comandoDelete = new MySqlCommand(comandoRemover, Program.conexao);
            comandoDelete.Parameters.AddWithValue("@id", this.id);
            comandoDelete.ExecuteNonQuery();
        }

        public void adicionarProduto()
        {
            string adicionarProduto = "INSERT INTO produtos (id, nome, preco, quantidade_estoque, ativo) VALUES (@id, @nome, @preco, @qtd_estoque, true)";
            MySqlCommand comandoAdicionar = new MySqlCommand(adicionarProduto, Program.conexao);
            comandoAdicionar.Parameters.AddWithValue("@id", id);
            comandoAdicionar.Parameters.AddWithValue("@nome", nome);
            comandoAdicionar.Parameters.AddWithValue("@preco", preco);
            comandoAdicionar.Parameters.AddWithValue("@qtd_estoque", qtd_estoque);
            comandoAdicionar.ExecuteNonQuery();
        }
    }
}
