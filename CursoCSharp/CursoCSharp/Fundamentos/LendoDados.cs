using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual o seu nome?");
            String nome = Console.ReadLine();

            Console.WriteLine("{0} qual a sua idade?", nome);

            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Olá {nome} de {idade} anos! ;)");

            // tem que usar culture invariant quando pegar os dados com " , "
        }
    }
}
