using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojadeprodutos
{
    abstract class Produto
    {
        //Variaveis dos produtos
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Declarando o construtores
        public Produto() { }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Etiqueta do produto 
        public override string ToString()
        {
            return Nome + " - " + Preco;
        }
    }
}

