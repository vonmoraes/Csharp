using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.ExplorandoAPI {
    class LendoArquivos {
        public static void Executar() {
            var path = "~/lendo_arquivo.txt".parseHome();

            if (! File.Exists(path)) {
                Console.WriteLine("Arquivo inexistente, criando arquivo...");
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("produto ; preco ; quantidade");
                    sw.WriteLine("a ; 1,99 ; 2");
                    sw.WriteLine("b ; 2,99 ; 3");
                    sw.WriteLine("c ; 3,99 ; 4");
                    sw.WriteLine("d ; 4,99 ; 5");
                    sw.WriteLine("e ; 5,99 ; 6");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    string texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                //Console.WriteLine("arquivo lido com sucesso");
            }


        }
    }
}
