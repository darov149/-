using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001._4
{
    class Program
    {
        // а) Написать программу которая выводит на экран Вашу фамилию, имя и город проживания;
        // б) *Сделать задание, только вывод написать посередине экрана;
        // в) *Сделать задание б с использованием собсвенных методов;
        // Автор: Даров Муаед

        static void Print(string[] msg, int x, int y)
        {
            // Установим позицию курсора на экране

            for (int i = 0; i < msg.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(msg[i]);
            }

        }

        static void Main(string[] args)
        {
            string[] info = { "Muaed", "Darov", "Moscow" };


            Print(info, 50, 13);

            Console.ReadKey();
        }
    }
}
