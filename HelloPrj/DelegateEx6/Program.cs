using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx6
{
    // 델리게이트 체인
    // 여러개를 참조해서 넘겨줄 수 있음(동시에 넘겨줄 수 있다는 뜻과 비슷)
    // 사실 연결 돼 있어서 동시보다는 한꺼번에 넘겨주는 개념

    //Delegate 체인: 델리게이트 하나가 여러개의 메소드를 동시에 참조하는 것

    delegate void CalDelegate(int x, int y);

    class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Main(string[] args)
        {
            //CalDelegate cd = Add;
            //cd += Sub;
            //cd += Multiply;
            //cd += Divide;
            //// 연결해줌!
            //cd -= Multiply;
            //// 빼줌

            //CalDelegate cd = new CalDelegate (Add)
            //    + Sub
            //    + Multiply
            //    + Divide;

            CalDelegate cd = (CalDelegate)Delegate.Combine(
                new CalDelegate(Add), 
                new CalDelegate(Sub),
                new CalDelegate(Multiply),
                new CalDelegate(Divide)
                );

            cd(10, 5);
            
            
        }
    }
}
