using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////b1
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.Write(i + " ");
            //}





            ////b2
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write(i + " ");
            //}


            ////b3
            //for (int i = 0; i <= 100; i++)
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");



            ////b4     
            //for (int i = 0; i <= 100; i++)
            //    if (i % 2 != 0)
            //        Console.Write(i + " ");


            ////b5
            //int s = 0;
            //for(int i =1; i<= 100; i++) {
            //    s += i;
            //    }
            //Console.WriteLine("Sum 1 => 100 is: " + s);



            ////b6
            //int s = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if( i % 2 ==0)
            //        s += i;
            //}
            //Console.WriteLine("Sum EvenNum 1 => 100 is: " + s);



            ////b7
            //int sum = 0,i = 0;
            //do
            //{
            //    sum += i;
            //    i++;    
            //}
            //while (sum <200000);
            //Console.WriteLine(sum-i);


            ////b8
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0,i=1;

            //for (; i < n; i++)
            //{
            //    sum += i;
            //    if (sum > n)
            //        break;
            //}
            //Console.WriteLine(sum-i);


            //b9
            Console.WriteLine("Enter n: ");
            int n;
            n = int.Parse(Console.ReadLine());
            while (n< 100 || n > 500 && n % 2 == 0)
            {
                Console.WriteLine("n is wrong, pls enter agian");

            }
            n = int.Parse(Console.ReadLine());

            ////b10
            ///
            //Console.WriteLine("Enter n of beer cans: ");
            //int n = int.Parse(Console.ReadLine());
            //int m = 0;
            //for(int i = 0; i < n; i++) {
            //    m =n+ (n / 10) * 3 + n % 10;
            //    if (n % 10 == 0)
            //        break;
            //}
            //Console.WriteLine(m);

        }
    }
}
