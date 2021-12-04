using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool mistake = false;
                Equation equation = new Equation { };
                Console.WriteLine("Вас приветствует программа решения уравнения 0=kx+b.");
                Console.Write("Введите k = ");
                try
                {
                    equation.k = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    mistake = true;
                    Console.WriteLine("Не удалось прочитать число k.");
                }
                if (mistake == false)
                {
                    Console.Write("Введите b = ");
                    try
                    {
                        equation.b = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        mistake = true;
                        Console.WriteLine("Не удалось прочитать число b.");
                    }
                }
                if (mistake == false)
                {
                    equation.Root();
                }
                Console.WriteLine();
            }
        }
        struct Equation
        {
            public double k;
            public double b;
            public void Root()
            {
                if (k == 0 && b != 0)
                {
                    Console.WriteLine("Решений нет.");
                }
                else if (k == 0 && b == 0)
                {
                    Console.WriteLine("Бесконечное множество решений.");
                }
                else
                {
                    Console.WriteLine("x = -({1}/{2}) = {0}",-b / k,b,k);
                }
            }
        }
    }
}