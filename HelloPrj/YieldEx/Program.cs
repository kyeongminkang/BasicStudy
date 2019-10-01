using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldEx
{

    // Enumerator(Iterator) : 집합적인 데이터셋으로부터 데이터를 하나씩 호출자에게 보내주는 기능. 반복자
    // yield 키워드 : 호출자에게 컬렉션 데이터를 하나씩 리턴할 때 사용하는 키워드
    
        /*
         yield 사용방식
         - yield return : 컬렉션 데이터를 하나씩 리턴하는데 사용
         
         - yield break : 리턴을 중지하고 Iteration 루프를 빠져나올 때 사용

         */ 


    class Program
    {

        static IEnumerable<int> GetNumber()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            // 각각의 ienumerable 타입 리턴

            // 왜 얘를 컬렉션 데이터 반복문 안돌리고 사용?
            // 예를 들어 게시판 데이터를 보고싶을 때, 한 페이지씩 봐야하는데
            // 데이터가 많으면 우선 총 데이터에 엑세스 해서 가져와야하기 때문에
            // 반복자 돌려서 가져올 때 수행하는 시간이 오래 걸림
            // 하지만 얘는 필요한 만큼만 가져오기 위함이라 시간을 단축시킬 수가 있음.
        }


        static void Main(string[] args)
        {
            // foreach문은 컬렉션, 배열같은 곳에서만 사용할 수 있음.
            // ienumerable 또는 ienumerate 상속 받아야 함.

            foreach(int num in GetNumber())
            {
                Console.WriteLine(num);
            }

        }
    }
}

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