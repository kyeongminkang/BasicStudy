using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 얘네도 namespace의 일종

// 따라서 현재 Helloprj 아래에 여러 program 들어올 수 있음.
namespace HelloPrj
{
    class Program
    {
        // 이 Main을 바로 윈도우OS가 실행 시켜주는 것(유일)!
        // 프로그램의 시작과 끝
        static void Main(string[] args)
                        // args란? 배열 string[] 형식의 인자 받아주는 매개변수
        {
            Console.WriteLine("Hello C#!!");
            // 한 번 찍어주고 끝났기 때문에 확인도 못 하고 꺼짐
            // why? 시작과 끝이니까!
            //Console.ReadKey();
            // readkey는 사용자가 아무 키도 누르지 않으면 항상 콘솔 화면이 떠 있음.
            // return하는 부분이 없기 때문에 아무 키나 누르면 콘솔 화면이 꺼짐.

            Console.Write(args.Length);
            // 매개변수가 없기 때문에 인자의 개수가 없어서 0이 나옴!
            //Console.ReadKey();


            // 맨 위에 select박스에서 Debug 의미
            // 현재 프로젝트 위치를 찾아가서 bin\debug를 보면 exe 실행 파일이 있음(파일탐색기에서 폴더 열기 선택)
            // cmd창에서 프로젝트 위치를 이동해서 실행파일명을 입력하면 현재 이 메인프로그램이 돌아감을 알 수 있음.
            // 하지만 저장만으로는 변동사항이 바로 적용되지 않는데, 이를 위해 빌드 후 가 필요함.
            // 단 cmd창 띄운 상태에서 해당 위치에서 프로그램 실행중인 상태에서 빌드하면 에러가 생김! 
            // 따라서 cmd를 닫거나, 프로그램에서 나와 위치에만 있는 상태에서 빌드를 해야 함!


            Console.WriteLine("HEllo!" + args[0]);
        }
    }
}
