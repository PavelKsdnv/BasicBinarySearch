using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            int target = 5;
            RandomizeArray(arr);
            Array.Sort(arr);
            PrintArray(arr);
            var idTarget = BinarySearch(arr, target, 0, arr.Length - 1);
            if (idTarget != null)
                Console.WriteLine("The target is at index " + idTarget);
            else
                Console.WriteLine("There was no " + target);
            Console.ReadLine();
        }

        static void RandomizeArray(int[] arr)
        {
            var r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(arr.Length);
        }

        static int? BinarySearch(int[] arr, int target, int l, int r)
        {
            if (l > r)
                return null;

            int check = (l + r) / 2;
            if (arr[check] == target)
                return check;
            else if (arr[check] > target)
                return BinarySearch(arr, target, l, check - 1);
            else
                return BinarySearch(arr, target, check + 1, r);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
