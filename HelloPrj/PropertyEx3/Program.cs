using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx3
{
    // C# 7.0에서 도입된 자동 프로퍼티 초기화 사용하기

        class EmployeeInfo
    {
        public string name { get; set; }// = "아무나";
        public DateTime EntryDate { get; set; } //= new DateTime(2000, 1, 1);
        
        public int SeviceLength
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(EntryDate).Ticks).Year;
            }
        }
  
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성 시 객체의 필드를 초기화하는 또 다른 방법
            // 생성자와 프로퍼티를 이용함.
            /*
             * 선언방법
             * 클래스명 인스턴스명 = new 클래스명()
             * {
             *      프로퍼티명1 = 값,
             *      프로퍼티명2 = 값,
             *      ..................
             * };
             * 
             */ 

            EmployeeInfo employee = new EmployeeInfo()
            {
                name = "홍길동",
                EntryDate = new DateTime(2011, 10, 11)

            };

            //EmployeeInfo employee = new EmployeeInfo();
            Console.WriteLine($"이름 : {employee.name}");
            Console.WriteLine($"입사일 : {employee.EntryDate.ToShortDateString()}");
            Console.WriteLine($"근속년수 : {employee.SeviceLength}");

            //employee.name = "고길동";
            //employee.EntryDate = new DateTime(2005, 5, 25);

            //Console.WriteLine(employee.name);
            //Console.WriteLine(employee.EntryDate.ToShortDateString());
            //Console.WriteLine(employee.SeviceLength);
        }
    }
}
