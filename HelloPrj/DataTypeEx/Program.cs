using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {

            /* C# 데이터 타입
             * 
             * .net 프로그래밍 언어는 .net 공용 타입 형식을 사용
             * 
             * int, double, string 키워드로 데이터 타입을 표현
             * 
             * system.int32, system.double, system.string (.net의 클래스로 데이터 타입을 표현하는 방법)
             * 
             *
             * ----------논리형-----------------
             * bool : true or false
             * 
             * -----------정수형----------------
             * byte : 8비트 unsigned 정수형 타입 (integer)
             * sbyte :  8비트 signed 정수형
             * (u)short : 16비트 (un)signed 정수형
             * (u)int : 32비트 (un)signed 정수형
             * (u)long : 64비트 (un)signed 정수형
             * 
             * -----------실수형----------------
             * float ; 32비트 실수형 (부동소수)
             * double : 64비트 실수형 (주로 대부분 사용. why? 메모리 사용량이 2배지만 float 수치에 따른 손실이 있을 수 있으므로!)
             * decimal : 128비트 실수형(float, double 보다 더 정밀한 소수 다룸)
             * 
             * 
             * -----------문자열 형--------------
             * char : 16비트 유니코드문자(다양한 언어형태를 표시할 수 있음. 전엔 8비트였음)
             * string : 유니코드 문자열
             * 
             * 
             * 
             * 
             

            // 변수란 메모리의 기억공간의 일부이며, 데이터 형식으로 공간을 선언해줌!
            // 변수 선언
            int x;
            // 메모리 공간에 할당
            x = 1000;
            //변수의 초기화(선언과 초기화를 동시에!)
            int y = 2000;

            // 여러개의 변수를 동시에 선언하기
            int a, b, c;
            a = 1000; b = 2000; c = 3000;

            // 여러개 변수를 선언과 초기화 동시에 하기
            double z = 12.1, kk = 11.11, zz = 22.22;

            */

            // char aa = "H"; 에러
            char a = 'H';
            char b = 'e';
            char c = 'l';
            char d = 'l';
            char e = 'o';

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);

            Console.WriteLine();

            string str = "Hello";
            // char(2바이트) 문자가 여러개가 모여서 만들어진 텍스트 형식의 형태. 크기가 정해져 있지 않음
          
            Console.Write(str);
            //Console.ReadKey();

            // 리터럴 데이터 : 123, True, "AGC" 와 같은 값들을 literal이라고 함. 주어져 있는 값!
            // 리터럴의 형식(타입) : 123(int 리터럴), 11.11(double 리터럴), "B"(string 리터럴), 'b'(char 리터럴), true(bool 리터럴)
            // 뒤에 접미사를 붙여 사용

            // C# 컴파일러 (프로그램 실행해주는 것)는 int, double, char, string, bool데이터 타입에 기본적으로
            // 그에 해당하는 값을 할당한다.

            // 데이터 타입 별 접미사(Suffix)를 사용해서 특정 데이터 타입을 지정할 수 있음.
            // ex 11.11f 실수형 타입임을 알려줌

            //[접미어] (대소문자 상관없음)
            // L : long형, U : Uint, UL : Ulong, F:float, D:doubeld, M:decimal
            long l = 12322L;

            // 최대수치, 최저수치
            int aa = int.MaxValue;
            int aaa = int.MinValue;
            Console.WriteLine(aa);
            Console.WriteLine(aaa);
            Console.ReadKey();


        }
    }
}
