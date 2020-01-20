using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string modelo;
        public string fabricante;
        public int ano;

        public Carro(string modelo, string fabricante, int ano) {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
        }

        public Carro() {
            ;
        }

    }

    class CalculadoraCadeia {
        int memoria;
         
        public CalculadoraCadeia somar(int a) {
            memoria += a;
            return this; // retorna o proprio objeto
        }

     }

    class Construtores {
        public static void Executar() {
            // igual java execçao construtor padrão existe quando vc não cria um construtor
            var carro3 = new Carro() { // pode-se criar um novo objeto de uma classe assim
                modelo = "i8",
                fabricante = "bmw",
                ano = 2222
            };

        }
    }
}
