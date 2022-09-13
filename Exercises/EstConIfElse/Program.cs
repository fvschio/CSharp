using System;

namespace EstConIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("Bom Dia");

            if (x > 5)
            {
                Console.WriteLine("Boa Tarde");
            }
            Console.WriteLine("Boa Noite");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Entre com um numero inteiro");
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Qual é a hora atual");
            int b = int.Parse(Console.ReadLine());

            if (b < 12)
            {
                Console.WriteLine("Bom Dia");
            }
            else if (b < 18)
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite");
            }
        }
    }
}
