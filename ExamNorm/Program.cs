using System;

namespace ExamNorm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagMinute = false, flagHour = false;
            int hour =0, minute=0;
            while (!flagHour) {
                Console.WriteLine("Введите часы от 1 до 12 (Например: 4)");
                var hourString = Console.ReadLine();
                if (int.TryParse(hourString, out int temp))
                {
                    if (temp >= 1 && temp <= 12)
                    {
                        flagHour = true;
                        hour = temp;
                    }
                }
            }

            while (!flagMinute)
            {
                Console.WriteLine("Введите минуты от 0 до 59 (Например: 42)");
                var minuteString = Console.ReadLine();
                if (int.TryParse(minuteString, out int temp))
                {
                    if (temp >= 0
                        && temp <= 59)
                    {
                        flagMinute = true;
                        minute = temp;
                    }
                }
            }

            CalculateTime calculateTime = new CalculateTime(hour, minute);
            Console.WriteLine($"Между ними разница в {calculateTime.CalculateDegreesMain()} градусов");
            Console.ReadKey();
        }
    }
}
