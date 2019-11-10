using System;
using System.Globalization;

namespace CodigoAulaDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2.0;
            double pY = (y.A + y.B + y.C) / 2.0;

            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));
            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            } else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
