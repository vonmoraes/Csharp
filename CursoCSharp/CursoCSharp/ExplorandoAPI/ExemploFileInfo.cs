using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.ExplorandoAPI {
    class ExemploFileInfo {

        public static void excluirSeExistir(params string[] caminhos) {
            foreach (var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);
                arquivo.Delete();
            }

        }


        public static void Executar() {
            var caminho_origem = @"~/arquivo_origem.txt".parseHome();
            var caminho_destino = @"~/arquivo_destino.txt".parseHome();
            var caminho_copia = @"~/arquivo_copia.txt".parseHome();
            excluirSeExistir(
                caminho_origem, caminho_copia, caminho_destino 
            );
            if (!File.Exists(caminho_origem)) {
                Console.WriteLine("Arquivo inexistente, criando arquivo...");
                using (StreamWriter sw = File.AppendText(caminho_origem)) {
                    sw.WriteLine("produto ; preco ; quantidade");
                    sw.WriteLine("f ; 1,99 ; 2");
                    sw.WriteLine("g ; 2,99 ; 3");
                    sw.WriteLine("h ; 3,99 ; 4");
                    sw.WriteLine("i ; 4,99 ; 5");
                    sw.WriteLine("j ; 5,99 ; 6");
                    sw.WriteLine("Arquivo Original");
                }
            }

            FileInfo origem = new FileInfo(caminho_origem);
            origem.CopyTo(caminho_copia);
            origem.MoveTo(caminho_destino);


        }
    }
}
