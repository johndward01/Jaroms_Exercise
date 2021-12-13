using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>();

            Populater(myList);

            Console.WriteLine($"Number of items in List: {myList.Count}");
        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; ++i)
            {
                Random rng = new Random();
                var nums = rng.Next(0, 50);
                numberList.Add(nums);
            }
        }

    }
}
