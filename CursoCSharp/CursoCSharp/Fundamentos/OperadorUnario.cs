using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorUnario {
        public static void Executar() {
            // igual java
            int numero1 = 2;
            int numero2 = 3;

            Console.WriteLine(numero1++ == --numero2); // a++ faz dps --a faz antes por causa da ordem
        }
    }
}
