using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO {
    class ConstrutorThis {

        class Animal {
            public string nome { get; set; }

            public Animal(string nome) {
                this.nome = nome;
            }
        }

        class Cachorro : Animal {
            public double altura { get; set; }

            public Cachorro(string nome) : base(nome) {
            }

            public Cachorro(string nome, double altura) : this(nome) {
                this.altura = altura;
            }

            public override string ToString() {
                return $"Cachorro de nome {nome} tem alura {altura}";
            }
        }

        public static void Executar() {
            Cachorro nick = new Cachorro("nick", 0.48);
            Console.WriteLine(nick.ToString());
            Animal luana = new Cachorro("luana", 0.12);
            Console.WriteLine(luana);
        }
    }
}
