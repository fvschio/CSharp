using System;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a;
            //float b;
            //int b;

            int a = 5;
            int b = 2;

            //a = 5.1;
            //b = (float)a; //Casting, transforma a variavel double em float
            //b = (int)a; // Casting, valores truncados

            double resultado = (double) a / b; //Casting, garante que não descarte as casas decimais por causa do int

            Console.WriteLine(resultado);
        }
    }
}
