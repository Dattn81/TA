using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3
{
    class Program
    {
        static void Main(string[] args)
        {
            //b1
            //int a, b, c,temp;
            //Console.WriteLine("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap c: ");
            //c = int.Parse(Console.ReadLine());
            //if (a > b){
            //    temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (a > c){
            //    temp = a;
            //    a = c;
            //    c = temp;
            //}
            //if (b > c){
            //    temp = b;
            //    b = c;
            //    c = temp;
            //}
            //Console.WriteLine(a + " " + b + " " + c);
            //Console.ReadKey();


            //b2
            //double a, b, c,p,dientich;
            //Console.WriteLine("Nhap a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap b: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap c: ");
            //c = double.Parse(Console.ReadLine());
            //if ((a + b > c) && (a + c > b) && (b + c > a))
            //{
            //    Console.WriteLine("Day la tam giac");
            //    // p la nua chu vi tam giac
            //    p = 1.0 / 2 * (a + b + c);
            //    dientich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //    Console.WriteLine("Dien tich tam giac la: " + dientich);
            //}
            //else
            //    Console.WriteLine("Dien tich hinh thang la: " + c * ((a + b) / 2));
            //Console.ReadKey();



            //b3
            //Console.WriteLine("Enter month: ");
            //int month = int.Parse(Console.ReadLine());
            //switch(month)
            //{
            //    case 1:
            //        Console.Write("January");
            //        break;
            //    case 2:
            //        Console.Write("February");
            //        break;
            //    case 3:
            //        Console.Write("March");
            //        break;
            //    case 4:
            //        Console.Write("April");
            //        break;
            //    case 5:
            //        Console.Write("May");
            //        break;
            //    case 6:
            //        Console.Write("June");
            //        break;
            //    case 7:
            //        Console.Write("July");
            //        break;
            //    case 8:
            //        Console.Write("August");
            //        break;
            //    case 9:
            //        Console.Write("September");
            //        break;
            //    case 10:
            //        Console.Write("October");
            //        break;
            //    case 11:
            //        Console.Write("November");
            //        break;
            //    case 12:
            //        Console.Write("December");
            //        break;
            //    default:
            //        Console.Write("invalid Month number. \nPlease try again ....\n");
            //        break;
            //}
            //Console.ReadKey();




            //b4
            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());
            if (salary >= 0 && salary <= 400.00)
                salary *= 1.15;
            else if (salary > 400.01 && salary <= 800.00)
                salary *= 1.12;
            else if (salary > 800.01 && salary <= 1200.00)
                salary *= 1.1;
            else if (salary > 1200.01 && salary <= 2000.00)
                salary *= 1.07;
            else
                salary *= 1.04;
            Console.WriteLine(salary);
            Console.ReadKey();

            //b5
            //Console.WriteLine("Nhap n:");
            //int n = int.Parse(Console.ReadLine());
            //int s = 1;
            //for(int i =1; i<=n; i++)
            //{
            //    s *= i;
            //}
            //Console.WriteLine(n + "! = " + s);


        }
    }
}
