using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        // imprimir variavel dentro de executar sem mexer na variavel a
        int variavel = 10;

        public static void Executar() {

            DesafioAtributo resposta = new DesafioAtributo();
            Console.WriteLine(resposta.variavel); // desta forma consigo acesso a variavel
        }
    }
}
