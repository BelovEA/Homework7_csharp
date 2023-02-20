// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// pull_req

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

void ArrAverage(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double average = Math.Round((double)sum / rows, 2);
        Console.WriteLine($"Average of column {j + 1} = {average}");
    }
}
int[,] array = MakeArray(3, 4, 10, 99);
PrintArray2D(array);
ArrAverage(array);


