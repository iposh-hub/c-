using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<Member> AllMembers()
        {
            List<Member> MemberList = new List<Member> 
            {
                new Member { Id = 1, Name = "Hasan Yorulmaz",},
                new Member { Id = 2, Name = "Hüseyin Hırslı" },
                new Member { Id = 3, Name = "Elif Taşkan" },
                new Member {Id=4, Name="Gaye Yorulmaz"},
                new Member {Id=5, Name ="Umut Gök"},
                new Member {Id=6, Name ="Mert Bakırcı"},
            };
            return MemberList;

     
        }
    }
}
