using System;

namespace ExemploConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais localidade = new Pais();

            Console.WriteLine("Pais: " + localidade.pais + " Cidade: " + localidade.cidade);

            Pais locais = new Pais("Estados Unidos", "California", "Los Angeles");

            Console.WriteLine("País: " + locais.pais + " Estado: " + locais.estado + " Cidade: " + locais.cidade);
        }
    }
}
