using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            ////b1
            //Console.WriteLine("Enter a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b: ");
            //double b = double.Parse(Console.ReadLine());       
            //Console.WriteLine("sum is: "+tinhTong(a, b));
            //Console.WriteLine("subtraction is: "+tinhHieu(a, b));
            //Console.WriteLine("multiplication is "+tinhTich(a, b));
            //Console.WriteLine("division is: "+tinhThuong(a, b));


            ////b2
            //Console.WriteLine("Enter a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter c: ");
            //double c = double.Parse(Console.ReadLine());
            //Console.WriteLine("Min number is :"+findMin(a,b,c));



            ////b3
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sum 1 to n is: "+Sum1toN(n));


            ////b4
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("sum of digit in number is: "+sumDigitOfNum(n));



            ////b5
            //Console.WriteLine("Enter a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b: ");
            //int b = int.Parse(Console.ReadLine());
            //HoanVi(a, b);



            ////b6
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //isDivisor(n);


            ////b7
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //maxDigit(n);


            ////b8
            //Console.WriteLine("Enter a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b: ");
            //int b = int.Parse(Console.ReadLine());
            //upTenUnits(a, b);


            ////b9
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            int c = int.Parse(Console.ReadLine());
            CheckArithmeticProgression(a, b, c);

        }

        //b1
        static double tinhTong(double a, double b)
        {
            return a + b;
        }
        static double tinhHieu(double a, double b)
        {
            return a -b;
        }
        static double tinhTich(double a, double b)
        {
            return a*b;
        }
        static double tinhThuong(double a, double b)
        {
            return a /b;
        }

        //b2
        static double findMin(double a, double b, double c)
        {
            double min = a;
            if (min > b)
                min = b;
            if(min >c)
                min = c;
            return min;
        }

        //b3
        static double Sum1toN(int n)
        {
            int sum = 0;
            for(int i =1; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }

        //b4
        static double sumDigitOfNum(int n)
        {
            int sum = 0;
            for (; n != 0;) {
                //n =0 ket thuc vong lap
                int Split = n % 10;
                sum += Split;
                n /= 10;

            }
            return sum;


        }
        //b5
        static void HoanVi(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a,b after swap: {0},{1}", a, b);
        }

        
        //b6
        static void isDivisor(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    s++;
            Console.WriteLine("Divisor is: " + s);
        }


        //b7
        static void maxDigit(int n)
        {
            int max=0;
            for(;n>0 ;)
            {
                int temp = n % 10;
                n /= 10;
                if (temp > max)
                    max = temp;
            }
            Console.WriteLine("max digit in number is: " + max);
        }

        //b8
        static  void upTenUnits(int a,int b)
        {
            a += 10;
            b += 10;
            Console.WriteLine("a,b after upper 10 digits: "+ a+", "+ b);
        }

        //b9
        static void CheckArithmeticProgression(int a,int b,int c)
        {
            if (c - b == b - a)
                Console.WriteLine("A,B,C is ArithmeticProgression");
            else
                Console.WriteLine("A,B,C isn't ArithmeticProgression");
        }
    }
}
