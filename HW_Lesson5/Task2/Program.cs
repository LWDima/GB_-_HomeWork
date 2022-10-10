// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
Write("Введите длину массива: ");
int lenArr = int.Parse(ReadLine()!);
int[] array = GetArray(lenArr);
int oddnum = oddIndexSum(array);

WriteLine($"Массив [{String.Join(",", array)}]: ");
WriteLine($"Cумму элементов, стоящих на нечётных позициях в массиве: {oddnum}");


int[] GetArray(int array)
{
    int[] result = new int[array];
    Random rnd = new Random();
    for (int i = 0; i < array; i++)
    {
        result[i] = rnd.Next(-50, 50 + 1);
    }
    return result;
}


int oddIndexSum(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) num += arr[i];
    }
    return num;
}

