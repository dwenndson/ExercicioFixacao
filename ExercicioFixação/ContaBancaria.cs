using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixação
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria() { }
        public ContaBancaria (int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, decimal saldo) : this (conta, titular)
        {
            Deposito(saldo);
        }

        public void Deposito(decimal deposito)
        {
            Saldo += deposito;
            
        }

        public void Saque(decimal saque)
        {
            decimal taxa = 5;
            Saldo -= taxa;
            Saldo -= saque;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: R$" + Saldo.ToString("F2");
        }
    }
}
