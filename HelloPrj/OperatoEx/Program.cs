using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연산자
            int a = 100 + 200;

            int mod = 13 % 2;
            Console.WriteLine(a);
            Console.WriteLine(mod);

            int aa = 10;
            Console.WriteLine(aa++); // 후치 연산이기 때문에 그대로 값이 나옴
            Console.WriteLine(++aa); // 12. 위에서 10+1이 된 상태에서 +1을 먼저 하기 때문에!
            Console.WriteLine(aa--);
            Console.WriteLine(--aa);

            bool res;
            res = 10 > 200;
            res = 100 == 100;
            Console.WriteLine(res);


        }
    }
}
