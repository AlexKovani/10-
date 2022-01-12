using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Corner
    {
        int gradus;
        int min;
        int sec;
        public int Gradus 
        {
            get
            {
                return gradus;
            }

            set
            {
                if (value<0)
                {
                   value = 0;
                }
                else
                {
                    gradus = value;
                    
                }  
            }      
        }

        public int Min // угловые минуты
        {
            get
            {
                return min;
            }

            set
            {
                if (value < 0)
                {

                    Console.WriteLine("Введите положительное значение!");
                    value = 0;
                }
                else
                {
                   
                            Gradus += value / 60;
                            min = value % 60;
                }
            }

        }

        public int Sec  // угловые секунд
        {
            get
            {
                return sec;
            }

            set
            {
                if (value < 0)
                {

                    Console.WriteLine("Введите положительное значение!");
                    value = 0;
                }
                else
                {
                    
                            Min += value / 60;
                            sec = value % 60;
                            Console.WriteLine("{0}° = {1} оборот и {2}°", Gradus, Gradus / 360, Gradus % 360);
                        
                }
            }

        }

        public Corner(int gradus, int min =0, int sec =0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            if (gradus<0 || min<0|| sec<0)
            {
                Console.WriteLine("Введите положительное значение!");
            }
            else
            {
                double x = gradus * Math.PI / 180 + min * Math.PI / (180 * 60) + sec * Math.PI / (180 * 60 * 60);
                Console.WriteLine("{0}° = {1} радиан", Gradus, Math.Round(x, 4));
            }
            
        }
    }
}
