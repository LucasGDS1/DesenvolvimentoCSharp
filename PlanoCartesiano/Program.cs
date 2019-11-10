using System;

namespace PlanoCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor das coordenadas de X e Y na (mesma linha): ");
            string[] coordenada = Console.ReadLine().Split(',');
            int x = int.Parse(coordenada[0]);
            int y = int.Parse(coordenada[1]);

            while (x != 0 && y != 0)
            {
                if ((x > 0) && (y > 0))
                {
                    Console.WriteLine("A coordenada está no 1º Quadrante");
                } 
                else if((x < 0) && (y > 0))
                {
                    Console.WriteLine("A coordenada está no 2º Quadrante");
                }
                else if((x < 0) && (y < 0))
                {
                    Console.WriteLine("A coordenada está no 3º Quadrante");
                }
                else
                {
                    Console.WriteLine("A coordenda está no 4º Quadrante");
                }
                coordenada = Console.ReadLine().Split(',');
                x = int.Parse(coordenada[0]);
                y = int.Parse(coordenada[1]);
            }
            Console.WriteLine("Programa Finalizado, devido a um dos valores não ter sido informado");
        }
    }
}
