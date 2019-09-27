using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx2
{
    // 기반(부모) 클래스의 인자 생성자에게 파생(자식) 클래스가 매개 변수(인자)를 전달하는 방법
    // base 키워드 : 기반 클래스를 가리키는 키워드. 기반 클래스의 멤버에 접근할 때 사용

    // sealed class Parent를 하면 (sealed 키워드;한정자) 상속을 봉인하게 되어 상속을 불가능하게 함
    // sealed class는 봉인 클래스라고 함.

    class Parent
    {
        protected string name;
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}.Parnet()");
        }

        ~Parent()
        {
            Console.WriteLine($"{this.name}.~Parent()");
        }

        public void ParentMethod()
        {
            Console.WriteLine($"{name}.ParentMethod()");
        }
    }

    class Child : Parent
    {
        public Child(string name) : base(name)
        {
            Console.WriteLine($"{this.name}.Child()");
        }

        ~Child()
        {
            Console.WriteLine($"{this.name}.~Child()");
        }

        public void ChildMethod()
        {
            //Console.WriteLine($"{name}.ChildMethod()");
            base.ParentMethod(); // 부모 클래스에 있는 멤버에 접근해서 메소드 가져올 수 있음.
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            // 부모클래스에 매개변수 있을 시 파생 클래스에서 인스턴스 생성시(생성자) 부모 클래스에 전달할 수가 있음
            Parent parentA = new Parent("parentA");
            parentA.ParentMethod();

            Child chidA = new Child("childA");
            // base 키워드가 부모 클래스에 접근하여 생성자를 호출하고 본인 호출함
            // 순서를 따지면 부모 생성자 호출 부모 메소드 child 이름의 부모 생성자 호출
            // child 자식 생성자, 종료자 호출 child 이름의 종료자호출 마지막 원래 parnet이름의 부모 종료자 호출됨
            chidA.ChildMethod();
            chidA.ParentMethod();
            // 메소드 호출 시 child의 자식 생성자와 종료자 사이에 메소드 호출됨.
        }
    }
}
