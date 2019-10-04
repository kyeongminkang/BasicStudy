using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    확장 메소드 : 클래스에 있는 메소드(기능)를 확장! 상속과 혼돈할 수 있음.
    자바와 같은 경우, extends를 이용하여 상속하는데 (확장성의 개념을 지니고 있기 때문에)
    C#은 따로 구분을 하고 있음. 기존 클래스에 새로운 기능을 넣는 것! 
    상속 이외에 따로 추가 시켰음. 부모가 갖고 있지 않은 필드나 메소드를 추가 시킬 수 있음.
    확장 메소드는 기존 클래스가 있다면, (그대로 두고) 하나 더 추가 한다거나 할 수 있다는 것!
    마치 기존 클래스에 해당 메소드가 있는 것 처럼!

    기존 클래스의 기능을 확장하는 기법, 상속과 구별하여 생각하면 이해하기 수월
    상속은 기존의 클래스를 상속 받아 새로운 클래스를 만들어 그 안에 필드나 메소드를 추가 해서 사용하지만
    상속은 기존의 클래스를 그대로 두고 그 클래스에 새로운 기능을 추가함!
    클래스를 새로 만드는 것이 아니기 때문에 마!치! 기존 클래스가 가지고 있던 것 처럼 사용!

    상속과 달리 기존 클래스 형태로 만들어 사용, static이어야함!
    선언형식
    public static class 클래스 이름
    {
        확장하고자 하는 메소드 (여기도 static이어야 함!)
        this 매개변수 필수! 대상형식은 어떠한 클래스를 어떠한 타입을 확장할 것인지!
        public static 반환형식 메소드명(this 대상형식(클래스 or 타입..) 식별자, 매개변수)
        {
        }

    }
 */
namespace ExtensionEx
{

    public static class MyExtension
    {
        //public static void ShowMyintList(this int n)
        //{
        //    Console.WriteLine($"int값은 {n}");

        //}

        public static void ShowMyintList(this int n, int n2)
        {
            Console.WriteLine($"int값은 {n}, {n2}");

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            // 변수 뒤에 점을 찍으면 int에서 제공해주는 메소드들이 나옴
            // n은 int의 변수이지만 int형의 인스턴스나 마찬가지기 때문에!

            // this한정자에 의해서 n하고 점을 찍으면 dnl showmyintlist메소드가 추가됐음.
            //n.ShowMyintList();

            //1000.ShowMyintList(); // 얘도 가능 1000은 누가봐도 int니까

            n.ShowMyintList(200);

            1000.ShowMyintList(2000);
        }
    }
}
