using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 가변배열 (Jagged Array)

            // 선언형식
            // 데이터형식 [][] 배열이름 = new 데이터형식[가변배열의 크기][];
            //가변배열의 크기는 필수임
            //int[][] arr = new int[3][];
            //arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            //arr[1] = new int[3] { 11, 22, 33 };
            //arr[2] = new int[2] { 20, 30 };

            //int[][] arr2 = new int[2][];
            //arr2[0] = new int[]{ 11, 22, 33, 44, 55, 66, 11};
            //// 단 축약형이 안됨! 숫자 생략까지만 됨
            //arr2[1] = new int[3] { 111, 222, 333 };

            // 가변배열의 경우 각 요소의 크기가 다르기 때문에 이중 for문으로는 어려움
            // foreach가능

            int[][] jArr = new int[3][];

            jArr[0] = new int[4] { 1, 2, 3, 4 };
            jArr[1] = new int[] { 10, 11, 12, 22, 33, 44 };
            jArr[2] = new int[] { 20, 30 };

            foreach(int[] arr in jArr)
            {
                Console.WriteLine($"배열의 크기(길이) : {arr.Length}");
                foreach (int element in arr)
                {
                    Console.Write("{0} ", element);
                }
                Console.WriteLine();
            }

            string[][] jArr2 = new string[2][]
            {
                new string[] {"홍길동", "임꺽정"},
                new string[] { "김말똥", "강길동"}
            };

            Console.WriteLine("----------------");

            foreach(string[] strArr in jArr2)
            {
                Console.WriteLine($"배열의 크기(길이) : {strArr.Length}");
                foreach (string element in strArr)
                {
                    Console.Write("{0} ", element);
                }
                Console.WriteLine();

            }




        }
    }
}
