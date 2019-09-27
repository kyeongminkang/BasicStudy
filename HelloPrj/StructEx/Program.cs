using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StructEx
{
    // 구조체 : 클래스와 거의 비슷하나 Value타입을 만듦
    // C#에서는 struct를 사용하면 value타입을 만들고 class 사용하면 ref 타입을 만듦.
    // int, double, float, bool과 같은 기본 (primitive Type)타입은 struct로 정의된 value타입이었음.
    // value타입은 상속할 수 없음.
    // 주로 간단한 데이터 값을 저장하는 데 사용.

    // ref Type은 class로 정의해서 만들고 상속이 가능하고 좀 더 복잡한 데이터와 기능들을 정의하는 곳에 많이 사용됨.

    // 구조체 : struct라는 키워드를 이용해서 정의.
    //      클래스와 같이 메소드, 속성(프로퍼티) 등 거의 비슷한 구조를 가지고 있음.
    //      하지만 상속 할 수 없음. 인터페이스 구현은 가능

        // 구조체는 클래스와 달리 복사 시 DeepCopy가 됨.


    // 구조체 정의
    struct Mypoint
    {
        public int x;
        public int y;

        // 기본 생성자(매개 변수가 없음)는 선언할 수 없음.
        public Mypoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 모든 구조체는 system.Object 형식을 상속하는 System.ValueType으로부터 직접 상속받음.

        public override string ToString()
        {
            return string.Format($"{x}, {y}");
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Mypoint mypoint;
            // 생산자 호출하지 않고(new 없이)도 인스턴스 만들 수 있음.
            mypoint.x = 100;
            mypoint.y = 100;
            Console.WriteLine(mypoint.ToString());

            // 생성자 이용
            Mypoint mypoint2 = new Mypoint(1000, 1000);
            Mypoint mypoint3 = mypoint2; // 복사
            mypoint3.y = 1001;

            Console.WriteLine(mypoint2.ToString());
            Console.WriteLine(mypoint3.ToString());
            // 원래 객체복사 시에 클래스 경우 같은 값이 나오지만 
            // 구조체는 복사 시 깊은 복사가 이루어 져서 값이 복사 돼서 다른 값이 나옴


        }
    }
}
