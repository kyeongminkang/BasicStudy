using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이차원 배열
            //int[,] arr = new int[2, 3];
            //arr[0, 0] = 1;
            //arr[0, 1] = 10;
            //arr[0, 2] = 100;
            //arr[1, 0] = 5;
            //arr[1, 1] = 50;
            //arr[1, 2] = 500;

            //int[,] arr = new int[2, 3] { { 1, 10, 100 }, { 5, 50, 500 } };
            //                이차원의 길이, 일차원의 길이/ 2행3열

            int[,] arr = { { 1, 10, 100 }, { 5, 50, 500 } };
            
            // GetLength() : 배열에서 지정한 차원의 길이를 구하는 메소드
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {arr[i, j]} ");
                }
                Console.WriteLine();
            }





        }
    }
}
