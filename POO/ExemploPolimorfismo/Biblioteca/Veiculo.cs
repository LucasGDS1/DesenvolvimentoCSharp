using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPolimorfismo.Biblioteca
{
    class Veiculo
    {

        public virtual void Mover()
        {
            Console.WriteLine("O veiculo se moveu!");
        }
    }
}
