using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero { Acao, Comedia, Drama };

    public class Filme {
        string nome;
        Genero genero_filme;
    }


    class EnumExemplo { // conjunto fechado de informações
        public static void Executar() {
            int id_acao = (int)Genero.Acao;
            int id_comedia = (int)Genero.Comedia;
            int id_drama = (int)Genero.Drama;
        }
    }
}
