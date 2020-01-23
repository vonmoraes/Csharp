using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO {
    public class Carro {
        protected readonly int velocidade_maxima;
        int velocidade_atual;

        //public Carro() { }

        public Carro(int velocidade_maxima) {
            this.velocidade_maxima = velocidade_maxima;
        }

        protected int alterar_velocidade(int delta) {
            int nova_velocidade = velocidade_atual + delta;
            if (nova_velocidade < 0) {
                nova_velocidade = 0;
            }
            else if (nova_velocidade > velocidade_maxima) {
                nova_velocidade = velocidade_maxima;
            }
            velocidade_atual = nova_velocidade;
            return nova_velocidade;
        }

        public virtual int acelerar() {
            return alterar_velocidade(5);
        }

        public int frear() {
            return alterar_velocidade(-5);
        }
    }

    class Uno : Carro {
        public Uno() : base(200) { // utilizar o construtor do pai dele.

        }
    }

    class Ferrari : Carro {
        public Ferrari() : base(250) { }

        public override int acelerar() { // necessita marcar que o metodo pode ser sobreescrito com virtual
            return alterar_velocidade(12);
        }

        public new int frear() { // tambem é possivel sobreescrever utilizando o new
            return alterar_velocidade(-12);
        }
    }


    class Heranca {
        public static void Executar() {
            Uno carro_1 = new Uno();
            Console.WriteLine("Uno:"); // heranca
            Console.Write(carro_1.acelerar() + " ");
            Console.Write(carro_1.acelerar() + " ");
            Console.Write(carro_1.frear() + " ");
            Console.Write(carro_1.frear() + " ");
            Ferrari carro_2 = new Ferrari();
            Console.WriteLine();
            Console.WriteLine("Ferrari:"); // heranca
            Console.Write(carro_2.acelerar() + " ");
            Console.Write(carro_2.acelerar() + " ");
            Console.Write(carro_2.frear() + " ");
            Console.Write(carro_2.frear() + " ");
            Console.WriteLine();
            Carro carro_3 = new Ferrari(); // polimorfismo
            Console.WriteLine("Ferrari com polimorfismo:"); // heranca
            Console.Write(carro_3.acelerar() + " ");
            Console.Write(carro_3.acelerar() + " ");
            Console.Write(carro_3.frear() + " ");
            Console.Write(carro_3.frear() + " ");
            Console.WriteLine(); // um metodo quando nao e sobrescrito ou seja e feito com new sempre ira pegar as funcoes do pai







        }
    }
}
