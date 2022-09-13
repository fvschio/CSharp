using System;

namespace ExecSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            double media = 0.00; 

            Console.WriteLine("Digite o nome do 1º Funcionario");
            f1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do 1º Funcionario");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do 2º Funcionario");
            f2.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do 2º Funcionario");
            f2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("A media salarial entre os 2 funcionarios é " + (media = (f2.Salario + f2.Salario) / 2));
        }
    }
}
