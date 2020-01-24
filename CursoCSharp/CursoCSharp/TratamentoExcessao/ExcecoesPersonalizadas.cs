using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TratamentoExcessao {

    public class NegativoException : Exception {

        public NegativoException() { }

        public NegativoException(string str) : base(str) { }

        public NegativoException(string str, Exception inner) : base(str, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string str) : base(str) { }
    }

    class ExcecoesPersonalizadas {

        public static int positivoPar() {
            Random rdn = new Random();
            int valor = rdn.Next(-30, 30);

            if (valor < 0) {
                throw new NegativoException("valor negativo");
            } else if (valor % 2 == 1) {
                throw new ImparException("valor impar");
            }

            return valor;
        }


        public static void Executar() {
            try {
                Console.WriteLine(positivoPar());
            } catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
