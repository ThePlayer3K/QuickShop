using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShop
{
    internal class ProdutoVenda
    {
        private int id, quantidade;
        private string nome;
        private decimal preco;
        public ProdutoVenda(int codigo, int quantia, string n, decimal vl_un)
        {
            this.id = codigo;
            this.quantidade = quantia;
            this.nome = n;
            this.preco = vl_un;
        }

        public int getId()
        {
            return this.id;
        }

        public int getQuantidade()
        {
            return this.quantidade;
        }

        public string getNome()
        {
            return this.nome;
        }

        public decimal getPreco()
        {
            return this.preco;
        }

        public void setQuantidade(int quantia)
        {
            this.quantidade = quantia;
        }
    }
}
