using System;

namespace IntroUI {
    public class StrongNumber {
        public static void Main () {
            
            int numberOriginal = int.Parse(Console.ReadLine());
            int number = numberOriginal;
            int factorial = 1;
            int sumFactorials = 0;

            while (number != 0) {
                int digit = number % 10;
                if (digit == 0) {
                    digit = 1;
                }
                number = number / 10;
              
                for (int i = 1; i <= digit; i++) {
                    factorial *= i;
                }
                sumFactorials += factorial;
                factorial = 1;
            }

            string result = "";
            var ternaryCheck = sumFactorials == numberOriginal 
            ? result = "yes" 
            : result = "no";

            Console.WriteLine (result);

        }
    }
}