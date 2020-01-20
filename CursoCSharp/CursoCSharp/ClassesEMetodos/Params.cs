using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Params {

        public static void Recepcionar(params string[] pessoas) { // lista de parametros
            foreach(var pessoa in pessoas) {
                Console.WriteLine("olá {0}", pessoa);
            }

        }




        public static void Executar() {
            Recepcionar("Lucas", "Luana", "Ana"); 
        }


    }
}
