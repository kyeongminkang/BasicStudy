using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace CollectionInitialEx
{
    //컬렉션 초기화

    class Program
    {
        static void Main(string[] args)
        {
            // 컬렉션 초기자를 이용한 초기화 방법
            ArrayList arrayList2 = new ArrayList() { 10, 20, 30};
            foreach(object obj in arrayList2)
            {
                WriteLine(obj);
            }
            // add 대신 사용
            // 컬렉션 초기자는 ienumerable 인터페이스를 상속 받아 add메소드를 구현하고 있음.

            // 단 컬렉션 초기자는 stack, queue에서는 사용할 수 없음.
            // why? stack, queue는 add메소드를 사용하지 않기 때문에

            // 배열을 이용해서 사용하는 방법
            // stack, queue도 가능
            int[] array = { 11, 22, 33, 44 };
            ArrayList arrayList = new ArrayList(array);
            
            foreach(object obj in arrayList)
            {
                WriteLine(obj);
                // using에 static에 올림
            }

            // 먼저 들어간 데이터가 나중에 들어오니까 거꾸로 출력
            Stack stack = new Stack(array);
            foreach(object obj in stack)
            {
                WriteLine(obj);
            }

            Queue queue = new Queue(array);
            foreach(object obj in queue)
            {
                WriteLine(obj);
            }
        }
    }
}
