using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {

        double desconto = 0.1;
        // é possivel criar os gets e sets dentro da variavel
        public string nome {
            get {
                return "Opcional " + nome;
            }
            set {
                nome = value;
            }
        }
        // propriedades autoimplementadas
        public double preco { get; set; }
        // somente leitura 
        public double precoComDesconto {
            get => preco - (desconto * preco); // notacao lambda
        }

    }




    class Props {
        public static void Executar() {

        }
    }
}
