using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace yieldEx2
{
    /*
 
    Enumerator : 데이터 요소를 하나씩 리턴하는 기능
    위의 기능을 구현하기 위해서 C#이나 .NET에서는 IEnumerator라는 인터페이스를 구현해야 함.

    IEnumerator는 Current(속성), MoveNext()(메소드), Reset()(메소드) 3개의 멤버로 이루어져있음.
    따라서, Enumerator가 되기 위해서는 Current와 MoveNext()를 반드시 구현해야 함.

    이 컬렉션 클래스는 Enumeration이 가능한 클래스인데, 이러한 클래스들을 Enumerable 클래스라고 함.
    또한, 이 Enumerable 클래스는 IEnumerable 인터페이스를 구현해야 함.

    IEnumerable 인터페이스는 GetEnumerator()를 메소드를 하나 가지고 있음.
    이 GetEnumerator() 메소드는 IEnumberator 구현한 객체를 리턴해줌.
    
    컬렉션 타입이나 또는 Enumerable 클래스에서 Getenmerator() 메소드를 구현하는 방법으로
    yield 키워드를 사용할 수 있음.

    GetEnumerator()메소드에서 yield return 사용하면 컬렉션 데이터를 순차적으로 하나씩 넘겨주는 코드를 구현할 수 있고,
    return type은 IEnumerator인터페이스를 리턴할 수 있음.

 */

        class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
