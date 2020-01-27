using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {


    public class Caixa<T> {
        T valor_privado;
        public T coisa { get; set; }

        public Caixa(T coisa) {
            this.coisa = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? coisa : valor;
        }

    }


    class ExemploGenerics {




        public static void Executar() {

        }
    }
}
