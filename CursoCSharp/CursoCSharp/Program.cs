using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos; // cap 1
using CursoCSharp.EstruturaDeControle; // cap 2
using CursoCSharp.ClassesEMetodos; // cap 3
using CursoCSharp.Colecoes; // cap 4
using CursoCSharp.POO; // cap 7
using CursoCSharp.MetodosFuncoes; // cap 8
using CursoCSharp.TratamentoExcessao; // cap 9

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
                {"Parametros Nomeados - Classes & Metodos", ParametrosNomeados.Executar},
                {"Propriedades - Classes & Metodos", Props.Executar},
                {"Enum - Classes & Metodos", EnumExemplo.Executar},
                {"Struct - Classes & Metodos", StructExemplo.Executar}, // qual motivo de interface (atribuição por valor)
                // classes atribuição por referencia
                {"ValorVSReferencia - Classes & Metodos", ValorVSReferencia.Executar},
                {"Parametros por referencia - Classes & Metodos", ParametrosPorReferencia.Executar},
                {"Parametros Padrao - Classes & Metodos", ParametrosPadrao.Executar},
                // capitulo 4
                {"Vetores - Coleções", Vetores.Executar},
                {"Listas - Coleções", Listas.Executar},
                {"Listas de Vetores - Coleções", ListaDeVetores.Executar},
                {"ColecoesSet - Coleções", ColecoesSet.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
               
                // capitulo 5
                // capitulo 6
                // capitulo 7 
                 {"Heranca - POO", Heranca.Executar},
                 {"Construtor This - POO", ConstrutorThis.Executar},
                 {"Encapsulamento - POO", POO.Encapsulamento.Executar},
                 {"Polimorfismo - POO", Polimorfismo.Executar},
                 {"Classe Abstrata - POO", ClasseAbstrata.Executar},
                 {"Interface - POO", Interfaces.Executar},
                 {"Classe Sealed- POO", ClasseSealed.Executar},
                 // capitulo 8
                 {"Exemplo lambda - Métodos e Funcoes", ExemploLambda.Executar},
                 {"Delegate lambda - Métodos e Funcoes", LambdaDelegate.Executar},
                 {"Usando lambda - Métodos e Funcoes", UsandoDelegate.Executar},
                 {"Delegate Funcoes Anonimas - Métodos e Funcoes", DelegateAnonima.Executar},
                 {"Delegate Parametro - Métodos e Funcoes", DelegateParametro.Executar},
                 {"Metodo Extensao - Métodos e Funcoes", MetodoExtensao.Executar},
                 // capitulo 9 
                 {"Metodo Extensao - Métodos e Funcoes", PrimeiraExcessao.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}