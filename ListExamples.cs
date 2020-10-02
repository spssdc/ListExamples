using System;
// Add system.collections.generic to access lists
using System.Collections.Generic;
// Add system.linq to access additional functions from the Language INtegrated Query library
using System.Linq;

namespace ListExamplesNS
{
    class ListExamples
    {
        static int SumList1(List<int> x)
        {
            // Method 1 - foreach to iterate members of list
            int total = 0;
            foreach (int value in x)
            {
                total += value;
            }
            return total;
        }

        static int MaxOfList(List<int> x)
        {
            int maxima = x[0];
            for (int i = 1; i < x.Count; i++)
            {
                if (x[i] > maxima) {
                    maxima = x[i];
                }
            }
            return maxima;
        }
        static int SumList2(List<int> x)
        {
            // Method 2 - index items in list
            int total = 0;
            for (int i = 0; i < x.Count; i++)
            {
                total += x[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("List examples");
            List<int> aList = new List<int> { 1, 3, 5, 9, 2, 4, 8, 7, 6, 10};
            Console.WriteLine("Method 1 Total = "+ SumList1(aList));
            Console.WriteLine("Method 2 Total = "+ SumList2(aList));
            Console.WriteLine(aList.Sum());
            aList.Add(11);
            Console.WriteLine(aList.Sum());
        }
    }
}
