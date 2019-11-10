using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDeposito;
            double valorSaque;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o títular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Hávera depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            Conta dados = new Conta(titular, numeroConta);
            //condição
            if (resposta == "s")
            {
                Console.Write("Entre com um valor de depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);              
                dados.deposito(valorDeposito);
                Console.WriteLine();// pular linha

                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(dados);
                Console.WriteLine(); // pular linha

                Console.Write("Entre com um valor de depósito: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.deposito(valorDeposito);
                Console.WriteLine(); // pular linha

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(dados);
                Console.WriteLine(); // pular linha

                Console.Write("Entre com um valor de saque: ");
                valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.saque(valorSaque);
                Console.WriteLine(); // pular linha

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(dados);              
            }
            else if (resposta == "n")
            {
                Console.WriteLine(); //pular linha
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(dados);
                Console.WriteLine(); // pular linha

                Console.Write("Entre com um valor de depósito: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.deposito(valorDeposito);
                Console.WriteLine(); // pular linha

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(dados);
                Console.WriteLine(); // pular linha

                Console.Write("Entre com um valor de saque: ");
                valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.saque(valorSaque);
                Console.WriteLine(); // pular linha

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(dados);
            }
        }
    }
}
