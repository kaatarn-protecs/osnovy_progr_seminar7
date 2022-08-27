// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // Метод создания двумерного массива
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random(); // Создаем объект рандом

    for (int i = 0; i < matrix.GetLength(0); i++) // Забираем количество строк в матрице
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Забираем количество столбцов матрицы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void AvgMiddleMatrixRow(int[,] matrix)
{
    double avgdigits = 0;
    int mrow = matrix.GetLength(0);
    int mcol = matrix.GetLength(1);
    Console.Write($"Среднее арифметическое каждого столбца: ");

    for (int i = 0; i < mcol; i++)
    {
        for (int j = 0; j < mrow; j++)
        {
            avgdigits += matrix[j, i];
        }
        avgdigits /= mrow;
        Console.Write (i == mcol - 1 ? $"{Math.Round(avgdigits, 2)}. " : $"{Math.Round(avgdigits, 2)}; ");
        avgdigits = 0;
    }  
}

int[,] newMatrix = CreateMatrixRndInt(6, 6, 1, 9);
PrintMatrix(newMatrix);
AvgMiddleMatrixRow(newMatrix);
