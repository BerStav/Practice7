// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

Console.Write("Please, enter the number of lines: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Please, enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] twoDimArray = new double[rows, columns];

void FillArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);