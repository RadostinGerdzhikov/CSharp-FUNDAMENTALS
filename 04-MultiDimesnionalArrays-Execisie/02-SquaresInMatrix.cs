namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System.Threading;
  using System;

  public class Program {
  public static void Main () {
    // 02 - Squares in Matrix  
    
     int[] dimensions = ParseArrayFromConsole(' ');
     int rows = dimensions[0];
     int cols = dimensions[1];

    string[,] matrix = new string[rows,cols];

     for (int row = 0; row < rows; row++)
     {
		 string[] currentRow = Console.ReadLine()
                           .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();
      
         for (int col = 0; col < cols; col++)
          {
              matrix[row, col] = currentRow[col]; 
          }
      }

      int counterIdenticalChars = 0; 


    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {   
               string ch = matrix[row, col];
              if (ch == matrix[row,col + 1])
              {
                  if (ch == matrix[row + 1 ,col])
                  {
                    if(ch == matrix[row + 1, col + 1])
                    {
                       counterIdenticalChars++;
                    }
                  }
              }
      
             
            } 
        }

        Console.WriteLine(counterIdenticalChars);
    
    }

    static int[] ParseArrayFromConsole (params char[] parseSymbols) => Console.ReadLine ()
      .Split (parseSymbols, StringSplitOptions.RemoveEmptyEntries)
      .Select (int.Parse)
      .ToArray ();
  }
}

  
