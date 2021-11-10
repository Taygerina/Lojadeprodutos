using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojadeprodutos
{
    class Importado : Produto
    {

        //Variaveis dos produtos importados 
        public double Taxa { get; set; }
        //declarando os construtores
        public Importado() { }
        public Importado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Taxa = taxa;
        }
        //variavel da taxa 
        public override string ToString()
        {
            return Nome + " - " + Preco + " - " + $"(Taxa: {Taxa})";
        }
    }
}

