using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double x = 0, y = 0, z = 0, r;
            bool result = false;
            while (result == false)
            {
                Console.Write("Введіть дробове значення x = ");
                result = double.TryParse(Console.ReadLine(), out x);
                if(result == false)
                    Console.WriteLine(" Помилка введення значення х. Повторіть введення значення ще раз!");
            }
            result = false;
            while (result == false)
            {
                Console.Write("Введіть дробове значення y = ");
                result = double.TryParse(Console.ReadLine(), out y);
                if (result == false)
                    Console.WriteLine(" Помилка введення значення y. Повторіть введення значення ще раз!");
            }
            result = false;
            while (result == false)
            {
                Console.Write("Введіть дробове значення z = ");
                result = double.TryParse(Console.ReadLine(), out z);
                if (result == false)
                    Console.WriteLine(" Помилка введення значення z. Повторіть введення значення ще раз!");
            }
            r = (Math.Pow(y, x + 1)) / (Math.Pow(Math.Abs(y - 2), 1.0 / 3) + 3) + (x + y / 2) / (2 * Math.Abs(x + y)) * Math.Pow((x + 1), -1 / Math.Sin(z));
            string res = string.Format("{0:f3}", r);
            Console.WriteLine("Результат очислення: r = " + res);
        }
    }
}
