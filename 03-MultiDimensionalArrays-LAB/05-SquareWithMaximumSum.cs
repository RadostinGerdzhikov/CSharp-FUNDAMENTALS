namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System;

  public class Program {

    public static void Main () {
       //05 - Square with Maximum Sum

      int[] dimensions = ParseArrayFromConsole(',',' ');  
      int rows = dimensions[0];
      int cols = dimensions[1];

      int[,] matrix = new int[rows,cols];

      for (int row = 0; row  matrix.GetLength(0) ; row++)
      {
          int[] currentRow = ParseArrayFromConsole(',',' '); 
          for (int col = 0; col  matrix.GetLength(1); col++)
          {
              matrix[row,col] = currentRow[col];
          }
      } 
    
         

         int biggestSum = int.MinValue;
         int bigRow = 0;
         int bigCol = 0;

         for (int row = 0; row  matrix.GetLength(0) - 1; row++)
         {
             for (int col = 0; col  matrix.GetLength(1) - 1; col++)
             {
                int currentSum = matrix[row, col] 
                               + matrix[row, col + 1]
                               + matrix [row + 1, col]
                               + matrix [row + 1, col + 1];


                  if(currentSum  biggestSum)
                  {
                    biggestSum = currentSum;
                    bigCol = col;
                    bigRow = row;
                  }             

             }
         }

              Console.WriteLine(${matrix[bigRow, bigCol]} {matrix[bigRow,bigCol + 1]}); 
              Console.WriteLine(${matrix[bigRow + 1,bigCol]} {matrix[bigRow + 1, bigCol + 1]});
              Console.WriteLine(biggestSum);
       }

     static int[] ParseArrayFromConsole(params char[] parseSymbols)
     = Console.ReadLine()
        .Split(parseSymbols,StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
     


  
  }
}
