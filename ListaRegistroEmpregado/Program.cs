using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaRegistroEmpregado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> lista = new List<Empregados>(); //Instanciando uma variavel do tipo List que referencia a Classe Empregados;

            Console.Write("Entre com o número de registro que vai realizar: ");
            int registros = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= registros; i++)
            {
                Console.WriteLine(); //Pular linha
                Console.WriteLine($"Empregado #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Empregados dados = new Empregados(id, nome, salario); //Depois que o usuário informar os dados para registro, instancia um novo objeto com os valores
                lista.Add(dados); //Adiciona na lista de Empregados, os valores do Objeto de Empregados que foram informados         
            }

            Console.WriteLine();
            Console.Write("Entre com o id do empregado que vai receber um aumento de salário: ");
            int srcId = int.Parse(Console.ReadLine());

            Empregados emp = lista.Find(x => x.Id == srcId); //Verifica na lista se o ID - Informado é igual ao ID - Registrado

            if (emp != null) //Se o empregado for encontrado, será solicitado que informe a porcentagem de aumento salarial
            {
                Console.Write("Entre com o valor da porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.aumentoSalario(porcentagem); //Chama o método que faz o cálculo para aumentar o salário
            } else
            {
                Console.WriteLine("Empregado não registrado!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Empregados Registrados: ");
            foreach(Empregados e in lista) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
