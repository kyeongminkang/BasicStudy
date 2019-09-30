using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiIheritanceEx
{
    //class A
    //{
    //    public void output()
    //    {
    //        Console.WriteLine("A의 출력");
    //    }
    //}

    //class B
    //{
    //    public void output()
    //    {
    //        Console.WriteLine("B의 출력");

    //    }
    //}


    interface IA
    {
        void output();
    }

    interface IB
    {
        void print();
    }

    class MyClass : IA, IB
    {
        public void output()
        {
            Console.WriteLine("A인터페이스 출력");
        }

        public void print()
        {
            Console.WriteLine("B인터페이스 출력");
        }
    }
    // 클래스 다중상속 불가.
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.output();
            mc.print();

            IA ia = mc as IA;
            ia.output();

            IB ib = mc as IB;
            ib.print(); 
        }
    }
}
