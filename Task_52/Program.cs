void Exit()
{
    Console.WriteLine();
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach52()
{
    //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
     Console.Clear();
    int[,] matrix = new int[4, 4];
    PrintArray2();
    FillArray(matrix);
    PrintArray3();
    PrintArray(matrix);
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 101);
            Console.Write($"{matrix[i, j]}\t ");

        }
        Console.WriteLine();
    }
}
void PrintArray(int[,] matrix)
{
    for (int n = 0; n < matrix.GetLength(1); n++)
{
    double sum = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        sum = sum + matrix[m, n];
    }
    sum = Math.Round(sum, 2);
    Console.Write($"{sum / matrix.GetLength(0)}\t");    
}

}

void PrintArray2()
{
    Console.WriteLine("Двумерный массив: ");
    Console.WriteLine();
}
void PrintArray3()
{
    Console.WriteLine();
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
}

Zadach52();
Console.WriteLine();
Exit();