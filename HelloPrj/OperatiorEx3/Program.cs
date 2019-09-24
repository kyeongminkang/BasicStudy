using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiorEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 조건 연산자 : ?
            // 조건식 ? 참일 때 값 : 거짓일 때 값

            string str = (100 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(str);
        }
    }
}
