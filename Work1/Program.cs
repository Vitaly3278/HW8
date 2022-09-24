// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();

    }
    return array;
}

void PrintSortArray(int[,] array)
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

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, colums);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}

PrintSortArray(array);
