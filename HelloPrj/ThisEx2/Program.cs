using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisEx2
{
    class Demo
    {
        public int a, b, c;
        public Demo()
        {
            this.a = 100;
            Console.WriteLine("Demo()");
        }

        // this는 앞에 있는 생성자를 상속 바로 앞에만 지칭함에 유의!
        public Demo(int b) : this()
        {
            // this.a = 100; // 코드 중복
            this.b = b;
            Console.WriteLine($"Demo({b})");

        }

        // this안에 매개변수를 넣지 않으면 맨 위에 것을 지칭하는 것과 같기 때문에
        // 같은 매개변수를 받아오도록 해야함!
        public Demo(int b, int c) : this(b)
        {
            // this.a = 100;
            // this.b = b;
            this.c = c;
            Console.WriteLine($"Demo({b} {c})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // this() 생성자 
            // 메소드와 비슷함. 오버로딩 가능함.

            Demo demo = new Demo(200, 300);
            Console.WriteLine(demo.a);
            Console.WriteLine(demo.b);
            Console.WriteLine(demo.c);
        }
    }
}
