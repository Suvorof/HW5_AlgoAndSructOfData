using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            // Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
            // Константин Суворов. Санкт-Петербург.

            int x = 300; // число для перевода
            Console.WriteLine(x);
            var stack = new Stack<int>();
            while (x > 0)
            {
                stack.Push(x % 2);
                x /= 2;
            }
            foreach (int i in stack)
                Console.Write(i);
            Console.ReadKey();
        }
    }
}
