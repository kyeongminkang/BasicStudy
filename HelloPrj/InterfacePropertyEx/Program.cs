using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePropertyEx
{
    // 인터페이스에서 프로퍼티
    // 인터페이스에서 자동 프로퍼티는 C# 컴파일러가 자동으로 구현해주지 않음.
    // 따라서,해당 인터페이스 상솓받는 클래스에서(구현부 없으니) 구현해줘야함!
    interface IKeyValue
    {
        string Key { get; set; }
        string Value
        {
            get; set;
        }

    }

    class KeyValue : IKeyValue
    {
        // iKeyValue의 인터페이스를 구현해주고 있음.
        // 즉 컴파일러가 자동으로 프로퍼티 구현을 해줌
        public string Key
        {
            get; set;
        }

        public string Value
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KeyValue school = new KeyValue()
            {
                Key = "초등학교",
                Value = "산천"
            };

            KeyValue grade = new KeyValue()
            {
                Key = "학년",
                Value = "3"
            };

            KeyValue address = new KeyValue()
            {
                Key = "주소",
                Value = "서울"
            };
            Console.WriteLine($"{school.Key} : {school.Value}");
            Console.WriteLine($"{grade.Key} : {grade.Value}");
            Console.WriteLine($"{address.Key} : { address.Value}");
        }
    }
}
