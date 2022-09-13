//Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

using System;

namespace Ximpares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero de 1-1000");
            int cont = int.Parse(Console.ReadLine());
            if (cont <= 1000)
            {
                for (int i = 0; i <= cont; i++)
                {
                    if (i % 2 == 0) //PAR
                    {
                      //  Console.WriteLine("Este numero é par {0}", i);

                    }
                    else //IMPAR
                    {
                        Console.WriteLine("Este numero é impar {0}", i);

                    }
                }
            }
            else
                Console.WriteLine("Numero fora do intervalo permitido");
        }
    }
}
