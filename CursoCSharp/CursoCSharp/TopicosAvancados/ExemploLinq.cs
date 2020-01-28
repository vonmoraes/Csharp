using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class ExemploLinq {
        public class Aluno {
            public string nome;
            public int idade;
            public double nota;
        }


        public static void Executar() {

            var alunos = new List<Aluno> {
                new Aluno(){ nome = "Lucas H", idade = 17, nota = 7.3 },
                new Aluno(){ nome = "Lucas D", idade = 16, nota = 2.2 },
                new Aluno(){ nome = "Lucas C", idade = 18, nota = 3.4 },
                new Aluno(){ nome = "Lucas E", idade = 16, nota = 1 },
                new Aluno(){ nome = "Lucas F", idade = 15, nota = 10 },
                new Aluno(){ nome = "Lucas D", idade = 17, nota = 4.6 },
                new Aluno(){ nome = "Lucas E", idade = 19, nota = 7.2 },
                new Aluno(){ nome = "Lucas A", idade = 20, nota = 10 },
            };


            Console.WriteLine("\n== Aprovados ==");
            var aprovados = alunos.Where(aluno => aluno.nota >= 7.0)
                    .OrderBy(aluno => aluno.nome);
            foreach(var aluno in aprovados) {
                Console.WriteLine(aluno.nome);
            }

            Console.WriteLine("\n== Chamada ==");
            var ordem_chamada = alunos.OrderBy(aluno => aluno.nome);
            foreach(var aluno in ordem_chamada) {
                Console.WriteLine(aluno.nome);
            }

            Console.WriteLine("\n== Aprovados por Idade ==");
            var aprovados_idade = 
                from aluno in alunos
                where 
                    aluno.nota >= 7
                orderby aluno.nome
                select aluno.nome; // Lista de strings
            foreach(var aluno in aprovados_idade) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Unico Aluno ==");
            var aluno_unico = alunos.Single(aluno => aluno.nome.Equals("Lucas A"));
            Console.WriteLine(aluno_unico.nome);

            Console.WriteLine("\n== Skip exemplo ==");
            var aluno_skip = alunos.Skip(1).Take(3);
            foreach (var aluno in aluno_skip) {
                Console.WriteLine(aluno.nome);
            }

            var aluno_maior_nota = alunos.Max(aluno => aluno.nota);
            var aluno_menor_nota = alunos.Min(aluno => aluno.nota);
            var soma_notas = alunos.Sum(aluno => aluno.nota);
            var media_notas = alunos.Average(aluno => aluno.nota);

            // testes diversos 
        }

    }
}
