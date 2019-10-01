using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEx
{
    // 모두 object형식으로 저장되기 때문에 컬렉션이 요소에 접근할때마다
    // 형변환이 자꾸 되기 때문에 성능이 저하될 수 있음.
    // 이를 해결하기 위함이 generic collection

     // Generic Collection : object 형식에 기반한 컬렉션의 문제들을 해결하는 방법으로 사용되고 있음.
     // Generic(일반화) 기반으로 만들어져 있기 때문에 컴파일 시 사용할 형식이 정해지므로 
     // 쓸데없는 형변환 발생이 줄어듦. 컬렉션이 가지고 있는 성능상의 문제를 해결할 수 있음.


        // ArrayList, Queue, Stack, Hashtable -- > List<T>, Queue<T>, Stack<T>, Dictionary<TKey, TValue>

        // List<T> 클래스는 ArrayList의 일반화(Generic)버전
        // 사용법은 동일하나 T 형식만 사용할 수 있음을 유의


    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i=0; i<10; i++)
            {
                list.Add(i);
            }

            foreach (int item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.RemoveAt(3);

            foreach (int item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.Insert(2, 2);
            foreach (int item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
