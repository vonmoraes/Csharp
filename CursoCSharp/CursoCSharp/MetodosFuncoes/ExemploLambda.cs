using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosFuncoes {
    class ExemploLambda {
        public static void Executar() {

            Action algoConsole = () => {
                Console.WriteLine("Algo C#");
            };

            Func<int> jogarDado = () => {
                Random dado = new Random();
                return dado.Next(1, 6);
            };


            Func<int, string> converterHexa = (numero) => numero.ToString("X");

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

            algoConsole();
            Console.WriteLine(jogarDado());
            Console.WriteLine(converterHexa(10));
            Console.WriteLine(converterHexa(7));

            Console.WriteLine(formatarData(6, 1, 1994));
        }

    }
}
