// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }

    }
    return array;
}

Console.Write("Введите размер массива  (x, y, z): ");
int x = Convert.ToInt32(Console.ReadLine());

int y = Convert.ToInt32(Console.ReadLine());

int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = GetArray(z, y, z);


