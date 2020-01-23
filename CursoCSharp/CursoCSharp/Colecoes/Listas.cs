using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto {
        string nome;
        double preco;

        public Produto(string nome, double preco) {
            this.nome = nome;
            this.preco = preco;
        }

        public override bool Equals(object obj) {
            Produto outro_produto = (Produto)obj;
            bool mesmo_nome = this.nome == outro_produto.nome;
            bool mesmo_preco = this.preco == outro_produto.preco;
            return mesmo_nome && mesmo_preco;
        }

    }


    class Listas {
        public static void Executar() {
            var livro = new Produto("livro", 10.99);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto>() {
                new Produto("filme", 7.99),
                new Produto("pipoca", 299.44)
            };

            carrinho.AddRange(combo); // metodo que add uma lista em outra lista 

            Console.WriteLine("Carrinho tem {0} itens", carrinho.Count);

            carrinho.RemoveAt(2); // remove elemento do carrinho 
        }

    }
}
