using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeContratos.Entities
{
    class Departament
    {
        public string Nome { get; set; }

        public Departament()
        {

        }
        public Departament(string nome)
        {
            Nome = nome;
        }
    }
}
