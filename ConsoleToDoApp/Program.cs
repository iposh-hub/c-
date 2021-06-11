using System;

namespace ConsoleToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            TodoLine todoLine = new TodoLine();
            InProgressLine ınProgressLine = new InProgressLine();
            Member member = new Member();
            Done done = new Done();
            ShowMenu menu = new ShowMenu();
            bool DevamMı = true;

            while (DevamMı) 
            {

                menu.Menu();
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {

                    todoLine.GetCards();
                    ınProgressLine.GetCards();
                    done.GetCards();

                }
                else if (answer == 2)
                {

                    Console.Write("Card Id'sini girin:  ");
                    int CartId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Başlık Giriniz:  ");
                    string CardTitle = Console.ReadLine();
                    Console.Write("İçerik Giriniz: ");
                    string CardContent = Console.ReadLine();
                    Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
                    int CardSize = Convert.ToInt32(Console.ReadLine());
                    if (CardSize == 1) 
                    {
                         card.size = Size.XS;
                    }
                    else if (CardSize == 2) 
                    {
                        card.size = Size.S;
                    }
                    else if (CardSize == 3)
                    {
                        card.size = Size.M;
                    }
                    else if (CardSize == 4)
                    {
                        card.size = Size.L;
                    }
                    else if (CardSize == 5)
                    {
                        card.size = Size.XL;
                    }
                    Console.Write("Kişi Seçiniz: ");
                    int MemberId  = Convert.ToInt32(Console.ReadLine());
                    card.CurrentCards().Add(new Card()
                    {
                        CartId = CartId,
                        Title = CardTitle,
                        Content = CardContent,
                        member = member.AllMembers().Find(m => m.Id == MemberId),
                    });

                    todoLine.AddCard(CartId);
                }

                else if (answer == 3)
                {
                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.Write("Lütfen kart başlığını yazınız:  ");
                    string title = Console.ReadLine();
                    var foundCard = card.CurrentCards().Find(c => c.Title == title);
                    card.CurrentCards().Remove(foundCard);
                    bool IsInToDoList = todoLine.Cards.Contains(foundCard);
                    bool IsInProgressList = todoLine.Cards.Contains(foundCard);
                    bool IsInDoneList = todoLine.Cards.Contains(foundCard);
                    if(IsInToDoList)
                    {
                        todoLine.RemoveCard(foundCard.CartId);
                    }
                    if(IsInProgressList)
                    {
                        ınProgressLine.RemoveCard(foundCard.CartId);
                    }
                    if (IsInDoneList)
                    {
                        done.RemoveCard(foundCard.CartId);
                    }
                }

                else if (answer == 4)
                {
                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.Write("Lütfen kart başlığını yazınız:  ");
                    string title = Console.ReadLine();
                    var foundCard = card.CurrentCards().Find(c => c.Title == title);

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n (1) TODO\n (2) IN PROGRESS\n (3) DONE");
                    int answer2 = Convert.ToInt32(Console.ReadLine());
                    if (answer2==1)
                    {
                        todoLine.AddCard(foundCard.CartId);
                    }
                    if (answer2 == 2)
                    {
                        ınProgressLine.AddCard(foundCard.CartId);
                    }
                    if (answer2 == 3)
                    {
                        ınProgressLine.AddCard(foundCard.CartId);
                    }


                    bool IsInToDoList = todoLine.Cards.Contains(foundCard);
                    bool IsInProgressList = todoLine.Cards.Contains(foundCard);
                    bool IsInDoneList = todoLine.Cards.Contains(foundCard);
                    if (IsInToDoList)
                    {
                        todoLine.RemoveCard(foundCard.CartId);
                    }
                    if (IsInProgressList)
                    {
                        ınProgressLine.RemoveCard(foundCard.CartId);
                    }
                    if (IsInDoneList)
                    {
                        done.RemoveCard(foundCard.CartId);
                    }


                }

                Console.Write("Devam etmek istermisiniz y/n");
                char value = Convert.ToChar(Console.ReadLine());
                if (value is 'y')
                {
                    DevamMı = true;

                }
                else
                {
                    DevamMı = false;
                }

            }
        }
    }

    class ShowMenu
    {
        public void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) Board Listelemek\n (2) Board'a Kart Eklemek\n (3)Board'dan Kart Silmek \n (4) Kart Taşımak \n ");
        }


    }
}
