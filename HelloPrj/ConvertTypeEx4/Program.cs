using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 부동 소수점과 정수형 사이의 형변환
             */

            //float f = 0.121234f;
            //int aa = (int)f;

            //Console.WriteLine(f); // 뒤에 소수점이 다 잘린 값이 나옴. 앞에 정수값만 나옴
            //Console.WriteLine(aa);

            // ***** 문자열과 숫자 사이의 형변환
            int aa = 34343434;
            string bb = aa.ToString(); //object에 있음! 모든 자료형은 object이기 때문에 object 상속가능
            Console.WriteLine(bb);

            string str1 = "121212";
            int aaa = int.Parse(str1);
            Console.WriteLine(aaa);
            

        }

    }
}
