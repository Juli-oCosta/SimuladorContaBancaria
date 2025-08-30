using System;
using System.Globalization;

namespace SimuladorContaBancaria{
    class Cliente {

        static void Main(String[] args) {

            ContaBancaria c1;

            Console.WriteLine("Bem-vindo ao Banco Digital!");
            Console.WriteLine("--------------------------");

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S') {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new ContaBancaria(numero, titular, depositoInicial);
            } else {
                c1 = new ContaBancaria(numero, titular, 0);
            }

            Console.WriteLine("\nConta criada com sucesso!");
            Console.WriteLine("--------------------------");

            c1.ExibirDados();
            Console.WriteLine("--------------------------\n");

            Console.Write("Digite um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c1.Depositar(valorDeposito);

            Console.WriteLine("Depósito realizado!");
            Console.WriteLine("--------------------------");
            c1.ExibirDados();
            Console.WriteLine("--------------------------\n");


            // --- ETAPA 3: SAQUE ---
            Console.Write("Digite um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c1.Sacar(valorSaque);

            Console.WriteLine("Saque realizado!");
            Console.WriteLine("--------------------------");
            c1.ExibirDados();
            Console.WriteLine("--------------------------\n");

        }

    }
}