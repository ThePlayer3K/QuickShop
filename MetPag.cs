using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShop
{
    internal class MetPag
    {
        int id;
        string nome;
        decimal taxa;

        public MetPag(int id, string nome, decimal taxa)
        {
            this.id = id;
            this.nome = nome;
            this.taxa = taxa;
        }

        public MetPag(string nome, decimal taxa)
        {
            this.nome = nome;
            this.taxa = taxa;
        }

        public string getNome()
        {
            return nome;
        }

        public decimal getTaxa()
        {
            return taxa;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
            string alterarNome = "UPDATE metodo_pag SET nome = @nome WHERE id = @id";
            MySqlCommand comandoNome = new MySqlCommand(alterarNome, Program.conexao);
            comandoNome.Parameters.AddWithValue("@nome", nome);
            comandoNome.Parameters.AddWithValue("@id", this.id);
            comandoNome.ExecuteNonQuery();
        }

        public void setTaxa(decimal taxa)
        {
            this.taxa = taxa;
            string alterarTaxa = "UPDATE metodo_pag SET taxa = @taxa WHERE id = @id";
            MySqlCommand comandoTaxa = new MySqlCommand(alterarTaxa, Program.conexao);
            comandoTaxa.Parameters.AddWithValue("@taxa", taxa);
            comandoTaxa.Parameters.AddWithValue("@id", this.id);
            comandoTaxa.ExecuteNonQuery();
        }

        public void adicionarMetodo(string nome, decimal taxa)
        {
            string adicionarProduto = "INSERT INTO metodo_pag (nome, taxa, ativo) VALUES (@nome, @taxa, true)";
            MySqlCommand comandoAdicionar = new MySqlCommand(adicionarProduto, Program.conexao);
            comandoAdicionar.Parameters.AddWithValue("@nome", nome);
            comandoAdicionar.Parameters.AddWithValue("@taxa", taxa);
            comandoAdicionar.ExecuteNonQuery();
            string lerId = "SELECT id FROM metodo_pag WHERE nome = @nome AND taxa = @taxa";
            MySqlCommand comandoLerId = new MySqlCommand(lerId, Program.conexao);
            comandoLerId.Parameters.AddWithValue("@nome", nome);
            comandoLerId.Parameters.AddWithValue("@taxa", taxa);
            MySqlDataReader leitorId = comandoLerId.ExecuteReader();
            while (leitorId.Read())
            {
                this.id = leitorId.GetInt32("id");
            }
        }

        public void removerBanco()
        {
            string comandoRemover = "UPDATE metodo_pag SET ativo = false WHERE id = @id";
            MySqlCommand comandoDelete = new MySqlCommand(comandoRemover, Program.conexao);
            comandoDelete.Parameters.AddWithValue("@id", this.id);
            comandoDelete.ExecuteNonQuery();
        }
    }
}
