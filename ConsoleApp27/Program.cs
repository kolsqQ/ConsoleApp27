using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCalculateDiscount(0, 1);
            TestCalculateDiscount(100, 3);
            TestCalculateDiscount(200, 5);
            TestCalculateDiscount(500, 10);


            Console.WriteLine("\nТест завершен");
            Console.ReadKey();
        }

        static int CalculateDiscount(int points)
        {
            if (points < 100)
                return 1;
            else if (points < 200)
                return 3;
            else if (points < 500)
                return 5;
            else
                return 10;
        }

        static void TestCalculateDiscount(int input, int expected)
        {
            int result = CalculateDiscount(input);
            if (result == expected)
            {
                Console.WriteLine($"[Все четко(passed)] баллы: {input} => скидка : {result}%");
            }
            else
            {
                Console.WriteLine($"[Анлак(failed)] баллы: {input} => Получил: {result}%, Ожидал: {expected}%");
            }
        }
    }
}
    

