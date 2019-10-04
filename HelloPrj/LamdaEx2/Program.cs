using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaEx2
{
    // 이 전은 매개변수목록 => 식
    // 이번에는 매개변수 목록 => { 실행코드 .... } 블록 사용 형식이용해보기
    
    /*
        ( )안에 아무것도 없으면 매개변수가 없는 무명함수 표현
        대리자 인스턴스 = ( ) =>
                        {
                            실행코드 ...
                        }
     */
    class Program
    {
        delegate string SumString(string[] args);

        static void Main(string[] args)
        {
            SumString sumString = (str) =>
            {
                string stringRes = "";
                foreach (string s in str)
                {
                    stringRes += s;
                }
                return stringRes;
            };

            Console.WriteLine(sumString(args));
            // 바로 실행하면 안되고 cmd에서 위치 찾아가서 실행해야함
            // exe 파일을 실행해야 하기 때문에 bin debug 찾아가야함.
            // 또한, 빌드를 한번은 해야 exe 파일이 생성되므로 빌드 다시 해줄것!
            // exe 파일 생성된 것을 확인 한 후, debug디렉토리에서
            // 파일이름 (LamdaEx2) 문자열 문자열 enter!

        }
    }
}
