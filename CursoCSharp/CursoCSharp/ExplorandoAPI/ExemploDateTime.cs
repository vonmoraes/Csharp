using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ExplorandoAPI {

   public static class ExtensaoDateTime {
        public static string diamesano(this DateTime data) {
            return $"{data.Day}/{data.Month}/{data.Year}";
            //return ("{0:##}/{1:##}/{2:##}", data.Day.ToString(), data.Month.ToString(), data.Year.ToString());
        }
    }


    class ExemploDateTime {
        public static void Executar() {
            var data = new DateTime(day:06, month:01, year: 2020);
            var today = DateTime.Today;

            Console.WriteLine(today.diamesano());

            var amanha = today.AddDays(1); 
            var ontem = today.AddDays(-1);


            Console.WriteLine(today.ToString("dd-MM-yy"));


        }

    }
}
