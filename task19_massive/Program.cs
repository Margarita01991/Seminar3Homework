﻿Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(N);
int[] array = {numberText[0],numberText[1],numberText[2],numberText[3],numberText[4]};
if (numberText.Length == 5)
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
else
{
    Console.WriteLine("введите 5-значное число");
}
Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}");
