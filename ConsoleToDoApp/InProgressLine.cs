using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp
{
    class InProgressLine : IApp
    {
        public Card card { get; set; }
        public List<Card> Cards { get; set; }

        public void GetCards()
        {
            Console.WriteLine("******In Progress Cards******");
            foreach (var item in Cards) 
            {
                Console.WriteLine(item.CartId);
                Console.WriteLine(item.Content);
                Console.WriteLine(item.size);
                Console.WriteLine(item.member.Name);

            }
        }

        public void AddCard(int CardId)
        {
            var searchedCard = card.CurrentCards().FirstOrDefault(c => c.CartId == CardId);
            
            Cards.Add(searchedCard);
            Console.WriteLine("Kartınız InProgressLine'a başarıyla eklendi");
        }


        public void RemoveCard(int CardId)
        {
            var searchedCard = card.CurrentCards().FirstOrDefault(c => c.CartId == CardId);
            
            Cards.Remove(searchedCard);
            Console.WriteLine("InProgressLine'da Silme işlemi başarılı");
        }

        public void UpdateCards(int CardId)
        {
            throw new NotImplementedException();
        }
    }
}
