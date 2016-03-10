using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1409
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите два целых числа, количество сбитых бутылок:");
            string test = Console.ReadLine();
            string[] splitString = test.Split(' ');
            int[] ints = new int[2];
            for (int i = 0; i < 2; i++)
            {
                int x;
                int.TryParse(splitString[i], out x);
                ints[i] = x;
            }
            a = ints[0];
            b = ints[1];
            c = a + b - 1;
            Console.WriteLine((c - a) + " " + (c - b));
        }
    }
}
