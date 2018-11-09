using System;
using System.Collections.Generic;

namespace Checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = MultiplyBy100andAdd3(new List<int> { 3, 14, 50, 33, 450 });

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

        }

        private static List<int> MultiplyBy100andAdd3(List<int> list)
        {
            var result = new List<int>();

            foreach (var item in list)
            {
                int newNumber = item * 100 + 3;
                result.Add(newNumber);  
            }

            return result;

        }
    }
}
