using System;

namespace ExemploVerificarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "vamos verificar a existência da palavra: Hello";

            if (texto.StartsWith("vamoss") == true)
            {
                Console.WriteLine("A palavra especificada também está no texto!");
            }
            else if (texto.EndsWith("Helloo") == true)
            {
                Console.WriteLine("A palavra especificada está no texto!");
            }
            else if (texto.Contains("existência") == true)
            {
                Console.WriteLine("A palavra está no texto!");
            }
           
        }
    }
}
