using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class ExemploTiposDinamicos {
        public static void Executar() {
            dynamic objeto = "lucas";

            objeto = 2;
            objeto++;

            Console.WriteLine(objeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Lucas";
            aluno.nota = "7.8";
            Console.WriteLine($"{aluno.nome} com nota {aluno.nota}");
        }
    }
}
