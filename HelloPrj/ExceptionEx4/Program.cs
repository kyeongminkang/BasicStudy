using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx4
{
    // try~catch finally
    // try문 안에서 예외가 발생하면 catch가 받음. try 안에 A B C 코드가 있을 경우, B코드에서 예외가 생기면 C코드는 실행을 안함.
    // 그런데 만약 C코드가 반드시 실행되어야 한다면 finally가 필요.
    // 반드시 실행되어야 하는 코드가 필요한 경우는 보통 Database(connection을 종료해주어야 다른 어플리케이션들이 컨넥션 부족으로 접속 못하는 상황을 방지할 수 있음),
    // 시스템자원을 사용할 경우(반납을 해야하므로 why? 다른 프로그램이 접근못함)

    // finally 절은 에외가 발생하더라도 반드시 실행되는 절.
    // N을 0으로 나눌경우 필요!
    class Program
    {
        static int diveMethod(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("나누기 예외 발생");
                throw ex;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("a/b 수식에서 a의 값을 입력 : ");
                string aa = Console.ReadLine();
                int a = Convert.ToInt32(aa);

                Console.Write("a/b 수식에서 b의 값을 입력 : ");
                string bb = Console.ReadLine();
                int b = Convert.ToInt32(bb);

                Console.Write($"{a}/{b} = {diveMethod(a, b)}");
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("에러 : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");
            }
        }
    }
}
