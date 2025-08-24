using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Program
    {
        static void Main()
        {
            

            CelsiusConvert();   // Bai1
            Sphere();           // Bai2
            Operators();        // Bai3
        }

        static void CelsiusConvert()
        {
           
            Console.Write("Nhap nhiet do (°C): ");
            double c = double.Parse(Console.ReadLine());
            double kelvin = c + 273;
            double fahrenheit = c * 18 / 10 + 32;
            Console.WriteLine("kelvin= " + kelvin);
            Console.WriteLine("fahrenheit= " + fahrenheit);
        }

        static void Sphere()
        {
            
            Console.Write("Nhap ban kinh: ");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volume = 4.0 / 3 * Math.PI * r * r * r;
            Console.WriteLine("Surface: " + surface);
            Console.WriteLine("Volume: " + volume);
        }

        static void Operators()
        {
            
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " x " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            Console.WriteLine(a + " mod " + b + " = " + (a % b));
        }
    }
}
