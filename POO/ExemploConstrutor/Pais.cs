using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploConstrutor
{
    class Pais
    {
        public string pais;
        public string cidade;
        public string estado;

        public Pais()
        {
            pais = "Brasil";
            cidade = "Curitiba";
        }
        public Pais(string pais, string estado, string cidade)
        {
            this.pais = pais;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}
