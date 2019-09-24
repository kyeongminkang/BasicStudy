using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiorEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 비트연산자 (shift, &, |, ^)

            int aa = 1, bb = 2, cc = 3;
            Console.WriteLine("aa : {0} bb : {1} cc : {2}", aa, bb, cc); // 형식지정
            // 특정형식에 맞춰 출력하는 포맷팅

            Console.WriteLine("{0:D5}", aa); // 5자리 형태로 출력 
            Console.WriteLine($"{aa:D}"); // 그냥 1만 출력


            Console.WriteLine("0x{0:x8}", aa); // 16진수로 출력하기, 8자리로(명확)
            Console.WriteLine("{0:D3} 0x{0:x8}", aa);
            Console.WriteLine("{0:D3} 0x{0:x8}", aa << 1); // 2, 16진수로 00000002
            Console.WriteLine("{0:D3} 0x{0:x8}", aa << 5); // 32, 16진수로는 00000020


            Console.WriteLine("----------------------------");
            int b = 255;
            Console.WriteLine("{0:D3} 0x{0:x8}", b);
            Console.WriteLine("{0:D3} 0x{0:x8}", b >> 2);

            int c = -255;
            Console.WriteLine("{0:D3} 0x{0:x8}", c);
            Console.WriteLine("{0:D3} 0x{0:x8}", c >> 1);

            int x = 9;
            int y = 10;

            Console.WriteLine(x & y); // 8
            Console.WriteLine(x | y); //11
            Console.WriteLine(x ^ y); // 3

            // ~ : 보수 연산자. (1, 0을 서로 뒤바꾸는 연산자)
            int xx = 255;
            Console.WriteLine("{0} 0x{0:x8} {1} 0x{1:x8}", xx, ~xx);
             
        }
    }
}
