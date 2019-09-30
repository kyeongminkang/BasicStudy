using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableEx
{
    // key, value
    // hashing 알고리즘을 이용한 데이터 검색이 이루어지는 방식의 자료구조
    // 키를 이용해서 한번에 데이터가 저장되어 있는 컬렉션 내의 주소를 계산해 낸다.
    // 순서 상관없다는 뜻.

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["Apple"] = "사과";
            ht["Orange"] = "오렌지";
            ht["Banana"] = "바나나";

            Console.WriteLine(ht["Apple"]);
            Console.WriteLine(ht["Banana"]);
            Console.WriteLine(ht["Orange"]);



        }
    }
}
