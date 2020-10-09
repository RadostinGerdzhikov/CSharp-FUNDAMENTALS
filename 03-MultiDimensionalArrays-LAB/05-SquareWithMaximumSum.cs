namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System.Threading;
  using System;

  public class Program {
    public static void Main () {

      int[] dimensions = ParseArrayFromConsole(',',' ');
      int rows = dimensions[0];
      int cols = dimensions[1];

      int[,] matrix = new int[rows, cols];

      for (int row = 0; row < matrix.GetLength(0); row++)
      {
         int[] currentRow = ParseArrayFromConsole(',', ' '); 
         for (int col = 0; col < matrix.GetLength(1); col++)
         {
             matrix[row,col] = currentRow[col];
         } 
      }  
     // read matrix
       
      //  for (int row = 0; row < matrix.GetLength(0); row++)
      //  {
      //      for (int col = 0; col < matrix.GetLength(1); col++)
      //      {
      //          Console.Write(matrix[row, col] + " ");
      //      }
      //    Console.WriteLine();
      //  }

      int subMatrixRows = 2;
      int subMatrixCols = 2;


      int maxSum = int.MinValue;
      int biggestSumRow = 0;
      int biggestSumCol = 0;

     for (int row = 0; row <= matrix.GetLength(0) - subMatrixRows; row++)
     {
         for (int  col = 0; col <= matrix.GetLength(1) - subMatrixCols; col++)
        {
              int subMatrixSum = 0;
              for (int subRow = 0; subRow < subMatrixRows; subRow++)
              {
                for (int subCol = 0; subCol < subMatrixCols; subCol++)
                {
                    subMatrixSum += matrix[row + subRow, col + subCol];
                }
              }
        
           if(subMatrixSum > maxSum)
           {
             maxSum = subMatrixSum;
             biggestSumRow = row;
             biggestSumCol = col;
           }  
            
        
        }
     }

        for (int row = 0; row < subMatrixRows; row++) 
        {
            for (int col = 0; col < subMatrixRows; col++)
            {
                Console.Write(matrix[biggestSumRow + row, biggestSumCol + col] + " ");
            }
        
          Console.WriteLine();
        } 




     Console.WriteLine(maxSum);
    }

    static int[] ParseArrayFromConsole(params char[] parseSymbols)
    => Console.ReadLine()
       .Split(parseSymbols,StringSplitOptions.RemoveEmptyEntries)
       .Select(int.Parse)
       .ToArray();
    
  }
}