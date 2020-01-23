using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosFuncoes {
    public static class ExtensoesInteiro {
        public static int Soma(this int a, int b) {
            return a + b;
        }

        public static int Subtracao(this int a, int b) {
            return a - b;
        }
    }


    class MetodoExtensao {
        public static void Executar() {
            int numero = 3;
            Console.WriteLine(numero.Soma(1));
            Console.WriteLine(numero.Subtracao(1));
        }
    }
}
