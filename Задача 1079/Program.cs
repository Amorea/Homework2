using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            //Считываю числа в массив arr и нахожу из них максимальное
            Console.WriteLine("Введите не более десяти целых чисел, окончание ввода ознаменуйте \"0\".");
            int[] arr = new int[11];
            string s = "Mmm";
            int i, maxi;
            maxi = 0;
            for (i = 0; s != "0"; i++)
            {
                s = (Console.ReadLine());
                arr[i] = Convert.ToInt32(s);
                if (arr[i] > maxi) maxi = arr[i];
            }
            //i - то сколько у нас всего чисел
            i = i - 1;
            //записываю значения членов последовательности в массив а длинной в максимальное число+1
            int[] a = new int[maxi + 1];
            a[0] = 0;
            a[1] = 1;
            for (int j = 2; j <= maxi; j++)
            {
                a[j] = a[j / 2] + (j % 2) * a[j / 2 + 1];
            }
            //для каждого члена последовательности нахожу максимальный член что был до него изаписываю в массив max
            int[] max = new int[maxi+1];
            max[0] = 0;
            for (int z = 1; z <= maxi; z++) 
            {
                if (max[z - 1] < a[z]) max[z] = a[z];
                else max[z] = max[z - 1];
            }
            //Ввывод
            for (int j = 0; j < i; j++) Console.WriteLine(max[arr[j]]);
        }
    }
}
