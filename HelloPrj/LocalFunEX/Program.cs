using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunEX
{
    class Program
    {
        static string ToLowerStr(string input)
        {
                            // 함수라 하지만 사실 object 객체 안에 있는 메소드!
            var arr = input.ToCharArray();

            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
                            //얘가 바로 로컬함수!
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i]+32);
            }

            // 새로운 문자열로 만들어 뿌림
            return new string(arr);
        }

        static void Main(string[] args)
        {
            // var 키워드 : 데이터 값에 따라 자동으로 데이터 형식을 지정
            // 데이터 형식을 알아서 C# 컴파일러기 자정함.
            // 반드시 선언 뿐만 아니라 초기화 해야지 사용할 수 있음.
            // ex) var a; 안됨!

            var a = "Hello";
            Console.WriteLine(a.GetType());

            var aa = 100;
            Console.WriteLine(aa.GetType());

            //로컬 함수 : 메소드 안에서 선언된 특별 함수, 메소드 안에 선언되었기
            //          때문에 클래스 멤버가 아님. 따라서 함수라고 칭함.
            // 메인과 같은 기존의 메소드는 클래스의 멤버로서 함수는 모두 메소드라고 함.
            // 클래스 안에 있는 함수는 모두 메소드!
            // 하지만 로컬함수는 특별히 함수라 함.


            Console.WriteLine(ToLowerStr("GOOD"));
            Console.WriteLine(ToLowerStr("MORNING"));
        }
    }
}
