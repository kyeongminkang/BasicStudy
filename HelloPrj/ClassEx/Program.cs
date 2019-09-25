using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // oop : 객체를 기반으로 하는 프로그래밍
            // obejct oriented programing
            // 객체? 이 세상 모든 것! 객체를 나타내는 속성!
            // 예시 : 사람이라는 객체. 사람의 특성인 이름, 나이, 성별로 표현하는데, 이러한 것들을 속성이라 함. 즉 필드
            // 그 사람이 할 수 있는 것 말하거나 먹거나 이러한 기능같은 것들을 메소드라고 함.

            // 클래스란? 객체를 모델링. 설계도와도 같음. 객체화함.
            // 붕어빵틀이 붕어빵을 만들듯이 틀이 있음 붕어빵 만들 수 있음. 여기에서 틀이 클래스
            // 기본적으로 앞글자가 대문자. 
            // 프로그램 실행하기 위해선 메모리에 올려야함.메모리에 올리는 것을 객체화한다. 인스턴스화한다고 함.
            // 메모리에 올리기 위해서는 new라는연산자를 이용해야함.

            Person person = new Person(); // 객체화 그 이름은 person이라 하고 타입은 Person class인것!
            // int a 에서 int 사실 또한 클래스, a가 객체가 되는 것.
            // person은 인스턴스 명 Person이라는 설계도가 있기 때문에 여러개 만들 수 있으며
            // person과 person1은 당연히 다름
            Person person1 = new Person();

            person.name = "홍길동";
            person.greet();

            person1.name = "홍길순";
            person1.greet();

        }
    }

    class Person
    {
        public string name; // 속성, 데이터
        public string gender;

        public void greet() // 기능, Method
        {
            Console.WriteLine($"안녕하세요. 저는 {name}입니다.");
        }
    }
}
