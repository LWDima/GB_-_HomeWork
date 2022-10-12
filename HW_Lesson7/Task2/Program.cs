// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();
Write("Введите кол-во строк и столбцов в массиве через пробел: ");
string[] StrParam = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters = ConverStringToNum(StrParam);
int[,] matrix = GetRandomMatrix(parameters[0], parameters[1]);
PrintMatrix(matrix);
Write("Введите номер строки и столбца через пробел, чтобы узнать какое число находится в массиве: ");
string[] SearchParam = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] SearchParameters = ConverStringToNum(SearchParam);
SearchNumber(matrix, SearchParameters[0], SearchParameters[1]);




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

void SearchNumber(int[,] matrix, int row, int column)
{
    int result = 0;
    if (row > matrix.GetLength(0) || column > matrix.GetLength(1)) WriteLine("Элемент с таким индексом отсутствует в массиве");
    else WriteLine(matrix[row - 1, column - 1]);
}


