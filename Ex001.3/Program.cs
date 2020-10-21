using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001._3
{
    class Program
    {
        // Написать программу обмена значений двех переменных:
        // а) с использованием третьей переменной;
        // б) *без использования третьей переменной;
        // Автор: Даров Муаед

        static void Main(string[] args)
        {
            int a = 1; int b = 2;
            Console.WriteLine($"a = {a}, b = {b}");
            //int c = a;
            //a = b;
            //b = c;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadKey();

        }
    }
}
