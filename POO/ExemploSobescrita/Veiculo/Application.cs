using System;
using System.Collections.Generic;
using System.Text;
using ExemploSobescrita.Veiculo;

namespace ExemploSobescrita.Veiculo
{
    class Application
    {
        public string marca;
        public string modelo;
        public int capacidadePassageiro;
        public int anoFabricacao;


        public virtual void Mover()
        {
            Console.WriteLine("A aplicação se moveu");
        }
    }
}
