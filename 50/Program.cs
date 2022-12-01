// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] GetArray( int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(4, 4);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
if ( row < resultMatrix.GetLength(0) && column < resultMatrix.GetLength(1)) Console.WriteLine("Искомый элемент: " + resultMatrix[row, column]);
else Console.WriteLine("В массиве нет элемента с таким индексом");