using System;
using System.Collections.Generic;

namespace HomeWork4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite razmernots' massiva");
            int N = int.Parse(Console.ReadLine());
            int[] massiv = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Press {i} element of Array");
                massiv[i] = int.Parse(Console.ReadLine()); 
            }
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                stack.Push(massiv[i]);          
            }
            Console.WriteLine("Вывод стака");
            foreach (int number in stack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"stack consist of {stack.Count} elements");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine($" Posle POP stack consist of {stack.Count} elements");
        }
    }
}
