using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            // *Реализовать алгоритм перевода из инфиксной записи фрифметического выражения в постфиксную.
            // Константин Суворов. Санкт-Петербург.

            ToRPN rpn = new ToRPN();
            Console.WriteLine("Введите выражение, например: 1+2*3 и нажмите enter:");
            rpn.algorithm();
            Console.ReadKey();
        }
    }

    public class ToRPN
    {
        private string input = "";
        private string output = "";
        private Stack<string> stack = new Stack<string>();
        private int idx = 0;

        public ToRPN()
        {

        }

        public int priority(char chr)
        {
            if (chr == '+' || chr == '-')
                return 1;
            else if (chr == '*' || chr == '/')
                return 2;
            else if (chr == '^')
                return 3;
            else return 0;
        }

        public void algorithm()
        {
            input = Console.ReadLine();
            foreach (char chr in input)
            {
                if (char.IsDigit(chr))
                {
                    output += Char.ToString(chr);
                }
                else
                {
                    if (chr == '-' || chr == '+' || chr == '*' || chr == '/' || chr == '^')
                    {
                        if (stack.Count == 0)
                        {
                            output += " ";
                            stack.Push(char.ToString(chr));
                        }
                        else
                        {
                            if (priority(Convert.ToChar(stack.Peek())) == priority(chr))
                            {
                                output += " ";
                                output += stack.Pop();
                                output += " ";
                                stack.Push(Char.ToString(chr));
                            }
                            if (priority(Convert.ToChar(stack.Peek())) < priority(chr))
                            {
                                output += " ";
                                stack.Push(Char.ToString(chr));
                            }
                            else if (priority(Convert.ToChar(stack.Peek())) > priority(chr))
                            {
                                output += " ";
                                output += stack.Pop();
                                output += " ";
                                stack.Push(Char.ToString(chr));
                            }
                        }
                    }
                    else
                    {

                        if (chr == '(')
                        {

                        }
                    }
                }

            }
            int n = stack.Count;
            for (int i = 0; i < n; i++)
            {
                output += " ";
                output += stack.Pop();
                output += " ";
            }
            Console.WriteLine(output);
        }
    }
}
