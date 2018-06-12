using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos, pode entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, mas esta acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, nao pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}