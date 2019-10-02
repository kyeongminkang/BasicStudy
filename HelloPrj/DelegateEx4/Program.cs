using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx4
{
    // 델리게이트의 선언
    delegate int CalDelegate(int x, int y);

    class Program
    {

        static int Add (int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }

        public static void Calc(int x, int y, CalDelegate cd)
        {
            Console.WriteLine(cd(x, y));
        }

        static void Main(string[] args)
        {
            //CalDelegate Plus = new CalDelegate(Add);
            //CalDelegate Minus = new CalDelegate(Sub);
            // 위도 가능하지만 간단하게도 가능

            CalDelegate Plus = Add;
            CalDelegate Minus = Sub;

            Calc(11, 22, Plus);
            Calc(22, 11, Minus);

            // 콜백 ? A B C 관계에서 A가 B에게 전달을 요청 - C에게 연락해달라고.
            // 그래서 C가 A에게 연락을 했을 때가 콜백을 한다고 함. B가 중간자 역할을 함.
            
            // cal을 호출하면 plus가 아닌 add 호출하여 plus값(콜백된 것)을 가져옴!


        }
    }
}
