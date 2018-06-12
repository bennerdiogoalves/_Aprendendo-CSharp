using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            //O INT é um tipo de variável que suporta valors de até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            long idade; /*O long é um tipo de variável que suporta valores de até 64 bits*/
            idade = 13000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos = 150; /*short aceita número de até 16bits*/
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}