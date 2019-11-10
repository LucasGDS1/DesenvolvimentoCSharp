using System;

namespace ExemploFormatarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "lucas";

            string textoFormatado = string.Format("Bem vindo a programação {0}!", nome);

            Console.WriteLine(textoFormatado);
        }
    }
}
