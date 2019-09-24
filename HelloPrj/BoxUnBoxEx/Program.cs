using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnBoxEx
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * boxing 과 unboxing 의 개념
             * 
             * object obj1 =111;
             * 위 코드에서 111은 int형 값이고
             * obj1은 object형의 참조 형식임
             * 이 경우 111의 값은 스택, 힙 중에 어디에 저장이 되는가?
             * 111은 힙에 저장됨.(박싱 기능을 통해서 힙에 저장하게 됨)
             * why?
             * 원래 정수형은 힙에 저장될 수 없기 때문에!
             * 
             * obj에 int를 할당한 경우 int는 스택에 들어가야 하지만 obj가 힙이므로 힙에 할당하게 됨
             * 이떄 사용하는 것이 박싱개념
             * 
             * 언박싱은 그 포장되어 있는 값을 꺼내는 것!
             * 
             * 언박싱은 박싱되어 있는 값을 꺼내서 값 형식 변수에 저장하는 과정을 의미.
             * 
             * 
             */

            int x = 111;

            object obj1 = (object)x;
            // x에 담겨있는 값을 박싱해서 힙에 저장하는 과정)

            // int y = obj1; 에러
            int y = (int)obj1;
            // unboxing후에 스택에 저장
            

            Console.WriteLine(x); // 얜 그냥 정수형 출력한 것
            Console.WriteLine(obj1); // 얜 박싱한 값이고!
            Console.WriteLine(y); // 언박싱 된 값

            double xx = 2.1818181;
            object yy = xx;
            //obj형식에 저장할 때에는 형변환 연산자를 사용하지 않아도
            //자동으로(묵시적) 형변환이 이루어짐.
            double zz = (int)yy;


            Console.ReadKey();
       
        }
    }
}
