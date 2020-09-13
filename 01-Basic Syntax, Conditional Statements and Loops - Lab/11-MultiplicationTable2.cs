using System;

namespace IntroUI {
    public class MultiplicationTable2 {
        public static void Main () {

            int number = int.Parse (Console.ReadLine ());
            int times = int.Parse (Console.ReadLine ());
            
            if (times > 10) {
                Console.WriteLine($"{number} X {times} = {number * times}");
            } else {
                for (int i = times; i <= 10; i++) {
                    Console.WriteLine ($"{number} X {times} = {number * times}");
                    times++;
                }
            }

        }
    }
}