using System;

namespace IntroUI
{
   public class PassedOrFailed
    {
       public static void Main()
        {
          
         double grade = double.Parse(Console.ReadLine());

         bool isPassed = grade >= 3.00;

         string result = "";

         var ternaryCheck = isPassed
         ? result = "Passed!"
         : result = "Failed!";     
     
          Console.WriteLine(result);

        }
    }
}
