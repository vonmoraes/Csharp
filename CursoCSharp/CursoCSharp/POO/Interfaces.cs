using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO {

    interface OpBinaria {
        int Operacao(int a, int b);
    }


    class Soma : OpBinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }


    class Multiplicacao : OpBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }


    class Subtracao : OpBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }


    class Divisao : OpBinaria {
        public int Operacao(int a, int b) {
            return a / b; 
        }
    }


    class Calculadora {
        List<OpBinaria> operacoes = new List<OpBinaria> {
            new Soma(), new Subtracao(), new Multiplicacao(), new Divisao()
        }; 

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";
            foreach(var operacao in operacoes) {
                resultado += $"A {operacao.GetType().Name} de {a} com {b} tem como resultado {operacao.Operacao(a,b)} \n";
            }
            return resultado;
        }
    }


    class Interfaces {
        public static void Executar() {
            var cal = new Calculadora();
            Console.WriteLine(cal.ExecutarOperacoes(1,2));
        }
    }
}
