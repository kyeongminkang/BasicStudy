using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorEx
{
    // ? : Nullable 타입을 선언할 때 사용하는 연산자

    // ?? 널 병합 연산자 : a ?? 100
    // a가 null이면 100, null이 아니면 a 그대로
    // 왼쪽의 피 연산자가 null인지 체크하고, null인 경우에는 오른쪽 피연산자를 리턴
    // null이 아니면 왼쪽 피연산자를 그대로 리턴함.
    class Program
    {
        static void Main(string[] args)
        {
            //int? a = null;
            // ? 를 통해 값 형식에도 null값을 넣게 해줌.

            int? bb = null;
            Console.WriteLine($"{bb ?? 10}");

            bb = 12;
            Console.WriteLine($"{bb ?? 10}");

            string str = null;
            // 얜 원래 null 가질 수 있음
            Console.WriteLine($"{str ?? "null값입니다."}");

            str = "안녕?";
            Console.WriteLine($"{str ?? "null값입니다."}");
        }
    }
}
