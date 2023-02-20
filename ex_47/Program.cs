//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] MakeArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.NextDouble() * 10, 1);

    return array;
}

 void PrintArray2D(double[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
 }


double[,] array = MakeArray(3, 4);
PrintArray2D(array);