using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool completo = false;
            char genero   = 'F';
            char letra    = '\u0041';
            byte n1       = 126;
            int n2        = 1000;
            int n3        = 2147483647;
            long n4       = 2147483648L;
            float n5      = 4.5f;
            double n6     = 4.5;
            string nome   = "Maria Green";
            object obj1   = "Alex Brown";
            object obj2   = 4.5f;
            int n9        = int.MinValue;
            int n10       = int.MaxValue;
            sbyte n11     = sbyte.MinValue;
            sbyte n12     = sbyte.MaxValue;
            decimal n13   = decimal.MaxValue;
            decimal n14   = decimal.MinValue;
            int idade     = 32;
            double saldo  = 10.35784;

            int a = 10;
            a += 2; // Soma o que já está no a
            a *= 3; //Multiplica o que já está no a

            string s = "ABC";
            s += "DEF"; //Concatena String

            int b = 10; //b = b + 1
            b++;

            int c = 10; //c = c - 1
            c--;

            int d = 10;
            int h = 10;
            int k = 10;
            int e = h++; //Primeiro atribui o resultado e depois incrementa a variável
            int f = ++k; //Primeiro incrementa a variável e depois atribui o resultado


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n4);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(n12);
            Console.WriteLine(n13);
            Console.WriteLine(n14);

            Console.WriteLine("-----------------------");

            Console.Write("Bom Dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            
            Console.WriteLine("-----------------------");
            
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //tirar ; para .

            Console.WriteLine("-----------------------");

            Console.WriteLine("{0} tem {1} anos e um saldo de {2} reais.", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture)); //PLACEHOLDERS
            Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2} reais.", nome, idade, saldo); // PLACEHOLDERS
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo:F2} reais."); // INTERPOLAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e um saldo de " + saldo.ToString("F2") + " reais."); //CONCATENAÇÃO

            Console.WriteLine("-----------------------");

            Console.WriteLine(a);
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(h);
            Console.WriteLine(k);
            Console.WriteLine(f);

            Console.WriteLine("-----------------------");


        }
    }
}
