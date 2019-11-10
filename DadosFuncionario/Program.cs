using System;
using System.Globalization;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            func2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double mediaDosSalarios = (func1.salario + func2.salario) / 2;

            Console.WriteLine($"\nSalário médio: {mediaDosSalarios.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
