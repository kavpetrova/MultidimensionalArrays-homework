/*Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum 
of its elements.*/
using System;

class Maximal
{
    static void Main()
    {
        Console.Write("Enter number of the rows: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter number of the columns: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, n];
        int bestSum = int.MinValue;
        string inputNum = "";

        for (int row = 0; row < m; row++)           //Filling matrix
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("matrix[{0},{1}]=", row, col);
                inputNum = Console.ReadLine();
                matrix[row, col] = int.Parse(inputNum);
            }
        }
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)     //Finding best 3x3 sum
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1]
                    + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)       //Printing matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The sum of max 3x3 is: {0}", bestSum);
    }
}

