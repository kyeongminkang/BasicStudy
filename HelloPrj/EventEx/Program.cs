using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이벤트 : 특정한 일이 일어났음을 알려주는 기능
// event 키워드를 이용하여 표시

    /*
        이벤트 선언과 사용 순서?
        (대리자 이용!)

    - delegate를 선언
    - 선언된 delegate에 event 키워드를 붙여줌
    - 이벤트 핸들러를 작성. 선언된 delegate의 프로토타입과 동일하게 메소드 작성
    - 클래스 인스턴스를 생성하고, 이 객체에 이벤트 핸들러를 등록하는 과정 필요
    - 이벤트가 발생하면 이벤트 핸들러가 호출됨
      
     */ 
namespace EventEx
{
    delegate void EventHandler(String msg);

    class MyEventDemo
    {
        // 인스턴스아님. 멤버만 선언함
        public event EventHandler eventHandler;

        public void TestMethod(int a)
        {
            if (a % 2 == 0)
            {
                // delegate를 event로 호출
                eventHandler(string.Format($"{a} : 짝수"));
            }

        }
    }
    
    class Program
    {
        // 실제 동작하는 것!
        static public void MyHandler(string msg)
        {
            Console.WriteLine(msg);
        }


        static void Main(string[] args)
        {

            MyEventDemo myDemo = new MyEventDemo();
            myDemo.eventHandler += new EventHandler(MyHandler);

            for (int i = 1; i < 20; i++)
            {
                myDemo.TestMethod(i);
                // myDemo.eventHandler("aaa"); // event로 선언돼 있는 것은 외부에서 불러올 수 없으므로 에러
            } 
        }
    }
}
