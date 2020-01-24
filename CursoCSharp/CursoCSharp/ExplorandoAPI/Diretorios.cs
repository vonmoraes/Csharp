using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.ExplorandoAPI {
    class Diretorios {

        public static void excluirSeExistir(params string[] diretorios) {
            foreach (var diretorio in diretorios) {
                if (Directory.Exists(diretorio)) {
                    Console.WriteLine(Directory.GetCreationTime(diretorio));
                    Directory.Delete(diretorio);
                }
            }

        }


        public static void Executar() {
            var novoDiretorio = @"~/NovaPasta".parseHome();
            var destinoDiretorio = @"DiretorioDestino".parseHome();
            excluirSeExistir(novoDiretorio, destinoDiretorio);

            Directory.CreateDirectory(novoDiretorio);
            Directory.CreateDirectory(destinoDiretorio);



        }
    }
}
