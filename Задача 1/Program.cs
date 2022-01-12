using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1

   //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
   //Реализовать класс, в котором указанные значения представлены в виде свойств.
   //Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки начальных значений,
   //а также метод ToRadians для перевода угла в радианы.Создать объект на основе разработанного класса.
   //Осуществить использование объекта в программе.
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение угла в градусах: ");
                int gradus = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение минут: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение секунд: ");
                int sec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Corner one = new Corner(gradus, min, sec);
                one.ToRadians();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
            
            Console.ReadKey();
        }
    }
}
