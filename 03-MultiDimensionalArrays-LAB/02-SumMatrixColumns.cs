namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System;

  public class Program {

    public static void Main () {
      // 02 - Sum Matrix Columns 
      int[] demensions = ParseArrayFromConsole(',');

      int rows = demensions[0];
      int cols = demensions[1]; 
        
      int[,] matrix = new int[rows, cols];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
         int[] currentrow = ParseArrayFromConsole(',', ' ');

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = currentrow[col];
        }


    }

       for (int col = 0; col < matrix.GetLength(1); col++)
       {
           int sumOfColumn = 0;
 
           for (int row = 0; row < matrix.GetLength(0); row++)
           {
               sumOfColumn += matrix[row,col];
           } 
           Console.WriteLine(sumOfColumn);  
        }
    }
    static int[] ParseArrayFromConsole(params char[] splitSymbols)
    => Console.ReadLine()
    .Split(splitSymbols,StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    
  }
}