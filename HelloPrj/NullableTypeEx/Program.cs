using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // NULL: 어떤 변수가 데이터를 가지고 있지 않을 때 표현방법
            // 즉, 메모리상에 어떠한 데이터도 갖고 있지 않을 때 사용하는 키워드

            // NULL을 가질 수 있는 데이터 타입이 있는데, 대표적으로 String타입 (refrence type)
            // null을 가질 수 없는 타입을 value type(보통 숫자 값을 의미함) (int, datetime...)이라고 함
            string str = null; //가능 int ab = null; 불가능

            // 정수(int)나 날짜(DateTime) 같은 Value Type은 일반적으로 null을 가질 수 없다.
            // Nullable 형식을 적용하면 정수같은 value ypte도 null 값을 가질 수 있음.
            // 즉, 값이 비어있는 nullable type의 변수를 선언할 수 있음.

            // nullable 선언할 때는 "?"을 이용.
            // 형식 : 데이터형식? 변수명;

            int a; // null 상태가 아님!!!! 선언만 한 상태임
            int? b = null;

            // null 초기화한 변수들, 값이 없이 비워둔 변수

            // nullable 타입은 hasvalue와 value 속성을 가지고 있음.
            // hasvalue란? 해당 변수가 값을 갖고 있는지 갖고 있지 않는 지 알려주는 속성
            // value속은 해당 value의 값을 알려주는 속성



            Console.WriteLine(str);
            Console.WriteLine(b);
            Console.WriteLine(b.HasValue); // 값이 없기 때문에 false 0과는 달라!!!
            Console.WriteLine(b != null); // 위와 같음
            //Console.WriteLine(b.Value); 오류
            //Console.ReadKey();
        }
    }
}
