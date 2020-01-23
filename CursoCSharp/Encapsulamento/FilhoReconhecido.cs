using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade {
        public new void meus_acessos() {
            Console.WriteLine("Filho reconhecido");
            Console.WriteLine(info_publica);
            Console.WriteLine(cor_olhos);
            Console.WriteLine(celular);
            Console.WriteLine(jeito_de_falar);
            Console.WriteLine(segredos);
            //Console.WriteLine(verdadeiro);
        }
    }
}
