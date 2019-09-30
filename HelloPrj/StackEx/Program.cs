using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx
{
    // Stack : 후입선출(LIFO) Last In First Out
    //      나중에 들어온 데이터가 먼저 출력되는 자료구조
    // - Push ; 데이터 입력 메소드
    // - Pop : 데이터 출력 메소드

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(11);
            stack.Pop();
            stack.Push(2.33);
            stack.Pop();
            stack.Push("문자열");

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
