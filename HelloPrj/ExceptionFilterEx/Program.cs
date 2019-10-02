using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilterEx
{
    // Exception Filter : 제약을 걸고 그 조건에 해당되는 코드 수행하게 함.
    // catch절이 받아들일 예외 객체에 제약사항을 주고, 만족 시 예외 처리를 실행할 수 있도록 함.

    // catch문 뒤에 when 키워드이용

    // 모든 예외 객체는 system.exceton 클래스로부터 파생됨
    // 사용자 정의 예외 클래스를 만들 때 역시 system.exception클래스를 상속받아 만듦.
    // 하지만 보통 사용자 정의 클래스 만들 일 없음 모두 제공하고 있으니까...

        class UserException : Exception
    {
        public int ErrorCode { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            
            Console.Write("1~5 숫자 중 하나를 입력 : ");
            string numTxt = Console.ReadLine();

            int num = Int32.Parse(numTxt);

            if(num <0 || num > 5)
            {
                throw new UserException() { ErrorCode = num };
                // 프로퍼티 이용하여 에러코드 설정함 값이 자동으로 세팅됨
            }
            else
            {
                Console.WriteLine($"{num}");
            }
            // 에러코드를 userexception에 담아옴
            }catch(UserException ex) when (ex.ErrorCode < 0)
            {
                Console.WriteLine("음수는 입력되지 않습니다.");
            }catch(UserException ex) when (ex.ErrorCode > 5)
            {
                Console.WriteLine("5보다 큰 수는 입력되지 않습니다.");

            } 
        }
    }
}
