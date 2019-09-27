using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConversionEx
{
    // 상속관계의 클래스 사이에서의 형변환

    class Human
    {
        public void showInfo()
        {
            Console.WriteLine("Human");
        }
    }

    class Programer : Human
    {
        public void programing()
        {
            Console.WriteLine("프로그래밍 하는 개발자");
        }
    }

    class Designer : Human
    {
        public void design()
        {
            Console.WriteLine("디자인하는 디자이너");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.showInfo();

            //Programer programer = new Programer();
            //programer.showInfo();
            //programer.programing();

            //Designer designer = new Designer();
            //designer.showInfo();
            //designer.design();

            human = new Programer();
            human.showInfo();
            // progrmaing은 호출이 안됨. 

            Programer programer = (Programer)human;
            programer.showInfo();
            programer.programing();
            // human을 상속받았기 때문에 human객체가 될 수 있음

            human = new Designer();
            human.showInfo();

            Designer designer = (Designer)human;
            designer.showInfo();
            designer.design();

            // human은 상속받은 programer와 deginer 객체는 서로간 형변환이 가능함
            // 즉 파생클래스의 인스턴스는 부모 클래스의 인스턴스로 사용될 수 있음
            // 이러한 것을 가능할 수 있도록 한 이유는 각각 오버로딩 하지 않고 하나의 부모 클래스만 오버로딩(매개변수에)해주면
            // humna안에 있는 각 객체(클래스)별로 매개변수 처리 안해줘도 되기 때문에
            // 예시로 Teacher class가 있고 그 안에 Teach 메소드가 있을 경우
            // Teacher는 Designer와 Programer 모두를 Teach할 수 있는데
            // 각각 Teach(Deginer deginer), Teach(Progremer programer)하는 것 보다 
            // 한번에 Teach(Human human)해주는 것이 편함

            
        }
    }
}
