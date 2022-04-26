using System;
using System.Collections.Generic;
using System.Linq;


namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------ 
             *    
             */
            if (matrixOfIntegers.GetLength(0) != matrixOfIntegers.GetLength(1))
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }
            else
            {
                int centralElement = matrixOfIntegers[matrixOfIntegers.GetLength(0) / 2, matrixOfIntegers.GetLength(1) / 2];
                Console.WriteLine(centralElement);
            }

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            int principal = 0, secondary = 0;
            if (matrixOfIntegers.GetLength(0) != matrixOfIntegers.GetLength(1))
                Console.WriteLine("This matrix doesn't have diagonals");
            else
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    principal += matrixOfIntegers[i, i];
                    secondary += matrixOfIntegers[i, matrixOfIntegers.GetLength(0) - i - 1];
                }

                Console.WriteLine("Principal Diagonal:"
                                          + principal);

                Console.WriteLine("Secondary Diagonal:"
                                          + secondary);
            }
        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            for (int i = 1; i <= triangleHight; i++)
            {
               for (int j = 1; j <= triangleHight - i; j++)
                {
                    Console.Write(" ");
                }
               for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here

            do
            {
                Console.WriteLine(listOfNumbers.Max());
                listOfNumbers.Remove(listOfNumbers.Max());

            } while (listOfNumbers.Count() != 0);
            
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);
        }

    }
}
