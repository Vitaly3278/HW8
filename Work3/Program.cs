// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

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

void PrintArray(int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write($"{resultArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = GetArray(rows, colums);
Console.WriteLine();
int[,] secondArray = GetArray(rows, colums);

int[,] resultArray = new int[rows, colums];

for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}
Console.WriteLine();
PrintArray(resultArray);