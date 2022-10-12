// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
WriteLine("Введите положительные и отрицательные числа, через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int SumArr = countNumbers(array);
WriteLine(SumArr);


int countNumbers(string[] inArray)
{
    int numbers = 0;
    int[] ConvArray = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        ConvArray[i] = Convert.ToInt32(inArray[i]);
    }

    for (int i = 0; i < ConvArray.Length; i++)
    {
        if (ConvArray[i] > 0) numbers++;
    }
    return numbers; q
}



