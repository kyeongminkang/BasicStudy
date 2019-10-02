using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 델리게이트 : 메소드를 다른 메소드로 전달할 수 있도록 하기 위해 만들어 진 것

/*
    void AAA(int arg1) {...}

    int a = 123;
    AAA(a);

    Class DemoClass
    {
        int id;
        string name;
        public void DisplayInfo() { }
    }

    void AAA(DemoClass d) { ... }
    DemoClass d = new DemoClass();
    AAA(d);

    ----------------delegate를 이용한 메소드를 전달-----
    void AAA(MyDelegate method) { ... }

    delegate int MyDelegate(string str);
    메소드처럼 반환형식과 매개변수 지정함
    동작은 클래스처럼! 
    단 클래스는 메소드뿐만 아니라 필드도 전달하지만, delegate는 메소드만!

    int StringToOnt(string str) { ... } <- 메소드
    인스턴스 만들기
    MyDelegate myDelegate = new MyDelegate(StringToint);
    단, Mydelegte와 stringtoint의 매개변수 인자(개수, 타입), 반환타입이 같아야함

    AAA(myDelegate);

 */
namespace DelegateEx
{
    class Program
    {
        // 델리게이트 정의
        delegate int MyDelegate(string str);

        void TestMethod()
        {
            //델리게이트 객체생성
            MyDelegate md = new MyDelegate(StringToInt);
            AAA(md);
        }

        // 델리게이트의 대상이 되는 메소드
        int StringToInt(string str)
        {
            return int.Parse(str);
        }

        // 델리게이트를 전달 받는 메소드
        void AAA(MyDelegate md)
        {
            int i = md("100");
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            new Program().TestMethod();
        }
    }
}
