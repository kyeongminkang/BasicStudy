using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx3
{
    // group by
    // 형식
    // group x by y into z
    // x는 from절에서 가져온 범위 변수
    // y는 분류 기준
    // z는 그룹 변수

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
                new Member(){Name="강호동", Age=49},
                new Member(){Name="이경규", Age=26},
                new Member(){Name="이경실", Age=33},
                new Member(){Name="손흥민", Age=26},
                new Member(){Name="김연아", Age=55}
            };

            // 30대 이상과 이하로 나누기

            var GroupMember = from member in memberList
                        group member by member.Age > 30 into g
                        select new { groupKey = g.Key, members = g };
            // key는 group by 뒤에 조건에 따른 true / false 키가 저장되고, members는 그에 해당하는 데이터가 들어감

            foreach (var Group in GroupMember)
            {
                if (Group.groupKey == true)
                {
                    Console.WriteLine("<30대 이상 멤버>");
                    foreach (var member in Group.members)
                    {
                        Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
                    }
                }else
                {
                    Console.WriteLine("<30대 이하 멤버>");
                    foreach (var member in Group.members)
                    {
                        Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
                    }
                    
                }
            }
        }
    }
}
