using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //b1
            //Console.WriteLine("Nhap a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap b:");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ban da nhap a :" + a);
            //Console.WriteLine("Ban da nhap b :" + b);
            //double temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("a và b sau khi hoan doi: {0},{1}", a, b);
            //Console.ReadKey();


            //b2
            //Console.WriteLine("Nhap ban kinh: ");
            //double r = double.Parse(Console.ReadLine());
            //double A = 3.14159 * r*r;
            //Console.WriteLine("Dien tich hinh tron: " + A); 
            //Console.ReadKey();

            //b3
            //Console.WriteLine("Nhap diem giua ki: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap diem cuoi ki: ");
            //double b= double.Parse(Console.ReadLine());
            //double diemTB = a * .3 + b * .7;
            //Console.WriteLine("Diem tb mon NMLT la: " + diemTB);
            //Console.ReadKey();

            //b4
            //Console.WriteLine("So gio lam: ");
            //double gio = double.Parse(Console.ReadLine());
            //Console.WriteLine("Gia tien theo gio :");
            //double giaTien = double.Parse(Console.ReadLine());
            //double luongThang = giaTien * gio;
            //Console.WriteLine("Luong cua nhan vien la : {0}",luongThang);
            //Console.ReadLine();

            //B5
            //int  soTo100, soTo50, soTo20 , soTo10, soTo5, soTo2, soTo1;
            //Console.WriteLine("Nhap so tien N : ");
            //int n = int.Parse(Console.ReadLine());
            //soTo100 = n / 100;    n %= 100;
            //soTo50 = n / 50; n %= 50;
            //soTo20 = n / 20; n %= 20;
            //soTo10 = n / 10; n %= 10;
            //soTo5 = n / 5; n %= 5;
            //soTo2 = n / 2; n %= 2;
            //soTo1 = n;

            //Console.WriteLine("So to 100 la {0}, So to 50 la {1}, So to 20 la {2}," +
            //    " So to 10 la {3}, So to 5 la {4}, So to 2 la{5}, So to 1 la {6}",soTo100,soTo50,soTo20,soTo10,soTo5,soTo2,soTo1);
            //Console.ReadKey();



            //b6
            //Console.WriteLine("Nhap giay : ");
            //int n = int.Parse(Console.ReadLine());
            //int hours = n / 3600;
            //int minutes = (n % 3600) / 60;
            //int seconds = n % 60;
            //Console.WriteLine("{0} gio, {1} phut, {2} giay", hours, minutes, seconds);
            //Console.ReadKey();

            Console.WriteLine("Nhap giay : ");
            int n = int.Parse(Console.ReadLine());
            int minutes = n/ 60;
            int seconds = n% 60;
            int hours = minutes % 60;
            Console.WriteLine("{0} gio, {1} phut, {2} giay", hours, minutes, seconds);
            Console.ReadKey();
        }
    }
}
