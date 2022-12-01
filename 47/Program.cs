// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] GetArray( int m, int n)
{
    double[,] matrix = new double[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = (new Random().NextDouble())*100;
        }
    }
    return matrix;
}
double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(Math.Round(inputMatrix[i,m], 1) + "\t");
        }
        Console.WriteLine();
    }
}
