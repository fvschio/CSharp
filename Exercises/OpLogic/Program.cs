﻿using System;

namespace OpLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; // flase
            bool c2 = 2 > 3 || 4 != 5; // true

            bool c3 = !(2 > 3) && 4 != 5; //true



            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("------------------");

            bool c5 = 10 < 5; //false

            bool c4 = c2 || c3 && c5; //true
            
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            
        }
    }
}
