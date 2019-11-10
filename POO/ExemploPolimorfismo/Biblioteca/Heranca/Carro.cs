using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPolimorfismo.Biblioteca.Heranca
{
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("O carro se moveu!");
        }
    }
}
