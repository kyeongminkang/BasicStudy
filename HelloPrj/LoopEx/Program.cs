using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 반복문 (Loop) : while, do while, for, foreach

            /*
             * while (조건식)
             *      반복실행 코드
             */

            //int i = 5;
            //while (i > 0)
            //    Console.WriteLine(i--);

            // do while문
            int ii = 5;
            do
            {
                Console.WriteLine(ii);
                ii -= 2;
            } while (ii > 0);// 문장 먼저 수행 조건 확인
            // 명령 먼저 수행하고 참일 경우에 수행
            // 반드시 먼저 실행해야 할 코드가 있으면 사용함
            // 한번은 실행해야 한다하면 사용하면 됨

            /*
             * for (초기화; 조건식; 증감){
             *      반복 실행 코드
             * }
             */

            for(int i=0; i<5; i++)
            {
                Console.WriteLine(i);
            }

            // 무한반복문 : 무한히 반복되는 루프
            // for(; ;) 초기값도, 조건도, 증감식이 없기 때문에 무한히 반복함

            // while(true) 참이면 반복이기 때문에 무한 반복


        }
    }
}
