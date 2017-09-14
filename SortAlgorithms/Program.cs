using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorting = new SortAlgorithms<int>();
            var arrayValues = new int[] { 9, 5, 2, 1, 7, 3, 4, 6 };
            
            Console.WriteLine("Array Not Organized: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            sorting.SortBubble(arrayValues);

            Console.WriteLine("Array Already Organized  With Bubble: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
            arrayValues = new int[] { 9, 5, 2, 1, 7, 3, 4, 6 };
            sorting.SortSelection(arrayValues);

            Console.WriteLine("Array Already Organized  By Selection: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

            arrayValues = new int[] { 9, 5, 2, 1, 7, 3, 4, 6 };
            sorting.SortInsertion(arrayValues);

            Console.WriteLine("Array Already Organized  By Insertion: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

            arrayValues = new int[] { 9, 5, 2, 1, 7, 3, 4, 6 };
            sorting.SortMerge(arrayValues);

            Console.WriteLine("Array Already Organized  By MergeSort: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

            arrayValues = new int[] { 9, 5, 2, 1, 7, 3, 4, 6 };
            sorting.SortQuick(arrayValues);

            Console.WriteLine("Array Already Organized  By QuickSort: ");

            foreach (var value in arrayValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
