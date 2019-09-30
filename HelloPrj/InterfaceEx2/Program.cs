using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx2
{
    // 인터페이스 인터페이스를 상속( interface inherits interface)

    /*
     * 인터페이스 상속 형식
     * interface : 자식인터페이스명 : 부모인터페이스명
     */ 

    interface ParentInterface
    {
        void myMethod(string str);
    }

    interface ChildInterface : ParentInterface
    {
        void myMethod(string str, int i);
    }

    class MyClass : ChildInterface
    {
        public void myMethod(string str)
        {
            Console.WriteLine(str + "부모 인터페이스호출");
        }

        public void myMethod(string str, int cnt)
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(str + "인터페이스 호출");
            }
        }
    }

    class Progra 
    {
      

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.myMethod("부모");
            mc.myMethod("자식", 3);
        }
    }
}
