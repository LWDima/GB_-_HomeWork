// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
Write("Введите длину массива: ");
int lenArr = int.Parse(ReadLine()!);
int[] array = GetArray(lenArr);
int evenNumArr = evenNumSum(array);
WriteLine($"Массив [{String.Join(",", array)}]: ");
WriteLine($"Кол-во четных чисел в массиве: {evenNumArr}");


//Решение через foreach


// int evenNumSum = 0;
// int oddNumSum = 0;
// foreach (int item in array)
// {
//     if (item % 2 == 0) evenNumSum++;
//     if (item % 2 != 0) oddNumSum++;
// }
// WriteLine($"Массив [{String.Join(",", array)}]: ");
// Write($"имеет {evenNumSum} четных чисел, и {oddNumSum} нечетных чисел");



//метод сбора массива
int[] GetArray(int array)
{
    int[] result = new int[array];
    Random rnd = new Random();
    for (int i = 0; i < array; i++)
    {
        result[i] = rnd.Next(100, 999 + 1);
    }
    return result;
}

//метод четности
int evenNumSum(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) num++;
    }
    return num;
}


