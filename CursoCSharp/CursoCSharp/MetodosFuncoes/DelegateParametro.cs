using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosFuncoes {
    class DelegateParametro {

        public delegate int Operacao(int a, int b);

        public static int soma(int a, int b) {
            return a + b;
        }

        public static string calculadora(Operacao op, int a, int b) {
            var resultado = op(a, b);
            return "resultado = " + resultado;
        }


        public static void Executar() {

            Operacao subtracao = (a, b) => a - b;

            Console.WriteLine(calculadora(soma,1,2));
            Console.WriteLine(calculadora(subtracao,1,2));
        }
    }
}
