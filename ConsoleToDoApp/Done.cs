using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp
{
    public class Done : IApp
    {
        public Card card { get ; set;}
        public List<Card> Cards { get; set ; }

        public void AddCard(int CardId)
        {
            var searchedCard = card.CurrentCards().FirstOrDefault(c => c.CartId == CardId);
            
            Cards.Add(searchedCard);
            Console.WriteLine("Kartınız InProgressLine'a başarıyla eklendi");
        }

        public void GetCards()
        {
            Console.WriteLine("******Done Cards******");
            foreach (var item in Cards)
            {
                Console.WriteLine(item.CartId);
                Console.WriteLine(item.Content);
                Console.WriteLine(item.size);
                Console.WriteLine(item.member.Name);
            }
        }

        public void RemoveCard(int CardId)
        {
            var searchedCard = card.CurrentCards().FirstOrDefault(c => c.CartId == CardId);
            
            Cards.Remove(searchedCard);
            Console.WriteLine("DoneLine'da Silme işlemi başarılı");
        }

        public void UpdateCards(int CardId)
        {
            throw new NotImplementedException();
        }
    }
}
