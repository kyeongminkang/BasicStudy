using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    // 오버라이드 : 메소드를 재정의

    // virtual ; 부모(베이스)클래스 메소드 앞에 붙는 키워드
    //  자식(파생 :derived)클래스에 의해서 재정의 될 수 있다는 의미를 갖음(안할 수도 있음)

    // overrides : 자식 클래스 메소드 앞에 붙는 키워드
    //  부모로부터 받은 메소드를 재정의 한다는 의미
    // 재정의 할 때는 부모의 메소드 이름과 같아야 함(void main과 같은 프로토 타입 혹은 시그니처)

    //new


    class BaseClass
    {
        public virtual void echo()
        {
            Console.WriteLine("기반 클래스");
        }
    }

    class Derived : BaseClass
    {
        public override void echo()
        {
            Console.WriteLine("파생 클래스");
        } // 해당 메소드가 없으면 오버라이딩을 한 것이 아니기 때문에 기반 클래스가 출력
          // ovveride 키워드 없어도 되지만 명시해주어야 함. 만약 없으면 기반 클래스 무시하는 형태임
          // virtual이 아에 없으면 ovveride만 쓰면 에러가 남

        // override를 사용하면 다형성과 관련이 있지만
        // 대신 new를 사용하게 되면 부모와 독립적으로 사용하는 것이기 때문에 다형성과 관게 없어짐

        // new : 오버라이딩과는 다른 개념으로 메소드를 숨기는 기능임.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.echo();

            BaseClass baseClass = new Derived();
            baseClass.echo(); // 파생 클래스가 출력

            // override 대신 키워드 new를 사용하면?
            // Base타입이지만 기반 클래스가 출력. (baseclass)자신의 메소드를 감춘다는 것이기 때문에
        }
    }
}
