// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] matrix = new int[4,3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0,9);
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sredn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sredn += matrix[i, j];
    }
    Console.Write($"{sredn / 4} ");
}
