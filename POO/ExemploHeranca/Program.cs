using System;
using ExemploHeranca.Veiculo;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Moto mot = new Moto();

            car.anoFabricacao = 2019;
            mot.marca = "BMW";

            Console.WriteLine(mot.marca);
        }
    }
}
