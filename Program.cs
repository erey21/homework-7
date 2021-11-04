using System;

namespace homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 7");

            Console.WriteLine("Введите первый операнд: ");
            int l_value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй операнд: ");
            int r_value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер операции: \n1. Сложение \n2. Вычитание \n3. Умножение \n4. Деление");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Сложение: ");
                    Console.WriteLine(l_value + r_value);
                    break;
                case 2:
                    Console.WriteLine("Вычитание: ");
                    Console.WriteLine(l_value - r_value);
                    break;
                case 3:
                    Console.WriteLine("Умножение: ");
                    Console.WriteLine(l_value * r_value);
                    break;
                case 4:
                    Console.WriteLine("Деление: ");
                    if (r_value == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя.");
                    }
                    else {
                        Console.WriteLine(l_value / r_value);
                    }
                    break;
                default:
                    Console.WriteLine("Операция не определена.");
                    break;
            }
        }
    }
}
