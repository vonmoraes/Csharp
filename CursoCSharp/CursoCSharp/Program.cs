using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos; // cap 1
using CursoCSharp.EstruturaDeControle; // cap 2

namespace CursoCSharp {
    class Program {

        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // capitulo 1 Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar}, // rever
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unario - Fundamentos", OperadorUnario.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},
                // capitulo 2 Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF ELSE - Estruturas de Controle", EstruturaIFELSE.Executar},
                {"Estrutura IF ELSE IF - Estruturas de Controle", EstruturaIFELSEIF.Executar},
                // capitulo 3 Classe & Métodos
                // capitulo 4
                // capitulo 5
                // capitulo 6


            });

            central.SelecionarEExecutar();
        }
    }
}