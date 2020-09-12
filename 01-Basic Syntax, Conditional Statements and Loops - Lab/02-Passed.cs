using System;

namespace IntroUI
{
   public class Passed
    {
       public static void Main()
        {
         
          double grade = double.Parse(Console.ReadLine());
          
          bool isPassed = grade >= 3.00;
          var result = "";
          var a = isPassed
          ? result = "Passed!"
          : result = "";
          Console.WriteLine(result);


        }
    }
}
