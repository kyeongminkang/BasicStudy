using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx5
{
    /*
        외부조인
        from a in A
                                        // on에 조건에 맞는 데이터를 temp에 저장
        join b in B on a.XXX equlas b.xxx into temp
        from b in temp.DefaultIfEmpty(new a() {empty =""})
                      // temp에서 없는 데이터는 (A가 기준데이터니까 B에는 없는 A의 요소) new 이하로 채운(비어있는 데이터로) 후 b데이터로 가져오겠다는 뜻!
     */ 

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
    class Program
    {
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

            
            var Students = from student in studentList
                           join score in scoreList
                           on student.name equals score.name into temp
                           from score in temp.DefaultIfEmpty(new Score()
                           {
                               math = 100,
                               english = 100
                           })
                           // 맨 위에 주석대신, 값을 넣었기 때문에 빈 값에 대신 데이터가 채워짐
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