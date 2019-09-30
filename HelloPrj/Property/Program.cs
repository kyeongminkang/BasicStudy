using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    // 프로퍼티
    class DemoClass
    {
        // 프로퍼티
        /*
          선언형식
          데이터타입 필드명;
          접귽한자 데이터타입 프로퍼티명
          {
            get
            {
                return 필드명;
            }
            set 
                필드명 = value;
            }
           }

            - value는 키워드임. 변수아님!
            (value키워드 사용하면 알아서 매개변수로 간주함.)
            - get, set은 접근자(accessor)

         */

        private int demoField;
        public int DemoField
        {
            get
            {
                return demoField;
            }
            set
            {
                demoField = value;
            }
            // 프로퍼티를 읽기전용(get만 구현), 쓰기전용(set만 구현)으로 정의할 수 있음.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //DemoClass demoClass = new DemoClass();
            //demoClass.SetDemoField(100);
            //Console.WriteLine(demoClass.GetDemoField());

            DemoClass demoClass = new DemoClass();
            demoClass.DemoField = 10;
            Console.WriteLine(demoClass.DemoField);
        }
    }
}
