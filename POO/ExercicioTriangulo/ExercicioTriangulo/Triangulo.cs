using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double calcularArea()
        {
            double formula = (A + B + C) / 2.0;
            return Math.Sqrt(formula * (formula - A) * (formula - B) * (formula - C));
        }
    }
}
