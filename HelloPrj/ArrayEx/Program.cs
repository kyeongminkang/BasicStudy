using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열 (Array) : 데이터 타입이 같은 요소들을 모아놓은 집합
            // 일련의 동일한 데이터 타입 요소들로 구성된 데이터 집합

            // 배열을 선언하는 방법
            // 데이터형식[] 배열의 이름 = new 데이터형식[배열의 크기];
            //string[] members = new string[10]; 10은 배열의 크기
            //string[]members = new string[3] {"kim", "Lee", "park"};를 축약하면
            //stirng[] members = {"kim", "Lee", "park"};

            //2차원
            // 데이터형식[,] 배열의 이름 = new데이터형식[2차원크기,1차원크기] (행렬로 생각하면됨)
            // string[,] depts = new string[2,2]{{"김과장","영업부"},{"박과장","홍보부"}};
            // 축약 가능
            // string[,] depts = {{"김과장","영업부"},{"박과장","홍보부"}};


            //int score1 = 77;
            //int score2 = 80;
            //int score3 = 90;
            //// 합 구하려면?
            //int sum = score1 + score2 + score3;
            //Console.WriteLine(sum);

            //int[] scre = new int[5] { 77, 80, 90, 60, 88 };
            //int[] scre = { 77, 80, 90, 60, 88 };

            int[] scre = new int[5];
            scre[0] = 77;
            scre[1] = 80;
            scre[2] = 90;
            scre[3] = 60;
            scre[4] = 68;

            int sum = 0;
            //for (int i=0; i<scre.Length; i++)
            //{
            //    sum += scre[i];
            //}

            // foreach문 사용
            // foreach(데이터형식 변수명 in 배열/ 컬렉션)
            //          반복 실행 코드

            foreach (int scoreData in scre)
                sum += scoreData;
            Console.WriteLine(sum);


        }
    }
}
