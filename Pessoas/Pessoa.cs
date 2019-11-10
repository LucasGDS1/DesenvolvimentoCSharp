using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoas
{
    class Pessoa
    {
        public string nome;
        public int idade;


        public override string ToString()
        {
            return "Pessoa mais velha: " + nome;
        }
    }
}
