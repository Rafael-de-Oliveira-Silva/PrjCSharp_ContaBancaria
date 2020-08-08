using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Informe o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            bool depositoInicial = ( resp == "S") || (resp == "s");

            if (depositoInicial)
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Cria a conta com valor inicial...
                conta = new ContaBancaria(numConta, nomeTitular, valorInicial);
            }
            else {
                //Cria a conta sem o valor inicial...
                conta = new ContaBancaria(numConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta...");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados...");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados...");
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}
