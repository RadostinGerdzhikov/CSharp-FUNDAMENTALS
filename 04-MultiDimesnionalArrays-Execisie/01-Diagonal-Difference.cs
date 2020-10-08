namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System.Threading;
  using System;

  public class Program {
  public static void Main () {
    // 01 - Diagonal Difference  
    
    int rows = int.Parse(Console.ReadLine());

    int[,] matrix = new int[rows,rows];

    for (int row = 0; row < rows; row++)
    {
        int[] currentRow = ParseArrayFromConsole(' ');

        for (int col = 0; col < rows; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

       int sumFirstDiagonal = 0;
       int sumSecondDiagonal = 0;
       int counter = rows - 1; 
   
      for (int row = 0; row < rows; row++)
      {
          sumFirstDiagonal += matrix[row, row];
          sumSecondDiagonal += matrix[row,counter--];
      }

     Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
  

  }

    static int[] ParseArrayFromConsole (params char[] parseSymbols) => Console.ReadLine ()
      .Split (parseSymbols, StringSplitOptions.RemoveEmptyEntries)
      .Select (int.Parse)
      .ToArray ();
  }
}