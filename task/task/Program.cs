using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Remove(3);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Clear();
            Console.WriteLine(numbers[2]);
            Console.WriteLine($"Count:{numbers.Count}");
        }
    }
}
