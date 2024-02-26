using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double p;
            double S;

            while (true)
            {
                Console.WriteLine("Введите длины сторон треугольника:");

                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Некорректное значение для стороны a. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Некорректное значение для стороны b. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Некорректное значение для стороны c. Введите корректное значение.");
                    continue;
                }

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Console.WriteLine("Треугольник с такими сторонами не существует. Введите корректные значения.");
                    continue;
                }
                break;
            }

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Треугольник прямоугольный.");
                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площадь треугольника равна {S}.");
            }
            else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
            {
                Console.WriteLine("Треугольник тупоугольный.");
                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площадь треугольника равна {S}.");
            }
            else
            {
                Console.WriteLine("Треугольник остроугольный.");
                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площадь треугольника равна {S}.");             
            }
            Console.ReadKey();
        }
    }
}
