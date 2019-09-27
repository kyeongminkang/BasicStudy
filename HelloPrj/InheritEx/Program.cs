using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx
{
    // 부모 클래스, 슈퍼 클래스, 상위 클래스, 기반클래스, 베이스클래스
    class Parent
    {
        //생성자
        public Parent()
        {
            Console.WriteLine("Parnet()생성자 호출");
        }

        ~Parent()
        {
            Console.WriteLine("~Parnet() 종료자 호출");
        }
        public void showInfo()
        {
            Console.WriteLine("parent Class");
        }
    }

    // 자식 클래스, 서브 클래스, 파생 클래스
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child() 생성자 호출");

        }
        ~Child()
        {
            Console.WriteLine("~Child() 종료자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 상속
            // 부모 클래스에서 자식 클래스에게 부모가 가지고 있는 것을 물려주는 것으로 재활용 할 수 있도록 하기 위함!

            Child child = new Child();
            // child.showInfo();
            // 파생 클래스 객체를 생성했더니 부모 생성자 호출, 자식 생성자 호출, 자식 종료자 호출, 부모 생성자 종료자 호출 순서

            // 부모클래스에 매개변수 있을 시 파생 클래스에서 인스턴스 생성시(생성자) 부모 클래스에 전달할 수가 있음


        }
    }
}
