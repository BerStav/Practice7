// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Please, enter the row number: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Please, enter the column number: ");
int column = int.Parse(Console.ReadLine());

int[,] twoDimArray = new int[15, 15];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100, 100) / 10;
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

if (row > twoDimArray.GetLength(0) || column > twoDimArray.GetLength(1))
{
    Console.WriteLine("The element not found!");
}
else
{
    Console.WriteLine($"The element value of raw: {row} and column: {column} is: {twoDimArray[row - 1, column - 1]}");
}