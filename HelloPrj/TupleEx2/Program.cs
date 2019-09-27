using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleEx2
{
    // c# 3.0에서도 Tuple 지원했었음. 하지만 그 때는 클래스형식이였고, 현재는 구조체 형식!
    class Program
    {
        static void Main(string[] args)
        {
            (int count, int sum, double average) GetJumsu(List<int> data) // 튜플 리턴타입
            {
                int cnt = 0, sum = 0;
                double avg = 0;

                foreach (var i in data)
                {
                    cnt++;
                    sum += i;
                }
                avg = sum / cnt;

                return (cnt, sum, avg);
            }

            var jumsuList = new List<int> { 10, 11, 22, 33, 44 };

            var result = GetJumsu(jumsuList);

            Console.WriteLine($"{result.count}, {result.sum}, {result.average}");
            Console.WriteLine($"{result.Item1}, {result.Item2}, {result.Item3}");
        }
    }
}
