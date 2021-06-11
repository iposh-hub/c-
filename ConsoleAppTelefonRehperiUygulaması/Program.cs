using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppTelefonRehperiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            ShowMenu menu = new ShowMenu();
            bool DevamMı = true;


            while (DevamMı)
            {
                menu.Menu();
                int answer = Convert.ToInt32(Console.ReadLine());
                
                if (answer == 1)
                {
                    
                    person.AddPerson();

                }
                else if (answer==4)
                {
                    person.GetList();

                }

                else if (answer == 2)
                {
                    person.Remove();

                }

                else if(answer==5)  
                {
                    person.FindMeInPhone();
                
                }

                Console.Write("Devam etmek istermisiniz y/n");
                char value= Convert.ToChar(Console.ReadLine());
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

        class ShowMenu 
        {
            public void Menu() 
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("******************************************* ");
                Console.WriteLine("(1) Yeni Numara Kaydetmek\n (2) Varolan Numarayı Silmek\n (3) Varolan Numarayı Güncelleme \n (4) Rehberi Listeleme \n (5) Rehberde Arama Yapmak");
            }
        
        
        }
        
        
        class Person 
        {
            Dictionary<string, string> my_people = new();

            public Person()
            {
                my_people.Add("Ali Gündüz", "05313778865");
                my_people.Add("Mehmet Yildirim", "05313778865");
                my_people.Add("Asli Çiçek", "05313778865");
                my_people.Add("Aydın Mutlu", "05313778865");
                my_people.Add("Halil Sevinc", "05313778865");
            }

            
            public string [] TakeInfo()
            {
                Console.Write("İsim: ");
                string isim = Console.ReadLine();
                Console.Write("Soyİsim: ");
                string soyisim = Console.ReadLine();
                Console.Write("Numara: ");
                string numara = Console.ReadLine();
                string[] properties = { isim, soyisim, numara };
                return properties;
            }

            public void AddPerson()
            {
                string[] properties= TakeInfo();
                
                my_people.Add(properties[0] + " "+properties[1], properties[2]);
                
                
            }

            public void GetList()

            {
                foreach (var item in my_people)
                {

                    Console.WriteLine("İsim: {0}", item.Key);
                    Console.WriteLine("No: {0}", item.Value );
                }
            }

            public void Remove()
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz: ");
                string isim = Console.ReadLine();

                bool devam = true;
                while (devam)
                {
                    
                    if (my_people.ContainsKey(isim) )
                    {
                        foreach (var item in my_people.Keys)
                        {
                            
                            if (item.Contains(isim)) 
                            {
                                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item);
                                char answer = Convert.ToChar(Console.ReadLine());
                                if (answer == 'y')
                                {
                                    my_people.Remove(item); 
                                    Console.WriteLine("Kişi başarıyla silinmiştir"); 
                                    devam = false;
                                    break;
                                }

                                else 
                                {

                                    Console.WriteLine("{0} Kişisi Telefon Rehperinden silinmemiştir",item);
                                    devam = false;
                                }

                            }

                        }
                            
                        
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                        Console.WriteLine(" * Silmeyi sonlandırmak için : (1) \n * Yeniden denemek için: (2)");
                        int z = Convert.ToInt32(Console.ReadLine());
                        if (z == 1) { devam = false; }
                        else { devam = true; }
                    }
                    
                }
            }

            public void  FindMeInPhone() 
            {

                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**********************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1) \n  Telefon numarasına göre arama yapmak için: (2)");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer==1) 
                {
                    Console.Write("Bulmak istediğiniz kişinin adını girin: ");
                    string text = Console.ReadLine();
                    foreach (var item in my_people) 
                    {
                        if (item.Key.Contains(text))
                        {
                            Console.WriteLine(item);
                            break;
                        }
                    
                    }
                }
                else 
                {
                    Console.Write("Bulmak istediğiniz kişinin adını girin: ");
                    string text = Console.ReadLine();
                    foreach (var item in my_people)
                    {
                        if (item.Value.Contains(text))
                        {
                            Console.WriteLine(item);
                            break;
                        }

                    }
                }

            }




        }
                



    }

           



}        
        
    

        


        

                 
        
          






    

  

