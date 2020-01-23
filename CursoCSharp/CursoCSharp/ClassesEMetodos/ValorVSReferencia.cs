using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ValorVSReferencia {

        public class Dependente { // por padrão é privado
            public string nome; 
            public int idade;
        }

        public static void Executar(){
            int numero = 3;
            int copia_numero = numero;

            Dependente dependente = new Dependente {
                nome = "lucas", idade = 25
            };

            Dependente copia_dependente = dependente; // atribuição por referencia, ou seja,
                                            // se mudar algo no copia também muda no dependente


        }
    }
}
