void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach50()
{
    //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    Console.Clear();
    int[,] matrix = new int[10, 10];
    PrintArray2();
    FillArray(matrix);
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
    Console.WriteLine();
    Console.WriteLine("Введите индекс строки: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    if (a < matrix.GetLength(0))
{
    if (b < matrix.GetLength(1))

    {
        Console.WriteLine($"Значение индексы элемента = {matrix[a, b]}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}
}
void PrintArray2()
{
    Console.WriteLine("Двумерный массив: ");
    Console.WriteLine();
}
Zadach50();
Console.WriteLine();
Exit();