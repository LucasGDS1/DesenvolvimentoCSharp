using System;

namespace AluguelDeQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] dados = new Alunos[10];
            
            Console.Write("Quantos quartos vai alugar: ");
            int qtde = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtde; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Nome: ");
                string nome =  Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                //A variavel quarto está apontando para a posição do vetor;
                dados[quarto] = new Alunos(nome, email); //instanciar a classe Alunos com os valores passados pelo usuário;
            }

            Console.WriteLine();
            Console.WriteLine("Lista de alugueis: ");
            for (int i = 0; i < dados.Length; i++)
            {
                if(dados[i] != null)
                {
                    Console.WriteLine("Número do quarto: " + i + ": " + dados[i]);
                }              
            }

        }
    }
}


