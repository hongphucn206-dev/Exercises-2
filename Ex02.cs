using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    internal class Ex02
    {
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
        }

        static void Bai1()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            Console.WriteLine(a + " % " + b + " = " + (a % b));
        }

        static void Bai2()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine("y = " + y + " => x = " + x);
            }
        }

        static void Bai3()
        {
            Console.Write("Nhap quang duong (km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Nhap gio: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            int s = int.Parse(Console.ReadLine());

            double timeHours = h + m / 60.0 + s / 3600.0;
            Console.WriteLine("Toc do km/h: " + (distance / timeHours));
            Console.WriteLine("Toc do miles/h: " + (distance / timeHours / 1.609));
        }

        static void Bai4()
        {
            Console.Write("Nhap ban kinh: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Surface = " + (4 * Math.PI * r * r));
            Console.WriteLine("Volume = " + (4.0 / 3 * Math.PI * r * r * r));
        }

        static void Bai5()
        {
            Console.Write("Nhap mot ki tu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("Nguyen am");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine("Chu so");
            }
            else
            {
                Console.WriteLine("Ky tu khac");
            }
        }
    }
}
