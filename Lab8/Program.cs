using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter l: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            inputArray(n, arr);
            //outputArray(n, arr);
            sortKtoL(n, k, l, arr);
        }
        static void inputArray(int n, int[] arr)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i + "]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void outputArray(int n, int[] arr)
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void sortKtoL(int n,int k,int l, int[] arr)
        {
            int temp;
            for (int i = k; i < l - 1; i++)
            {
                for (int j = k + 1; j < l; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        // Hoan vi 2 so a[i] va a[j]
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("After sort: ");
            outputArray(n, arr);
        }
    }
}
