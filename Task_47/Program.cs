void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach47()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    Console.Clear();
    double[,] matrix = new double[4, 4];
    FillArray(matrix);
    PrintArray2();
    PrintArray1(matrix);
}
void FillArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Random random = new Random();
            matr[m, n] = random.NextDouble();
        }
    }
}
void PrintArray1(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{Math.Round(matr[m, n] * 100, 2)}\t");
        }
        Console.WriteLine();
    }
}
void PrintArray2()
{
    Console.WriteLine("Двумерный массив, заполненный случайными вещественными числами:");
    Console.WriteLine();
}
Zadach47();
Console.WriteLine();
Exit();