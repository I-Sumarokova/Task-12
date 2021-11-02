using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки х, y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double r1, l, s;

            if (r >= 0)
            {
                Okr.LenghtCircle(r, out l);
                Okr.AreaCircle(r, out s);
                Okr.FindPoint(x, y, r, out r1);
            }
            else
            {
                Console.WriteLine("Радиус не может быть отрицательным");
            }

            Console.ReadKey();
        }
        static class Okr
        {
            static double r { get; set; }
            static double x { get; set; }
            static double y { get; set; }

            public static void LenghtCircle(double r, out double l)
            {
                l = 2 * r * Math.PI;
                Console.WriteLine("Длина окружности равна L= {0:F2}", l);
            }

            public static void AreaCircle(double r, out double s)
            {
                s = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Площадь круга равна S= {0:F2}", s);
            }

            public static void FindPoint(double x, double y, double r, out double r1)
            {
                r1 = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (r1 <= r)
                {
                    Console.WriteLine("Точка с координатами x = {0}, y = {1} принадлежит кругу", x, y);
                }
                else
                {
                    Console.WriteLine("Точка с координатами x = {0}, y = {1} не принадлежит кругу", x, y);
                }
            }

        }

    }
}
