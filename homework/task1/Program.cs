// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5   7    -2   -0,2
//  1  -3,3    8   -9,9
//  8   7,8   -7,1   9

double[,] CreateMatrixRndDouble(int row, int col, int min, int max) // Метод создания двумерного массива вещественных чисел
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random(); // Создаем объект рандом

    for (int i = 0; i < matrix.GetLength(0); i++) // Забираем количество строк в матрице
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Забираем количество столбцов матрицы
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6}, ");
            else Console.Write($"{matrix[i, j], 6} ");
        }
        Console.WriteLine("]");
    }
}

double[,] arr = CreateMatrixRndDouble(7, 6, -50, 50);
PrintMatrixDouble(arr);