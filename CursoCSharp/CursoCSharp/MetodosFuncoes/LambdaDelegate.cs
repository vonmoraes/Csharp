using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosFuncoes {

    delegate double Operacao(double x, double y);

    class LambdaDelegate {

        // delegate define o tipo que armazena a assinatura de uma função
        public static void Executar() {
            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;
            Operacao divisao = (x, y) => x / y;

            List<Operacao> operacoes = new List<Operacao> { soma, subtracao, multiplicacao, divisao }; 
            
            foreach(var operacao in operacoes) {
                Console.WriteLine(operacao(1,1));
            }

        }
    }
}
