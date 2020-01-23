using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        // todos
        public string info_publica = "→ public";
        // heranca
        protected string cor_olhos = "→ protected";
        // mesmo projeto 
        internal string celular = "→ internal";
        // heranca ou mesmo projeto
        protected internal string jeito_de_falar = "→ protected internal";
        // mesma classe ou heranca no mesmo projeto (c# > 7.2)
        private protected string segredos = "→ private protected";
        // private
        string verdadeiro = "→ private default";

        public void meus_acessos() {
            Console.WriteLine("SubCelebridade");
            Console.WriteLine(info_publica);
            Console.WriteLine(cor_olhos);
            Console.WriteLine(celular);
            Console.WriteLine(jeito_de_falar);
            Console.WriteLine(segredos);
            Console.WriteLine(verdadeiro);
        }
    }
}
