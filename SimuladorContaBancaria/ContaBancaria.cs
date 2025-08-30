using System;
using System.Globalization;

namespace SimuladorContaBancaria {
    internal class ContaBancaria {

        private int numeroConta;
        private string nomeTitular;
        private double saldo;

        public ContaBancaria(int numero, string titular, double depositoinicial) { 
            this.numeroConta = numero;
            this.nomeTitular = titular;
            if (depositoinicial < 0) { 
                depositoinicial = 0;
            }
            this.saldo = depositoinicial;

            // Lógica da implementação dos dados aqui abaixo{}
        }

        public void Depositar(double quantia) {
            saldo = saldo + quantia;
        }
         
        public void Sacar(double quantia) {
            saldo = saldo - quantia;
        }

        public void ExibirDados() {
            string mensagem = $@"-- Dados da Conta --
-- Titular: {nomeTitular}
-- Número da Conta: {numeroConta}
-- Saldo Atual: {saldo:C}";

            Console.WriteLine(mensagem);
        }
    }

}
