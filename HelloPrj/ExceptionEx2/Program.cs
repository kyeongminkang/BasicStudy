using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// system.Exception 클래스는 모든 Exception의 Base 클래스임.
// 모든 예외상황을 catch할 수 있음

// 앞서 사용한 IndexOutofRangeException 예외 클래스도 System.Exception으로부터 파생된 것
// System.Exception을 이용해서 모든 예외상황을 처리하지 않는 이유?
// 개발자가 예상하지 못했던 예외를 처리할 수는 있지만
// 처리하지 않아야할 예외상황도 처리할 수도 있기 때문(오히려 오류발생 시킬 수 있음)

//throw 문

//    try {
//       thorow new Exception("예외를 던짐");
//  }
//   catch (Exception e) 
//  {
//Console.WriteLine(e.Message);
//}
namespace ExceptionEx2
{

    class Program
    {
        static void throwMethod(int aa)
        {
            if (aa < 5)
                Console.WriteLine($"{aa}");
            else
            {
                throw new Exception("aa는 5이상의 값이다");
            }
    }
        static void Main(string[] args)
        {
            try { 
            throwMethod(1);
            throwMethod(2);
            throwMethod(3);
            throwMethod(4);
            throwMethod(5);
            throwMethod(6); // 얘는 수행되지 않음
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
