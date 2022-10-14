// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using static System.Console;
Clear();

WriteLine("Введите кол-во строк и столбцов первой матрицы: ");
string[] StrParam1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters1 = ReadString(StrParam1);
int[,] matrix1 = GetRandomMatrix(parameters1[0], parameters1[1]);

WriteLine("Введите кол-во строк и столбцов второй матрицы: ");
string[] StrParam2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] parameters2 = ReadString(StrParam2);
int[,] matrix2 = GetRandomMatrix(parameters2[0], parameters2[1]);
if (parameters1[1] != parameters2[0])
{
    WriteLine("Такие матрицы невозможно перемножить");
    return;
}

PrintMatrix(matrix1);
WriteLine();
PrintMatrix(matrix2);
WriteLine();
int[,] newMatrix = MegaMatrix(matrix1, matrix2);
PrintMatrix(newMatrix);

// Метод для конвертации строки в int
int[] ReadString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}

// Метод-генератор двумерного массива заданных размеров, заполненного случайными числами
int[,] GetRandomMatrix(int rows, int column)
{
    int[,] result = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

// Метод для печати двумерного массива
void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

// Метод для перемножения матриц
int[,] MegaMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] megaMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                megaMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return megaMatrix;
}

