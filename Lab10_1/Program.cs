using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(0, 0, 0);
            try
            {
                Console.WriteLine("Для перевода угла в радианы введите значения угла. \nВведите целочисленное значение градуса угла от 0 до 360:");
                angle.Gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты угла от 0 до 60:");
                angle.Min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите секунды угла от 0 до 60:");
                angle.Sec = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Неверный формат ввода значения.");
                Console.ReadKey();
                return;
            }
            
            angle.ToRadians();
            Console.ReadKey();

        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение угла должно быть от 0 до 360");
                    Console.ReadKey();
                    Environment.Exit(0);
                    
                }
            }
            get
            {
                return gradus;
            }
                        
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение угловых минут должно быть от 0 до 60");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение угловых секунд должно быть от 0 до 60");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            get
            {
                return sec;
            }
                
            
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            double radian = (gradus + (min + (double)sec / 60) / 60) * Math.PI / 180;
            Console.WriteLine("{0} рад", radian);
        }

    }
    
    
    
        
}

    





