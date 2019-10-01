using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx2
{
    // 일반화 클래스 선언방식
    // 일반화 클래스는 똑같은 기능을 하지만 내부적으로 사용하는 데이터 형식이 다를 경우에 사용하면 편리함.
    /*
      class 클래스명 <T>
      {
      }

        <예시>
        class DemoList
        {
            private int[] array;
            public int GetItem(int idx) {return array[idx];}
        }

        class DemoList2
        {
            private double[] array;
            public double GetItem(int idx) {return array[idx];}
        }

        위 두개의 클래스를 일반화 클래스로 사용한다면
        class DemoList<T>
        {
            private T[] array;
            public T GetItem(int idx) {return array[idx];}
        }

        클래스 2개 굳이 만들지 말고
        객체 생성시에 인자로 치환해서 사용하면 됨!
        DemoList<int> demoList1 = new DemoList<int>();
        DemoList2<double> demoList2 = new demoList<double>();
     */ 

        class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[4];
        }

        public T this[int idx]
        {
            get
            {
                return array[idx];
            }
            set
            {
                if (idx >= array.Length)
                {
                    Array.Resize<T>(ref array, idx + 1);
                    Console.WriteLine($"배열 사이즈 조정 : {array.Length}");
                }
                array[idx] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList1 = new MyList<string>();
            myList1[0] = "A";
            myList1[1] = "B";
            myList1[2] = "C";
            myList1[3] = "D";
            myList1[4] = "E";

            for (int i=0; i<myList1.Length; i++)
            {
                Console.WriteLine(myList1[i]);
            }

            MyList<int> myList2 = new MyList<int>();
            myList2[0] = 100;
            myList2[1] = 200;
            myList2[2] = 300;
            myList2[3] = 400;
            myList2[4] = 500;
            myList2[5] = 600;

            for (int i = 0; i < myList2.Length; i++)
            {
                Console.WriteLine(myList2[i]);
            }

        }
    }
}
