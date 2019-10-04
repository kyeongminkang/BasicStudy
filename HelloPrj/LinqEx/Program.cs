using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx
{
    /*
     대개 데이터베이스에 접근할 때 sql을 사용
     더 편리하게 이용하기 위하여 보통 ORM((객체관게매핑) 이용하는데
     그 중 하나가 Linq임!
     
     LINQ (Language INtergated Query) : C# 언어에 통합된 데이터 질의 기능
     쿼리? 조회하다 뭐 이런 의미!

     */


    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Member[] memberList =
            {
                new Member(){ Name ="홍길동", Age=24},
                new Member(){ Name ="이순신", Age=55},
                new Member(){ Name ="고길서", Age=43},
                new Member(){ Name ="김말똥", Age=28},
                new Member(){ Name ="강말똥", Age=35}
            };

            //List<Member> members = new List<Member>();

            //foreach(Member member in memberList)
            //{
            //    if (member.Age >= 30)
            //    {
            //        members.Add(member);
            //    }
            //}

            //members.Sort(
            //    (member1, member2) =>
            //    {
            //        return member1.Age - member2.Age;
            //    });
            //// 나이 오름차순 정렬

            //foreach(Member member in members)
            //{
            //    Console.WriteLine($"{member.Name}, {member.Age}");
            //}

            // linq 이용해보기
            var members = from member in memberList
                          where member.Age >= 30
                          orderby member.Age
                          //select member;

                          //데이터 조작가능
                          select new { member.Name, Age = member.Age + "세" };
            
            // var말고 Member도 가능하나, 위와 같이 데이터를 조작할 경우 var 형태로 바꿔주어야 한다
            
            foreach (var member in members)
            {
                Console.WriteLine($"{member.Name}, {member.Age}");
            }
        }
    }
}

/*
  [LINQ]
    LINQ의 Query Expression(쿼리 식, 질의 표현식)은 from 절로 시작.
    
    - from 절 다음에는 (질의의 대상이 됨) 데이터 원본이 옴. 데이터 원본은 배열, 컬렉션 등이 올 수 있음.
      IEnumerable<T>을 상속받는 것들 이기 때문에(배열, 컬렉션) 범위변수(요소)필요
      
        from 범위변수 in 데이터원본

    ex) int[] aaa = {11, 22, 33, 44, 55};
        var res = from a in aaa
                  where a % 2 !== 0
                  orderby a
                  select a
        foreach문과 from절에 사용하는 범위변수는 foreach문과 달리 데이터를 저장하거나 복사할 수 없음에 유의

    - where (조건절) 데이터 (원본)의 범위변수가 가져야할 조건을 지정하여 해당하는 데이터를 걸러내는 역할
    
    - orderby절은 where절에서 걸러낸 데이터를 정렬하는 역할을 함.
      기본 정렬값은 오름차순(ascending)임(즉, 생략가능) 내림차순의 경우 descending 키워드 사용하면 됨.
    
    - select절은 질의의 최종 결과를 추출(가져옴). 
 */
