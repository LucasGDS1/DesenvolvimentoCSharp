using GerenciamentoDeContratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoDeContratos.Entities
{
    class Worker
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Departament Departament { get; set; }

        public Worker(string nome, WorkerLevel level, double basesalary, Departament departament )
        {
            Nome = nome;
            Level = level;
            BaseSalary = basesalary;
            Departament = departament;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract percorre in Contracts)
            {
                if(percorre.Date.Year == year && percorre.Date.Month == month)
                {
                    sum += percorre.TotalValue();
                }
            }
            return sum;
        }
    }
}
