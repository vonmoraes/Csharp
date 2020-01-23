using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO {

    public class Feijao {
        public double peso; 
    }


    public class Arroz {
        public double peso; 
    }


    public class Carne {
        public double peso; 
    }


    public class Pessoa {
        public double peso;

        public void comer(Arroz arroz) {
            peso += arroz.peso;
        }

        public void comer(Feijao feijao) {
            peso += feijao.peso;
        }

        public void comer(Carne carne) {
            peso += carne.peso;
        }

    }


    class Polimorfismo {
        public static void Executar() {
            Arroz a = new Arroz();
            Feijao f = new Feijao();
            Carne c = new Carne(); 
        }
    }
}
