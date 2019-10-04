using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 익명(무명)타입 : (Anonymous type) 일반적으로 클래스를 사용하기 위해서는 먼저 클래스를 정의한 후에 사용함.
// C# 3.0에서는 클래스를 미리 정의하지 않고 사용할 수 있도록 익명타입 기능을 제공
/*
    new { 속성1 = 값, 속성2 = 값 }
    
    ex var c = new {Name = "홍길동", Age = 22}
    new 뒤에 해당 클래스 명이 없다는 것!
 */ 
namespace AnonymousTypeEx
{


    class Program
    {
        static void Main(string[] args)
        {

            //var v = new[]
            //{
            //    new {Name = "홍길동", Age=33},
            //    new {Name = "이길동", Age=44},
            //    new {Name = "김길동", Age=55}
            //};

            var v = new { Name = "홍길동", Age = 33 };

            Console.WriteLine($"이름 : {v.Name}, 나이 : {v.Age}");

            var vv = new { Subject = "국어", Scores = new int[] { 66, 99, 77, 88 } };
            Console.WriteLine($"과목 : {vv.Subject}");
            foreach(var score in vv.Scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();
           

        }
    }
}
