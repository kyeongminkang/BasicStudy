using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx2
{
    // 자동프로퍼티 기능은 C# 3.0에서 도입된 기능
    // C# 7.0에서는 자동프로퍼티에 초기값이 필요할때 생성자에 초기화 코드를 작성해야 하는 불편함을
    // 해소할 수 있도록 초기값을 바로 설정할 수 있음.
    class EmployeeInfo
    {
        private string name;
        private DateTime entryDate;

        public string Name
        {
            //get
            //{
            //    return name;
            //}
            //set
            //{
            // 자동프로퍼티
            //    name = value;
            //}
            get; set;
        }

        public DateTime EntryDate
        {
            //get
            //{
            //    return entryDate;

            //}
            //set
            //{
            //    entryDate = value;
            //}
            get; set;
        }

        // 근속년수
        public int serviceLength
        {
            get
            {
                // 1 Tick(틱)은 100나노 초(천만분의 1초)를 나타냄. 1밀리 초는 1,0000틱
                // Tick속성을 이용할 경우, 정밀하게 계산되고 날짜와 시간 나타낼 때 많이 사용함.
                return new DateTime(DateTime.Now.Subtract(entryDate).Ticks).Year;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo employee = new EmployeeInfo();
            employee.Name = "홍길동";
            employee.EntryDate = new DateTime(2010, 10, 10);

            Console.WriteLine($"Name : {employee.Name}");
            Console.WriteLine($"EntryDate.ToshortDatestring() : {employee.EntryDate.ToShortDateString()}");
            Console.WriteLine($"serviceLength : {employee.serviceLength}");
        }
    }
}
