using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodEx
{
    // 익명메소드 : 이름이 없는 메소드
    // 보통의 메소드는 한정자 반환형식 메소드명(매개변수){ ... }

     /*
      선언형식 (대리자 형식과 동일한 형식을 취해야 함 이름만 없을 뿐!)
      delegate 인스턴스 = delegate(매개변수)
                        {
                            실행코드....
                        };
      */
      
        // 익명메소드의 경우 다음에 사용하지 않을 것 같을 경우에 사용


    // 델리게이트 클래스 안에 선언해도 됨.
    delegate int CalDelegate(int x, int y);

    class Program
    {

        static void Main(string[] args)
        {
            CalDelegate cd;
            cd = delegate (int x, int y)
            {
                return x + y;
            }; // 얘가 익명메소드

            Console.WriteLine($"{cd(10, 20)}");
        }
    }
}
