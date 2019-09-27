using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleEx
{
    // Tuple(튜플) : 메소드 사용 시 복수개의 값을 전달할 수 있게 됨. 소괄호 사용
    //      C# 7.0 이전 버전에서는 메소ㅡ에서 하나의 값만을 리턴할 수 있었지만
    //      이후 버전에서는 튜플을 이용해서 복수개의 값을 리턴할 수 있게 됨.
    //      즉, 여러개의 필드를 담을 수 있는 구조체와 비슷한 것.

    // 튜플 선언 예
    // var t = (100, 200) --> 명명되지 않은 튜플 ,Unnamed Tuple. 현재 2개의 필드가 어떤 필드인지 구체적이지 않음
    // 100은 item1, 200은 item2라고 자동으로 지정됨
    // 튜플은 ( ) 안에 여러개의 필드를 지정하여 만들 수 있음.

        // var t = (Name : "홍길동", ID : "120") --> Named Tuple 명명된 튜플
        // 콜론을 사용하여 이름을 지정할 수 있음.

        // 역으로 분리할 수도 있음. 필드를 무시할 수 있는(없애는) 방법도 있음

        // 튜플 사용하기 위해서는 패키지 관리자 콘솔에서 패키지 설치해야 사용할 수 있음
        // Install-Package "System.ValueTuple"

        // 솔루션? 프로젝트 만들면 솔루션 폴더가 있음.
        // 그 안에 여러개 프로젝트들이 있음. 프로젝트가 모여있는 것이 솔루션

    class Program
    {
        static void Main(string[] args)
        {
            var aa = ("홍길동", 40); // 명명되지 않은 튜플
            Console.WriteLine($"{aa.Item1}, {aa.Item2}");

            var bb = (Name: "홍길복", Age : 55);
            Console.WriteLine($"{bb.Name}, {bb.Age}"); // 명명된 튜플

            // 튜플 분리
            var (name, age) = bb;
            Console.WriteLine($"{name}, {age}");
            
            // 구조체이기 때문에 복사가 가능
            bb = aa;
            Console.WriteLine($"{bb.Name}, {bb.Age}");
        }
    }
}
