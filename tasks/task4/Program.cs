// Задача 51: 
// Задайте двумерный массив. 
// Найдите сумму
// элементов, находящихся на главной диагонали 
// (с индексами
// (0,0); (1;1) и т.д.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}


int SumDiagonalElements(int[,] matrix)
{
    int sum = 0;
    int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1)); // Выбираем мин. между строками и столбцами
    
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int [,] array2d = CreateMatrixRndInt(7, 5, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();

int res = SumDiagonalElements(array2d);
Console.WriteLine($"Сумма диоганальных элементов = {res}");