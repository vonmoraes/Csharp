using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; // relativo a cultura 





namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.3666666666;

            Console.WriteLine(valor.ToString("F1")); // casas decimais
            Console.WriteLine(valor.ToString("#.##")); // casas decimais
            Console.WriteLine(valor.ToString("P")); // percentual
            Console.WriteLine(valor.ToString("C")); // moeda


            int valorint = 2;
            Console.WriteLine(valorint.ToString("D10")); // imprime numero sempre com 10 casas decimais

            CultureInfo cultura_brasileira = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C", cultura_brasileira)); // moeda real




        }
    }
}
