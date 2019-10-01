using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConstraintEx
{
    /*
        제네릭스의 타입 제약
        앞의 일반화 메소드, 일반화 클래스에서 사용하던 T(타입파라미터)는 모든 데이터 형식을
        대신할 수 있는 매개변수로 사용했다.

        모든 형식을 대신하는 매개변수가 필요할 수도 있지만 그렇지 않은 경우도 있음.
        그런 경우에는 매개변수에 제약 조건을 줄 수 있음.

        제약 조건을 주는 방법으로 where 절을 이용함.
        <예>

        class DemoList<T> where T : DemoClass
        {
        }

        위의 경우에 T라고 하는 매개변수는 Democlass로부터 상속받는 형식이어야 한다는 의미

        void CompyData<T>(T a, T b> where T : struct
        {
        }

        위의 경우 T는 "값 형식이어야 한다"는 제약조건을 준 의미임.
        class는 ref타입, struct은 value타입이니까!

        제네릭스에서 제약조건을 주는 방식은 
            Where T : 제약조건

        제약조건의 종류
        where T : struct - T가 값형식이어야 함.
        where T : Class - T는 참조형식이어야 함.
        whiere t : new() - T는 반드시 기본 생성자가 있어야 함(즉 매개변수가 없는 생성자가 있어야 함)
                            기본생성자가 없으면 안됨.
        where T : 기반클래스명 - T는 기반 클래스의 ㅍ파생클래스 이어야 함
        where T : 인터페이스명 - T는 인터페이스를 반드시 구현해야 함. 인터페이스는 여러개가 올 수 있음.
        where U - 또 다른 형식매개변수 U로부터 상속받은 클래스 이어야함.
     */ 

        class DemoArray1<T> where T : struct
    {
        public T[] Array { get; set; }

        public DemoArray1(int size)
        {
            Array = new T[size];
        }

        public int Length
        {
            get
            {
                return Array.Length;
            }
        }
    }

    class DemoArray2<T> where T : class
    {
        public T[] Array { get; set; }
        public DemoArray2(int size)
        {
            Array = new T[size];
        }

        public int Length
        {
            get
            {
                return Array.Length;
            }
        }
    }

    class Parent { }
    class Child : Parent { }

    class DemoArray3<U> where U : Parent
    {
        public U[] Array { get; set; }
        public DemoArray3(int size)
        {
            Array = new U[size];
        }

        public void CopyData<T>(T[]a) where T : U
        {
            a.CopyTo(Array, 0);
        }
    }

    class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            DemoArray1<int> aa = new DemoArray1<int>(2);
            aa.Array[0] = 11;
            aa.Array[1] = 22;

            for (int i=0; i<aa.Length; i++)
            {
                Console.WriteLine(aa.Array[i]);
            }
            DemoArray2<DemoArray1<double>> bb = new DemoArray2<DemoArray1<double>>(2);
            
            bb.Array[0] = new DemoArray1<double>(3);
        
            bb.Array[1] = new DemoArray1<double>(10);
            for (int i = 0; i < bb.Length; i++)
            {
                Console.WriteLine(bb.Array[i]);
            }


            DemoArray3<Parent> cc = new DemoArray3<Parent>(3);
            cc.Array[0] = new Parent();
            cc.Array[1] = new Child();
            cc.Array[2] = CreateInstance<Parent>();

            DemoArray3<Child> dd = new DemoArray3<Child>(2);
            dd.Array[0] = new Child();
            // parent는X 
            dd.Array[1] = CreateInstance<Child>();

            DemoArray3<Child> ee = new DemoArray3<Child>(2);
            ee.CopyData<Child>(dd.Array);
        }
    }
}
