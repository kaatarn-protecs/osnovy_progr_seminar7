// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
Console.WriteLine("Введите позицию элемента в строке: ");
int rowposin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце: ");
int colposin = Convert.ToInt32(Console.ReadLine());

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

void SearchElementMatrix(int[,] searchmatr, int rowpos, int colpos)
{
    int ressearch = 0;
    if (searchmatr.GetLength(0) < rowpos - 1 
    || searchmatr.GetLength(1) < colpos - 1 
    || rowpos == 0 
    || colpos == 0) 
    Console.WriteLine($"{rowpos}, {colpos} -> такого элемента в массиве нет");
    else 
    {
        ressearch = searchmatr[rowpos - 1, colpos - 1];
        Console.WriteLine($"{rowpos}, {colpos} -> {ressearch}");
    }
}

int[,] matrix = CreateMatrixRndInt(7, 7, -50, 50);
PrintMatrix(matrix);
Console.WriteLine();
SearchElementMatrix(matrix, rowposin, colposin);

