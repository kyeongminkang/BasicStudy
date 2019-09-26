using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEx2
{

    class MyClass
    {
        public static int global_Count = 0;
    }

    class DemoClass1
    {
        public DemoClass1()
        {
            MyClass.global_Count++;
        }
    }

    class DemoClass2
    {
        public DemoClass2()
        {
            MyClass.global_Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global_Count : {MyClass.global_Count}");
            new DemoClass1();
            new DemoClass1();
            new DemoClass2();
            Console.WriteLine($"Global_Count : {MyClass.global_Count}");
        }
    }
}
