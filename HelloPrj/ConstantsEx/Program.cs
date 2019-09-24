using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsEx
{
    class Program
    {
        //enum City { Seoul, Incheon, Daegu, Daejeon }
        enum City { Seoul = 02, Incheon = 032, Daegu, Daejeon }
        // 직접 값을 넣는 것도 가능하며, 대구 대전은 33, 34가 나옴 (인천 뒤로 알아서 1씩 붙임)
       
        static void Main(string[] args)
        {
            // 변수 : 담고 있는 데이터를 얼마든지 변경할 수 있는 메모리 공간
            // 상수 : 담고 있는 데이터를 절대 바꿀 수 없는 메모리 공간

            // 상수는 const라는 키워드를 사용.
            // 선언 형식 ;  const type명 상수명;

            const int AAA = 10000;
            Console.WriteLine(AAA);

            // AAA = 300; 에러

            // 상수 많이 사용할 경우의 문제점?
            // 수백 개가 되어버리면 상수를 정할 때 헷갈릴 수 있음.
            // 의미가 반대인 변수에 같읕 값을 준다던가 하는...
            // 이런 실수를 줄이기 위해 탄생한 것이 enum

            // enum은 열거형 상수(constarnt)를 표현하기 위한 것
            // 선언형식 : enum 열거형식명 : 자료형 {상수1, 상수2, ....}
            // 위에서 자료형은 정수형 자료형만 사용됨
            // 정수형 자료형이란(byte, sbyte, shourt, int, long, ulog char......)
            // 자료형을 생략해서 사용하는 경우가 많은데 이 경우에는 int로 설정

            // enum City {seoutl. incheon, daegu} 그런 경우 seoul = 0, incheon = 1, daegu = 2가 됨
            // 열거형식 안에 선언된 상수들이 어떤 값도 할당되지 않았을 경우에는 
            // 첫번째 상수에는 0이 할당. 그리고 그 다음 요소에는 1, 그 다음은 2(1씩 증가시켜서 컴파일러가 자동으로 할당)


            // 상수 위에 선언해줘야함(메인 위)
            Console.WriteLine(City.Seoul); // enum명 적어줘야 함! 숫자값이 아닌 그대로 나옴

            Console.WriteLine((int)City.Seoul); // 숫자값 알고싶을 때 형변환 하면 자동 할당된 번호 알게됨
            // 서로다른 중복되지 않은 값을 갖을 수 있다는 것에 의의!

            City sel = City.Seoul;
            Console.WriteLine(sel == City.Seoul); // 상수 이용하여 변수애 대입가능함
            Console.WriteLine(sel == City.Daejeon);
        }
    }
}
