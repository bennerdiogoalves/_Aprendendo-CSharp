﻿using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade); /*O C# FAZ UMA LEITURA DOS VALORES A DIREITA E NO CASO AMBOS SÃO INTEIROS
                                        POR ESTE MOTIVO ELE APRESENTA 7*/

            idade = 15.0 / 2;
            Console.WriteLine(idade); /*PARA EU 'FORCAR' O TRABALHO COM DOUBLE DEVO COLOCAR O '.0'*/

            idade = 5 / 3;
            Console.WriteLine("5 / 3 " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 " + idade);


            Console.WriteLine("A execucao acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}