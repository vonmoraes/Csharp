using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {

        public static void FormatarData(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }



        public static void Executar() {
            FormatarData(mes: 1, ano: 1994, dia: 6);
        }
    }
}
