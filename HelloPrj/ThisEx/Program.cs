using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisEx
{
    class Student
    {
        private string name;
        private string grade;
        public void SetName(string name)
        {
            this.name = name;
            // 매개변수에 있는 이름으로 객체 변경
        }

        // private은 클래스 내에서만 사용할 수 있어서 외부에서 못 사용함
        // 따라서 get, set같은 메소드로 접근할 수 있도록 해
        public string GetName()
        {
            return name;
        }

        public void SetGrade(string grade)
        {
            this.grade = grade;
           
        }

        public string GetGrade()
        {
            return grade;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            // this, this()
            // this 자신을 지칭. 클래스에 의해 만들어진 객체가 자신을 지칭할 때 사용
            // this : 객체가 자신을 지칭할 때 사용하는 키워드

            Student Kim = new Student();
            Kim.SetName("김말똥");
            // name으로 직접 접근 X (private때문)
            Kim.SetGrade("2학년");

            Console.WriteLine($"{Kim.GetName()}, {Kim.GetGrade()}");

            Student Lee = new Student();
            Lee.SetName("이길동");
            Lee.SetGrade("3학년");
            Console.WriteLine($"{Lee.GetName()}, {Lee.GetGrade()}");
        }
    }
}
