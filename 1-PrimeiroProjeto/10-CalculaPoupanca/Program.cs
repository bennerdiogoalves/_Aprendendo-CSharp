using System;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupanca");
            double valorInvestido = 1000;

            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                //0,36 % = 0,0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + contadorMes + " meses, voce tera R$" + valorInvestido);
                contadorMes++;
            }
            
            Console.ReadLine();
        }
    }
}