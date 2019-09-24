using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEx
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {


                Console.WriteLine("-----------메뉴-------------");
                Console.WriteLine();
                Console.WriteLine("1. 사이다");
                Console.WriteLine("2. 콜라");
                Console.WriteLine("3. 오렌지주스");
                Console.WriteLine("4. 환타");

                Console.Write("메뉴 번호를 선택하세요. (종료는 Q 또는 q를 누르세요 == >");

                string answer = Console.ReadLine();
                Console.WriteLine();

                if (answer == "Q" || answer == "q") break;

                if (answer == "1") Console.WriteLine("사이다 가격 : 1,000원");
                else if (answer == "2") Console.WriteLine("콜라 가격 : 1,200원");
                else if (answer == "3") Console.WriteLine("오렌지주스 : 2,000원");
                else if (answer == "4") Console.WriteLine("환타 : 1,500원");

            }

        }
    }
}
