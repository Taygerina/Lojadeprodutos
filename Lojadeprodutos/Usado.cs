using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojadeprodutos
{
    class Usado : Produto
    {
        //Variavel dos produtos usados
        public DateTime Fabricacao { get; set; }

        //declarando os construtores
        public Usado() { }
        public Usado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Fabricacao = fabricacao;
        }
        //variavel da fabricacao
        public override string ToString()
        {
            return Nome + " - " + Preco + " - " + $"(fabricado: {Fabricacao.ToString("dd/MM/yyyy")})";
        }

    }
}

