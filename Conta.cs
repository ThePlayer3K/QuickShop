using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShop
{
    public class Conta
    {
        private int id;
        private string nome, senha_hash, p1_hash, p2_hash, p3_hash;
        private char tipo;

        public Conta(int id, string nome, string senha_hash, string p1_hash, string p2_hash, string p3_hash, char tipo)
        {
            this.id = id;
            this.nome = nome;
            this.senha_hash = senha_hash;
            this.p1_hash = p1_hash;
            this.p2_hash = p2_hash;
            this.p3_hash = p3_hash;
            this.tipo = tipo;
        }

        public int getId()
        {
            return id;
        }

        public string getUsuario()
        {
            return nome;
        }

        public string getSenhaHash()
        {
            return senha_hash;
        }

        public string getP1Hash()
        {
            return p1_hash;
        }

        public string getP2Hash()
        {
            return p2_hash;
        }

        public string getP3Hash()
        {
            return p3_hash;
        }

        public char getTipo()
        {
            return tipo;
        }

        public void setUsuario(string nome)
        {
            this.nome = nome;
        }
    }
}
