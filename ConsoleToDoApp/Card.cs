using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp
{

    public  enum Size 
    {
        XS,
        S,
        M,
        L,
        XL,
        nosize,

        
    }
   public class Card
   {
        public string Title { get; set; }
        public string Content { get; set; }
        public Size size { get; set; }
        public Member member { get; set; }
        public int CartId { get; set; }

        public List<Card> CurrentCards()
        {
           List<Card> cards = new List<Card>
           {
                new Card{CartId=1, Content="Alışverişe Git", Title="Alışveriş", size=Size.S, member= member.AllMembers().Find(m=> m.Id==1)},
                new Card{ CartId=2, Content="Spora Git", Title="Spor", size=Size.M, member= member.AllMembers().Find(m=> m.Id==2)},
                new Card{CartId = 3,  Content="Faturaları Öde", Title="Fatura", size=Size.XL, member= member.AllMembers().Find(m=> m.Id==3)},

           };
           return cards;
            
        }

    }



}
