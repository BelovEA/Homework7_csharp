//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] MakeArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rnd.Next(min, max + 1);

    return result;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void CheckElInArray(int column, int row, int[,] array)
{
    if (column >= array.GetLength(0) || column < 0 || row >= array.GetLength(1) || row < 0)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"значение необходимого элемента = {array[column, row]}");
    }
}

int[,] array = MakeArray(3, 4, 10, 99);
PrintArray2D(array);
int row;
Console.Write("введите индекс cтолбца: ");
while (!int.TryParse(Console.ReadLine(), out row))
{
    Console.Write("Введен неверный параметр, введите целое число: ");
}
int column;
Console.Write("введите индекс строки: ");
while (!int.TryParse(Console.ReadLine(), out column))
{
    Console.Write("Введен неверный параметр, введите целое число: ");
}
CheckElInArray(column, row, array);

