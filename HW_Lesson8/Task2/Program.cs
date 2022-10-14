// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


using static System.Console;
Clear();
Write("Введите кол-во строк и столбцов в массиве через пробел: ");
string[] StrParam = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters = ConverStringToNum(StrParam);
int[,] matrix = GetRandomMatrix(parameters[0], parameters[1]);
PrintMatrix(matrix);
WriteLine();
int MinRow = MinSumElem(matrix);
WriteLine($"Строкой с минимальной суммой элементов является {MinRow}");


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

int MinSumElem(int[,] matrix)
{
    int currentSum = 0;
    int minLine = 0;
    int[] temp = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentSum += matrix[i, j];
        }
        temp[i] = currentSum;
        WriteLine($"Сумма элементов строки {i} равна {currentSum}");
        currentSum = 0;
    }
    int minElement = temp[0];
    for (int i = 0; i < temp.Length; i++)
    {
        if (temp[i] < minElement)
        {
            minElement = temp[i];
            minLine = i;
        }
    }
    return minLine;
}

