using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 부동 소수점 형식 사이의 형변환

            float f = 79.6777f;
            Console.WriteLine($"f : {f}");
            double d = (double)f;
            Console.WriteLine($"d : {d}");
            // 뒤에가 더 붙어서 출력 (숫자 변동에 대한 의미는 없음 반올림하면 되니까)
            // 어찌보면 더 정밀 형태로 출력된 것임

            double dd = 0.121212121212121212d;
            Console.WriteLine($"dd : {dd}");

            float ff = (float)dd;
            Console.WriteLine($"ff : {ff}");
            // 뒷 부분이 짤림 데이터 손실이 일어난 것!

            float x = 69.6875f;
            Console.WriteLine($"x : {x}");

            double dx = (double)x;
            Console.WriteLine($"dx : {dx}");
            // d와 비슷하지만 얘는 똑같이 나옴
            // 즉, 우리가 의도치 않은 값들이 나올 수 있음을 의미!

            // 십진수를 이진수로 바꾸는 과정에서
            // (메모리에 이진수로 저장한다는 뜻) 
            // 예를 들어 플롯형을 더블형으로 바꿀 때
            // 십진수를 이진수로 변환했다가
            // 다시 십진수로 변환해서 돌려주기 때문에
            // 온전히 넘어가지 않을 수 있음.
          
        }
    }
}
