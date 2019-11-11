using System;
using System.Collections.Generic;
using System.Globalization;
using GerenciamentoDeContratos.Entities;
using GerenciamentoDeContratos.Entities.Enums;


namespace GerenciamentoDeContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker dados = new Worker(nome, level, salary, dept);

            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            int qtdeContract = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeContract; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);
                dados.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] data = Console.ReadLine().Split('/');
            int month = int.Parse(data[0]);
            int year = int.Parse(data[1]);

            Console.WriteLine();
            Console.WriteLine("Name: " + dados.Nome);
            Console.WriteLine("Department: " + dados.Departament.Nome);
            Console.WriteLine("Income: " + dados.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
