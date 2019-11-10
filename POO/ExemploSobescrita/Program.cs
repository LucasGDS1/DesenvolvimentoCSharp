using ExemploSobescrita.Veiculo;
using System;

namespace ExemploSobescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Moto mot = new Moto();
            Application app = new Application();

            car.Mover();
            mot.Mover();
            app.Mover();
        }
    }
}
