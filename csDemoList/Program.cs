using System;
using System.Collections.Generic;

namespace csDemoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            //numbers.Remove(1);
            //Console.WriteLine(numbers.Count);

            //foreach (var number in numbers)
            //    numbers.Remove(1);     [error, we can't change list in foreach loop]

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            Console.WriteLine("List after removal: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Clearing List: .... ");
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
