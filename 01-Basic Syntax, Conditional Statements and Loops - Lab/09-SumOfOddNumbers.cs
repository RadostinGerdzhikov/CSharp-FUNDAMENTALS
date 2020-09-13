using System;

namespace IntroUI {
    public class SumOfOddNumbers {
        public static void Main () {
            
            int digit = int.Parse(Console.ReadLine());
            int sum = 0;   
            for (int i = 1; i <= digit * 2; i+=2) 
            {
                Console.WriteLine (i);
                sum += i;
            }
              Console.WriteLine($"Sum: {sum}");
              
        }
    }
}
