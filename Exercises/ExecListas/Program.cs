using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExecListas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
              
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = (Console.ReadLine());
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }



            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idSearch);
            if (emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.Increase(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Update list of employees: ");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
