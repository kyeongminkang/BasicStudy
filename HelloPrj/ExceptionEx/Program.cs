using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외처리 (Exception Handling)

    // 예기치 않는 상황에서 프로그램이 종료 처리가 되지 않도록 하게 하는 것!

    /*
     * 예외처리구문
     * try
     * {
     *  // 실행코드
     * }
     * catch (Exception 객체1)
     * {
     *  // 예외가 발생했을 때 처리 코드 
     * }
     * catch (Exception 객체2)
     * {
     *  // 예외가 발생했을 때 처리 코드
     * }
     * 
     * 다른 예외상황 발생했을 경우? 최상위 객체를 사용할 수 있음.
     * 
     */ 
namespace ExceptionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열 크기 over 경우!
            int[] array = { 1, 2, 3, 4 };

            try
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(array[i]);
                }

            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine($"오류가 발생했습니다 : {e.Message}");
            } 

            // 인덱스 배열 범위가 벗어난 오류가 IndexOutofrangeException(객체)에 던지고,
            // 그 객체는 Main에 던지고, Main이 CLR에 던져서 에러메시지 출력을 시킴

            Console.WriteLine("프로그램 종료!!");
        }
    }
}
