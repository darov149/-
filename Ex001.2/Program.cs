using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001._2
{
    class Program
    {
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
        //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
        //Автор: Даров Муаед


        

        static void Main(string[] args)
        {

            Console.WriteLine("x1 = "); double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Distance(x1, y1, x2, y2);
            Console.WriteLine($" r = {r}");
            Console.WriteLine($" r = {r.ToString("#,##")}");

            Console.ReadKey();
        }

        private static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
