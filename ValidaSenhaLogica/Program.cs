using System;

namespace ValidaSenhaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "2002";

            Console.WriteLine("Dígite sua senha");
            string lerSenha = Console.ReadLine();

            //Caso o usuário dígite a senha certa logo de primeira, entra no IF e Printa que o acesso foi permitido
            //Caso contrário, entra no While e fica solicitando ao usuário que coloque a senha novamente
            if (lerSenha == senha)
            {
                Console.WriteLine("\nAcesso permitido");
            }

            while (lerSenha != senha)
            {
                
                Console.WriteLine("\nSenha invalida");
                Console.WriteLine("\nTente novamente");
                lerSenha = Console.ReadLine();

                if(lerSenha == senha)
                {
                    Console.WriteLine("\nAcesso permitido");
                } 
            }
        }
    }
}
