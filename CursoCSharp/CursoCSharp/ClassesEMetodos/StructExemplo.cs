using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {



    interface Ponto { // por padrão os metodos são publicos não entendi o motivo de interface
        void mover_diagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int x;
        public int y;

        public Coordenada(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void mover_diagonal(int delta) {
            x += delta;
            y += delta;
        }

    }


    class StructExemplo {
        public static void Executar() {


        }
    }
}
