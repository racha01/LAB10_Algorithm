using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ArrayList mynums = new ArrayList(9);
            for (int i = 0; i < 10; i++)
                mynums.Add(random.Next(10));
            mynums.Sort();

            int position = -1;
            while (position == -1)
            {
                try
                {
                    Console.Write("Enter a number to search for:");
                    int searchNumber = int.Parse(Console.ReadLine());

                    position = BinarySearch(mynums, searchNumber, 0, mynums.Count - 1);
                    if (position > -1)
                        Console.WriteLine("found item index = " + position);
                    else
                        Console.WriteLine("Not in the array");
                }catch (Exception) { }
            }
            Console.Write("\nArray items :");
            for (int i = 0; i <= 9; i++)
                Console.Write(mynums[i] + " ");
            Console.ReadLine();
        }
        static int BinarySearch(ArrayList arr, int value, int lower, int upper)
        {
            if (lower > upper)
                return -1;
            else
            {
                int mid;
                mid = (int)(upper + lower) / 2;
                if (value < (int)arr[mid])
                    return BinarySearch(arr, value, lower, mid - 1);
                else if (value == (int)arr[mid])
                    return mid;
                else
                    return BinarySearch(arr, value, mid + 1, upper);
            }
        }
    }
}
