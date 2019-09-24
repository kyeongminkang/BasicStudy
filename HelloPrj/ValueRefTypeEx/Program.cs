using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Value Type과 Reference Type
            *
            * Value type(값 형식) : 변수가 값을 담는 데이터 형식
            * Reference Type(참조 형식) : 변수가 실제 값 대신 그 값이 있는 위치를 담는 형식
            * 
            * 메모리 영역 ; 스택(stack), 힙(Heap)
            * 값 형식과 관련 있는 메모리 영역? stack (내가 알고 있는 그 스택, 중괄호 만나면 메모리 비워짐)
            * 
            * 참조 형식과 관련 있는 메모리 영역 ? heap
            * stack은 자기가 알아서 데이터를 비우지만 haep은 따로 데이터를 제거하기 위한 가비지 컬렉터를 이용해야 함.
            * 그럼 왜 굳이 heap을 쓰느냐?
            * 메모리가 블록이 끝남과 동시에 사라지면 메모리 관리 측면에서는 장점이 될 수 있지만, 
            * 재사용이 불가능하다는 단점이 있음.끝까지 유지할 수가 없음!
            * 더이상 사용하지 않을 때 가비지 컬렉터가 가져가버림
            * 
            * 참조 형식이 heap만 사용하지 않음. 힙에 데이터를 저장하고, 스택에 힙의 메모리 주소를 저장해놓음
            * 힙에 실제 데이터 저장, 스택에 실제 데이터가 저장되어 있는 힙의 메모리 주소를 저장
            *  
            *  object형식(참조형식)
            *  object x= 10; object y = 100; x의 변수에 담긴 10의 위치값을 2000(주소는 보통 숫자로 표현)이라하고 100의 위치가 3000번지
            *  스택에 $2000 ($은 주소연산자), $3000이 기록됨
            *  블록이 끝나면 전부 사라지지만, 위치를 주소를 가리키고 있기 때문에 
            *  그 안에 들어있는 값(10, 100)이 사라지지 않는 것!
            *  
            *  object 형식 (사물, 객체를 뜻함. 데이터도 어떻게 보면 object가 될 수 있음)
            *  모든 클래스의 최상위 클래스 (모든 데이터 형식을 포괄함)
            *  
            *  [object 형식]
            *  c# 은 모든 데이터를 다룰 수 있는 objectㅎ ㅕㅇ식을 제공하고 있음.
            *  c# 컴파일러는 어떤 형식의 데이터라도 oject 형식에 담아 처리할 수 있게 하고 있음.
            *  
            *  
           

            */

            object obj1 = 111;
            object obj2 = 3.141212118184m;
            object obj3 = true;
            object obj4 = "Hi";

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);
            Console.ReadKey();
        }
    }
}
