using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework23
{
    // Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
    class Program
    {
        static int GetFactorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
                factorial *= i;
            return factorial;
        }

        static async Task<int> GetFactorialAsync(int n)
        {
            Console.WriteLine($"Факториал числа {n} вычисляется.");
            int Result = await Task.Run(() => GetFactorial(n));
            Console.WriteLine($"Расчет окончен.");
            return Result;
        }

        static void Main(string[] args)
        {
            int result = GetFactorialAsync(10).Result;
            Console.WriteLine(result); ;
            Console.ReadKey();
        }
    }
}
