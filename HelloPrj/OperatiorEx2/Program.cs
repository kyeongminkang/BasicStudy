using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiorEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 논리연산자
            Console.WriteLine(10 > 5 && 10 < 100);  // T && T = T
            Console.WriteLine(10 > 5 && 10 < 5); // T && F = F
            Console.WriteLine(10 < 5 && 10 > 9); // F && T = F
            Console.WriteLine(10 < 5 && 10 < 9); // F && F = F

            Console.WriteLine(10 > 5 || 10 < 100);  // T || T = T
            Console.WriteLine(10 > 5 || 10 < 5); // T || F = T
            Console.WriteLine(10 < 5 || 10 > 9); // F || T = T
            Console.WriteLine(10 < 5 || 10 < 9); // F || F = F

            // ! (Not연산자)
            Console.WriteLine(!true); // true 소문자여야 함. 결과는 F



        }
    }
}
