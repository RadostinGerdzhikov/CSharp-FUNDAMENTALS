 using System;

 namespace IntroUI {

     public class RageExpenses {

         public static void Main () {

             int lostGamesCount = int.Parse (Console.ReadLine ());
             double headSetPrice = double.Parse (Console.ReadLine ());
             double mousePrice = double.Parse (Console.ReadLine ());
             double keyboardPrice = double.Parse (Console.ReadLine ());
             double displayPrice = double.Parse (Console.ReadLine ());

             int trashedHeadset = 0;
             int trashedMouse = 0;
             int trashedKeyboard = 0;
             int trashedDisplay = 0;

             for (int i = 1; i <= lostGamesCount; i++) {
                 if (i % 2 == 0) {
                     trashedHeadset++;
                 }

                 if (i % 3 == 0) {
                     trashedMouse++;
                 }

                 if (i % 6 == 0) {
                     trashedKeyboard++;
                 }

                 if (i % 12 == 0) {
                     trashedDisplay++;
                 }

             }
                 var totalExpenses = (trashedHeadset * headSetPrice) + (trashedDisplay * displayPrice) + (trashedKeyboard * keyboardPrice) + (trashedMouse * mousePrice);
                 

              Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
         }
     }
}