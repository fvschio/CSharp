using System;

namespace posto
{
    class Program
    {
        static void Main(string[] args)
        {
            int combustivel = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("1 - ÁLCOOL");
            Console.WriteLine("2 - GASOLINA");
            Console.WriteLine("3 - DIESEL");
            Console.WriteLine("4 - SAIR");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 4)
            {

                if (opcao == 1)
                {
                    alcool++;
                    opcao = int.Parse(Console.ReadLine());
                }

                if (opcao == 2)
                {
                    gasolina++;
                    opcao = int.Parse(Console.ReadLine());
                }

                if (opcao == 3)
                {
                    diesel++;
                    opcao = int.Parse(Console.ReadLine());
                }
            }                        
            
            if ( opcao >= 4)
            {
                Console.WriteLine("Alcool = {0}", alcool);
                Console.WriteLine("Gasolina = {0}", gasolina);
                Console.WriteLine("Diesel = {0}", diesel);
                Console.WriteLine("MUITO OBRIGADO");

            }
        }
    }
}
