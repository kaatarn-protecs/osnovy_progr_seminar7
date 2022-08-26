// Задача 49: 
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

void ReplaceEvenELement(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) // i += 2 - Проходим только по четным индексам
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) // j += 2 - Проходим только по четным индексам
        {
            matrix[i, j] = matrix[i,j] * matrix [i,j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

int [,] array2d = CreateMatrixRndInt(3, 4, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();

ReplaceEvenELement(array2d);
PrintMatrix(array2d);