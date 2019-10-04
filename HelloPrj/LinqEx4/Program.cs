using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx4
{
    // 조인 (join)  : 두 데이터를 합치는 것
    /*
        - 내부조인 (이너): 교집합, 두 데이터에 일치하는 데이터들만 연결해서 반환 하는 것
        - 외부조인 (아우터) : 기본적으로 내부 조인과 비슷하지만, 조건이 일치하지 않더라도
                                기준 데이터를 하나도 누락 시키지 않고 그대로 추출하여
                                빈 데이터를 채워서 통합하는 방식
                조건이 일치하지 않더라도 그대로 추출하여 데이터를 통합시킴
                기준 데이터를 기준으로 해서 이에 맞게 조인 데이터(실제 합치는)를 맞춤.
                즉 기준 데이터에 A, B, C, D 가 있고, 조인 데이터에 B, C, D, E가 있다면
                기준 데이터에 있는 A,(일치항목 X), B, C, D(일치항목있음)이 통합 데이터가됨. E는 조인 데이터에만 있으므로 합쳐지지 않음
                레프트 조인과 같음!

        선언형식
        내부조인
        A 원본 데이터, a는 변위변수
        From a in A
        join b in B on a.xxx equals b.xxx
        여기에서 on은 조건, a와 b가 비교 대상
        == 연산자 말고 equals사용해야함
     */ 
    class Program
    {

        class Student
        {
            public string name { get; set; }
            public int age { get; set; }
        }

        class Score
        {
            public string name { get; set; }
            public int math { get; set; }
            public int english { get; set; }
        }

        static void Main(string[] args)
        {
            Student[] studentList =
            {
                new Student(){name="홍길동", age=21},
                new Student(){name="이길동", age=22},
                new Student(){name="김길동", age=23},
                new Student(){name="홍길복", age=24}
            };

            Score[] scoreList =
            {
                new Score(){name="홍길동", math=90, english=77},
                new Score(){name="김길동", math=88, english=66},
                new Score(){name="홍길복", math=60, english=99},
                new Score(){name="강길동", math=79, english=88}
            };

            // 내부조인
            var Students = from student in studentList
                           join score in scoreList
                           on student.name equals score.name
                           select new
                           {
                               Name = student.name,
                               Age = student.age,
                               Math = score.math,
                               English = score.english
                           };

            foreach (var student in Students)
                Console.WriteLine($"이름 : {student.Name}, 나이 : {student.Age}, 수학 : {student.Math}점, 영어 : {student.English}점");
        }
    }
}
