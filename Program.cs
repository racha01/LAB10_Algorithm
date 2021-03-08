using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 5, 18, 3, 7, 6 };
            FindMin(numbers);
            FindMix(numbers);
            /*Console.Write("Enter a number to search for :");
            int searchNumber = Convert.ToInt32(Console.ReadLine());
           
            bool found = SequentialSearch(numbers, searchNumber);
            if (found)
                Console.WriteLine(searchNumber + " is in array.");
            else
                Console.WriteLine(searchNumber + " is not in array.");*/
        }
        static bool SequentialSearch(int[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length; index++)
                if (arr[index] == sValue)
                    return true;
                return false;
        }
        static void FindMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= min)
                    min = numbers[i];
            }
            Console.WriteLine(min);
        }
        static void FindMix(int[] numbers)
        {
            int mix = numbers[0];
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] >= mix)
                    mix = numbers[i];
            }
            Console.WriteLine(mix);
        }
    }
}
