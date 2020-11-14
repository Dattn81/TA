using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            //b1
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            inputArray(n, arr);
            outputArray(n, arr);

            //b2
            outputLengthArr(arr);

            //b3
            SumIntofArr(n, arr);

            //b4
            findNuminArr(n, arr);

            //b5
            sortIncresce(n, arr);

            //b6
            Console.WriteLine("Max num in arr: "+maxNuminArr(n,arr));

            //b7
            sortDecrease(n, arr);

        }
        static void inputArray(int n,int []arr)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i + "]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void outputArray(int n,int []arr)
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < n;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }

        static void outputLengthArr(int []arr) {
            Console.WriteLine("Length of arr: "+arr.Length);

        }

        static void SumIntofArr(int n ,int []arr)
        {
            int s = 0;
            for (int i = 0; i <n;i++)
            {
                s += arr[i];
            }
            Console.WriteLine("Sum of integer int array is: " + s);
        }

        static void findNuminArr(int n , int[] arr)
        {
            Console.WriteLine("Enter the number in arr:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    Console.Write("index: " + "arr["+i+"] ");
            }
        }
        static void sortIncresce(int n ,int []arr)
        {
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i+1 ; j < n; j++)
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
            outputArray(n,arr);
        }
        static int maxNuminArr(int n,int[] arr)
        {
            int max = arr[0];
            for(int i = 1; i < n; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }

        static void sortDecrease(int n,int []arr)
        {
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
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
