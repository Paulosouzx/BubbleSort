using ConsoleApp1.Entities;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 3, 5, 10, 0, 124, 69 };

            BubbleSort bubbleSort = new BubbleSort();

            bubbleSort.MakeSort(numeros);

            Console.WriteLine(string.Join(" , ", numeros));
        }
    }
}
