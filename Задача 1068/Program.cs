using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1068
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) Console.WriteLine(((1 + n) * n) / 2);
            else Console.WriteLine(-((2 - n) * (-n - 1)) / 2);
        }
    }
}
