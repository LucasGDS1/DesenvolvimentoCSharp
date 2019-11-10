using System;
using System.Collections.Generic;

namespace DicionarioExemplo
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> dicionario = new Dictionary<string, int>();

            //Adicionando ID e Valor ao dicionário
            dicionario.Add("T1", 10);
            dicionario.Add("T2", 20);

            int contador = 0;

            //Enquanto o usuário não dígitar um número,  o mesmo não podera sair do laço de repetição
            while(contador <= 0)
            {
                Console.WriteLine("Digite um número: ");
                string ler = Console.ReadLine();

                //Tratamento de exceção para o usuário ser forçado a dígitar um número inteiro qualquer
                try
                {
                    int valor = Convert.ToInt32(ler);
                    Console.WriteLine("Número digitado = " + valor);
                    contador = contador + 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Você digitou um número e não uma letra.");
                }
            }

            //Nome = ID; Keys = Valores
            foreach(string nome in dicionario.Keys)
            {
                Console.WriteLine("Chave: " + nome + " Valores: " + dicionario[nome]);
            }
        }
    }
}
