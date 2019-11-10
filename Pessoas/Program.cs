using System;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dígite os dados da primeira pessoa, nome e idade:");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dígite os dados da segunda pessoa, nome e idade:");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1}");
            } else
            {
                Console.WriteLine($"{pessoa2}");
            }
        }
    }
}
