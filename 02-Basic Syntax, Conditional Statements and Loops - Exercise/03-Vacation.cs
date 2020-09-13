using System;

namespace IntroUI {
    public class Vacation {
        public static void Main () {

            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double totalPrice = 0;

            switch (typeGroup) {
                case "students":
                    if (day == "friday") {
                        totalPrice += 8.45;
                    }
                    if (day == "saturday") {
                        totalPrice += 9.80;
                    }
                    if (day == "sunday") {
                        totalPrice += 10.46;
                    }
                    if (numberPeople >= 30) {
                        totalPrice -=  totalPrice * 0.15;
                    }
                    
                    break;
                case "business":
                    if (day == "friday") {
                        totalPrice += 10.90;
                    }
                    if (day == "saturday") {
                        totalPrice += 15.60;
                    }
                    if (day == "sunday") {
                        totalPrice += 16;
                    }
                    if (numberPeople >= 100) {
                        numberPeople -= 10;
                    }
                    break;
                case "regular":
                    if (day == "friday") {
                        totalPrice += 15;
                    }
                    if (day == "saturday") {
                        totalPrice += 20;
                    }
                    if (day == "sunday") {
                        totalPrice += 22.50;
                    }
                    if (numberPeople >=10 && numberPeople <= 20) {
                        totalPrice -=  totalPrice * 0.05;
                    }
                    break;
            }

                  totalPrice *= numberPeople;
                  Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}