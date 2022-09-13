using System;
using System.Globalization;

namespace parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //  string[] vet = Console.ReadLine().Split(' ');
            //  string nome = vet[0];
            //  char sexo = char.Parse(vet[1]);
            //  int idade = int.Parse(vet[2]);
            //  double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            // Console.WriteLine("Você digitou:");
            // Console.WriteLine(n1);
            // Console.WriteLine(ch);
            // Console.WriteLine(n2);
            // Console.WriteLine(nome);
            // Console.WriteLine(sexo);
            // Console.WriteLine(idade);
            // Console.WriteLine(altura);

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double prod = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (na mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            int b = int.Parse(vetor[1]);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(qtd);
            Console.WriteLine(prod);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
