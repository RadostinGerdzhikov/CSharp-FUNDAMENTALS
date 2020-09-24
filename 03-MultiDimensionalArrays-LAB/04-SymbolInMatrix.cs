namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System;

  public class Program {
       public static void Main () {
      // 04 - Symbol in Matrix 
    
      int cowsRows = int.Parse(Console.ReadLine());
      int rows = cowsRows;
      int cols = rows;

      char[,] matrixSymbols = new char[rows,cols];
      
      for (int row = 0; row < matrixSymbols.GetLength(0); row++)
      {
          string currentRow = Console.ReadLine();
         
         
         for (int col = 0; col < matrixSymbols.GetLength(1); col++)
         {
             matrixSymbols[row,col] = currentRow[col];
         } 
      }
      
      char symbol = char.Parse(Console.ReadLine());
     
      for (int row = 0; row < matrixSymbols.GetLength(0); row++)
      {
          for (int col = 0; col < matrixSymbols.GetLength(1); col++)
          {
              if(matrixSymbols[row,col] == symbol)
              {
                 Console.WriteLine($"({row}, {col})");
                 return;
              }
          }
      }
      
       Console.WriteLine($"{symbol} does not occur in the matrix ");
    
    }
  }
}

