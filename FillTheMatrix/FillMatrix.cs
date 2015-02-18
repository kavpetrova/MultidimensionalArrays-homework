/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:*/
using System;

class FillMatrix
{
    static void Main()
    {
        Console.Write("Please enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the type of matrix you won (a, b, c, d): ");
        char choice = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int digit = 1;


        if (choice == 'a')
        {
            
        
        //variant 1
        for (int col= 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[col, row] = digit;
                digit++;
            }
        }
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();
        }
        //variant b
        if (choice == 'b')
        {
            

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }

        }
        for (int col = 0; col < n; col++)           
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();
        }
        //varinat c 
        if (choice == 'c')
        {
            int Row = n - 1;
            int Col = 0;
            int startRow = n - 1;
            int startCol = 0;

            while (digit < n * n)
            {
                if (Row == (n - 1) && Col < (n - 1))        
                {
                    if (digit == 1)
                    {
                        matrix[Col, Row] = digit;
                    }
                    startRow--;
                    startCol = 0;
                    Row = startRow;
                    Col = startCol;
                    digit++;
                    matrix[Col, Row] = digit;

                    while (Row < (n - 1) && Col < (n - 1))
                    {
                        Row++;
                        Col++;
                        digit++;
                        matrix[Col, Row] = digit;
                    }
                }
                if (Row <= (n - 1) && Col == (n - 1))
                {
                    startRow = 0;
                    startCol++;
                    Row = startRow;
                    Col = startCol;
                    digit++;
                    matrix[Col, Row] = digit;

                    while (Col < (n - 1))
                    {
                        Col++;
                        Row++;
                        digit++;
                        matrix[Col, Row] = digit;
                    }
                }
            }
            for (int c = 0; c < n; c++)           
            {
                for (int r = 0; r < n; r++)
                {
                    Console.Write("{0, 4}", matrix[r, c]);
                }
                Console.WriteLine();
            }
            digit = 1;
            Console.WriteLine();

        }  


        // variant d
        if (choice == 'd')
        {
            int offset = 0;
        int ROW = 0;
        int COL = 0;
        while (digit <= n * n)            
        {
            for (ROW = offset; ROW < n - offset; ROW++)
            {
                COL = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = 1 + offset; COL < n - offset; COL++)
            {
                ROW = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (ROW = n - 2 - offset; ROW >= offset; ROW--)
            {
                COL = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = n - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            offset++;
        }

        for (int irow = 0; irow < n; irow++)          
        {
            for (int column = 0; column < n; column++)
            {
                Console.Write("{0, 4}", matrix[irow, column]);
            }
            Console.WriteLine();
        }
        }
    }

  
}

