using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterEX
{
    class Program
    {
        static void Main(string[] args)
        {
            // 매개변수

            //int a = 100;
            //int b = 200;

            //Console.WriteLine(Multiply(a,b));
            // 메소드 호출 시, 매개변수 x,y는 a,b에 값을 복사해옴. 다른 메모리 공간을 사용중임. 
            // 따라서 a를 다른 곳에서 값 변경 하더라도 x의 값은 변하지 않음??? 뭔 소리야

            int aa = 100;
            int bb = 111;

            //aa = bb;
            //bb = aa;

            // 당연히 안 바뀜

            // 데이터 교환법
            //int temp = aa;
            //aa = bb;
            //bb = temp;

            Console.WriteLine(aa);
            Console.WriteLine(bb);

            //Swap(aa, bb); // 데이터 안 바뀜. 메모리는 바뀌었겠지만

            Swap(ref aa, ref bb);

            Console.WriteLine(aa);
            Console.WriteLine(bb);
        }

        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}

        // 참조에 의한 매개변수 전달
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        // ref는 데이터 위치를 가르키기 때문에 값을 가져옴


        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
