//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();
Write("Введите кол-во строк и столбцов в массиве через пробел: ");
string[] StrParam = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters = ConverStringToNum(StrParam);
int[,] matrix = GetRandomMatrix(parameters[0], parameters[1]);
PrintMatrix(matrix);
WriteLine();
SortMatrix(matrix);
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

int[,] GetRandomMatrix(int row, int column)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(1, 10);
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

void SortMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}





