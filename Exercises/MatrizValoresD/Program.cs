using System;

namespace MatrizValoresD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para as colunas da matriz: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para as linhas da matriz: ");
            int l = int.Parse(Console.ReadLine());

            int[,] mat = new int[c, l];

            for (int i = 0; i < c; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < l; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Digite um valor para buscar os numeros próximos aos arredores: ");
            int pos = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {                
                for (int j = 0; j < l; j++)
                {                    
                    if (pos == mat[i, j])
                    {
                        Console.WriteLine("Position {0},{1}", i, j);
                                                                   
                        if ((j - 1) >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);                           
                        }
                        if ((j + 1) < l)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);                            
                        }
                            if ((i + 1) < c)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);                            
                        }
                        if ((i - 1) >= 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                    }
                }
            }
        }
    }
}










