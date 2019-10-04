using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx2
{
    class MemberScore
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MemberScore[] ms =
            {
                new MemberScore(){ Name="홍말똥", Score=new int[]{ 99, 75, 67 } },
                new MemberScore(){Name = "김말똥", Score=new int[]{88, 45, 87} },
                new MemberScore() {Name="이길동", Score=new int[]{ 55, 66, 77} },
                new MemberScore() {Name="오길동", Score=new int[]{ 90, 80, 30} }
            };

            // 60점 미만인 F학점 이하의 학생 구하기

            // 여기에서 m은 객체 한줄!
            var members = from m in ms
                          from s in m.Score
                          where s < 60
                          orderby s
                          select new { m.Name, Fscore = s };

            foreach (var m in members)
            {
                Console.WriteLine($"과락 : {m.Name}, {m.Fscore}");
            }


        }
    }
}
