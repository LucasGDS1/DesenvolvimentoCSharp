using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPolimorfismo.Biblioteca.Heranca
{
    class Moto : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("A moto se moveu!");
        }
    }
}
