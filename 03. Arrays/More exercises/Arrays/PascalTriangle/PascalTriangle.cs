using System;
using System.Linq;


namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //creating an array to hold the values of each new row
            int[] newRow = new int[n];
            //creating an array to hold the values of each old row
            int[] oldRow = new int[n];

            //looping through the rows of the triangle
            for (int row = 0; row < n; row++)
            {
                newRow = new int[n];
                //looping through the array for each row
                for (int col = 0; col < n; col++)
                {
                    //assigning 1s to first element of each row
                    if (col == 0)
                    {
                        newRow[col] = 1;
                    }
                    //assigning 1s to close each row at the proper index
                    else if (col == row)
                    {
                        newRow[col] = 1;
                    }
                    //looping through the indexes between 1s
                    else if (col > 0 && col < row)
                    {
                        newRow[col] = oldRow[col - 1] + oldRow[col];
                    }
                }

                //copying the new row into the old one
                oldRow = newRow;

                //printing the triangle
                for (int j = 0; j < n; j++)
                {
                    if (newRow[j] != 0)
                    {
                        Console.Write(newRow[j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
