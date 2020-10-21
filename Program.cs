using System;
using System.Globalization;

namespace ConstrutoresThisEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(conta, nome, depositoInicial);
            }
            else
            {
                contaBancaria = new ContaBancaria(conta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();

            Console.Write("Entre com o valor para depósito: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque: ");
            contaBancaria.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

        }
    }
}
