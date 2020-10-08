namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System;

  public class Program {
    public static void Main () {
      // 06- Jagged-Array Modification

      int rows = int.Parse(Console.ReadLine());
    
      int[][] jArr = new int[rows][]; 
      
      for (int row = 0; row < rows; row++)
      {
         int[] currentRow = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
          jArr[row] = currentRow;
      }
    
       while (true)
       {
         string command = Console.ReadLine().ToLower();

         if(command == "end")
         {
           
           foreach (int[] currentRow in jArr)
           {
               Console.WriteLine(string.Join(" ",currentRow));
           }
           
           
            break;
         }
    
        string[] commandParts = command
                                .Split();   
           
        int row = int.Parse(commandParts[1]); 
        int col = int.Parse(commandParts[2]); 
        int value = int.Parse(commandParts[3]);


        if (
          row < 0 
        || row >= rows
        || col < 0
        || col >= jArr[row].Length 
          )
          {
            Console.WriteLine("Invalid coordinates");
            continue;
          }
   
         if (commandParts[0] == "add")
         {
            jArr[row][col] += value; 
         }
         else if (commandParts[0] == "subtract")
         {
            jArr[row][col] -= value; 
            
         }

       }
    
    }
  }
}