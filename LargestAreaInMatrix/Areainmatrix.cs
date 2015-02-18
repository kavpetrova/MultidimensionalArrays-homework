﻿/*Problem 7.* Largest area in matrix

Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

class Areainmatrix
{
    static void Main()
    {
        Console.Write("Please,enter number for rows: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Please,enter number for colunms: ");
            int numberM = int.Parse(Console.ReadLine());

            Console.Write("Please, enter {0} numbers separated by space: ", numberN * numberM);
            string text = Console.ReadLine();

            string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[,] matrix = new string[numberN, numberM];
            bool[,] matrixBool = new bool[numberN, numberM];

            int elementsCounter = 0;

            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    matrix[row, col] = elements[elementsCounter++];
                    matrixBool[row, col] = false;
                }
            }

            Queue myQ = new Queue();
            int largestArea = 0;
            int counter = 1;
            

            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    myQ.Enqueue(matrix[row, col]);
                    matrixBool[row, col] = true;

                    while (myQ.Count > 0)
                    {
                        myQ.Dequeue();
                        for (int i = 0 ; i < numberN; i++)
                        {
                            for (int j = 0; j < numberM; j++)
                            {
                                if (!matrixBool[i, j] && matrix[row, col] == matrix[i, j])
                                {
                                    myQ.Enqueue(matrix[i, j]);
                                    counter++;
                                    matrixBool[i, j] = true;
                                }
                            }
                        }
                       
                    }
                    if (largestArea < counter)
                    {
                        largestArea = counter;
                    }
                    counter = 1;
                    for (int m = 0; m < numberN; m++)
                    {
                        for (int k = 0; k < numberM; k++)
                        {
                            matrixBool[m, k] = false;
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int row = 0; row < numberN; row++)
            {
                for (int col = 0; col < numberM; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Largest area = {0}",largestArea);
        }
    }


