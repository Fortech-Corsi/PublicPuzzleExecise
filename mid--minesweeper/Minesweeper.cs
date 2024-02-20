using System;
using System.Collections.Generic;
using System.Linq;

public static class Minesweeper
{
    public static string[] Annotate(string[] input)
    {
        // PROCESSING DELL'INPUT  
        int rows = input.Length;
        int columns = input.Length > 0 ? input[0].Length : 0;

        int[,] multiDimensionalArray = new int[rows, columns];

        {
            int i = 0;
            foreach (var riga in input)
            {
                int j = 0;
                foreach (char c in riga)
                {
                    int valore = 0;
                    if (c == '*')
                    {
                        // inseriamo il -1
                        valore = -1;
                    }

                    multiDimensionalArray[i, j] = valore;
                    j++;
                }
                i++;
            }
        }

        // BUSINESS LOGIC

        for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
            {
                System.Console.WriteLine("Element({0},{1})={2}", i, j, 
                multiDimensionalArray[i, j]);
                if (multiDimensionalArray[i, j] == -1)
                {
                    // Devo procedere all'incremento 
                    IncrementValue(multiDimensionalArray, i-1, j);
                    IncrementValue(multiDimensionalArray, i-1, j+1);
                    IncrementValue(multiDimensionalArray, i, j+1);
                    IncrementValue(multiDimensionalArray, i+1, j+1);
                    IncrementValue(multiDimensionalArray, i+1, j);
                    IncrementValue(multiDimensionalArray, i+1, j-1);
                    IncrementValue(multiDimensionalArray, i, j-1);
                    IncrementValue(multiDimensionalArray, i-1, j-1);
                }
            }
        }

        // PROCESSING DELL'OUTPUT 





        return null;
    }

    public static void IncrementValue(int[,] multiDimensionalArray, int i, int j)
    {
        // controlliamo i valore delle varialibi siano dentro la nostra matrice
        if (
        i >= 0 
        && j >= 0 
        && i < multiDimensionalArray.GetLength(0)  
        &&
        i < multiDimensionalArray.GetLength(1) 
        && multiDimensionalArray[i, j] != -1       
        )
        {
            multiDimensionalArray[i, j]++;
        }

    }
}
