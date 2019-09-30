using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 인터페이스?
// 예를 들면 컴퓨터와 모니터를 연결해주는 USB 역할 (접속 장치)
// 키워드 : interface 
// 다른 클래스와 연결해주는 중간부분 역할을 함

    // 인터페이스 선언
    // inter face 인터페이스 명
    // { 필드 말고 메소드만 정의
    // 반환형식 메소드명 (매개변수 있으면 적기);
    // }
    // 클래스와 비슷하나 인터페이스는 필드를 선언할수 없다.(이벤트, 메소드, 프로퍼티만을 멤버로 갖음)
    // 모든 멤버는 public 접근 권한으로 지정된다. (기본적으로 설정 되기 때문에 접근 제한자 사용할 수 없음)
    // 구현부가 없기 때문에 메소드를 블럭 {} 형식을 사용하지 않음(이름만 정의), 명세서 느낌
    // 구현부(몸통)가 없는 추상멤버를 갖음.
    // 클래스는 부모클래스가 1개인 반면, 여러개를 갖을 수 있음. 다중 상속 가능. 구조체, 클래스 모두 상속 받을 수 있음.
    // 다중 상속 가능. 다른 인터페이스를 상속 받을 수 있음.
    // 클래스에서도 인터페이스를 상속받을 수 있고, 구조체에서도 인터페이스를 상속 받을 수 있다.
    // 인스턴스 만들 수 없음.


namespace interfaceEx
{

    interface IMyInterfaceA
    {
        void output();
    }

    interface IMyInterfaceB
    {
        void output();
    }

    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            IMyInterfaceA iA = myClass;
            iA.output();

            IMyInterfaceB iB = myClass;
            iB.output();
        }

        void IMyInterfaceA.output()
        {
            Console.WriteLine("A인터페이스 output() 호출");
        }

        void IMyInterfaceB.output()
        {
            Console.WriteLine("B인터페이스 output() 호출");
        }
    }
}
