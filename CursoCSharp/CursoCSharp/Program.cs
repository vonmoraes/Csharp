using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos; // cap 1
using CursoCSharp.EstruturaDeControle; // cap 2
using CursoCSharp.ClassesEMetodos; // cap 3

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
                // Membros → Construtores e métodos com e sem retorno, métodos estáticos
                //  estaticos são da classe ou seja são compartilhados com todos os objetos
                //  atributos estaticos pertencem a classe e não a instância
                //  por padrão os atributos são private
                //  atributos readonly são constantes que são declaradas apenas uma vez
                {"Desafio Atributo - Classes & Metodos", DesafioAtributo.Executar},
                {"Params - Classes & Metodos", Params.Executar},
                {"Params - Classes & Metodos", ParametrosNomeados.Executar},
                {"Propriedades - Classes & Metodos", Props.Executar},



                // capitulo 4
                // capitulo 5
                // capitulo 6


            });

            central.SelecionarEExecutar();
        }
    }
}