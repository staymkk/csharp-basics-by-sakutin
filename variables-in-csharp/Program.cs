using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Основные типы int | float | char | string | bool
            // Целочисленные типы
            byte b;
            sbyte sb;
            short s;
            ushort us;
            int i;
            uint ui;
            long l = long.MaxValue;
            ulong ul;
            // Числа с плавающей точкой
            float f = 5.7f;
            double d = 5.7;
            // Символьный тип
            char c = ' ';
            // Строковый тип
            string st = "Привет!";
            // Логический тип
            bool bl = true;

            // + - * / %
            float result;

            int x, y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);

            int timeInMinutes = 130;
            int hour;
            int minute;

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;

            Console.WriteLine("hours: " + hour);
            Console.WriteLine("minutes: " + minute);
        }
    }
}
