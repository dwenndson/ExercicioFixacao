using System;

namespace ExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char res = char.Parse(Console.ReadLine());
            if(res.Equals('s')|| res.Equals('S'))
            {
                decimal deposito = decimal.Parse(Console.ReadLine());
                conta = new ContaBancaria( numero, titular, deposito);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta bancaria");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Deseja depositar na conta?");
            res = char.Parse(Console.ReadLine());
            if(res == 's' || res == 'S')
            {
                Console.WriteLine("Valor a depositar: ");
                decimal dp = decimal.Parse(Console.ReadLine());
                conta.Deposito(dp);
                Console.WriteLine(conta);
            }

            Console.WriteLine();
            Console.WriteLine("Deseja fazer um saque? ");
            res = char.Parse(Console.ReadLine());
            if (res.Equals('s') || res.Equals('S')){
                Console.Write("Valor do Saque: R$");
                decimal sq = decimal.Parse(Console.ReadLine());
                conta.Saque(sq);
                Console.WriteLine(conta);

            }

        }
    }
}
