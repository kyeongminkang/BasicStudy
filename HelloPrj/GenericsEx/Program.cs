using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    // Generics : int, filoat, double 같은 데이터 타입을 확정하지 않고 이 데이터 타입 자체를
    // 타입 파라미터(Type parameter) 받아들이도록 하는 기능

    // 예를 들면 사칙연산을 하는 클래스가 있다고 가정.
    // 모든 데이터 타입은 int type 필드를 가지고 매개 변수 역시 int여야 함.
    // 그런데 double나 float가 들어오면 연산이 작동되지 않음.
    // 따라서 이러한 실수형을 연산하기 위해서는 데이터타입만 다른 클래스를 구현해야 하는데
    // 이러한 불필요한 과정을 제거하기 위해 생겨남.

    /*
        일반화 메소드 선언방식:

        접근제한자 반환형식 메소드이름<형식 매개변수>(매개변수)
        {
        }

    예시>
    void CopyData(int a, int b)
    {
        b = a; b에 a를 복사
    }
    void CompyData(string a, string b)
    {
        b = a; 문자열 a를 b에 복사
    }

    위의 방식은 데이터 형식에 따라서 여러 개의 메소드가 필요함. 비효율적.
    위 방식을 Generics로 변환하면
    void CopyData<T> (T a, T b) // 여기에서 T는 type을 뜻함. <T>붙여줘야해!
    {
        b = a;
    }
     */

        // 일반화 메소드
    class Program
    {
        static void CopyData<T>(T[]a, T[] b)
        {
            for (int i=0; i< a.Length; i++)
            {
                b[i] = a[i];
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55 };
            int[] b = new int[a.Length];

            CopyData<int>(a, b);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            string[] aa = { "사과", "배", "딸기", "포도", "수박" };
            string[] bb = new string[aa.Length];

            CopyData<string>(aa, bb);

            foreach (string item in bb)
            {
                Console.WriteLine(item);
            }

        }
    }
}
