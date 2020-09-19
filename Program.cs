using System;

namespace OlaUsuario_AT_Etec
{
    class Program
    {
        static void Main(string[] args)
        {
         
         string nomeDoUsuario;

            Console.Write("Por favor, Digita Seu Nome: ");
            nomeDoUsuario = Console.ReadLine();
            Console.Write("Ola ");
            Console.Write(nomeDoUsuario );
            Console.WriteLine("Clique,em uma tecla para finalizar");
            Console.ReadKey();
        }
    }
}
