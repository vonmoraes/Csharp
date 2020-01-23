using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {

        public static void AlterarRef(ref int num) { // necessário inicializar variavel antes de mandar
            num += 1000;
        }

        public static void AlterarOut(out int num) { // necessario variavel existir antes de mandar
            num = 0;
            num += 15;
        }



        public static void Executar() {
            int a = 11;
            Console.WriteLine("valor original {0}", a);
            AlterarRef(ref a);
            Console.WriteLine("valor passado por ref {0}", a);
            Console.WriteLine("valor passado por out {0}", a);

            int b = 15;
            Console.WriteLine("valor original {0}", b);
            AlterarOut(out b);
            Console.WriteLine("valor passado por ref {0}", b);
            Console.WriteLine("valor passado por out {0}", b);


        }
    }
}
