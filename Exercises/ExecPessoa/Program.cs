using System;

namespace ExecPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da 1ª Pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da 1ª Pessoa");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da 2ª Pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da 2ª Pessoa");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
                Console.WriteLine("A Pessoa {0} é  mais velha com {1} anos", p1.Nome, p1.Idade);
            else
                Console.WriteLine("A Pessoa {0} é  mais velha com {1} anos", p2.Nome, p2.Idade);
        }
    }
}
