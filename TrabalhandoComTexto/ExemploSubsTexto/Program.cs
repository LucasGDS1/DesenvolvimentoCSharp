using System;

namespace ExemploSubsTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "ela";

            Console.WriteLine("Nome da bendita: " + nome);

            nome = nome.Replace("ela", "elas");

            Console.WriteLine("O nome das benditas: " + nome);
        }
    }
}
