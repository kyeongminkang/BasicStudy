using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // static(정적) 메소드, 정적 필드
            // 한 프로그램안에 클래스는 하나만 존재하지만 인스턴스는 여러개가 존재할 수 있음.
            // 한 프로그램안에 똑같은 클래스는 두개가 존재할 수 없음.

            // static 필드나 static 메소드는 클래스에 소속된 것이므로 프로그램안에 유일하게 존재한다는 의미.

            DemoClass demoClass = new DemoClass();

            demoClass.a = 100;
            demoClass.b = 200;

            DemoClass demoClass2 = new DemoClass();
            demoClass2.a = 1;
            demoClass2.b = 2;
            // 인스턴스이기 때문에 그 개수만큼 사용할 수 있음.


            // 유일하기 때문에 해당 클래스 이름만 적어도 되고, 한번만 사용할 수 있음.
            // static은 인스턴스 만들지 않고 클래스 이름만 가져와서 접근
            SdemoClass.a = 11;
            SdemoClass.b = 22;
        }


    }

    class DemoClass
    {
        public int a;
        public int b;
    }

    class SdemoClass
    {
        public static int a;
        public static int b;
    }
}
