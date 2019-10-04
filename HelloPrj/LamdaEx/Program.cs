using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaEx
{
    // 람다식 : 익명 메소드를 만들기 위해 사용하는 식
    // 람다식으로 만들어진 익명 메소드를 무명 함수(Annonymous Funciton)라고도 함.
    // C#2.0에서 익명메소드 지원. 처음엔 delegate 이용, 3.0부터 람다식 지원 => 이용

    /*
    람다식 선언 형식
    매개변수목록 => 식

    => 이 연산자를 입력 연산자라가 함.

    delegate int Aaa(int x, int y);

        static void Main(string[] args)
        {
            AAA aaa =(int x, int y) => x+y;
        }
        이름이 없는 메소드를 통해 AAA delegate에 값이 전달되고 있음
        위의 코드는 다음과 같이 바꿔서 사용 가능
            AAA aaa = (x, y) => x+y;
            매개 변수 타입 지정하지 않고도 바로 사용 가능
            delegate에 이미 타입이 지정되어 있기 때문

        위의 익명 메소드(무명함수)는 기존의 익명 메소드를 사용하던 것 보다 간소화 됨.
        delegate를 사용하던 방식으로 아래에 구현 해 보면?

        delegate int Aaa(int x, int y);

        static void Main(string[] args)
        {
            AAA aaa=delegate(int x, int y)
            {
                return x+y;
            };
        } 

    */

    class Program
    {
        delegate int Sum(int x, int y);

        static void Main(string[] args)
        {
            Sum sum = (x, y) => x + y;

            Console.WriteLine($"{sum(10, 20)}");
        }
    }
}
