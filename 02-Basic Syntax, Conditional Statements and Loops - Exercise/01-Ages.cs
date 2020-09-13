using System;
using System.Globalization;

namespace IntroUI {
    public class Ages {
        public static void Main () {

        int age = int.Parse(Console.ReadLine());
        string personTypeByAge = string.Empty;
        
        if (age <= 2){
          personTypeByAge = "baby";
        }
        else if (age <= 13){
            personTypeByAge = "child";
        }
        else if (age <= 19){
            personTypeByAge = "teenager";
        }
        else if (age <= 65){
            personTypeByAge = "adult";
        }
        else
        {
            personTypeByAge = "elder";
        }
           
           Console.WriteLine(personTypeByAge);

        }
    }
}