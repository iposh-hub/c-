using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp
{
    public interface IApp
    {
        public Card card { get; set; }
        List<Card> Cards { get; set; }
        void AddCard(int CardId);
        void RemoveCard(int CardId);
        void UpdateCards(int CardId);
        void GetCards();
    }
}
