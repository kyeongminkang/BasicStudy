using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx
{
    // 추상클래스 : 인터페이스와 비슷하지만 구현부(몸통) 가질 수 있음.
    // 단, 인스턴스를 가질 수는 없다.
    // 구현부를 갖을 수 있지만 인스턴스를 만들 수 없음!
    // 사용하는 한정자는 abstract와 class 사용한다.

    /*
     선언형식
     abstract class 클래스명
     {
        // 클래스와 동일
     }

  추상 클래스는 클래스와 달리 추상메소드를 가지고 있음.
  추상 클래스는 모든 멤버에 접근 제한자를 사용하지 않을 경우 private 설정됨.
  추상 메소드를 지정할 때 abstract 키워드를 사용
  클래스와 인터페이스의 중간형식

    추상메소드의 형식
    public abstract void A();

    추상 메소드는 private이 될 수 없음. (외부에서 구현할 수 없음)
    따라서 public protected internal protected internal 중에 하나를 꼭 사용

     */

    abstract class MyAbstractClass
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("추상클래스의 ProtectedMethod호출");
        }

        public void PublicMethod()
        {
            Console.WriteLine("추상클래스의 PublicMethod호출");
        }

        public abstract void AbstractMethod();
        // 꼭 사용해야함!
    }

    class Child : MyAbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("추상클래스의 AbstractMethod 호출");
            ProtectedMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyAbstractClass myabs = new Child();

            myabs.AbstractMethod();
            myabs.PublicMethod();

        }
    }
}
