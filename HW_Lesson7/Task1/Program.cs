// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Введите кол-во строк и столбцов в массиве через пробел: ");
string[] StrParam = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters = ConverStringToNum(StrParam);
double[,] matrix = GetRandomMatrix(parameters[0], parameters[1]);
PrintMatrix(matrix);


int[] ConverStringToNum(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;

}

double[,] GetRandomMatrix(int row, int column)
{
    double[,] result = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble(), 1) + new Random().Next(-10, 10);
        }
    }
    return result;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]}\t");
        }
        WriteLine();
    }
}

