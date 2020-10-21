using System;
using System.Globalization;

namespace ConstrutoresThisEncapsulamento
{
    public class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
        public ContaBancaria(int conta, string nome, double saldo) : this(conta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        /* public void AlterarSaldo(double valor)
        {
            if (valor > Saldo)
                throw new Exception("Não é possivel alterar o saldo");

            this.Saldo += valor;
        } */

        public override string ToString()
        {
            return "Conta "
            + Conta
            + ", Titular: "
            + Nome
            + ", Saldo: R$  "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}