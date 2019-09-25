using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 메소드 : 객체지향 언어에서 사용하는 용어(기존에는 function:함수 라고 불렸음)
            /*
             * 메소드 선언 형식
             * 한정자 반환형식 메소드명(매개변수){
             *      실행코드,
             *      실행코드,
             *      ......
             *  }
             *  매개변수 넣는 자리에
             *  직접 값을 넣어도 되고, 변수 이용해도 됨
             *  void인 경우 리턴값 없음.
             *  리턴 값 있는 경우 반환형식 즉 리턴 타입에 유의
             *  
             */ 

            int x, y;
            x = 10;
            y = 11;

            //Console.WriteLine(sum(x, y)); // Sum메소드를 호출하여 리턴값을 받음.
            sum(x, y); //sum 메소드를 호출 (void라 리턴값 X)

            sum(100, 200);
            //int xx = x + y;

            //Console.WriteLine(xx);

            //x = 100;
            //y = 200;

            //int yy = x + y;

            //Console.WriteLine(yy);

            
        }

        //static int sum(int x, int y)
        //{
        //    return x + y;
        //}

            
        static void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
