using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx2
{
    // 델리게이트의 선언
    delegate int MyDelegete(int a, int b);

    class SumSubtract
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // static 상관없이 넘기기 가능! 메소드가 메모리 어딘가에 저장돼 있다는 뜻
        // 즉, 해당 메모리 참조한 주소값을 전달하고 있음
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SumSubtract ss = new SumSubtract();
            MyDelegete md = new MyDelegete(ss.Sum);
            // 호출아닌 이름만 넘기면 됨
            Console.WriteLine(md(1, 2));

            // static은 클래스 소속이기 때문에 ss안됨. 클래스 이름을 적어줄 것!
            md = new MyDelegete(SumSubtract.Subtract);
            Console.WriteLine(md(10, 3));
        }
    }
}
