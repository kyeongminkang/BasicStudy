using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueEx
{
    // Queue : 먼저 들어온 놈이 먼저 빠져나감 First In First Out 선입선출
    //  - Enqueue ; 데이터를 입력
    //  - Dequque : 데이터를 출력
    // 동영상 스트리밍시 버퍼링이 큐 형식을 사용함.

    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue(200);

            q.Dequeue(); // 1제거. 앞부분에서 무조건 빼기 때문에 지정안함
            q.Enqueue(22.5);

            // 값 저장하려면? int같은거 사용시에는 캐스팅해주면 됨.
            //object aa = q.Dequeue();
            q.Dequeue();
            q.Enqueue("가나다");

            while(q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }

        }
    }
}
