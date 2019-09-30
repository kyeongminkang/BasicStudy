using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListEx
{

    /*
      Collection(컬렉션) : ArrayList, Queue, Stack, HashTable
      간단히 말하면, 데이터 모음을 담는 자료구조
      배열이나 스택, 큐 등을 C#에서는 컬렉션이라는 이름으로 제공

       .net 프레임워크에서 사용하는 컬렉션은 ICollection 인터페이스를 상속 받음.
        배열은 system.Array(클래스 타입)타입이다.
        system.Array는 ICollection 인터페이스를 상속 받기 때문에
        배열은 컬렉션의 일부이다.
        
        ArrayList는 배열과 비슷한 컬렉션
        배열처럼 [] 이용. 인덱스로 요소의 접근이 가능하고, 특정 요소를 바로 읽고 쓸 수 있음.
        반면, 배열을 선언할 때는 배열의 크기를 지정해야 하지만 ArrayList는 크기를 지정하지 않음.
        요소에 추가 삭제에 따라서 자동으로 크기를 늘였다 줄일 수 있음.

        또한, ArrayList 컬렉션은 모든 타입의 변수를 담을 수 있음.
        (C#에서 제공하는 모든 컬렉션 역시 모든 타입의 변수를 담을 수 있음. 그 이유는 컬렉션의 요소들은 obj타입으로 저장되기 때문)
     */

    class Program
    {
        
        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열의 타입 ; {array.GetType()}");
            //Console.WriteLine($"배열의 기본타입 : {array.GetType().BaseType}");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(100);

            // RemoveAt(index) : 리스트의 해당 인덱스를 찾아 제거
            // Remove(data) : 매개변수로 전달된 data를 찾아 제거. 단 먼저 찾은 값만 제거해줌
            arrayList.RemoveAt(1); //인덱스번호 
            // arraylist.Remove(2) 그 값을 지워줌.

            // insert(intdex, data) index위치에 data삽입
            arrayList.Insert(1, 2.2f); // 1, 2.2, 100
            // 이미 지워져있음

            //끝에 추가하는것
            arrayList.Add("abc"); // 1, 2.2, 100, abc
            arrayList.Add("가나다"); // 1, 2.2, 100, abc 가나다

            // 컬렉션의 모든 요소들은 object 타입이기 때문에 아래(foreach)에서 object obj가 가능
            foreach(object obj in arrayList)
            {
                Console.WriteLine($"{obj}");
            }


        }
    }
}
