using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosFuncoes {
    class DelegateAnonima {

        delegate string StringOperacao(string str);



        public static void Executar() {

            StringOperacao inverter = delegate (string str) {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };


            Console.WriteLine(inverter("Lucas e Luana"));

        }
    }
}
