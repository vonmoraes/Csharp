using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento; 

namespace CursoCSharp.POO {
    class FilhoNãoReconhecido : SubCelebridade {
        public new void meus_acessos() {
            Console.WriteLine("Filho ñ reconhecido");
            Console.WriteLine(info_publica);
            Console.WriteLine(cor_olhos);
            //Console.WriteLine(celular);
            Console.WriteLine(jeito_de_falar);
            //Console.WriteLine(segredos);
            //Console.WriteLine(verdadeiro);
        }
    }

    class AmigoDistante {

        public readonly SubCelebridade amigo = new SubCelebridade();

        public new void meus_acessos() {
            Console.WriteLine("Amigo distante");
            Console.WriteLine(amigo.info_publica);
            //Console.WriteLine(amigo.cor_olhos);
            //Console.WriteLine(amigo.celular);
            //Console.WriteLine(amigo.jeito_de_falar);
            //Console.WriteLine(amigo.segredos);
            //Console.WriteLine(amigo.verdadeiro);
        }
    }

    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.meus_acessos();

            new FilhoReconhecido().meus_acessos();
            new AmigoProximo().meus_acessos();
            new FilhoNãoReconhecido().meus_acessos();
            new AmigoDistante().meus_acessos();
        }
    }
}
