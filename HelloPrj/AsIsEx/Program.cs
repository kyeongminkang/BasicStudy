using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsIsEx
{
    class Human
    {
        public void showInfo()
        {
            Console.WriteLine("Human");
        }
    }

    class Programer : Human
    {
        public void programing()
        {
            Console.WriteLine("코딩하는 개발자");
        }
    }

    class Designer : Human
    {
        public void design()
        {
            Console.WriteLine("디자인하는 디자이너");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // as is 연산자

            // as : 형변환 연산자(캐스팅)와 같은 역할을 하는 연산자
            // 단 형변환 실패했을 경우에 null 값을 리턴

            // is : 해당 객체의 Type(형)이 일치하는 여부를 bool값으로 반환하는 연산자
            ;
            Human human = new Programer();
            // humane을 프로그래머 객체로 만듦.
            Programer programer;
            // 프로그래머 타입으로 progrmer 선언

            if (human is Programer)
            // human이 프로그래머 타입인지
            {
                programer = (Programer)human;
                // progrmer에 human은 프로그래머로 형변환을 하겠음
                programer.programing();

            }

            Human human2 = new Designer();
            // human2를 디자이너로 만듦.
            Designer designer = human2 as Designer;
            // human2를 디자이너로 형변환 해서 실피하면 null 반환

            if (designer != null) designer.design();

            Designer designer2 = human as Designer;
            if (designer2 != null)
                designer2.design();
            else
                Console.WriteLine("designer2는 Designer형이 아님");
        }
    }
}
