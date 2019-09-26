using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjCopyEx
{
    class Program
    {
        class Demo1
        {
            public int aa;
            public int bb;

            // 자신의 객체를 또 만들어서 자기 자신의 인스턴스 멤버를
            // 복사하여 newDemo1으로 리턴함
            public Demo1 DeepCopy()
            {
                Demo1 newDemo1 = new Demo1();
                newDemo1.aa = this.aa;
                newDemo1.bb = this.bb;

                return newDemo1;
            }
        }

        static void Main(string[] args)
        {
            {
                // 얕은 복사
                Demo1 demo1 = new Demo1();
                demo1.aa = 100;
                demo1.bb = 1000;

                Demo1 demo11 = demo1;
                demo11.bb = 1111;
                Console.WriteLine($"{demo1.aa}, {demo1.bb}");
                Console.WriteLine($"{demo11.aa}, {demo11.bb}");
                // 생각한 바와 다르게 demo1.bb 역시 1111 출력됨

                // value타입과 reference타입이 있음.
                // value는 stack, ref는 heap 메모리 영역에 데이터를 저장
                // 클래스도 ref 형식을 취하고 있음.
                // 따라서 stack에 demo1, demo11 변수가 있고, heap에 aa bb 위치를 가리키고 있기 때문에
                // 복사 시에 bb 값을 바꿔버렸기 때문에 demo1역시 바뀐 값이 출력
                // 요것이 얕은 복사!
            }

            // 깊은 복사
            {
                Demo1 demo1 = new Demo1(); // 원래 위에서 변수 사용해서 안되지만 빈 블럭하면 로컬변수처럼 사용해서 또 쓸 수가 있음!

                demo1.aa = 100;
                demo1.bb = 1000;

                Demo1 demo11 = demo1.DeepCopy();
                demo11.bb = 1111;
                Console.WriteLine($"{demo1.aa}, {demo1.bb}");
                Console.WriteLine($"{demo11.aa}, {demo11.bb}");
            }



        }
    }
}
