using System;
// Add system.collections.generic to access lists
using System.Collections.Generic;
using System.Diagnostics;
// Add system.linq to access additional functions from the Language INtegrated Query library
using System.Linq;

namespace ListExamplesNS
{
    class ListExamples
    {

        // Return sum of list of integers
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


        // Return max item from integer list
        static int MaxOfList(List<int> x)
        {
            int maxima = x[0];
            for (int i = 1; i < x.Count; i++)
            {
                if (x[i] > maxima)
                {
                    maxima = x[i];
                }
            }
            return maxima;
        }

        // Return min item from integer list
        static int MinOfList(List<int> x)
        {
            int minima = x[0];
            for (int i = 1; i < x.Count; i++)
            {
                if (x[i] < minima)
                {
                    minima = x[i];
                }
            }
            return minima;
        }

        // Return negative elements from an array of ints as a list
        static List<int> NegativeElements(List<int> x)
        {
            List<int> result = new List<int>{ };
            foreach(int value in x)
            {
                if (value < 0)
                {
                    result.Add(value);
                }

            }
            return result;
        }

        // Alternative negative function
        static List<int> AlternativeNegativeLINQ(List<int> x)
        {
            // Use LINQ framework
            // e => is an example of an anonymous lambda function
            List<int> result = x.FindAll(e => e < 0);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("List examples");
            List<int> aList = new List<int> { 1, 3, 5, 9, 2, 4, 8, 7, 6, 10, -3, -2};
            // Test assertions
            Debug.Assert(SumList1(aList) == 50);
            Debug.Assert(MinOfList(aList) == -3);
            Debug.Assert(MaxOfList(aList) == 10);
            // Testing by console output
            Console.WriteLine("Method 1 Total = "+ SumList1(aList));
            Console.WriteLine("Max = "+MaxOfList(aList));
            Console.WriteLine("Min = "+MaxOfList(aList));
            Console.WriteLine("Negatives in list: ");
            foreach (int x in NegativeElements(aList))
            {
                Console.WriteLine(x);
            }
        }
    }
}
