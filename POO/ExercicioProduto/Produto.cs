using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioProduto
{
    class Produto
    {
        public string nome;
        public int quantidade;
        public double preco;


        public void adicionarProduto(int add)
        {
            quantidade += add;
        }

        public void removerProduto(int remove)
        {
            quantidade -= remove;
        }

        public double valorEmEstoque()
        {
            return quantidade * preco;
        }

        public override string ToString()
        {
            return nome
                + ", R$"
                + preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + quantidade + " unidades"
                + ", Total: R$" 
                + valorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
