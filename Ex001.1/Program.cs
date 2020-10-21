using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
            // где m — масса тела в килограммах, h — рост в метрах. 
            // Автор: Даров Муаед 

            Console.Write("Вас приветствует программа для рассчёта ИМТ." +
                Environment.NewLine + "Введите вес человека в кг: ");
            double mass = double.Parse(Console.ReadLine());

            Console.Write("Введите рост человека в см: ");
            double heigth = double.Parse(Console.ReadLine());

            heigth /= 100;

            Console.Write(Environment.NewLine + "Индекс массы тела: ");
            double BMI = mass / (heigth * heigth);
            Console.WriteLine("{0:0.##}", BMI);

            Console.ReadKey();


        }
    }
}
