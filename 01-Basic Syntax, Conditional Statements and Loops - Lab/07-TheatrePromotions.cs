using System;

namespace IntroUI {
    public class TheatrePromotions {
        public static void Main () {

            string typeDay = Console.ReadLine().ToLower(); 
            int age = int.Parse(Console.ReadLine());
            int price = 0;
           if (age < 0 || age > 122)
           {
               
               Console.WriteLine("Error!");
               
               return;
           }

           switch (typeDay)
           {
               case "weekday": 
               
                if (age <= 18) 
                {
                    price = 12;
                }
                else if (age <= 64 )
                {
                   price = 18;
                } 
                else 
                {
                   price = 12; 
                }
              break;
               case "weekend":
               if (age <= 18) 
                {
                    price = 15;
                }
                else if (age <= 64 )
                {
                   price = 20;
                } 
                else 
                {
                   price = 15; 
                }
              break; 
               case "holiday": 
               if (age <= 18) 
                {
                    price = 5;
                }
                else if (age <= 64 )
                {
                   price = 12;
                } 
                else 
                {
                   price = 10; 
                }
              break;
           }   

           Console.WriteLine($"{price}$");
        }
    }
}