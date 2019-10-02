using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx3
{
    // Delegate의 사용 이유
    // 예를 들어 정렬이 하고 싶다고 가정!
    // 정렬 알고리즘 이용할 떄, 오름 내림 차순 설정방법이 있는데 
    // 보통 if문을 2개 사용해 코드를 일일히 사용하여 코드가 번잡하기 때문에 이를 해소하기 위함!
    delegate int SelSort(int a, int b);

    class Program
    {

        static int Ascenging(int a, int b)
        {
            if (a > b)
                return 1; // 참
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int Descending (int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        // 버블 정렬 알고리즘
        // 원래 매개변수 int[] Array1
        static void BSort(int[] Array1, SelSort Ss)
        {
            int i = 0; // 이중for문
            int j = 0;
            int temp = 0; // 자리바꿈

            for (i=0; i<Array1.Length-1; i++)
            {
                for (j=0; j<Array1.Length-(i+1); j++)
                {
                    // 오른차순
                    //if(Array1[j] > Array1[j + 1])

                    if(Ss(Array1[j], Array1[j+1]) > 0)
                    {
                        temp = Array1[j];
                        Array1[j] = Array1[j + 1];
                        Array1[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            int[] Array = { 22, 11, 55, 3, 9 , 17};
            Console.WriteLine("오른차순 정렬");
            //BSort(Array);
            BSort(Array, new SelSort(Ascenging));

            for (int i= 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("내림차순 정렬");
            int[] array2 = { 100, 201, 109, 34 };
            BSort(array2, new SelSort(Descending));

            for (int i=0; i<array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
            Console.WriteLine();
        }
    }
}
