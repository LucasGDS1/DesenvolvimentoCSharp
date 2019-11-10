using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploSobescrita.Veiculo
{
    class Carro : Application
    {
        private int rodas = 4;

        public override void Mover()
        {
            Console.WriteLine("O carro se moveu!");
        }
    }
}
