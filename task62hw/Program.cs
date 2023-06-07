// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] matrix)
    {
        int number = 1;
        int topRow = 0;
        int bottomRow = matrix.GetLength(0) - 1;
        int leftColumn = 0;
        int rightColumn = matrix.GetLength(1) - 1;

        while (number <= matrix.GetLength(0) * matrix.GetLength(1))
        {
            for (int i = leftColumn; i <= rightColumn; i++)
            {
                matrix[topRow, i] = number;
                number++;
            }
            topRow++;

            for (int i = topRow; i <= bottomRow; i++)
            {
                matrix[i, rightColumn] = number;
                number++;
            }
            rightColumn--;

            for (int i = rightColumn; i >= leftColumn; i--)
            {
                matrix[bottomRow, i] = number;
                number++;
            }
            bottomRow--;

            for (int i = bottomRow; i >= topRow; i--)
            {
                matrix[i, leftColumn] = number;
                number++;
            }
            leftColumn++;
        }
    }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество сторк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

    int[,] spiralArray = new int[rows, columns];
        FillSpiralArray(spiralArray);
        PrintMatrix(spiralArray);