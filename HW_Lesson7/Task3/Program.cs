// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
Write("Введите кол-во строк и столбцов в массиве через пробел: ");
string[] StrParam = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters = ConverStringToNum(StrParam);
int[,] matrix = GetRandomMatrix(parameters[0], parameters[1]);
PrintMatrix(matrix);
FindAverage(matrix);




int[] ConverStringToNum(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;

}

int[,] GetRandomMatrix(int row, int column)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(0, 50);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
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

void FindAverage(int[,] data)
{

    for (int i = 0; i < data.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < data.GetLength(0); j++)
        {
            average += data[j, i];
        }
        WriteLine($"Среднее арифметическое чисел столбца {i} равно {average / data.GetLength(0)};");
    }
}




