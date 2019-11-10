using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ListaRegistroEmpregado
{
    class Empregados
    {
        private string Nome { get; set; }
        public int Id { get; set; }
        private double Salario { get; set; }

        public Empregados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }


        public void aumentoSalario(double value)
        {
            Salario += (Salario * (value/100));     
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Nome: " + Nome + ", Salário: R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
