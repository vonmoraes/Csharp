using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Vetores {
        public static void Executar () {
            string[] alunos = new string[5];
            alunos[0] = "lucas0";
            alunos[1] = "lucas1";
            alunos[2] = "lucas2";
            alunos[3] = "lucas3";
            alunos[4] = "lucas4";

            foreach( var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double[] notas = { 1.1, 2.2, 3.4, 4.2, 5.0 };

            double soma = 0;
            foreach(var nota in notas) {
                soma += nota;
            }
            double media = soma / notas.Length;

            Console.WriteLine("A média é {0}", media);


        }
    }
}
