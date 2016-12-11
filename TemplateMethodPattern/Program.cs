using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MargeSort Test
            int[] numbersMargeSort = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = numbersMargeSort.Length;

            Console.WriteLine("MergeSort By Recursive Method");
            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < 9; i++)
                Console.Write(numbersMargeSort[i] + " ");

            SortBase margeSort = new MargeSort();
            margeSort.Sort(numbersMargeSort, 0, len - 1);
            Console.WriteLine("\nSorted Array: ");
            for (int i = 0; i < 9; i++)
                Console.Write(numbersMargeSort[i] + " ");
            #endregion

            #region QuickSort Test
            int[] numbersQuickSort = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            len = numbersQuickSort.Length;

            Console.WriteLine("\nQuickSort By Recursive Method");
            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < 9; i++)
                Console.Write(numbersQuickSort[i] + " ");

            SortBase quickSort = new QuickSort();
            quickSort.Sort(numbersQuickSort, 0, len - 1);

            Console.WriteLine("\nsSorted Array: ");
            for (int i = 0; i < 9; i++)
                Console.Write(numbersQuickSort[i] + " ");


            #endregion
        }
    }
}
