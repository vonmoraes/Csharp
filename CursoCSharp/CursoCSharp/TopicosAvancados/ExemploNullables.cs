using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class ExemploNullables {
        public static void Executar() {
            Nullable<int> num_1 = null; // criando
            int? num_2 = null; // criando


            if (num_1.HasValue) {
                Console.WriteLine("Tem valor");
            } else {
                Console.WriteLine("Não tem valor");
            }

            int teste = num_1 ?? 0; // teste e num_1 caso num_1 nao seja nulo  
        }
    }
}
