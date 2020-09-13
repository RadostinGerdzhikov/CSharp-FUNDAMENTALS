using System;

namespace IntroUI {
    public class EvenNumber {
        public static void Main () {

            int number = int.Parse (Console.ReadLine ());
            while (number % 2 != 0) {
                Console.WriteLine ("Please write an even number.");
                number = int.Parse (Console.ReadLine ());
                if (number % 2 == 0) {
                    break;
                }
            }
            Console.WriteLine ($"The number is: {Math.Abs(number)}");
        }
    }
}