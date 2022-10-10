// Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]

using static System.Console;
Clear();
Console.Write("Введите длину массива : ");
int arrLen = int.Parse(ReadLine()!);
int[] array = GetArray(arrLen);
PrintArray(array);



//метод наполнения массива числами от -100 до 100
int[] GetArray(int lengArray)
{
    int[] result = new int[lengArray];
    for (int i = 0; i < lengArray; i++)
    {
        result[i] = new Random().Next(-100, 100 + 1);
    }
    return result;
}

//метод вывода массива в [.....]

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}