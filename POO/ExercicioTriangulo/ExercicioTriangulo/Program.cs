using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Dígite o valor dos lados do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dígite o valor dos lados do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);          
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.calcularArea();
            double areaY = y.calcularArea();

            Console.WriteLine("A área do triângulo X informada é " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triângulo y informada é " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
