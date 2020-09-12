using System;

namespace IntroUI
{
   public class BackIn30Minutes
    {
       public static void Main()
        {
          
          int hours = int.Parse(Console.ReadLine());
          int minutes = int.Parse(Console.ReadLine());
          var date = new DateTime(1,1,1,hours,minutes,0);
          date = date.AddMinutes(30);
          Console.WriteLine($"{date.Hour}:{date.Minute}");


        }
    }
}
