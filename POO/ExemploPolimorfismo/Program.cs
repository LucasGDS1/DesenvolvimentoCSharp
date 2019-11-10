using System;
using ExemploPolimorfismo.Biblioteca;
using ExemploPolimorfismo.Biblioteca.Heranca;

namespace ExemploPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo vei = new Veiculo();
            Carro car = new Carro();
            Moto mot = new Moto();

            moverVeiculos(vei, car, mot);
        }

        public static void moverVeiculos(Veiculo veiculos, Carro carros, Moto motos)
        {
            veiculos.Mover();
            carros.Mover();
            motos.Mover();
        }
    }
}
