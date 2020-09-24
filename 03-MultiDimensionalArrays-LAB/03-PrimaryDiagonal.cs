namespace IntroUI {

  using System.Collections.Generic;
  using System.Data;
  using System.Linq;
  using System.Text;
  using System;

  public class Program {

    public static void Main () {
      // 03 - Primary Diagonal 
     int colsRowsNumber = int.Parse(Console.ReadLine());
     
     int rows = colsRowsNumber;
     int cols = colsRowsNumber;
    
     int[,] matrix = new int[rows,cols];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
       int[] currentRow = ParseArrayFromConsole();
       
        for (int col = 0; col < matrix.GetLength(1); col++)
       {
         matrix[row,col] = currentRow[col];    
       }
    } 
       long sumPrimaryDiagonal = 0;
       int counter = 0;
      for (int row = 0; row < matrix.GetLength(0); row++)
      {
            
         for (int col = 0; col < matrix.GetLength(1); col++)
        {
           if(col == counter){
             sumPrimaryDiagonal += matrix[row, col];
           }
            

        } 
          counter++;
      }  

        Console.WriteLine(sumPrimaryDiagonal);


    }

    static int[] ParseArrayFromConsole(params char[] parseSymbols)
    => Console.ReadLine()
      .Split(parseSymbols)
      .Select(int.Parse)
      .ToArray();
    

  }
}

