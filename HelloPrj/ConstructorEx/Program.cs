using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEx
{
    class Person
    {
        public Person() // 기본생성자. 구현 안해도 기본적으로 만들어 줌. 생성자의 이름은 클래스의 이름과 같음
        {
            name = "";
            gender = "";

        }

        public Person(string _name, string _gender) // 매개변수, 오버로딩한 것~~
        {
            name = _name;
            gender = _gender;

        }

        // 종료자 : 클래스의 이름에 ~를 붙여서 사용한다.
        // 생성자와 달리 한정자를 사용하지 않음. 매개변수도 없음. 그러니 오버로딩도 안됨
        // 직접 호출 할 수도 없음.why? CLR의 가비지 컬렉터가 객체가 소멸되는 시점을 판단해서 종료자를 호출
        // 하드웨어(보통 컴퓨터) 그 위에 운영체제(윈도우 등) 그 위에 프레임워크 (닷넷) 
        //그 위에 CLR(common language runtime) 어프리케이션 실행하게 해주는 실행환경
        // 운영체제는 직접 컴파일된 코드를 실행 할 수 없기 때문에 하드웨어가 인식할 수 있게 해주는 최적환경을 제공하는 것이 CLR
        // 가능하면 사용하지 않으면 좋음. 알아서 해주는데 굳이..

        // 빌드를 하면 컴파일된 파일을 만들어줌.하드웨어가 이해할 수 없기 때문에
        // 컴파일된 언어를 보통 중간언어 IL이라고 하는데 이 IL을 CLR이 읽어들이고 하드웨어가 인식할 수 있도록 변환작업을 해줌.
        // 컴파일된 코드를 컴터가 인식할 수 있는 네이티브 코드로 변환해주는 것이 CLR, 이러한 과정은 JIT이라 함.

        // 실행 시 이루어지기 때문에 실행때마다 컴파일에 대한 부담이 있을 수 있지만 어떠한 플랫폼에서도 최적화된 성능을 제공!
        ~Person()
        {
            // 포맷팅
            // C# 6.0문자열 보간(포맷팅)할 때 $ 기호 이용하여 표현할 수 있도록 하고 있음.
            Console.WriteLine("{0}님 다음에 봬요!", name);
            Console.WriteLine($"{name}님 다음에 봬요!!");
        }

        
        // 필드 속성
        public string name;
        public string gender;




        //메소드
        public void greet()
        {
            Console.WriteLine($"안녕하세요. 저는 {name}입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 생성자(Constructor) : 설계된 클래스의 객체를 생성하는 메소드와 같은 것
            // 생성자 형식 : 한정자 클래스명 (매개변수명)
            // {
            //          ~~
            // }

            // 클래스를 선언할 때 생성자를 구현하지 않았을 경우에는 컴파일러에서 기본생성자를 만들어준다.

            Person person = new Person(); //이게 가능한 이유는 기본 생성자를 만들어줬었기 때문
            person.name = "홍길동";
            person.gender = "남";

            Person person2 = new Person("홍길순", "여");

            
        }
    }
}
