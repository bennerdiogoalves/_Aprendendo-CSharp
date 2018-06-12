using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado)
                mensagemAdicional = "Joao esta acompanhado!";
            else
                mensagemAdicional = "Joao nao esta acompanhado!";

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Joao pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Joao nao pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}