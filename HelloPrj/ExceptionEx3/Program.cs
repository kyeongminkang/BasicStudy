using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx3
{
    // 7.0에서 thorw문 표현식(expression)
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int? aa = null;
                int bb = aa ?? throw new AggregateException();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // 위는 메시지를 출력해주므로 프로그램이 종료되는 상황은 아님

            try
            {
                int[] arr = { 11, 22, 33, 44 };
                int idx = 5;
                // 조건연산자
                int value = arr[idx >= 0 && idx <4 ? idx : throw new IndexOutOfRangeException()];
                Console.WriteLine(value); // idx가 3일 경우, 44 출력
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
