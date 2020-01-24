using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace CursoCSharp.ExplorandoAPI {

    public static class ExtensaoString {
        public static string parseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix 
                || Environment.OSVersion.Platform == PlatformID.MacOSX ? 
                Environment.GetEnvironmentVariable("HOME") 
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"));
            home += "/Desktop/Csharp/Csharp/CursoCSharp/Arquivos";
            return path.Replace("~", home);
        }
    }



    class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo_csharp.txt".parseHome(); // o @ interpreta o texto como ele é
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) { // criar um arquivo novo
                    sw.WriteLine("Arquivo criado com sucesso");
                    sw.WriteLine("a");
                    sw.WriteLine("b");
                    sw.WriteLine("c");
                    sw.WriteLine("d");
                    sw.WriteLine("e");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) { // Adicionar novo texto em arquivo ja existente
                sw.WriteLine("Adicionando novas linhas no arquivo");
            }



        }
    }
}
