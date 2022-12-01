// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
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
int[,] resultMatrix = GetArray(rows, columns);
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
for (int k = 0; k < columns; k++)
{
    int summ = 0;
    for (int m = 0; m < rows; m++)
    {
        summ = summ + resultMatrix[m,k];
    }
    Console.WriteLine("Среднее арифметическое стобца с индексом " + k + " равно " + Convert.ToDouble(summ)/rows);
}