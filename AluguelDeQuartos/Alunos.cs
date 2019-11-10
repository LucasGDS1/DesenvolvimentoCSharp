using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelDeQuartos
{
    class Alunos
    {
        private string Nome { get; set; }
        private string Email { get; set; }

        public Alunos(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Estudante: " + Nome + ", Email: " + Email;
        }
    }
}
