using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var caneta1 = new Produto("azul", 1.99);
            var caneta2 = new Produto("azul", 1.99);

            Console.WriteLine(caneta1 == caneta2);

            Console.WriteLine(caneta1.Equals(caneta2));

        }
    }
}
