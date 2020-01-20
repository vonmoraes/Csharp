using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            // igual java
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "lucas";
        }
    }
}
