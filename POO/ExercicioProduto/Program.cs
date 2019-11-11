using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto item = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            item.nome = Console.ReadLine();

            Console.Write("Preço: ");
            item.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            item.quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nDados do produto: " + item);
            Console.Write("\nDígite o número de produtos a ser adicionado:");
            int add = int.Parse(Console.ReadLine());
            item.adicionarProduto(add);

            Console.WriteLine($"\nDados atualizados: " + item);

            Console.Write("\nDígite o número de produtos a ser removido do estoque:");
            int remove = int.Parse(Console.ReadLine());
            item.removerProduto(remove);

            Console.WriteLine($"\nDados atualizados: " + item);


            Console.ReadKey();
        }
    }
}
