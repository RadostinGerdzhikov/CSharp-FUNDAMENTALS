namespace IntroUI {

  using System;
  using System.Data;
  using System.Linq;
  using System.Text;
  
  public class Program {
  
    public static void Main () {
      // 01-Sum Matrix Element  
      int[] dimensions = ParseArrayFromConsole ();

      int rows = dimensions[0];
      int cols = dimensions[1];

      // create matrix
      int[, ] matrix = new int[rows, cols];

      for (int row = 0; row < rows; row++) {
        // take the row from the input
        int[] currentRow = ParseArrayFromConsole ();

        for (int col = 0; col < cols; col++) {
          matrix[row, col] = currentRow[col];
        }

      }

      // Sum elements form Matrix

      long sum = 0;
      foreach (var num in matrix) {
        sum += num;
      }
      Console.WriteLine (rows);
      Console.WriteLine (cols);
      Console.WriteLine (sum);
    }

    static int[] ParseArrayFromConsole () {
      return Console.ReadLine ()
        .Split (new [] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
        .Select (int.Parse)
        .ToArray ();

    }

  }
}