using System;
using System.Collections.Generic;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press the length of Array");
            int lengthOfArray = int.Parse(Console.ReadLine());
            int[] ints1 = new int[lengthOfArray];
            int summ = 0;
            int Chet = 0;
            
            for (int i = 0; i < ints1.Length; i++)
            {
                Console.WriteLine($"Press {i} element of arrray:");
                ints1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Your array is: ");
            foreach (int timelapse in ints1)
            {
                Console.Write($"{timelapse}   ");
            }
            Console.WriteLine();
            for (int z = 0; z <= ints1.Length - 1; z = z + 2)
            {
                summ += ints1[z];
            }
            Console.WriteLine($"Summ of odd elements of Array : {summ}");
            for (int i = 0; i <ints1.Length; i++)
            {
                if (ints1[i] % 2 == 0)
                {
                    Chet += ints1[i];
                }
            }
            Console.WriteLine($"Summ of even numbers in Array (which you entered): {Chet}");
            int minimus = ints1[0];
            for (int i = 0; i < ints1.Length; i++)
            {
                if (ints1[i] < minimus)
                {
                   minimus = ints1[i];
                }
                
            }
            Console.WriteLine($"minimal number of Array is {minimus}");
        }
    }
}
