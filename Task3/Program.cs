// Задайте двумерный массив из целых чисел. Надите среднее арифметическое элементов в каждом столбце.

int[,] twoDimArray = new int[5, 5];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);

for (int j = 0; j < twoDimArray.GetLength(1); j++)
{
    double avarage = 0;

    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        avarage = (avarage + twoDimArray[i, j]);
    }
    avarage = avarage / 5;

    if (j == 4)
    {
        Console.Write(avarage + ".");
    }
    else
    {
        Console.Write(avarage + "; ");
    }
}