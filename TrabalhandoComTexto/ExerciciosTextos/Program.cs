using System;

namespace ExerciciosTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "jose, pedro, JOÃO e lucas";
            string[] separador = {", "," e "};
            string[] novoArrayNome = nome.Split(separador, StringSplitOptions.None);

            /*foreach (string nomes in novoArrayNome)
            {
                if (nomes == nomes.ToUpper())
                {
                    Console.WriteLine("O nome maisculo é: " + nomes.ToLower());
                }
            }*/

           for (int i = 0; i < novoArrayNome.Length; i++)
            {
                if(novoArrayNome[i] == novoArrayNome[i].ToUpper())
                {
                    Console.WriteLine("Nome alterado para minusculo: " + novoArrayNome[i].ToLower().Substring(0,4));
                } else
                {
                    Console.WriteLine("Nome minusculo: " + novoArrayNome[i]);
                }
            }
        }
    }
}
