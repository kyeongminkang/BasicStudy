using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 데이터 형식 변환하기 (Type conversion)
            // 소괄호 () 컨버전 연산자

            /*
             * 데이터 형식 변환 : 변수를 다른 데이터 형식의 변수에 옮기는 것
             * 줄여서 형변환이라고 많이 사용
             * 
             * 
             * 크기가 서로 다른 정수형 사이의 형변환
             * 
             * 큰 데이터를 작은 데이터에 담을 때 데이터 손실이 일어날 수 있음
             * 넘치는 현상으로 overflow라고 함
             * 작은 데이터를 큰 데이터에 담을 때는 데이터 손실이 일어나지 않음 
             * 
             * 크기가 서로 다른 부동소수점 사이의 형변환
             * 부호있는 정수형과 부호없는 정수형 사이의 형변환
             * 실수형과 정수형 사이의 형변환
             * 문자열과 숫자열 사이의 형변환
             * 
             */

            sbyte a = 127;
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(a);
            int aa = (int)a; // 손실없음
            Console.WriteLine(aa);
            int x = 128;
            Console.WriteLine(x);
            sbyte xx = (sbyte)x;
            Console.WriteLine(xx);
            // overflow현상이 나타나서 엉뚱한 값이 나옴
            // -128이 나오는데 1씩 증가하여 맨 앞에 부호비트가 바뀌기 때문

        }
    }
}
