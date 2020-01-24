using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TratamentoExcessao {

    public class Conta {
        double saldo;
        
        public Conta(double saldo) {
            this.saldo = saldo;
        }

        public void sacar(double valor) {
            if(valor > saldo) {
                throw new ArgumentException("Saldo insuficiente"); // criando excecoes novas
            }
            saldo -= valor;
        }
    }

    class PrimeiraExcessao {
        public static void Executar() {
            Conta minha_conta = new Conta(10.4);

            try {
                minha_conta.sacar(50f);
                Console.WriteLine("valor sacado com sucesso");
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            } finally {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
