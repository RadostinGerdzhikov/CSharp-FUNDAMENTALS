using System;

namespace IntroUI {
    public class ForeignLanguages {
        public static void Main () {

            string country = Console.ReadLine ();
            var result = "";
           
            switch (country) {
                
                case "USA": 
                case "England": result = "English"; break;
                case "Spain": 
                case "Argentina": 
                case "Mexico": result = "Spanish"; break;
                default:
                result = "unknown"; break;
            }

              Console.WriteLine(result);

        }
    }
}