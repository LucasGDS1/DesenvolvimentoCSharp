using System;

namespace ExemploLocalizarTexto
{
    class Program
    {
        static void Main(string[] args)
        {

            string textos = "Ola mundo da programação C#";

            //IndexOf vai localizar a primeira palavra especificada.
            Console.WriteLine("Posição da palavra mundo: " + textos.IndexOf("mundo"));
            //LastIndexOf vai localicar a última palavra especificada.
            Console.WriteLine("Posição da última palavra do texto: " + textos.LastIndexOf("C#"));
        }
    }
}
