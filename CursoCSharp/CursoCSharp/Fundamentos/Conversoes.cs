using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;

            double nota = 9.8;
            int nota_truncada = (int) nota;

            nota_truncada = Convert.ToInt32(quebrado);


            String palavra = "1";
            int.TryParse(palavra, out int numero); // tenta converter para inteiro
        }
    }
}
