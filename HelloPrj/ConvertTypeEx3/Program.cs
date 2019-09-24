using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 부호 있는 정수형과 부호 없는 정수형 사이의 형변환
             * ex) sbyte byte
             * ex) short unshort, int uint, long, ulong
             * 
             * 부호 있는 정수형 2진수로 표현하는 방법?
             * byte : 0 ~ 255, sbyte : -128 ~ 127
             * 8 자리 비트로 이루어져있고, 맨 앞자리는 부호비트 실제로 게산되는 숫자는 뒤에 7자리
             * 단, 1 111 1111는 -127일것 같지만 -1이 나옴
             * why? 0표현하고 싶을 때 0000 0000 (부호가 없는 경우) 1 000 0000 (부호가 있는 경우) -0??? 말도 안됨
             * 이런경우를 방지하기 위해 2의 보수법을 사용
             * 1-1 = 0 1+(-1)=0 임. 단, 0000 0001(1) + 1000 0001(-1) = 1000 0010 => -2 ??? 말도안됨
             * 따라서 0000 0001(1) + 1111 1111(-1) = 10000 0000지만 8비트이기 때문에 맨 앞자리 1 빼면 0이 됨
             * 0000 0001(1)을 2의 보수로? 모두 반대로! 1111 1110 + 1 = 1111 1111 그렇기 때문에 -1
             */

            //byte bb = 255; // 부호없는 정수형 1111 1111
            //sbyte sb = (sbyte)bb; // 부호 있는 정수형 -1이 나옴 why? 2의 보수라서!

            //Console.WriteLine(bb);
            //Console.WriteLine(sb);
            //Console.ReadKey();

            int ia = 600; // 영향 줄 수 없음. 차이가 없음. int는 32비트라서
            Console.WriteLine(ia);

            uint ua = (uint)ia;
            Console.WriteLine(ua);

            int iaa = -40;
            Console.WriteLine(iaa);

            uint uaa = (uint)iaa; // 부호로 인하여 2의 31승 부분이 계산되기 때문에 큰 값이 나옴
            Console.WriteLine(uaa);
         
        }
    }
}
