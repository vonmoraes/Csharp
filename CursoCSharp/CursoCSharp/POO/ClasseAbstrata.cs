using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO {

    public abstract class Celular {
        public abstract string Assistente();
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Iphone";
        }
    }

    public class Xiaomi : Celular {
        public override string Assistente() {
            return "Xiaomi";
        }
    }

    public class Lenovo : Celular {
        public override string Assistente() {
            return "Lenovo";
        }
    }
    class ClasseAbstrata {
        public static void Executar() {

            var celulares = new List<Celular> {
                new Iphone(), new Xiaomi(), new Lenovo()
            };


            foreach(var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
