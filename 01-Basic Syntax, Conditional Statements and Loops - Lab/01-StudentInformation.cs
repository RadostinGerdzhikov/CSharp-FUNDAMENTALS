using System;

namespace IntroUI
{
   public class StudentInformation
    {
       public static void Main()
        {
          
		string name = Console.ReadLine();
          int age = int.Parse(Console.ReadLine());
          double grade = double.Parse(Console.ReadLine());

          Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");


        }
    }
}
