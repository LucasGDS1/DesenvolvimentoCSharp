using System;

namespace EntradaeSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodigoASCII = Console.Read();
            char letra = (char)CodigoASCII;
            Console.WriteLine("Código ASCII: " + CodigoASCII + " Letra digitada: " + letra);

            //ConsoleKeyInfo console = Console.ReadKey();
        }
    }
}
