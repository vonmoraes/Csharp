using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;



namespace Encapsulamento {
    public class AmigoProximo {

        public readonly SubCelebridade amigo = new SubCelebridade();



        public new void meus_acessos() {
            Console.WriteLine("Amigo Proximo");
            Console.WriteLine(amigo.info_publica);
            //Console.WriteLine(amigo.cor_olhos);
            Console.WriteLine(amigo.celular);
            Console.WriteLine(amigo.jeito_de_falar);
            //Console.WriteLine(amigo.segredos);
            //Console.WriteLine(amigo.verdadeiro);
        }
    }
}
