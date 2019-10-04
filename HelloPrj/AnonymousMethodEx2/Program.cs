using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodEx2
{
    // 익명 메소드 예제
    delegate int SelSort(int x, int y);

    class Program
    {

        static void BSort(int[] Array, SelSort ss)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < Array.Length - 1; i++)
            {
                for (j = 0; j < Array.Length - (i + 1); j++)
                {
                    if (ss(Array[j], Array[j + 1]) > 0)
                    {
                        temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 1, 10, 7 };

            Console.WriteLine("----------오름차순--------");
            BSort(array, delegate (int x, int y)
            {
                if (x > y)
                    return 1;
                else if (x == y)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

            Console.WriteLine("--------내림차순 정렬------");
            BSort(array, delegate (int x, int y)
            {
                if (x < y)
                    return 1;
                else if (x == y)
                    return 0;
                else
                    return -1;

            });
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}
