

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
            //your code here

            int midlength0m1 = matrixOfIntegers.GetLength(0) / 2;
            int midlength1m1 = matrixOfIntegers.GetLength(1) / 2;
            int n = matrixOfIntegers.GetLength(0);
            int m = matrixOfIntegers.GetLength(1);

            if (matrixOfIntegers.GetLength(0) % 2 != 0 && matrixOfIntegers.GetLength(1) % 2 != 0 && n == m)
            {
                Console.WriteLine("The central element is " + matrixOfIntegers[midlength0m1, midlength1m1]);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
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
            //your code here

            int diagonallength0m1 = matrixOfIntegers.GetLength(0);
            int diagonallength1m1 = matrixOfIntegers.GetLength(1);
            int n = matrixOfIntegers.GetLength(0);
            int m = matrixOfIntegers.GetLength(1);

            if (matrixOfIntegers.GetLength(0) % 2 != 0 && matrixOfIntegers.GetLength(1) % 2 != 0 && n == m)
            {

                int principal = 0, secondary = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        // Condition for first diagonal
                        if (i == j)
                            principal += matrixOfIntegers[i, j];

                        // Condition for second diagonal
                        if ((i + j) == (n - 1))
                            secondary += matrixOfIntegers[i, j];
                    }
                }

                Console.WriteLine("First Diagonal:"
                                          + principal);

                Console.WriteLine("Second Diagonal:"
                                          + secondary);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have diagonals");
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
            //your code here

            int i, j, k;

            for (i = 1; i <= triangleHight; i++)
            {
                for (j = 1; j < triangleHight - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
            var sortedList = listOfNumbers.OrderBy(x => x);
            foreach (int element in sortedList)
            {
                Console.WriteLine(element);
            }
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
