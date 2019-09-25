using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultparameterEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 파라미터에 기본값을 적용하기 (매개변수에 전달하는 값이 없을 경우)
            // void aaa(int a = 0, int b = 1) {
            //      Console.WriteLine(a+b);
            // }
            // aaa; 의 결과는 1

            MemberInfo("홍길동");
            MemberInfo("길말똥", "인천");
            MemberInfo(name: "이말똥", addr: "광주"); // 키와 밸류로 보냄
        }

        static void MemberInfo(string name, string addr = "")
        {
            Console.WriteLine($"이름 : {name}, 주소 : {addr}");
        }
    }
}
