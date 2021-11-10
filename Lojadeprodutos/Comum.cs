using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojadeprodutos
{
    class Comum : Produto
    {
        //declrando os construtores
        public Comum() { }
        public Comum(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        //produtos comuns
        public override string ToString()
        {
            return Nome + " - " + Preco;
        }
    }
}
