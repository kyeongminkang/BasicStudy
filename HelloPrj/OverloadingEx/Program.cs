using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 메소드 오버로딩 : 하나의 메소드 이름으로 여러개의 기능을 구현할 수 있게 함
            // 메소드명을 똑같이 정의 할 순 있지만 매개변수는 달라야함(개수, 타입)
            // 반환값이 다르다고 하더라도 void, int 매개변수는 달라야함!

            // 오버라이딩은 메소드 안에 식을 바꾸는 것! 

            int a = Sum(1, 2);
            int b = Sum(1, 2, 3);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static int Sum(int i, int j)
        {
            Console.WriteLine("Sum(int i, int j)");
            return i + j;


        }

        static int Sum(int i, int j, int k)
        {
            Console.WriteLine("Sum(int i, int j, int k)");
            return i + j + k;
        }
    }
}
